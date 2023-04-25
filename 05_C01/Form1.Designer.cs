namespace _05_C01
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Euro = new System.Windows.Forms.Label();
            this.lbl_Dolar = new System.Windows.Forms.Label();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.lbl_Cotizacion = new System.Windows.Forms.Label();
            this.txb_Euro = new System.Windows.Forms.TextBox();
            this.txb_Dolar = new System.Windows.Forms.TextBox();
            this.txb_Peso = new System.Windows.Forms.TextBox();
            this.btn_ConvertEuro = new System.Windows.Forms.Button();
            this.btn_ConvertDolar = new System.Windows.Forms.Button();
            this.btn_ConvertPeso = new System.Windows.Forms.Button();
            this.txb_EuroAEuro = new System.Windows.Forms.TextBox();
            this.txb_EuroADolar = new System.Windows.Forms.TextBox();
            this.txb_EuroAPeso = new System.Windows.Forms.TextBox();
            this.txb_DolarAEuro = new System.Windows.Forms.TextBox();
            this.txb_DolarADolar = new System.Windows.Forms.TextBox();
            this.txb_DolarAPeso = new System.Windows.Forms.TextBox();
            this.txb_PesoAEuro = new System.Windows.Forms.TextBox();
            this.txb_PesoADolar = new System.Windows.Forms.TextBox();
            this.txb_PesoAPeso = new System.Windows.Forms.TextBox();
            this.txb_CotizacionEuro = new System.Windows.Forms.TextBox();
            this.txb_CotizacionDolar = new System.Windows.Forms.TextBox();
            this.txb_CotizacionPeso = new System.Windows.Forms.TextBox();
            this.igl_Candado = new System.Windows.Forms.ImageList(this.components);
            this.btn_AtcCotz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Euro
            // 
            this.lbl_Euro.AutoSize = true;
            this.lbl_Euro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Euro.Location = new System.Drawing.Point(29, 87);
            this.lbl_Euro.Name = "lbl_Euro";
            this.lbl_Euro.Size = new System.Drawing.Size(45, 21);
            this.lbl_Euro.TabIndex = 0;
            this.lbl_Euro.Text = "Euro";
            // 
            // lbl_Dolar
            // 
            this.lbl_Dolar.AutoSize = true;
            this.lbl_Dolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dolar.Location = new System.Drawing.Point(29, 130);
            this.lbl_Dolar.Name = "lbl_Dolar";
            this.lbl_Dolar.Size = new System.Drawing.Size(52, 21);
            this.lbl_Dolar.TabIndex = 1;
            this.lbl_Dolar.Text = "Dolar";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Peso.Location = new System.Drawing.Point(29, 173);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(46, 21);
            this.lbl_Peso.TabIndex = 2;
            this.lbl_Peso.Text = "Peso";
            // 
            // lbl_Cotizacion
            // 
            this.lbl_Cotizacion.AutoSize = true;
            this.lbl_Cotizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cotizacion.Location = new System.Drawing.Point(120, 20);
            this.lbl_Cotizacion.Name = "lbl_Cotizacion";
            this.lbl_Cotizacion.Size = new System.Drawing.Size(91, 21);
            this.lbl_Cotizacion.TabIndex = 3;
            this.lbl_Cotizacion.Text = "Cotizacion";
            // 
            // txb_Euro
            // 
            this.txb_Euro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Euro.Location = new System.Drawing.Point(111, 84);
            this.txb_Euro.Name = "txb_Euro";
            this.txb_Euro.Size = new System.Drawing.Size(100, 29);
            this.txb_Euro.TabIndex = 4;
            this.txb_Euro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_Dolar
            // 
            this.txb_Dolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Dolar.Location = new System.Drawing.Point(111, 127);
            this.txb_Dolar.Name = "txb_Dolar";
            this.txb_Dolar.Size = new System.Drawing.Size(100, 29);
            this.txb_Dolar.TabIndex = 5;
            this.txb_Dolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_Peso
            // 
            this.txb_Peso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Peso.Location = new System.Drawing.Point(111, 170);
            this.txb_Peso.Name = "txb_Peso";
            this.txb_Peso.Size = new System.Drawing.Size(100, 29);
            this.txb_Peso.TabIndex = 6;
            this.txb_Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ConvertEuro
            // 
            this.btn_ConvertEuro.Location = new System.Drawing.Point(230, 84);
            this.btn_ConvertEuro.Name = "btn_ConvertEuro";
            this.btn_ConvertEuro.Size = new System.Drawing.Size(75, 29);
            this.btn_ConvertEuro.TabIndex = 7;
            this.btn_ConvertEuro.Text = "->";
            this.btn_ConvertEuro.UseVisualStyleBackColor = true;
            this.btn_ConvertEuro.Click += new System.EventHandler(this.btn_ConvertEuro_Click);
            // 
            // btn_ConvertDolar
            // 
            this.btn_ConvertDolar.Location = new System.Drawing.Point(230, 127);
            this.btn_ConvertDolar.Name = "btn_ConvertDolar";
            this.btn_ConvertDolar.Size = new System.Drawing.Size(75, 29);
            this.btn_ConvertDolar.TabIndex = 8;
            this.btn_ConvertDolar.Text = "->";
            this.btn_ConvertDolar.UseVisualStyleBackColor = true;
            this.btn_ConvertDolar.Click += new System.EventHandler(this.btn_ConvertDolar_Click);
            // 
            // btn_ConvertPeso
            // 
            this.btn_ConvertPeso.Location = new System.Drawing.Point(230, 170);
            this.btn_ConvertPeso.Name = "btn_ConvertPeso";
            this.btn_ConvertPeso.Size = new System.Drawing.Size(75, 29);
            this.btn_ConvertPeso.TabIndex = 9;
            this.btn_ConvertPeso.Text = "->";
            this.btn_ConvertPeso.UseVisualStyleBackColor = true;
            this.btn_ConvertPeso.Click += new System.EventHandler(this.btn_ConvertPeso_Click);
            // 
            // txb_EuroAEuro
            // 
            this.txb_EuroAEuro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_EuroAEuro.Location = new System.Drawing.Point(320, 84);
            this.txb_EuroAEuro.Name = "txb_EuroAEuro";
            this.txb_EuroAEuro.Size = new System.Drawing.Size(100, 29);
            this.txb_EuroAEuro.TabIndex = 10;
            this.txb_EuroAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_EuroADolar
            // 
            this.txb_EuroADolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_EuroADolar.Location = new System.Drawing.Point(440, 83);
            this.txb_EuroADolar.Name = "txb_EuroADolar";
            this.txb_EuroADolar.Size = new System.Drawing.Size(100, 29);
            this.txb_EuroADolar.TabIndex = 11;
            this.txb_EuroADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_EuroAPeso
            // 
            this.txb_EuroAPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_EuroAPeso.Location = new System.Drawing.Point(558, 84);
            this.txb_EuroAPeso.Name = "txb_EuroAPeso";
            this.txb_EuroAPeso.Size = new System.Drawing.Size(100, 29);
            this.txb_EuroAPeso.TabIndex = 12;
            this.txb_EuroAPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_DolarAEuro
            // 
            this.txb_DolarAEuro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_DolarAEuro.Location = new System.Drawing.Point(320, 126);
            this.txb_DolarAEuro.Name = "txb_DolarAEuro";
            this.txb_DolarAEuro.Size = new System.Drawing.Size(100, 29);
            this.txb_DolarAEuro.TabIndex = 13;
            this.txb_DolarAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_DolarADolar
            // 
            this.txb_DolarADolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_DolarADolar.Location = new System.Drawing.Point(440, 126);
            this.txb_DolarADolar.Name = "txb_DolarADolar";
            this.txb_DolarADolar.Size = new System.Drawing.Size(100, 29);
            this.txb_DolarADolar.TabIndex = 14;
            this.txb_DolarADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_DolarAPeso
            // 
            this.txb_DolarAPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_DolarAPeso.Location = new System.Drawing.Point(558, 126);
            this.txb_DolarAPeso.Name = "txb_DolarAPeso";
            this.txb_DolarAPeso.Size = new System.Drawing.Size(100, 29);
            this.txb_DolarAPeso.TabIndex = 15;
            this.txb_DolarAPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_PesoAEuro
            // 
            this.txb_PesoAEuro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_PesoAEuro.Location = new System.Drawing.Point(320, 169);
            this.txb_PesoAEuro.Name = "txb_PesoAEuro";
            this.txb_PesoAEuro.Size = new System.Drawing.Size(100, 29);
            this.txb_PesoAEuro.TabIndex = 16;
            this.txb_PesoAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_PesoADolar
            // 
            this.txb_PesoADolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_PesoADolar.Location = new System.Drawing.Point(440, 169);
            this.txb_PesoADolar.Name = "txb_PesoADolar";
            this.txb_PesoADolar.Size = new System.Drawing.Size(100, 29);
            this.txb_PesoADolar.TabIndex = 17;
            this.txb_PesoADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_PesoAPeso
            // 
            this.txb_PesoAPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_PesoAPeso.Location = new System.Drawing.Point(558, 169);
            this.txb_PesoAPeso.Name = "txb_PesoAPeso";
            this.txb_PesoAPeso.Size = new System.Drawing.Size(100, 29);
            this.txb_PesoAPeso.TabIndex = 18;
            this.txb_PesoAPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_CotizacionEuro
            // 
            this.txb_CotizacionEuro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_CotizacionEuro.Location = new System.Drawing.Point(320, 17);
            this.txb_CotizacionEuro.Name = "txb_CotizacionEuro";
            this.txb_CotizacionEuro.Size = new System.Drawing.Size(100, 29);
            this.txb_CotizacionEuro.TabIndex = 19;
            this.txb_CotizacionEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_CotizacionEuro.Leave += new System.EventHandler(this.txb_CotizacionEuro_Leave);
            // 
            // txb_CotizacionDolar
            // 
            this.txb_CotizacionDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_CotizacionDolar.Location = new System.Drawing.Point(440, 17);
            this.txb_CotizacionDolar.Name = "txb_CotizacionDolar";
            this.txb_CotizacionDolar.Size = new System.Drawing.Size(100, 29);
            this.txb_CotizacionDolar.TabIndex = 20;
            this.txb_CotizacionDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_CotizacionDolar.LostFocus += new System.EventHandler(this.txb_CotizacionDolar_LostFocus);
            // 
            // txb_CotizacionPeso
            // 
            this.txb_CotizacionPeso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_CotizacionPeso.Location = new System.Drawing.Point(558, 17);
            this.txb_CotizacionPeso.Name = "txb_CotizacionPeso";
            this.txb_CotizacionPeso.Size = new System.Drawing.Size(100, 29);
            this.txb_CotizacionPeso.TabIndex = 21;
            this.txb_CotizacionPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_CotizacionPeso.Leave += new System.EventHandler(this.txb_CotizacionPeso_Leave);
            // 
            // igl_Candado
            // 
            this.igl_Candado.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.igl_Candado.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("igl_Candado.ImageStream")));
            this.igl_Candado.TransparentColor = System.Drawing.Color.Transparent;
            this.igl_Candado.Images.SetKeyName(0, "candado_abierto.png");
            this.igl_Candado.Images.SetKeyName(1, "candado_cerrado.png");
            // 
            // btn_AtcCotz
            // 
            this.btn_AtcCotz.ImageList = this.igl_Candado;
            this.btn_AtcCotz.Location = new System.Drawing.Point(230, 17);
            this.btn_AtcCotz.Name = "btn_AtcCotz";
            this.btn_AtcCotz.Size = new System.Drawing.Size(75, 29);
            this.btn_AtcCotz.TabIndex = 22;
            this.btn_AtcCotz.UseVisualStyleBackColor = true;
            this.btn_AtcCotz.Click += new System.EventHandler(this.btn_AtcCotz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(349, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(466, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(588, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AtcCotz);
            this.Controls.Add(this.txb_CotizacionPeso);
            this.Controls.Add(this.txb_CotizacionDolar);
            this.Controls.Add(this.txb_CotizacionEuro);
            this.Controls.Add(this.txb_PesoAPeso);
            this.Controls.Add(this.txb_PesoADolar);
            this.Controls.Add(this.txb_PesoAEuro);
            this.Controls.Add(this.txb_DolarAPeso);
            this.Controls.Add(this.txb_DolarADolar);
            this.Controls.Add(this.txb_DolarAEuro);
            this.Controls.Add(this.txb_EuroAPeso);
            this.Controls.Add(this.txb_EuroADolar);
            this.Controls.Add(this.txb_EuroAEuro);
            this.Controls.Add(this.btn_ConvertPeso);
            this.Controls.Add(this.btn_ConvertDolar);
            this.Controls.Add(this.btn_ConvertEuro);
            this.Controls.Add(this.txb_Peso);
            this.Controls.Add(this.txb_Dolar);
            this.Controls.Add(this.txb_Euro);
            this.Controls.Add(this.lbl_Cotizacion);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.lbl_Dolar);
            this.Controls.Add(this.lbl_Euro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Euro;
        private System.Windows.Forms.Label lbl_Dolar;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.Label lbl_Cotizacion;
        private System.Windows.Forms.TextBox txb_Euro;
        private System.Windows.Forms.TextBox txb_Dolar;
        private System.Windows.Forms.TextBox txb_Peso;
        private System.Windows.Forms.Button btn_ConvertEuro;
        private System.Windows.Forms.Button btn_ConvertDolar;
        private System.Windows.Forms.Button btn_ConvertPeso;
        private System.Windows.Forms.TextBox txb_EuroAEuro;
        private System.Windows.Forms.TextBox txb_EuroADolar;
        private System.Windows.Forms.TextBox txb_EuroAPeso;
        private System.Windows.Forms.TextBox txb_DolarAEuro;
        private System.Windows.Forms.TextBox txb_DolarADolar;
        private System.Windows.Forms.TextBox txb_DolarAPeso;
        private System.Windows.Forms.TextBox txb_PesoAEuro;
        private System.Windows.Forms.TextBox txb_PesoADolar;
        private System.Windows.Forms.TextBox txb_PesoAPeso;
        private System.Windows.Forms.TextBox txb_CotizacionEuro;
        private System.Windows.Forms.TextBox txb_CotizacionDolar;
        private System.Windows.Forms.TextBox txb_CotizacionPeso;
        private System.Windows.Forms.ImageList igl_Candado;
        private System.Windows.Forms.Button btn_AtcCotz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
