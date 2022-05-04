using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Domain.Figures
{
    public abstract class Figure
    {
        protected bool isDrawing = false;
        protected Bitmap bitmap;
        protected Color fillColor;
        protected Color strokeColor;
        protected int stokeWidth;
    }
}
