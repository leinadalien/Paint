using Paint.Figures;
using System.Reflection;

namespace Paint.Domain.FigureImporter
{
    public class CreatorImporter
    {
        private List<FigureCreator> importedCreators;
        public List<FigureCreator> ImportedCreators { get { return importedCreators; } }
        public CreatorImporter()
        {
            importedCreators = new();
        }
        public ImportResult ImportFromDll(string fileName)
        {
            int prevImport = importedCreators.Count;
            try
            {
                Assembly assembly = Assembly.LoadFrom(fileName);
                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    if (type.IsSubclassOf(typeof(FigureCreator)))
                    {
                        var importCreator = assembly.CreateInstance(type.FullName);
                        if (importCreator != null)
                        {
                            importedCreators?.Add((FigureCreator)importCreator);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ImportResult.IMPORT_ERROR;
            }
            if (importedCreators.Count == prevImport)
            {
                return ImportResult.IMPORT_ERROR;
            }
            return ImportResult.OK;
        }
        public void ClearImportData()
        {
            importedCreators.Clear();
        }
    }
    public enum ImportResult
    {
        OK = 0,
        IMPORT_ERROR = 1,
    }
}
