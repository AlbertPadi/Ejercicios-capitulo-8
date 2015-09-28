namespace EjerciciosCap8
{
    partial class Justificar
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDerecha = new System.Windows.Forms.Button();
            this.buttonHizquierda = new System.Windows.Forms.Button();
            this.richTextBoxTexto = new System.Windows.Forms.RichTextBox();
            this.textBoxTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Justificar a:";
            // 
            // buttonDerecha
            // 
            this.buttonDerecha.Location = new System.Drawing.Point(178, 271);
            this.buttonDerecha.Name = "buttonDerecha";
            this.buttonDerecha.Size = new System.Drawing.Size(75, 31);
            this.buttonDerecha.TabIndex = 3;
            this.buttonDerecha.Text = "Derecha";
            this.buttonDerecha.UseVisualStyleBackColor = true;
            this.buttonDerecha.Click += new System.EventHandler(this.buttonDerecha_Click);
            // 
            // buttonHizquierda
            // 
            this.buttonHizquierda.Location = new System.Drawing.Point(24, 271);
            this.buttonHizquierda.Name = "buttonHizquierda";
            this.buttonHizquierda.Size = new System.Drawing.Size(75, 31);
            this.buttonHizquierda.TabIndex = 1;
            this.buttonHizquierda.Text = "Hizquierda";
            this.buttonHizquierda.UseVisualStyleBackColor = true;
            this.buttonHizquierda.Click += new System.EventHandler(this.buttonHizquierda_Click);
            // 
            // richTextBoxTexto
            // 
            this.richTextBoxTexto.Location = new System.Drawing.Point(3, 146);
            this.richTextBoxTexto.Name = "richTextBoxTexto";
            this.richTextBoxTexto.Size = new System.Drawing.Size(269, 96);
            this.richTextBoxTexto.TabIndex = 2;
            this.richTextBoxTexto.Text = "";
            // 
            // textBoxTexto
            // 
            this.textBoxTexto.Location = new System.Drawing.Point(46, 68);
            this.textBoxTexto.Name = "textBoxTexto";
            this.textBoxTexto.Size = new System.Drawing.Size(186, 20);
            this.textBoxTexto.TabIndex = 0;
            // 
            // Justificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.textBoxTexto);
            this.Controls.Add(this.buttonHizquierda);
            this.Controls.Add(this.buttonDerecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxTexto);
            this.Name = "Justificar";
            this.Text = "Justificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDerecha;
        private System.Windows.Forms.Button buttonHizquierda;
        private System.Windows.Forms.RichTextBox richTextBoxTexto;
        private System.Windows.Forms.TextBox textBoxTexto;
    }
}