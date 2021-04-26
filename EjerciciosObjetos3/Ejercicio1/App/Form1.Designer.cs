
namespace App
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.TextBox();
            this.Historial = new System.Windows.Forms.Label();
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma y Resta de números";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 69);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 23);
            this.num1.TabIndex = 1;
            this.num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresa Numero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(177, 108);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(100, 23);
            this.resultado.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Acumulado";
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(337, 71);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.Size = new System.Drawing.Size(352, 189);
            this.history.TabIndex = 8;
            // 
            // Historial
            // 
            this.Historial.AutoSize = true;
            this.Historial.Location = new System.Drawing.Point(337, 48);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(51, 15);
            this.Historial.TabIndex = 9;
            this.Historial.Text = "Historial";
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(12, 108);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(75, 23);
            this.sumar.TabIndex = 10;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(12, 149);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(75, 23);
            this.restar.TabIndex = 11;
            this.restar.Text = "Restar";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.history);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Total Acumulado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Label Historial;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
    }
}

