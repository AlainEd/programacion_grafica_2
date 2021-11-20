using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grafica
{
    class Game : GameWindow 
    {
        int arriba = 0, abajo = 0, derecha = 0, izquierda = 0;
        public Escenario escenario;
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {


        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.W)) arriba += 10;
            else if (input.IsKeyDown(Key.S)) abajo += 10;
            else if (input.IsKeyDown(Key.D)) derecha += 10;
            else if (input.IsKeyDown(Key.A)) izquierda += 10;

            base.OnUpdateFrame(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color4.Black);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-300, 300, -300, 300, -300, 300);


            //escenario = new Escenario();
            //escenario.agregarObjeto("casa1", "Casa.json");
            //escenario.agregarObjeto("casa2", "Casa.json");

            base.OnLoad(e);
        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Rotate(arriba, abajo, derecha, izquierda);

            //escenario.dibujar();

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {

            base.OnResize(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);
        }


    }
}
