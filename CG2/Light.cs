using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG2
{
    public class Light
    {
        public float[] Position;
        public float[] Direction;
        public static float[] Mat_Specular = { 1, 1, 1, 1 };
        public float[] position {
            get { return Position; }
            set
            {
                if (value.Length != 4)
                    throw new ArgumentException();
                Position = value;
            } }
        public float[] direction
        {
            get { return Direction; }
            set
            {
                if (value.Length != 3)
                    throw new ArgumentException();
                Direction = value;
            }
        }
        public float[] mat_specular {get { return Mat_Specular; }}
        public Light(float[] pos, float[] dir)
        {
            position = pos;
            direction = dir;
        }
    }
}
