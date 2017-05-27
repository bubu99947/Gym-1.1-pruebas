namespace Gym_1_1_pruebas.Views
{
    partial class FrmTomaFoto
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
            this.ptbCamara = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCamara
            // 
            this.ptbCamara.Location = new System.Drawing.Point(12, 12);
            this.ptbCamara.Name = "ptbCamara";
            this.ptbCamara.Size = new System.Drawing.Size(400, 500);
            this.ptbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCamara.TabIndex = 0;
            this.ptbCamara.TabStop = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.AllowDrop = true;
            this.btnCapturar.Location = new System.Drawing.Point(166, 526);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(337, 526);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmTomaFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 561);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.ptbCamara);
            this.Name = "FrmTomaFoto";
            this.Text = "FrmTomaFoto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTomaFoto_FormClosing);
            this.Load += new System.EventHandler(this.FrmTomaFoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCamara;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnCancelar;
    }
}