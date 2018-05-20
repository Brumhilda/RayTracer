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
    public static class Matrix
    {

        public static void Make()
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT | GL_ACCUM_BUFFER_BIT);
            // Матрица проецирования
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            // Видовая матрица
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
            glEnable(GL_DEPTH_TEST);
            glEnable(GL_TEXTURE_2D);

            glEnable(GL_COLOR_MATERIAL);
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);
            Light l0 = new Light(new float[] { 5, 5, 5, 0.5f }, new float[] { -1, -1, -1 });
            glLightfv(GL_LIGHT0, GL_POSITION, l0.position);
            glLightfv(GL_LIGHT0, GL_SPOT_DIRECTION, l0.direction);

            glMaterialfv(GL_FRONT, GL_SPECULAR, l0.mat_specular);
            glMaterialf(GL_FRONT, GL_SHININESS, 128.0f);


            glLighti(GL_LIGHT0, GL_SPOT_EXPONENT, 0);
            glLighti(GL_LIGHT0, GL_SPOT_CUTOFF, 90);
            // включаем режим текстурирования, указывая идентификатор mGlTextureObject 
            //Gl.glBindTexture( Gl.GL_TEXTURE_2D, myForm.mGlTextureObject);
        }
    }
}
