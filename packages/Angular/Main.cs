using System;

namespace Angular
{

    public class Properties
    {
        // Bisa di akses di luar class tetapi masih dalam 1 assembly/namescape yg sama
        internal string Name;
        internal string Shape;
        internal string Color;
        internal double Length;
        internal double Width;
        internal double Heigth;

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

        public void Setlength(double Length)
        {
            this.Length = Length;
        }

        public void SetWidth(double Width)
        {
            this.Width = Width;
        }

        public void SetHeigth(double Heigth)
        {
            this.Heigth = Heigth;
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

        public double Getlength()
        {
            return this.Length;
        }

        public double GetWidth()
        {
            return this.Width;
        }

        public double GetHeigth()
        {
            return this.Heigth;
        }

    }

    public class Square
    {

        // Bisa di akses di class turunan baik dalam 1 assembly atau berbeda
        internal protected Properties property = new Properties();

        public Square()
        {
            this.property.Name = "Persegi Sama Sisi";
            this.property.Shape = "Square";
        }

        public Square input()
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Nama : {this.property.Name}");
            Console.WriteLine($"Bentuk : {this.property.Shape}");
            Console.Write("Warna : ");
            this.property.Color = Console.ReadLine();
            Console.Write("Panjang : ");
            this.property.Length = Convert.ToDouble(Console.ReadLine());
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


        protected double getArea()
        {
            return this.property.Length * this.property.Length;
        }

    }

    public class Tile : Square
    {

        public Tile()
        {
            base.property.Name = "Ubin";
            base.property.Shape = "Square";
        }

    }

    public class Plasterboard : Square
    {

        public Plasterboard()
        {
            base.property.Name = "Eternit / Plafon";
            base.property.Shape = "Square";
        }

    }

    public class Rectangle
    {

        internal protected Properties property = new Properties();

        public Rectangle()
        {
            this.property.Name = "Persegi Panjang";
            this.property.Shape = "Rectangle";
        }

        protected double getArea()
        {

            return this.property.Length * this.property.Width;

        }

        public Rectangle input()
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Nama : {0}", this.property.Name);
            Console.WriteLine("Bentuk : {0}", this.property.Shape);
            Console.Write("Warna : ");
            this.property.Color = Console.ReadLine();
            Console.Write("Panjang : ");
            this.property.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lebar : ");
            this.property.Width = Convert.ToDouble(Console.ReadLine());
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

    public class WhiteBoard : Rectangle
    {

        public WhiteBoard()
        {
            base.property.Name = "Papan Tulis";
            base.property.Shape = "Rectangle";
        }

    }

    public class Door : Rectangle
    {

        public Door()
        {
            base.property.Name = "Pintu";
            base.property.Shape = "Rectangle";
        }

    }


}
