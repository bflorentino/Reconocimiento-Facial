namespace ReconocimientoFacial
{
    partial class VerPersona
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Historial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textocorreo = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textotelefono = new System.Windows.Forms.TextBox();
            this.txtHistorial = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtHistorial);
            this.panel1.Controls.Add(this.textotelefono);
            this.panel1.Controls.Add(this.textnombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Historial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textocorreo);
            this.panel1.Location = new System.Drawing.Point(75, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 318);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // Historial
            // 
            this.Historial.AutoSize = true;
            this.Historial.Location = new System.Drawing.Point(3, 216);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(74, 13);
            this.Historial.TabIndex = 10;
            this.Historial.Text = "Historial Penal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // textocorreo
            // 
            this.textocorreo.Location = new System.Drawing.Point(74, 111);
            this.textocorreo.Name = "textocorreo";
            this.textocorreo.Size = new System.Drawing.Size(188, 20);
            this.textocorreo.TabIndex = 3;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(74, 73);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(188, 20);
            this.textnombre.TabIndex = 11;
            // 
            // textotelefono
            // 
            this.textotelefono.Location = new System.Drawing.Point(74, 150);
            this.textotelefono.Name = "textotelefono";
            this.textotelefono.Size = new System.Drawing.Size(188, 20);
            this.textotelefono.TabIndex = 12;
            // 
            // txtHistorial
            // 
            this.txtHistorial.Location = new System.Drawing.Point(74, 192);
            this.txtHistorial.Multiline = true;
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.Size = new System.Drawing.Size(188, 83);
            this.txtHistorial.TabIndex = 13;
            // 
            // VerPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 393);
            this.Controls.Add(this.panel1);
            this.Name = "VerPersona";
            this.Text = "VerPersona";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Historial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textocorreo;
        private System.Windows.Forms.TextBox textotelefono;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox txtHistorial;
    }
}