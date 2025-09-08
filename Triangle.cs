using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP252Clase1Tarea2
{
    internal class Triangle
    {
        private float h;
        private float b;

        public Triangle(float h, float b)
        {
            this.h = h;
            this.b = b;
        }
        public virtual float GetArea()
        {
            return (b * h)/2;
        }
    }
}
