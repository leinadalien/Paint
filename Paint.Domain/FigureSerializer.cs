using Newtonsoft.Json;
using Paint.Figures;

namespace Paint.Domain.FigureSerializer
{
    public class FigureSerializer
    {
        private List<IFigure>? data;
        public List<IFigure> DeserializedFigures { get { return data; } }
        public static Result SerializeToJson(List<IFigure> figures, string fileName)
        {
            try
            {
                File.WriteAllText(fileName, JsonConvert.SerializeObject(figures, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All}));
            }
            catch (Exception ex)
            {
                return Result.SERIALIZE_ERROR;
            }
            return Result.OK;
        }
        public Result DeserializeFromJson(string fileName)
        {
            try
            {
                data = (List<IFigure>)JsonConvert.DeserializeObject(File.ReadAllText(fileName), new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
                return Result.OK;
            }
            catch
            {
                return Result.DESERIALIZE_ERROR;
            }
        }
    }
    public enum Result
    {
        OK = 0,
        SERIALIZE_ERROR = 1,
        DESERIALIZE_ERROR = 1,
    }
}
