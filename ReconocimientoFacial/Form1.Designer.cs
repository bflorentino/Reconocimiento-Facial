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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.picCapturada = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnReconocer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturada)).BeginInit();
            this.SuspendLayout();
            // 
            // picCaptura
            // 
            this.picCaptura.Location = new System.Drawing.Point(13, 13);
            this.picCaptura.Name = "picCaptura";
            this.picCaptura.Size = new System.Drawing.Size(623, 425);
            this.picCaptura.TabIndex = 0;
            this.picCaptura.TabStop = false;
            // 
            // btnCaptura
            // 
            this.btnCaptura.Location = new System.Drawing.Point(642, 27);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(145, 23);
            this.btnCaptura.TabIndex = 1;
            this.btnCaptura.Text = "1. Captura";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnDetectar
            // 
            this.btnDetectar.Location = new System.Drawing.Point(643, 56);
            this.btnDetectar.Name = "btnDetectar";
            this.btnDetectar.Size = new System.Drawing.Size(145, 23);
            this.btnDetectar.TabIndex = 2;
            this.btnDetectar.Text = "2. Detectar Rostros";
            this.btnDetectar.UseVisualStyleBackColor = true;
            this.btnDetectar.Click += new System.EventHandler(this.btnDetectar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(643, 85);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(145, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "3. Registrar Persona";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(642, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar Imagen";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(643, 277);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(145, 23);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "Entrenar imagenes";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // picCapturada
            // 
            this.picCapturada.Location = new System.Drawing.Point(643, 119);
            this.picCapturada.Name = "picCapturada";
            this.picCapturada.Size = new System.Drawing.Size(145, 126);
            this.picCapturada.TabIndex = 6;
            this.picCapturada.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(642, 251);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // btnReconocer
            // 
            this.btnReconocer.Location = new System.Drawing.Point(643, 306);
            this.btnReconocer.Name = "btnReconocer";
            this.btnReconocer.Size = new System.Drawing.Size(145, 23);
            this.btnReconocer.TabIndex = 8;
            this.btnReconocer.Text = "Reconocer";
            this.btnReconocer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReconocer);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.picCapturada);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnDetectar);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.picCaptura);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.PictureBox picCapturada;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnReconocer;
    }
}

