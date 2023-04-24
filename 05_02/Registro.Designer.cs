namespace _05_02
{
    partial class Registro
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
            gpb_Detalles = new System.Windows.Forms.GroupBox();
            nud_Edad = new System.Windows.Forms.NumericUpDown();
            txb_Direccion = new System.Windows.Forms.TextBox();
            txb_Nombre = new System.Windows.Forms.TextBox();
            lbl_Edad = new System.Windows.Forms.Label();
            lbl_Direccion = new System.Windows.Forms.Label();
            lbl_Nombre = new System.Windows.Forms.Label();
            gpb_Genero = new System.Windows.Forms.GroupBox();
            rdb_Nobinario = new System.Windows.Forms.RadioButton();
            rdb_Femenino = new System.Windows.Forms.RadioButton();
            rdb_Masculino = new System.Windows.Forms.RadioButton();
            gpb_Cursos = new System.Windows.Forms.GroupBox();
            chb_JavaScript = new System.Windows.Forms.CheckBox();
            chb_CPlus = new System.Windows.Forms.CheckBox();
            chb_CSharp = new System.Windows.Forms.CheckBox();
            ltb_Pais = new System.Windows.Forms.ListBox();
            lbl_Pais = new System.Windows.Forms.Label();
            btn_Ingresar = new System.Windows.Forms.Button();
            gpb_Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Edad).BeginInit();
            gpb_Genero.SuspendLayout();
            gpb_Cursos.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_Detalles
            // 
            gpb_Detalles.Controls.Add(nud_Edad);
            gpb_Detalles.Controls.Add(txb_Direccion);
            gpb_Detalles.Controls.Add(txb_Nombre);
            gpb_Detalles.Controls.Add(lbl_Edad);
            gpb_Detalles.Controls.Add(lbl_Direccion);
            gpb_Detalles.Controls.Add(lbl_Nombre);
            gpb_Detalles.Location = new System.Drawing.Point(21, 17);
            gpb_Detalles.Name = "gpb_Detalles";
            gpb_Detalles.Size = new System.Drawing.Size(250, 150);
            gpb_Detalles.TabIndex = 0;
            gpb_Detalles.TabStop = false;
            gpb_Detalles.Text = "Detalles del usuario";
            // 
            // nud_Edad
            // 
            nud_Edad.Location = new System.Drawing.Point(98, 106);
            nud_Edad.Name = "nud_Edad";
            nud_Edad.Size = new System.Drawing.Size(130, 23);
            nud_Edad.TabIndex = 5;
            // 
            // txb_Direccion
            // 
            txb_Direccion.Location = new System.Drawing.Point(98, 69);
            txb_Direccion.Name = "txb_Direccion";
            txb_Direccion.Size = new System.Drawing.Size(130, 23);
            txb_Direccion.TabIndex = 4;
            // 
            // txb_Nombre
            // 
            txb_Nombre.Location = new System.Drawing.Point(98, 34);
            txb_Nombre.Name = "txb_Nombre";
            txb_Nombre.Size = new System.Drawing.Size(130, 23);
            txb_Nombre.TabIndex = 3;
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize = true;
            lbl_Edad.Location = new System.Drawing.Point(22, 108);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new System.Drawing.Size(33, 15);
            lbl_Edad.TabIndex = 2;
            lbl_Edad.Text = "Edad";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new System.Drawing.Point(22, 72);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new System.Drawing.Size(57, 15);
            lbl_Direccion.TabIndex = 1;
            lbl_Direccion.Text = "Dirección";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new System.Drawing.Point(22, 37);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "Nombre";
            // 
            // gpb_Genero
            // 
            gpb_Genero.Controls.Add(rdb_Nobinario);
            gpb_Genero.Controls.Add(rdb_Femenino);
            gpb_Genero.Controls.Add(rdb_Masculino);
            gpb_Genero.Location = new System.Drawing.Point(277, 17);
            gpb_Genero.Name = "gpb_Genero";
            gpb_Genero.Size = new System.Drawing.Size(120, 100);
            gpb_Genero.TabIndex = 1;
            gpb_Genero.TabStop = false;
            gpb_Genero.Text = "Género";
            // 
            // rdb_Nobinario
            // 
            rdb_Nobinario.AutoSize = true;
            rdb_Nobinario.Location = new System.Drawing.Point(22, 71);
            rdb_Nobinario.Name = "rdb_Nobinario";
            rdb_Nobinario.Size = new System.Drawing.Size(81, 19);
            rdb_Nobinario.TabIndex = 2;
            rdb_Nobinario.TabStop = true;
            rdb_Nobinario.Text = "No binario";
            rdb_Nobinario.UseVisualStyleBackColor = true;
            // 
            // rdb_Femenino
            // 
            rdb_Femenino.AutoSize = true;
            rdb_Femenino.Location = new System.Drawing.Point(22, 46);
            rdb_Femenino.Name = "rdb_Femenino";
            rdb_Femenino.Size = new System.Drawing.Size(78, 19);
            rdb_Femenino.TabIndex = 1;
            rdb_Femenino.TabStop = true;
            rdb_Femenino.Text = "Femenino";
            rdb_Femenino.UseVisualStyleBackColor = true;
            // 
            // rdb_Masculino
            // 
            rdb_Masculino.AutoSize = true;
            rdb_Masculino.Location = new System.Drawing.Point(22, 19);
            rdb_Masculino.Name = "rdb_Masculino";
            rdb_Masculino.Size = new System.Drawing.Size(80, 19);
            rdb_Masculino.TabIndex = 0;
            rdb_Masculino.TabStop = true;
            rdb_Masculino.Text = "Masculino";
            rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // gpb_Cursos
            // 
            gpb_Cursos.Controls.Add(chb_JavaScript);
            gpb_Cursos.Controls.Add(chb_CPlus);
            gpb_Cursos.Controls.Add(chb_CSharp);
            gpb_Cursos.Location = new System.Drawing.Point(277, 125);
            gpb_Cursos.Name = "gpb_Cursos";
            gpb_Cursos.Size = new System.Drawing.Size(120, 100);
            gpb_Cursos.TabIndex = 2;
            gpb_Cursos.TabStop = false;
            gpb_Cursos.Text = "Cursos";
            // 
            // chb_JavaScript
            // 
            chb_JavaScript.AutoSize = true;
            chb_JavaScript.Location = new System.Drawing.Point(22, 72);
            chb_JavaScript.Name = "chb_JavaScript";
            chb_JavaScript.Size = new System.Drawing.Size(78, 19);
            chb_JavaScript.TabIndex = 2;
            chb_JavaScript.Text = "JavaScript";
            chb_JavaScript.UseVisualStyleBackColor = true;
            // 
            // chb_CPlus
            // 
            chb_CPlus.AutoSize = true;
            chb_CPlus.Location = new System.Drawing.Point(22, 47);
            chb_CPlus.Name = "chb_CPlus";
            chb_CPlus.Size = new System.Drawing.Size(50, 19);
            chb_CPlus.TabIndex = 1;
            chb_CPlus.Text = "C++";
            chb_CPlus.UseVisualStyleBackColor = true;
            // 
            // chb_CSharp
            // 
            chb_CSharp.AutoSize = true;
            chb_CSharp.Location = new System.Drawing.Point(22, 22);
            chb_CSharp.Name = "chb_CSharp";
            chb_CSharp.Size = new System.Drawing.Size(41, 19);
            chb_CSharp.TabIndex = 0;
            chb_CSharp.Text = "C#";
            chb_CSharp.UseVisualStyleBackColor = true;
            // 
            // ltb_Pais
            // 
            ltb_Pais.FormattingEnabled = true;
            ltb_Pais.ItemHeight = 15;
            ltb_Pais.Location = new System.Drawing.Point(21, 188);
            ltb_Pais.Name = "ltb_Pais";
            ltb_Pais.Size = new System.Drawing.Size(250, 79);
            ltb_Pais.TabIndex = 3;
            // 
            // lbl_Pais
            // 
            lbl_Pais.AutoSize = true;
            lbl_Pais.Location = new System.Drawing.Point(21, 170);
            lbl_Pais.Name = "lbl_Pais";
            lbl_Pais.Size = new System.Drawing.Size(28, 15);
            lbl_Pais.TabIndex = 4;
            lbl_Pais.Text = "País";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new System.Drawing.Point(277, 242);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new System.Drawing.Size(120, 25);
            btn_Ingresar.TabIndex = 5;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(414, 281);
            Controls.Add(btn_Ingresar);
            Controls.Add(lbl_Pais);
            Controls.Add(ltb_Pais);
            Controls.Add(gpb_Cursos);
            Controls.Add(gpb_Genero);
            Controls.Add(gpb_Detalles);
            Name = "Registro";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            gpb_Detalles.ResumeLayout(false);
            gpb_Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Edad).EndInit();
            gpb_Genero.ResumeLayout(false);
            gpb_Genero.PerformLayout();
            gpb_Cursos.ResumeLayout(false);
            gpb_Cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Detalles;
        private System.Windows.Forms.NumericUpDown nud_Edad;
        private System.Windows.Forms.TextBox txb_Direccion;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.GroupBox gpb_Genero;
        private System.Windows.Forms.RadioButton rdb_Nobinario;
        private System.Windows.Forms.RadioButton rdb_Femenino;
        private System.Windows.Forms.RadioButton rdb_Masculino;
        private System.Windows.Forms.GroupBox gpb_Cursos;
        private System.Windows.Forms.CheckBox chb_JavaScript;
        private System.Windows.Forms.CheckBox chb_CPlus;
        private System.Windows.Forms.CheckBox chb_CSharp;
        private System.Windows.Forms.ListBox ltb_Pais;
        private System.Windows.Forms.Label lbl_Pais;
        private System.Windows.Forms.Button btn_Ingresar;
    }
}
