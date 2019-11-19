namespace Navegador
{
    partial class PagInicio
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
            this.richTextBox1nuevoFavorito = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1nuevoFavorito
            // 
            this.richTextBox1nuevoFavorito.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1nuevoFavorito.Name = "richTextBox1nuevoFavorito";
            this.richTextBox1nuevoFavorito.Size = new System.Drawing.Size(507, 28);
            this.richTextBox1nuevoFavorito.TabIndex = 0;
            this.richTextBox1nuevoFavorito.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(229, 82);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PagInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 135);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.richTextBox1nuevoFavorito);
            this.Name = "PagInicio";
            this.Text = "Nueva página inicio";
            this.Load += new System.EventHandler(this.PagInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1nuevoFavorito;
        private System.Windows.Forms.Button btnGuardar;
    }
}