
namespace LiquidacionSueldos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.aniosAntiguedad = new System.Windows.Forms.TextBox();
            this.cuil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cantidadHijos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectCargos = new System.Windows.Forms.ComboBox();
            this.liquidacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liquidacion de Sueldos";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(15, 39);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(51, 15);
            this.a.TabIndex = 1;
            this.a.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(15, 57);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(138, 23);
            this.nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(15, 101);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(138, 23);
            this.apellido.TabIndex = 4;
            // 
            // aniosAntiguedad
            // 
            this.aniosAntiguedad.Location = new System.Drawing.Point(15, 145);
            this.aniosAntiguedad.Name = "aniosAntiguedad";
            this.aniosAntiguedad.Size = new System.Drawing.Size(138, 23);
            this.aniosAntiguedad.TabIndex = 5;
            this.aniosAntiguedad.TextChanged += new System.EventHandler(this.aniosAntiguedad_TextChanged);
            this.aniosAntiguedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aniosAntiguedad_KeyPress);
            // 
            // cuil
            // 
            this.cuil.Location = new System.Drawing.Point(15, 189);
            this.cuil.Name = "cuil";
            this.cuil.Size = new System.Drawing.Size(138, 23);
            this.cuil.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Años de antiguedad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "CUIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad de hijos a cargo";
            // 
            // cantidadHijos
            // 
            this.cantidadHijos.Location = new System.Drawing.Point(15, 233);
            this.cantidadHijos.Name = "cantidadHijos";
            this.cantidadHijos.Size = new System.Drawing.Size(138, 23);
            this.cantidadHijos.TabIndex = 11;
            this.cantidadHijos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadHijos_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cargo";
            // 
            // selectCargos
            // 
            this.selectCargos.FormattingEnabled = true;
            this.selectCargos.Location = new System.Drawing.Point(15, 277);
            this.selectCargos.Name = "selectCargos";
            this.selectCargos.Size = new System.Drawing.Size(138, 23);
            this.selectCargos.TabIndex = 13;
            // 
            // liquidacion
            // 
            this.liquidacion.Location = new System.Drawing.Point(233, 57);
            this.liquidacion.Multiline = true;
            this.liquidacion.Name = "liquidacion";
            this.liquidacion.ReadOnly = true;
            this.liquidacion.Size = new System.Drawing.Size(362, 243);
            this.liquidacion.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Liquidar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liquidacion);
            this.Controls.Add(this.selectCargos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cantidadHijos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cuil);
            this.Controls.Add(this.aniosAntiguedad);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox aniosAntiguedad;
        private System.Windows.Forms.TextBox cuil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cantidadHijos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectCargos;
        private System.Windows.Forms.TextBox liquidacion;
        private System.Windows.Forms.Button button1;
    }
}

