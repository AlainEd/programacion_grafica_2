using Newtonsoft.Json;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grafica
{
    public partial class Form1 : Form
    {
        Escenario escenario;
        Dictionary<string, string> listaObj;
        public Form1()
        {
            InitializeComponent();
            iniciarEscenario();
            cargarObjetos();
        }
   
        public void iniciarEscenario()
        {
            escenario = new Escenario();
        }

        public void cargarObjetos()
        {
            listaObj = new Dictionary<string, string>();
            listaObj.Add("Casa", "Casa.json");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (listaObj != null) { 
                foreach (var item in listaObj)
                {
                    comboBox1.Items.Add(item.Key);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string objSeleccionado = comboBox1.SelectedItem.ToString();
            foreach (var item in listaObj)
            {
                if (item.Key == objSeleccionado)
                {
                    escenario.agregarObjeto(objSeleccionado, item.Value);
                }
            }
            
            glControl1.Refresh();
        }


        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-300, 300, -300, 300, -300, 300);
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
 
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            if (escenario.ListaObj != null)
                escenario.dibujar();

            glControl1.SwapBuffers();
        }

        private void nuevoEscenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            escenario = new Escenario();
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            if (escenario == null)
            {
                MessageBox.Show("No se creó el escenario");
                return;
            }

            if (String.IsNullOrEmpty(textBox_eje.Text))
            {
                MessageBox.Show("Selecciona un eje para la rotación.");
                return;
            }

            Vector3d eje = new Vector3d();

            if (textBox_eje.Text == "X")
            {
                eje = new Vector3d(1, 0, 0);
            }else if (textBox_eje.Text == "Y")
            {
                eje = new Vector3d(0, 1, 0);
            }else if (textBox_eje.Text == "Z")
            {
                eje = new Vector3d(0, 0, 1);
            }
            escenario.rotar(Int32.Parse(textBox_angulo.Text), eje);
            glControl1.Refresh();
                
        }

        private void button_trasladar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(X.Text) || String.IsNullOrEmpty(Y.Text) || String.IsNullOrEmpty(Z.Text))
            {
                MessageBox.Show("Ingresa un valor en 'X', 'Y' y 'Z' para realizar la traslacion.");
                return;
            }

            double x = Double.Parse(X.Text);
            double y = Double.Parse(Y.Text);
            double z = Double.Parse(Z.Text);

            Vector3d centro = new Vector3d(x, y, z);

            escenario.trasladar(centro);
            glControl1.Refresh();
        }

        private void button_escalar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_esc.Text))
            {
                MessageBox.Show("Ingresa un valor en 'X', 'Y' y 'Z' o en 'Factor escala' para realizar la escalacion.");
                return;
            }

            double x = Double.Parse(Xe.Text);
            double y = Double.Parse(Ye.Text);
            double z = Double.Parse(Ze.Text);

            Vector3d centro = new Vector3d(x, y, z);

            if (centro.X != 0 || centro.Y != 0 || centro.Z != 0)
            {
                escenario.escalar(centro);
            }
            else
            {
                float fe = float.Parse(textBox_esc.Text);
                escenario.escalar((float)fe);
            }
            glControl1.Refresh();
        }
    }
}
