namespace _05_02
{
    partial class Ingreso
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
            lbl_DetalleAl = new System.Windows.Forms.Label();
            btn_Aceptar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbl_DetalleAl
            // 
            lbl_DetalleAl.Location = new System.Drawing.Point(12, 18);
            lbl_DetalleAl.Name = "lbl_DetalleAl";
            lbl_DetalleAl.Size = new System.Drawing.Size(160, 240);
            lbl_DetalleAl.TabIndex = 0;
            lbl_DetalleAl.Text = "label1";
            lbl_DetalleAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new System.Drawing.Point(97, 246);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            btn_Aceptar.TabIndex = 1;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(184, 281);
            Controls.Add(btn_Aceptar);
            Controls.Add(lbl_DetalleAl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Ingreso";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ingreso";
            Load += Ingreso_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lbl_DetalleAl;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}