
namespace Proyecto_Grafica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.glControl1 = new OpenTK.GLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEscenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_eje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_esc = new System.Windows.Forms.TextBox();
            this.button_escalar = new System.Windows.Forms.Button();
            this.Xe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ye = new System.Windows.Forms.TextBox();
            this.Ze = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_trasladar = new System.Windows.Forms.Button();
            this.button_rotar = new System.Windows.Forms.Button();
            this.textBox_angulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_objetos = new System.Windows.Forms.ComboBox();
            this.comboBox_faces = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // X
            // 
            resources.ApplyResources(this.X, "X");
            this.X.Name = "X";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // Y
            // 
            resources.ApplyResources(this.Y, "Y");
            this.Y.Name = "Y";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // Z
            // 
            resources.ApplyResources(this.Z, "Z");
            this.Z.Name = "Z";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.glControl1, "glControl1");
            this.glControl1.Name = "glControl1";
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEscenarioToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // nuevoEscenarioToolStripMenuItem
            // 
            this.nuevoEscenarioToolStripMenuItem.Name = "nuevoEscenarioToolStripMenuItem";
            resources.ApplyResources(this.nuevoEscenarioToolStripMenuItem, "nuevoEscenarioToolStripMenuItem");
            this.nuevoEscenarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoEscenarioToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox_eje);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_esc);
            this.panel1.Controls.Add(this.button_escalar);
            this.panel1.Controls.Add(this.Xe);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Ye);
            this.panel1.Controls.Add(this.Ze);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_trasladar);
            this.panel1.Controls.Add(this.button_rotar);
            this.panel1.Controls.Add(this.textBox_angulo);
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Y);
            this.panel1.Controls.Add(this.Z);
            this.panel1.Controls.Add(this.label3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // textBox_eje
            // 
            resources.ApplyResources(this.textBox_eje, "textBox_eje");
            this.textBox_eje.Name = "textBox_eje";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Name = "label8";
            // 
            // textBox_esc
            // 
            resources.ApplyResources(this.textBox_esc, "textBox_esc");
            this.textBox_esc.Name = "textBox_esc";
            // 
            // button_escalar
            // 
            resources.ApplyResources(this.button_escalar, "button_escalar");
            this.button_escalar.Name = "button_escalar";
            this.button_escalar.UseVisualStyleBackColor = true;
            this.button_escalar.Click += new System.EventHandler(this.button_escalar_Click);
            // 
            // Xe
            // 
            resources.ApplyResources(this.Xe, "Xe");
            this.Xe.Name = "Xe";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Name = "label6";
            // 
            // Ye
            // 
            resources.ApplyResources(this.Ye, "Ye");
            this.Ye.Name = "Ye";
            // 
            // Ze
            // 
            resources.ApplyResources(this.Ze, "Ze");
            this.Ze.Name = "Ze";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Name = "label7";
            // 
            // button_trasladar
            // 
            resources.ApplyResources(this.button_trasladar, "button_trasladar");
            this.button_trasladar.Name = "button_trasladar";
            this.button_trasladar.UseVisualStyleBackColor = true;
            this.button_trasladar.Click += new System.EventHandler(this.button_trasladar_Click);
            // 
            // button_rotar
            // 
            resources.ApplyResources(this.button_rotar, "button_rotar");
            this.button_rotar.Name = "button_rotar";
            this.button_rotar.UseVisualStyleBackColor = true;
            this.button_rotar.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_angulo
            // 
            resources.ApplyResources(this.textBox_angulo, "textBox_angulo");
            this.textBox_angulo.Name = "textBox_angulo";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // comboBox_objetos
            // 
            this.comboBox_objetos.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_objetos, "comboBox_objetos");
            this.comboBox_objetos.Name = "comboBox_objetos";
            // 
            // comboBox_faces
            // 
            this.comboBox_faces.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_faces, "comboBox_faces");
            this.comboBox_faces.Name = "comboBox_faces";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.comboBox_faces);
            this.Controls.Add(this.comboBox_objetos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Z;
        private System.Windows.Forms.Button button2;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEscenarioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_rotar;
        private System.Windows.Forms.TextBox textBox_angulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_esc;
        private System.Windows.Forms.Button button_escalar;
        private System.Windows.Forms.TextBox Xe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Ye;
        private System.Windows.Forms.TextBox Ze;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_trasladar;
        private System.Windows.Forms.TextBox textBox_eje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_objetos;
        private System.Windows.Forms.ComboBox comboBox_faces;
    }
}

