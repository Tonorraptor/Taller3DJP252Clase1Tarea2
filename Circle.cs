using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP252Clase1Tarea2
{
    internal class Circle
    {
        private float r;

        public Circle(float r)
        {
            this.r = r;
        }

        public virtual float GetArea()
        {
            return r * r * 3.14f;
        }
    }
}
