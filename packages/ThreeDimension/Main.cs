using System;
using Angular;
using Rounded;

namespace ThreeDimension
{
    public class Cube : Square
    {

        private const int field = 6;

        public Cube()
        {
            base.property.SetName("Kubus");
            base.property.SetShape("Square 3D");
        }

        public double GetVolume()
        {
            double localLength = base.property.Getlength();
            return (localLength * localLength * localLength);
        }

        public double getArea()
        {
            double localLength = base.property.Getlength();
            return localLength * localLength * Cube.field;
        }

        public Cube input()
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Nama : {base.property.GetName()}");
            Console.WriteLine($"Bentuk : {base.property.GetShape()}");
            Console.Write("Warna : ");
            base.property.SetColor(Console.ReadLine());
            Console.Write("Panjang : ");
            base.property.Setlength(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("------------------------------------------------------------");

            return this;

        }

        public void display()
        {
            Console.WriteLine("Nama : {0}", base.property.GetName());
            Console.WriteLine("Bentuk : {0}", base.property.GetShape());
            Console.WriteLine("Warna : {0}", base.property.GetColor());
            Console.WriteLine("Luas : {0}", this.getArea());
            Console.WriteLine("Volume : {0}", this.GetVolume());
            Console.WriteLine("============================================================");
        }

    }

    public class Block : Rectangle
    {

        private const int field = 2;

        public Block()
        {
            base.property.SetName("Balok");
            base.property.SetShape("Rectangle 3D");
        }

        public double GetVolume()
        {
            double localLength = base.property.Getlength();
            double localWidth = base.property.GetWidth();
            double localHeight = base.property.GetHeigth();

            return (localLength * localWidth * localHeight);
        }

        public double getArea()
        {

            double localLength = base.property.Getlength();
            double localWidth = base.property.GetWidth();
            double localHeight = base.property.GetHeigth();

            return ((localLength * localWidth) * Block.field) + ((localLength * localHeight) * Block.field) + ((localWidth * localHeight) * Block.field);

        }

        public Block input()
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Nama : {base.property.GetName()}");
            Console.WriteLine($"Bentuk : {base.property.GetShape()}");
            Console.Write("Warna : ");
            base.property.SetColor(Console.ReadLine());
            Console.Write("Panjang : ");
            base.property.Setlength(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Lebar : ");
            base.property.SetWidth(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Tinggi : ");
            base.property.SetHeigth(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("------------------------------------------------------------");

            return this;

        }

        public void display()
        {
            Console.WriteLine("Nama : {0}", base.property.GetName());
            Console.WriteLine("Bentuk : {0}", base.property.GetShape());
            Console.WriteLine("Warna : {0}", base.property.GetColor());
            Console.WriteLine("Luas : {0}", this.getArea());
            Console.WriteLine("Volume : {0}", this.GetVolume());
            Console.WriteLine("============================================================");
        }

    }

    public class Sphere : Circle
    {

        private const double SphereConst = (double) 4 / 3;
        private const short field = 4;

        public Sphere()
        {
            base.property.SetName("Bola");
            base.property.SetShape("Sphere");
        }

        private double GetVolume()
        {

            double localSpoke = base.property.GetSpoke();

            // 4/3 x π x r3
            localSpoke = localSpoke * localSpoke * localSpoke;
            double result = (double) Sphere.SphereConst * Circle.pi * localSpoke;

            return Math.Round(result, 2);

        }

        private double getArea()
        {

            double localSpoke = base.property.GetSpoke();

            // L = 4 x π x r2
            double result = (double) Sphere.field * Circle.pi * (localSpoke * localSpoke);

            return Math.Round(result, 2);

        }

        public Sphere input()
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Nama : {base.property.GetName()}");
            Console.WriteLine($"Bentuk : {base.property.GetShape()}");
            Console.Write("Warna : ");
            base.property.SetColor(Console.ReadLine());
            Console.Write("Jari-Jari : ");
            base.property.SetSpoke(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("------------------------------------------------------------");

            return this;

        }

        public void display()
        {
            Console.WriteLine("Nama : {0}", base.property.GetName());
            Console.WriteLine("Bentuk : {0}", base.property.GetShape());
            Console.WriteLine("Warna : {0}", base.property.GetColor());
            Console.WriteLine("Luas : {0}", this.getArea());
            Console.WriteLine("Volume : {0}", this.GetVolume());
            Console.WriteLine("============================================================");
        }

    }

    public class Cone : Circle
    {

        private const double ConeConst = (double) 1 / 3;

        public Cone()
        {
            base.property.SetName("Kerucut");
            base.property.SetShape("Cone");
        }

        private double GetVolume()
        {

            double localSpoke = base.property.GetSpoke();
            double localHeight = base.property.GetHeight();

            // 1/3 π r2 t
            localSpoke = localSpoke * localSpoke;
            double result = (double) Cone.ConeConst * Circle.pi * localSpoke * localHeight;

            return Math.Round(result, 2);

        }

        private double getArea()
        {

            double localSpoke = base.property.GetSpoke();
            double localHeight = base.property.GetHeight();
            double garisPelukis = ((double)localSpoke * localSpoke) + ((double)localHeight * localHeight);
            garisPelukis = Math.Sqrt(garisPelukis);
            Console.WriteLine($"Gs : {garisPelukis}");
            double alas = (double)Circle.pi * (localSpoke * localSpoke);
            double selimut = (double)Circle.pi * localSpoke * garisPelukis;

            // L = 4 x π x r2
            double result = alas + selimut;

            return Math.Round(result, 2);

        }

        public Cone input()
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Nama : {base.property.GetName()}");
            Console.WriteLine($"Bentuk : {base.property.GetShape()}");
            Console.Write("Warna : ");
            base.property.SetColor(Console.ReadLine());
            Console.Write("Jari-Jari : ");
            base.property.SetSpoke(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Tinggi : ");
            base.property.SetHeight(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("------------------------------------------------------------");

            return this;

        }

        public void display()
        {
            Console.WriteLine("Nama : {0}", base.property.GetName());
            Console.WriteLine("Bentuk : {0}", base.property.GetShape());
            Console.WriteLine("Warna : {0}", base.property.GetColor());
            Console.WriteLine("Luas : {0}", this.getArea());
            Console.WriteLine("Volume : {0}", this.GetVolume());
            Console.WriteLine("============================================================");
        }

    }
}
