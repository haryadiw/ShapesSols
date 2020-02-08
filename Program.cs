using System;
using Angular;
using Rounded;
using ThreeDimension;

namespace Shapes
{

    class Program
    {


        static void Main(string[] args)
        {

            int opt = -1;

           

            while (opt != 0)
            {

                Console.WriteLine("Program Bentuk-Bentuk : ");
                Console.WriteLine("============================================================");
                Console.WriteLine("1. Persegi Sama Sisi");
                Console.WriteLine("2. Ubin (Turuan Dari Persegi Sama Sisi)");
                Console.WriteLine("3. Eternit / Plafon (Turuan Dari Persegi Sama Sisi)");
                Console.WriteLine("4. Kubus (Turuan Dari Persegi Sama Sisi 3D)");
                Console.WriteLine("............................................................");
                Console.WriteLine("5. Persegi Panjang");
                Console.WriteLine("6. Papan Tulis (Turuan Dari Persegi Panjang)");
                Console.WriteLine("7. Pintu (Turuan Dari Persegi Panjang)");
                Console.WriteLine("8. Balok (Turuan Dari Persegi Panjang 3D)");
                Console.WriteLine("............................................................");
                Console.WriteLine("9. Lingkaran");
                Console.WriteLine("10. Bola");
                Console.WriteLine("11. Kerucut");
                Console.WriteLine("............................................................");
                Console.WriteLine("0. Keluar");
                Console.WriteLine("------------------------------------------------------------");

                Console.Write("Pilih Opsi : ");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {

                    case 1:
                        Square sqr1 = new Square();
                        sqr1.input().display();
                        break;

                    case 2:
                        Tile tle1 = new Tile();
                        tle1.input().display();
                        break;

                    case 3:
                        Plasterboard plb = new Plasterboard();
                        plb.input().display();
                        break;

                    case 4:
                        Cube cube = new Cube();
                        cube.input().display();
                        break;

                    case 5:
                        Rectangle rct1 = new Rectangle();
                        rct1.input().display();
                        break;


                    case 6:
                        WhiteBoard whtb = new WhiteBoard();
                        whtb.input().display();
                        break;

                    case 7:
                        Door door = new Door();
                        door.input().display();
                        break;

                    case 8:
                        Block block = new Block();
                        block.input().display();
                        break;

                    case 9:
                        Circle circle = new Circle();
                        circle.input().display();
                        break;

                    case 10:
                        Sphere sphere = new Sphere();
                        sphere.input().display();
                        break;

                    case 11:
                        Cone cone = new Cone();
                        cone.input().display();
                        break;

                    default:
                        break;


                }

                Console.WriteLine("\n\n");

            }


        }

    }

}
