namespace EjerciciosCap8
{
    partial class MuestraCadena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCadena = new System.Windows.Forms.TextBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar cadena";
            // 
            // textBoxCadena
            // 
            this.textBoxCadena.Location = new System.Drawing.Point(111, 30);
            this.textBoxCadena.Name = "textBoxCadena";
            this.textBoxCadena.Size = new System.Drawing.Size(161, 20);
            this.textBoxCadena.TabIndex = 1;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(181, 88);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar.TabIndex = 2;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cadena";
            // 
            // richTextBoxResultado
            // 
            this.richTextBoxResultado.Location = new System.Drawing.Point(12, 154);
            this.richTextBoxResultado.Name = "richTextBoxResultado";
            this.richTextBoxResultado.Size = new System.Drawing.Size(260, 96);
            this.richTextBoxResultado.TabIndex = 5;
            this.richTextBoxResultado.Text = "";
            // 
            // MuestraCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextBoxResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.textBoxCadena);
            this.Controls.Add(this.label1);
            this.Name = "MuestraCadena";
            this.Text = "MuestraCadena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCadena;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxResultado;
    }
}