using System;

namespace Taller3DJP252Clase1Tarea2
{
    internal class Menu
    {
        public void Execute()
        {
            int option = -1;
            while (option != 3)
            {
                Console.WriteLine("Escoge una opcion:");
                Console.WriteLine("0: Area y perimetro del rectangulo");
                Console.WriteLine("1: Area del circulo");
                Console.WriteLine("2: Area del triangulo");
                Console.WriteLine("3: Salir de consola");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Rectangle r = GetRectangle();
                        Console.WriteLine($"El area del rectangulo es: {r.GetArea()}");
                        Console.WriteLine($"El perimetro del rectangulo es: {r.GetPerimeter()}");
                        break;
                    case 1:
                        Circle c = GetCircle();
                        Console.WriteLine($"El area del circulo es: {c.GetArea()}");
                        break;
                    case 2:
                        Triangle t = GetTriangle();
                        Console.WriteLine($"El area del triangulo es: {t.GetArea()}");
                        break;
                    case 3:
                        Console.WriteLine("Salir del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        private Rectangle GetRectangle()
        {
            float h, b;
            Console.WriteLine("Ingrese la base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            h = float.Parse(Console.ReadLine());
            return new Rectangle(h, b);
        }
        private Triangle GetTriangle()
        {
            float h, b;
            Console.WriteLine("Ingrese la base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            h = float.Parse(Console.ReadLine());
            return new Triangle(h, b);
        }
        private Circle GetCircle()
        {
            float r;
            Console.WriteLine("Ingrese el radio");
            r = float.Parse(Console.ReadLine());
            return new Circle(r);
        }
    }
}
