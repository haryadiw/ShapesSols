using System;
using Angular;
using Rounded;

namespace ThreeDimension
{
    public class Cube : Square
    {

        public double GetVolume()
        {
            return (base.length * base.length * base.length);
        } 


    }

    public class Block : Rectangle
    {

    }

    public class Sphere : Circle
    {

        // Penambahan





    }
}
