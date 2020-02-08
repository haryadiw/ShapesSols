using System;

namespace Rounded
{

    public class Properties
    {
        // Bisa di akses di luar class tetapi masih dalam 1 assembly/namescape yg sama
        internal string Name;
        internal string Shape;
        internal string Color;
        internal double Spoke;
        internal double Height;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetShape(string Shape)
        {
            this.Shape = Shape;
        }


        public void SetColor(string Color)
        {
            this.Color = Color;
        }

        public void SetSpoke(double Spoke)
        {
            this.Spoke = Spoke;
        }

        public void SetHeight(double Height)
        {
            this.Height = Height;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetShape()
        {
            return this.Shape;
        }


        public string GetColor()
        {
            return this.Color;
        }

        public double GetSpoke()
        {
            return this.Spoke;
        }

        public double GetHeight()
        {
            return this.Height;
        }


    }

    public class Circle
    {

        internal protected Properties property = new Properties();
        protected const double pi = (double) 22 / 7;

        public Circle()
        {
            this.property.Name = "Lingkaran";
            this.property.Shape = "Circle";
        }

        private double getArea()
        {
            return Circle.pi * (this.property.Spoke * this.property.Spoke);
        }

        public Circle input()
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Nama : {this.property.Name}");
            Console.WriteLine($"Bentuk : {this.property.Shape}");
            Console.Write("Warna : ");
            this.property.Color = Console.ReadLine();
            Console.Write("Jari-Jari : ");
            this.property.Spoke = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");

            return this;

        }

        public void display()
        {
            Console.WriteLine("Nama : {0}", this.property.Name);
            Console.WriteLine("Bentuk : {0}", this.property.Shape);
            Console.WriteLine("Warna : {0}", this.property.Color);
            Console.WriteLine("Luas : {0}", this.getArea());
            Console.WriteLine("============================================================");
        }

    }
}
