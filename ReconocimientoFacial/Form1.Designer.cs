namespace ReconocimientoFacial
{
    partial class Form1
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
            this.picCaptura = new System.Windows.Forms.PictureBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnDetectar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.picCapturada = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnReconocer = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturada)).BeginInit();
            this.SuspendLayout();
            // 
            // picCaptura
            // 
            this.picCaptura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCaptura.Location = new System.Drawing.Point(15, 13);
            this.picCaptura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picCaptura.Name = "picCaptura";
            this.picCaptura.Size = new System.Drawing.Size(727, 425);
            this.picCaptura.TabIndex = 0;
            this.picCaptura.TabStop = false;
            // 
            // btnCaptura
            // 
            this.btnCaptura.BackColor = System.Drawing.Color.Crimson;
            this.btnCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaptura.Location = new System.Drawing.Point(748, 74);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(169, 23);
            this.btnCaptura.TabIndex = 1;
            this.btnCaptura.Text = "2. Encender Camara";
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnDetectar
            // 
            this.btnDetectar.BackColor = System.Drawing.Color.Crimson;
            this.btnDetectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetectar.Location = new System.Drawing.Point(749, 116);
            this.btnDetectar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDetectar.Name = "btnDetectar";
            this.btnDetectar.Size = new System.Drawing.Size(169, 23);
            this.btnDetectar.TabIndex = 2;
            this.btnDetectar.Text = "3. Detectar Rostro";
            this.btnDetectar.UseVisualStyleBackColor = false;
            this.btnDetectar.Click += new System.EventHandler(this.btnDetectar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Crimson;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Location = new System.Drawing.Point(749, 313);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(169, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "4.Capturar Persona";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Crimson;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrain.Location = new System.Drawing.Point(749, 354);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(169, 23);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "5. Consultar Persona";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // picCapturada
            // 
            this.picCapturada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCapturada.Location = new System.Drawing.Point(750, 155);
            this.picCapturada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picCapturada.Name = "picCapturada";
            this.picCapturada.Size = new System.Drawing.Size(169, 126);
            this.picCapturada.TabIndex = 6;
            this.picCapturada.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(749, 287);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // btnReconocer
            // 
            this.btnReconocer.BackColor = System.Drawing.Color.Crimson;
            this.btnReconocer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReconocer.Location = new System.Drawing.Point(748, 395);
            this.btnReconocer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReconocer.Name = "btnReconocer";
            this.btnReconocer.Size = new System.Drawing.Size(169, 23);
            this.btnReconocer.TabIndex = 8;
            this.btnReconocer.Text = "Reconocer";
            this.btnReconocer.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Crimson;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(748, 32);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "1. Registrar Persona";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnReconocer);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.picCapturada);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnDetectar);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.picCaptura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCaptura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCaptura;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Button btnDetectar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.PictureBox picCapturada;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnReconocer;
        private System.Windows.Forms.Button btnAgregar;
    }
}

