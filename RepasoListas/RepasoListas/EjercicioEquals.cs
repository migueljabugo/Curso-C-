using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoListas
{
    public class Quaternion
    {
        //x y z w
        private float x;

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        private float y;

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        private float z;

        public float Z
        {
            get { return z; }
            set { z = value; }
        }

        private float w;

        public float W
        {
            get { return w; }
            set { w = value; }
        }

        public Quaternion()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
            this.w = 0;
        }

        public Quaternion(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3})", x, y, z, w);
        }

        public override bool Equals(object obj)
        {
            if (obj is Quaternion)
            {
                Quaternion other = (Quaternion)obj;
                return X == other.X && Y == other.Y && Z == other.Z && W == other.W;
            }
            else { return false; }
        }

        public static void ImprimeSiSonIguales(Quaternion q1, Quaternion q2)
        {
            bool iguales = q1.Equals(q2);
            Console.WriteLine(iguales ? "Son iguales" : "Son distintos");
        }

    }


    public class EjercicioEquals
    {
        public static void RealizarTest()
        {
            Quaternion q1 = new Quaternion();
            Quaternion q2 = new Quaternion(0f, 1f, 2f, 3f);
            Quaternion q3 = new Quaternion(0f, 5.6f, 2.3f, 0.3f);
            Quaternion q4 = new Quaternion(0f, 2f, 2f, 8f);
            Quaternion q5 = new Quaternion(0f, 1f, 6f, 3f);
            Quaternion q6 = new Quaternion();

            List<Quaternion> qList = new List<Quaternion>() { q1,q2,q3,q4,q5,q6};

            //Console.WriteLine(q1);


            //Quaternion.ImprimeSiSonIguales(q1, q6);
            //Quaternion.ImprimeSiSonIguales(q3, q1);
            //Quaternion.ImprimeSiSonIguales(q4, q1);

        }
    }
}
