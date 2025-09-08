using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP252Clase1Tarea2
{
    internal class Rectangle
    {
        private float h;
        private float b;

        public Rectangle(float h, float b)
        {
            this.h = h;
            this.b = b;
        }
        public virtual float GetArea()
        {
            return b * h;
        }
        public virtual float GetPerimeter()
        {
            return (2 * b) + (2 * h);
        }
    }
}
