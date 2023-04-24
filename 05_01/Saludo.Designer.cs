namespace _05_01
{
    partial class Saludo
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
            lbl_Titulo = new System.Windows.Forms.Label();
            lbl_Mensaje = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Titulo.Location = new System.Drawing.Point(12, 33);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new System.Drawing.Size(94, 25);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "lbl_Titulo";
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Mensaje.Location = new System.Drawing.Point(12, 81);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new System.Drawing.Size(450, 50);
            lbl_Mensaje.TabIndex = 1;
            lbl_Mensaje.Text = "lbl_Mensaje";
            // 
            // Saludo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 161);
            Controls.Add(lbl_Mensaje);
            Controls.Add(lbl_Titulo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Saludo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Saludo";
            FormClosing += Saludo_FormClosing;
            Load += Saludo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Mensaje;
    }
}