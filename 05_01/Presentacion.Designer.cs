namespace _05_01
{
    partial class Presentacion
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
            txb_Nombre = new System.Windows.Forms.TextBox();
            txb_Apellido = new System.Windows.Forms.TextBox();
            lbl_Nombre = new System.Windows.Forms.Label();
            lbl_Apellido = new System.Windows.Forms.Label();
            btn_Saludar = new System.Windows.Forms.Button();
            lbl_Materias = new System.Windows.Forms.Label();
            cbb_Materias = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // txb_Nombre
            // 
            txb_Nombre.Location = new System.Drawing.Point(52, 40);
            txb_Nombre.Name = "txb_Nombre";
            txb_Nombre.Size = new System.Drawing.Size(150, 23);
            txb_Nombre.TabIndex = 0;
            // 
            // txb_Apellido
            // 
            txb_Apellido.Location = new System.Drawing.Point(287, 40);
            txb_Apellido.Name = "txb_Apellido";
            txb_Apellido.Size = new System.Drawing.Size(150, 23);
            txb_Apellido.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Nombre.Location = new System.Drawing.Point(52, 18);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(65, 19);
            lbl_Nombre.TabIndex = 2;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Apellido.Location = new System.Drawing.Point(287, 18);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new System.Drawing.Size(66, 19);
            lbl_Apellido.TabIndex = 3;
            lbl_Apellido.Text = "Apellido";
            // 
            // btn_Saludar
            // 
            btn_Saludar.Location = new System.Drawing.Point(287, 159);
            btn_Saludar.Name = "btn_Saludar";
            btn_Saludar.Size = new System.Drawing.Size(150, 23);
            btn_Saludar.TabIndex = 4;
            btn_Saludar.Text = "Saludar";
            btn_Saludar.UseVisualStyleBackColor = true;
            btn_Saludar.Click += btn_Saludar_Click;
            // 
            // lbl_Materias
            // 
            lbl_Materias.AutoSize = true;
            lbl_Materias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Materias.Location = new System.Drawing.Point(52, 83);
            lbl_Materias.Name = "lbl_Materias";
            lbl_Materias.Size = new System.Drawing.Size(118, 19);
            lbl_Materias.TabIndex = 5;
            lbl_Materias.Text = "Materia favorita";
            // 
            // cbb_Materias
            // 
            cbb_Materias.FormattingEnabled = true;
            cbb_Materias.Location = new System.Drawing.Point(52, 111);
            cbb_Materias.Name = "cbb_Materias";
            cbb_Materias.Size = new System.Drawing.Size(385, 23);
            cbb_Materias.TabIndex = 6;
            // 
            // Presentacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 211);
            Controls.Add(cbb_Materias);
            Controls.Add(lbl_Materias);
            Controls.Add(btn_Saludar);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(txb_Apellido);
            Controls.Add(txb_Nombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Presentacion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "¡Hola, Window Forms!";
            Load += Presentacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.TextBox txb_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Button btn_Saludar;
        private System.Windows.Forms.Label lbl_Materias;
        private System.Windows.Forms.ComboBox cbb_Materias;
    }
}
