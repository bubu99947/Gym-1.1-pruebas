namespace Gym_1_1_pruebas.Views
{
    partial class FrmEditarSocio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSociosClave = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dtpSociosFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbSociosSexo = new System.Windows.Forms.ComboBox();
            this.txtSociosEmail = new System.Windows.Forms.TextBox();
            this.txtSociosTelefono = new System.Windows.Forms.TextBox();
            this.txtSociosApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtSociosApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtSociosNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pctbSociosFoto = new System.Windows.Forms.PictureBox();
            this.btnAgregarFotografia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSociosFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSociosClave);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.dtpSociosFechaNacimiento);
            this.groupBox1.Controls.Add(this.cmbSociosSexo);
            this.groupBox1.Controls.Add(this.txtSociosEmail);
            this.groupBox1.Controls.Add(this.txtSociosTelefono);
            this.groupBox1.Controls.Add(this.txtSociosApellidoMaterno);
            this.groupBox1.Controls.Add(this.txtSociosApellidoPaterno);
            this.groupBox1.Controls.Add(this.txtSociosNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 250);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSociosClave
            // 
            this.txtSociosClave.Location = new System.Drawing.Point(122, 27);
            this.txtSociosClave.Name = "txtSociosClave";
            this.txtSociosClave.ReadOnly = true;
            this.txtSociosClave.Size = new System.Drawing.Size(121, 20);
            this.txtSociosClave.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "Clave:";
            // 
            // dtpSociosFechaNacimiento
            // 
            this.dtpSociosFechaNacimiento.Location = new System.Drawing.Point(122, 183);
            this.dtpSociosFechaNacimiento.Name = "dtpSociosFechaNacimiento";
            this.dtpSociosFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpSociosFechaNacimiento.TabIndex = 18;
            // 
            // cmbSociosSexo
            // 
            this.cmbSociosSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSociosSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSociosSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSociosSexo.FormattingEnabled = true;
            this.cmbSociosSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSociosSexo.Location = new System.Drawing.Point(448, 30);
            this.cmbSociosSexo.Name = "cmbSociosSexo";
            this.cmbSociosSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSociosSexo.TabIndex = 17;
            // 
            // txtSociosEmail
            // 
            this.txtSociosEmail.Location = new System.Drawing.Point(449, 103);
            this.txtSociosEmail.Name = "txtSociosEmail";
            this.txtSociosEmail.Size = new System.Drawing.Size(220, 20);
            this.txtSociosEmail.TabIndex = 14;
            // 
            // txtSociosTelefono
            // 
            this.txtSociosTelefono.Location = new System.Drawing.Point(449, 63);
            this.txtSociosTelefono.Name = "txtSociosTelefono";
            this.txtSociosTelefono.Size = new System.Drawing.Size(220, 20);
            this.txtSociosTelefono.TabIndex = 13;
            // 
            // txtSociosApellidoMaterno
            // 
            this.txtSociosApellidoMaterno.Location = new System.Drawing.Point(122, 143);
            this.txtSociosApellidoMaterno.Name = "txtSociosApellidoMaterno";
            this.txtSociosApellidoMaterno.Size = new System.Drawing.Size(223, 20);
            this.txtSociosApellidoMaterno.TabIndex = 11;
            // 
            // txtSociosApellidoPaterno
            // 
            this.txtSociosApellidoPaterno.Location = new System.Drawing.Point(122, 105);
            this.txtSociosApellidoPaterno.Name = "txtSociosApellidoPaterno";
            this.txtSociosApellidoPaterno.Size = new System.Drawing.Size(223, 20);
            this.txtSociosApellidoPaterno.TabIndex = 10;
            // 
            // txtSociosNombre
            // 
            this.txtSociosNombre.Location = new System.Drawing.Point(122, 63);
            this.txtSociosNombre.Name = "txtSociosNombre";
            this.txtSociosNombre.Size = new System.Drawing.Size(223, 20);
            this.txtSociosNombre.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(742, 268);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(823, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pctbSociosFoto
            // 
            this.pctbSociosFoto.Location = new System.Drawing.Point(12, 12);
            this.pctbSociosFoto.Name = "pctbSociosFoto";
            this.pctbSociosFoto.Size = new System.Drawing.Size(200, 250);
            this.pctbSociosFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbSociosFoto.TabIndex = 23;
            this.pctbSociosFoto.TabStop = false;
            // 
            // btnAgregarFotografia
            // 
            this.btnAgregarFotografia.Location = new System.Drawing.Point(12, 268);
            this.btnAgregarFotografia.Name = "btnAgregarFotografia";
            this.btnAgregarFotografia.Size = new System.Drawing.Size(198, 23);
            this.btnAgregarFotografia.TabIndex = 24;
            this.btnAgregarFotografia.Text = "Agregar Fotografía";
            this.btnAgregarFotografia.UseVisualStyleBackColor = true;
            this.btnAgregarFotografia.Click += new System.EventHandler(this.btnCambiarFotografia_Click);
            // 
            // FrmEditarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 300);
            this.Controls.Add(this.btnAgregarFotografia);
            this.Controls.Add(this.pctbSociosFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditarSocio";
            this.Text = "FrmEditarSocio";
            this.Load += new System.EventHandler(this.FrmEditarSocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSociosFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtSociosClave;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dtpSociosFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbSociosSexo;
        private System.Windows.Forms.TextBox txtSociosEmail;
        private System.Windows.Forms.TextBox txtSociosTelefono;
        private System.Windows.Forms.TextBox txtSociosApellidoMaterno;
        private System.Windows.Forms.TextBox txtSociosApellidoPaterno;
        private System.Windows.Forms.TextBox txtSociosNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pctbSociosFoto;
        private System.Windows.Forms.Button btnAgregarFotografia;
    }
}