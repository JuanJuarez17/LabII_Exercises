namespace _10_02
{
    partial class FrmPrincipal
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
            btn_Calcular=new System.Windows.Forms.Button();
            lbl_Kilometros=new System.Windows.Forms.Label();
            txb_Kilometros=new System.Windows.Forms.TextBox();
            lbl_Litros=new System.Windows.Forms.Label();
            txb_Litros=new System.Windows.Forms.TextBox();
            rtb_Mensaje=new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location=new System.Drawing.Point(197, 226);
            btn_Calcular.Name="btn_Calcular";
            btn_Calcular.Size=new System.Drawing.Size(75, 23);
            btn_Calcular.TabIndex=0;
            btn_Calcular.Text="Calcular";
            btn_Calcular.UseVisualStyleBackColor=true;
            btn_Calcular.Click+=btn_Calcular_Click;
            // 
            // lbl_Kilometros
            // 
            lbl_Kilometros.AutoSize=true;
            lbl_Kilometros.Location=new System.Drawing.Point(12, 9);
            lbl_Kilometros.Name="lbl_Kilometros";
            lbl_Kilometros.Size=new System.Drawing.Size(64, 15);
            lbl_Kilometros.TabIndex=1;
            lbl_Kilometros.Text="Kilometros";
            // 
            // txb_Kilometros
            // 
            txb_Kilometros.Location=new System.Drawing.Point(12, 27);
            txb_Kilometros.Name="txb_Kilometros";
            txb_Kilometros.Size=new System.Drawing.Size(100, 23);
            txb_Kilometros.TabIndex=2;
            // 
            // lbl_Litros
            // 
            lbl_Litros.AutoSize=true;
            lbl_Litros.Location=new System.Drawing.Point(12, 74);
            lbl_Litros.Name="lbl_Litros";
            lbl_Litros.Size=new System.Drawing.Size(36, 15);
            lbl_Litros.TabIndex=3;
            lbl_Litros.Text="Litros";
            // 
            // txb_Litros
            // 
            txb_Litros.Location=new System.Drawing.Point(12, 92);
            txb_Litros.Name="txb_Litros";
            txb_Litros.Size=new System.Drawing.Size(100, 23);
            txb_Litros.TabIndex=4;
            // 
            // rtb_Mensaje
            // 
            rtb_Mensaje.Enabled=false;
            rtb_Mensaje.Location=new System.Drawing.Point(118, 12);
            rtb_Mensaje.Name="rtb_Mensaje";
            rtb_Mensaje.Size=new System.Drawing.Size(154, 208);
            rtb_Mensaje.TabIndex=5;
            rtb_Mensaje.Text="";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions=new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            ClientSize=new System.Drawing.Size(284, 261);
            Controls.Add(rtb_Mensaje);
            Controls.Add(txb_Litros);
            Controls.Add(lbl_Litros);
            Controls.Add(txb_Kilometros);
            Controls.Add(lbl_Kilometros);
            Controls.Add(btn_Calcular);
            MinimumSize=new System.Drawing.Size(300, 300);
            Name="FrmPrincipal";
            StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Kilometros;
        private System.Windows.Forms.TextBox txb_Kilometros;
        private System.Windows.Forms.Label lbl_Litros;
        private System.Windows.Forms.TextBox txb_Litros;
        private System.Windows.Forms.RichTextBox rtb_Mensaje;
    }
}
