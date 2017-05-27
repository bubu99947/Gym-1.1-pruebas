namespace Gym_1_1_pruebas.Views
{
    partial class FrmControlDeAcceso
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
            this.pctbFoto = new System.Windows.Forms.PictureBox();
            this.pctbEstado = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblMembresia = new System.Windows.Forms.Label();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctbFoto
            // 
            this.pctbFoto.Location = new System.Drawing.Point(972, 12);
            this.pctbFoto.Name = "pctbFoto";
            this.pctbFoto.Size = new System.Drawing.Size(300, 375);
            this.pctbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbFoto.TabIndex = 0;
            this.pctbFoto.TabStop = false;
            // 
            // pctbEstado
            // 
            this.pctbEstado.Location = new System.Drawing.Point(972, 393);
            this.pctbEstado.Name = "pctbEstado";
            this.pctbEstado.Size = new System.Drawing.Size(300, 316);
            this.pctbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbEstado.TabIndex = 2;
            this.pctbEstado.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(954, 225);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese su Clave de Acceso";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.lblMembresia);
            this.panel1.Controls.Add(this.lblAcceso);
            this.panel1.Location = new System.Drawing.Point(12, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 396);
            this.panel1.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(5, 247);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(946, 23);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "lblMensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMembresia
            // 
            this.lblMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembresia.Location = new System.Drawing.Point(5, 139);
            this.lblMembresia.Name = "lblMembresia";
            this.lblMembresia.Size = new System.Drawing.Size(946, 23);
            this.lblMembresia.TabIndex = 1;
            this.lblMembresia.Text = "lblMembresia";
            this.lblMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcceso
            // 
            this.lblAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceso.Location = new System.Drawing.Point(5, 37);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(946, 23);
            this.lblAcceso.TabIndex = 0;
            this.lblAcceso.Text = "lblAcceso";
            this.lblAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(275, 261);
            this.txtClave.MaxLength = 6;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(691, 30);
            this.txtClave.TabIndex = 0;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // FrmControlDeAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 721);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pctbEstado);
            this.Controls.Add(this.pctbFoto);
            this.Name = "FrmControlDeAcceso";
            this.Text = "FrmControlDeAcceso";
            this.Load += new System.EventHandler(this.FrmControlDeAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbFoto;
        private System.Windows.Forms.PictureBox pctbEstado;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblMembresia;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.TextBox txtClave;
    }
}