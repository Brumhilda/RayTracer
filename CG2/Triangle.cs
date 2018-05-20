using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using static Tao.OpenGl.Glu;
using static Tao.OpenGl.Gl;
using static Tao.FreeGlut.Glut;
using Tao.Platform.Windows;

namespace CG2
{
    public class Triangle
    {
        public Point v1, v2,v3;
        public void Draw()
        {
            glVertex3d(v1.x, v1.y, v1.z);
            glVertex3d(v2.x, v2.y, v2.z);
            glVertex3d(v3.x, v3.y, v3.z);
        }
    }
}
