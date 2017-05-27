namespace Gym_1_1_pruebas.Views
{ 
    partial class FrmAdministracionGimnasio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbAdmin = new System.Windows.Forms.TabControl();
            this.tbpSocios = new System.Windows.Forms.TabPage();
            this.btnSociosMostrarTodos = new System.Windows.Forms.Button();
            this.rdbtnSociosBuscarNombre = new System.Windows.Forms.RadioButton();
            this.rdbtnSociosBuscarClave = new System.Windows.Forms.RadioButton();
            this.btnSociosAnadirFotografia = new System.Windows.Forms.Button();
            this.txtSociosBuscar = new System.Windows.Forms.TextBox();
            this.btnSociosEliminar = new System.Windows.Forms.Button();
            this.btnSociosBuscar = new System.Windows.Forms.Button();
            this.btnSociosNuevo = new System.Windows.Forms.Button();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.sociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gimnasioPruebasDataSet = new Gym_1_1_pruebas.GimnasioPruebasDataSet();
            this.pctbSociosFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSociosAgregar = new System.Windows.Forms.Button();
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
            this.tbpRutinas = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dtpRutinasFin = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.dtpRutinasInicio = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.btnRutinasGurdarRutina = new System.Windows.Forms.Button();
            this.txtRutinasNotas = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pctbRutinasFotoSocio = new System.Windows.Forms.PictureBox();
            this.txtRutinasClaveSocio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRutinasNombreSocio = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.rdbtnRutinasBuscarSocioNombre = new System.Windows.Forms.RadioButton();
            this.rdbtnRutinasBusarSocioClave = new System.Windows.Forms.RadioButton();
            this.btnRutinasBuscarSocio = new System.Windows.Forms.Button();
            this.txtRutinasBuscarSocio = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dgvRutinasDias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domingo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lunes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.martes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.miercoles = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jueves = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.viernes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRutinasAgregarARutina = new System.Windows.Forms.Button();
            this.chkRutinasSabado = new System.Windows.Forms.CheckBox();
            this.chkRutinasViernes = new System.Windows.Forms.CheckBox();
            this.chkRutinasJueves = new System.Windows.Forms.CheckBox();
            this.chkRutinasMiercoles = new System.Windows.Forms.CheckBox();
            this.chkRutinasMartes = new System.Windows.Forms.CheckBox();
            this.chkRutinasLunes = new System.Windows.Forms.CheckBox();
            this.chkRutinasDomingo = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRutinasTipoEjercicio = new System.Windows.Forms.TextBox();
            this.btnRutinasBuscarEjercicio = new System.Windows.Forms.Button();
            this.txtRutinasRepeticionesEjercicio = new System.Windows.Forms.TextBox();
            this.txtRutinasSeriesEjercicio = new System.Windows.Forms.TextBox();
            this.txtRutinasDescripcionEjercicio = new System.Windows.Forms.TextBox();
            this.txtRutinasNombreEjercicio = new System.Windows.Forms.TextBox();
            this.txtRutinasBuscarEjercicio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMembresias = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRenovarMembresiaMembresia = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.btnMembresiasEliminar = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pctbMembresiaFotoSocio = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutinasAsignadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarMembresiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarSocio = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeAccesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstmControlAccesoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeMembresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTipoDeMembresiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTiposDeMembresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSociosRenoarMembresia = new System.Windows.Forms.Button();
            this.btnSociosAgregarRutinas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.txtBuscarSocio = new System.Windows.Forms.TextBox();
            this.txtIdSocio = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPorciento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtCobro = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMembresia = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCostoNeto = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dtmFechaFInal = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscarMembresia = new System.Windows.Forms.Button();
            this.dtmFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoDescuento = new System.Windows.Forms.TextBox();
            this.txtCostoMembresia = new System.Windows.Forms.TextBox();
            this.txtBuscarTipoMembresia = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbAdmin.SuspendLayout();
            this.tbpSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioPruebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSociosFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbpRutinas.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRutinasFotoSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutinasDias)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresias)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMembresiaFotoSocio)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAdmin
            // 
            this.tbAdmin.Controls.Add(this.tbpSocios);
            this.tbAdmin.Controls.Add(this.tbpRutinas);
            this.tbAdmin.Controls.Add(this.tabPage1);
            this.tbAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmin.Location = new System.Drawing.Point(0, 24);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.SelectedIndex = 0;
            this.tbAdmin.Size = new System.Drawing.Size(1276, 657);
            this.tbAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbAdmin.TabIndex = 0;
            // 
            // tbpSocios
            // 
            this.tbpSocios.Controls.Add(this.groupBox2);
            this.tbpSocios.Controls.Add(this.btnSociosAgregarRutinas);
            this.tbpSocios.Controls.Add(this.btnSociosRenoarMembresia);
            this.tbpSocios.Controls.Add(this.btnSociosMostrarTodos);
            this.tbpSocios.Controls.Add(this.rdbtnSociosBuscarNombre);
            this.tbpSocios.Controls.Add(this.rdbtnSociosBuscarClave);
            this.tbpSocios.Controls.Add(this.btnSociosAnadirFotografia);
            this.tbpSocios.Controls.Add(this.txtSociosBuscar);
            this.tbpSocios.Controls.Add(this.btnSociosEliminar);
            this.tbpSocios.Controls.Add(this.btnSociosBuscar);
            this.tbpSocios.Controls.Add(this.btnSociosNuevo);
            this.tbpSocios.Controls.Add(this.dgvSocios);
            this.tbpSocios.Controls.Add(this.pctbSociosFoto);
            this.tbpSocios.Controls.Add(this.groupBox1);
            this.tbpSocios.Location = new System.Drawing.Point(4, 22);
            this.tbpSocios.Name = "tbpSocios";
            this.tbpSocios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSocios.Size = new System.Drawing.Size(1268, 631);
            this.tbpSocios.TabIndex = 0;
            this.tbpSocios.Text = "Socios";
            this.tbpSocios.UseVisualStyleBackColor = true;
            this.tbpSocios.Click += new System.EventHandler(this.tbpSocios_Click);
            // 
            // btnSociosMostrarTodos
            // 
            this.btnSociosMostrarTodos.Location = new System.Drawing.Point(500, 262);
            this.btnSociosMostrarTodos.Name = "btnSociosMostrarTodos";
            this.btnSociosMostrarTodos.Size = new System.Drawing.Size(100, 23);
            this.btnSociosMostrarTodos.TabIndex = 31;
            this.btnSociosMostrarTodos.Text = "Mostrar Todos";
            this.btnSociosMostrarTodos.UseVisualStyleBackColor = true;
            this.btnSociosMostrarTodos.Click += new System.EventHandler(this.btnSociosMostrarTodos_Click);
            // 
            // rdbtnSociosBuscarNombre
            // 
            this.rdbtnSociosBuscarNombre.AutoSize = true;
            this.rdbtnSociosBuscarNombre.Location = new System.Drawing.Point(764, 290);
            this.rdbtnSociosBuscarNombre.Name = "rdbtnSociosBuscarNombre";
            this.rdbtnSociosBuscarNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbtnSociosBuscarNombre.TabIndex = 30;
            this.rdbtnSociosBuscarNombre.TabStop = true;
            this.rdbtnSociosBuscarNombre.Text = "Nombre";
            this.rdbtnSociosBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // rdbtnSociosBuscarClave
            // 
            this.rdbtnSociosBuscarClave.AutoSize = true;
            this.rdbtnSociosBuscarClave.Location = new System.Drawing.Point(637, 288);
            this.rdbtnSociosBuscarClave.Name = "rdbtnSociosBuscarClave";
            this.rdbtnSociosBuscarClave.Size = new System.Drawing.Size(52, 17);
            this.rdbtnSociosBuscarClave.TabIndex = 29;
            this.rdbtnSociosBuscarClave.TabStop = true;
            this.rdbtnSociosBuscarClave.Text = "Clave";
            this.rdbtnSociosBuscarClave.UseVisualStyleBackColor = true;
            // 
            // btnSociosAnadirFotografia
            // 
            this.btnSociosAnadirFotografia.Location = new System.Drawing.Point(8, 262);
            this.btnSociosAnadirFotografia.Name = "btnSociosAnadirFotografia";
            this.btnSociosAnadirFotografia.Size = new System.Drawing.Size(198, 23);
            this.btnSociosAnadirFotografia.TabIndex = 14;
            this.btnSociosAnadirFotografia.Text = "Añadir Fotografía";
            this.btnSociosAnadirFotografia.UseVisualStyleBackColor = true;
            this.btnSociosAnadirFotografia.Click += new System.EventHandler(this.btnSociosAnadirFotografia_Click);
            // 
            // txtSociosBuscar
            // 
            this.txtSociosBuscar.Location = new System.Drawing.Point(606, 262);
            this.txtSociosBuscar.Name = "txtSociosBuscar";
            this.txtSociosBuscar.Size = new System.Drawing.Size(200, 20);
            this.txtSociosBuscar.TabIndex = 13;
            // 
            // btnSociosEliminar
            // 
            this.btnSociosEliminar.Location = new System.Drawing.Point(293, 262);
            this.btnSociosEliminar.Name = "btnSociosEliminar";
            this.btnSociosEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnSociosEliminar.TabIndex = 12;
            this.btnSociosEliminar.Text = "Eliminar";
            this.btnSociosEliminar.UseVisualStyleBackColor = true;
            this.btnSociosEliminar.Click += new System.EventHandler(this.btnSociosEliminar_Click);
            // 
            // btnSociosBuscar
            // 
            this.btnSociosBuscar.Location = new System.Drawing.Point(812, 262);
            this.btnSociosBuscar.Name = "btnSociosBuscar";
            this.btnSociosBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnSociosBuscar.TabIndex = 11;
            this.btnSociosBuscar.Text = "Buscar";
            this.btnSociosBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSociosNuevo
            // 
            this.btnSociosNuevo.Location = new System.Drawing.Point(212, 262);
            this.btnSociosNuevo.Name = "btnSociosNuevo";
            this.btnSociosNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnSociosNuevo.TabIndex = 9;
            this.btnSociosNuevo.Text = "Nuevo";
            this.btnSociosNuevo.UseVisualStyleBackColor = true;
            this.btnSociosNuevo.Click += new System.EventHandler(this.btnSociosNuevo_Click);
            // 
            // dgvSocios
            // 
            this.dgvSocios.AllowUserToAddRows = false;
            this.dgvSocios.AllowUserToDeleteRows = false;
            this.dgvSocios.AutoGenerateColumns = false;
            this.dgvSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSocios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.nombres,
            this.apellidoPaterno,
            this.apellidoMaterno,
            this.sexo,
            this.email,
            this.telefono,
            this.fechaDeNacimiento,
            this.Foto});
            this.dgvSocios.DataSource = this.sociosBindingSource;
            this.dgvSocios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSocios.Location = new System.Drawing.Point(6, 308);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.ReadOnly = true;
            this.dgvSocios.Size = new System.Drawing.Size(1254, 315);
            this.dgvSocios.TabIndex = 8;
            this.dgvSocios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocios_CellContentClick);
            this.dgvSocios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSocios_CellMouseDoubleClick);
            // 
            // clave
            // 
            this.clave.DataPropertyName = "Clave";
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "Nombres";
            this.nombres.HeaderText = "Nombres";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // apellidoPaterno
            // 
            this.apellidoPaterno.DataPropertyName = "Apellido Paterno";
            this.apellidoPaterno.HeaderText = "Apellido Paterno";
            this.apellidoPaterno.Name = "apellidoPaterno";
            this.apellidoPaterno.ReadOnly = true;
            // 
            // apellidoMaterno
            // 
            this.apellidoMaterno.DataPropertyName = "Apellido Materno";
            this.apellidoMaterno.HeaderText = "Apellido Materno";
            this.apellidoMaterno.Name = "apellidoMaterno";
            this.apellidoMaterno.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "Sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fechaDeNacimiento
            // 
            this.fechaDeNacimiento.DataPropertyName = "Fecha de Nacimiento";
            this.fechaDeNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaDeNacimiento.Name = "fechaDeNacimiento";
            this.fechaDeNacimiento.ReadOnly = true;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Visible = false;
            // 
            // sociosBindingSource
            // 
            this.sociosBindingSource.DataMember = "Socios";
            this.sociosBindingSource.DataSource = this.gimnasioPruebasDataSet;
            // 
            // gimnasioPruebasDataSet
            // 
            this.gimnasioPruebasDataSet.DataSetName = "GimnasioPruebasDataSet";
            this.gimnasioPruebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pctbSociosFoto
            // 
            this.pctbSociosFoto.Location = new System.Drawing.Point(6, 6);
            this.pctbSociosFoto.Name = "pctbSociosFoto";
            this.pctbSociosFoto.Size = new System.Drawing.Size(200, 250);
            this.pctbSociosFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbSociosFoto.TabIndex = 6;
            this.pctbSociosFoto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSociosAgregar);
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
            this.groupBox1.Location = new System.Drawing.Point(212, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 250);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnSociosAgregar
            // 
            this.btnSociosAgregar.Location = new System.Drawing.Point(594, 216);
            this.btnSociosAgregar.Name = "btnSociosAgregar";
            this.btnSociosAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnSociosAgregar.TabIndex = 17;
            this.btnSociosAgregar.Text = "Agregar";
            this.btnSociosAgregar.UseVisualStyleBackColor = true;
            this.btnSociosAgregar.Click += new System.EventHandler(this.btnSociosAgregar_Click);
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
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "ID:";
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
            this.cmbSociosSexo.FormattingEnabled = true;
            this.cmbSociosSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSociosSexo.Location = new System.Drawing.Point(122, 223);
            this.cmbSociosSexo.Name = "cmbSociosSexo";
            this.cmbSociosSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSociosSexo.TabIndex = 17;
            // 
            // txtSociosEmail
            // 
            this.txtSociosEmail.Location = new System.Drawing.Point(449, 63);
            this.txtSociosEmail.Name = "txtSociosEmail";
            this.txtSociosEmail.Size = new System.Drawing.Size(220, 20);
            this.txtSociosEmail.TabIndex = 14;
            // 
            // txtSociosTelefono
            // 
            this.txtSociosTelefono.Location = new System.Drawing.Point(449, 23);
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
            this.label7.Location = new System.Drawing.Point(6, 226);
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
            this.label5.Location = new System.Drawing.Point(391, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 26);
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
            // tbpRutinas
            // 
            this.tbpRutinas.Controls.Add(this.groupBox8);
            this.tbpRutinas.Controls.Add(this.groupBox7);
            this.tbpRutinas.Controls.Add(this.dgvRutinasDias);
            this.tbpRutinas.Controls.Add(this.groupBox4);
            this.tbpRutinas.Location = new System.Drawing.Point(4, 22);
            this.tbpRutinas.Name = "tbpRutinas";
            this.tbpRutinas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRutinas.Size = new System.Drawing.Size(1268, 631);
            this.tbpRutinas.TabIndex = 1;
            this.tbpRutinas.Text = "Asignar Rutina";
            this.tbpRutinas.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dtpRutinasFin);
            this.groupBox8.Controls.Add(this.label32);
            this.groupBox8.Controls.Add(this.dtpRutinasInicio);
            this.groupBox8.Controls.Add(this.label33);
            this.groupBox8.Controls.Add(this.btnRutinasGurdarRutina);
            this.groupBox8.Controls.Add(this.txtRutinasNotas);
            this.groupBox8.Controls.Add(this.label38);
            this.groupBox8.Location = new System.Drawing.Point(8, 330);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(571, 293);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Rutina";
            // 
            // dtpRutinasFin
            // 
            this.dtpRutinasFin.Location = new System.Drawing.Point(136, 67);
            this.dtpRutinasFin.Name = "dtpRutinasFin";
            this.dtpRutinasFin.Size = new System.Drawing.Size(200, 20);
            this.dtpRutinasFin.TabIndex = 60;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 73);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(48, 13);
            this.label32.TabIndex = 59;
            this.label32.Text = "Termino:";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // dtpRutinasInicio
            // 
            this.dtpRutinasInicio.Location = new System.Drawing.Point(136, 25);
            this.dtpRutinasInicio.Name = "dtpRutinasInicio";
            this.dtpRutinasInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpRutinasInicio.TabIndex = 58;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(20, 31);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(32, 13);
            this.label33.TabIndex = 57;
            this.label33.Text = "incio:";
            // 
            // btnRutinasGurdarRutina
            // 
            this.btnRutinasGurdarRutina.Location = new System.Drawing.Point(449, 264);
            this.btnRutinasGurdarRutina.Name = "btnRutinasGurdarRutina";
            this.btnRutinasGurdarRutina.Size = new System.Drawing.Size(116, 23);
            this.btnRutinasGurdarRutina.TabIndex = 32;
            this.btnRutinasGurdarRutina.Text = "Guardar Rutina";
            this.btnRutinasGurdarRutina.UseVisualStyleBackColor = true;
            this.btnRutinasGurdarRutina.Click += new System.EventHandler(this.btnRutinasGurdarRutina_Click);
            // 
            // txtRutinasNotas
            // 
            this.txtRutinasNotas.Location = new System.Drawing.Point(136, 113);
            this.txtRutinasNotas.Multiline = true;
            this.txtRutinasNotas.Name = "txtRutinasNotas";
            this.txtRutinasNotas.Size = new System.Drawing.Size(253, 61);
            this.txtRutinasNotas.TabIndex = 11;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(20, 116);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(38, 13);
            this.label38.TabIndex = 2;
            this.label38.Text = "Notas:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pctbRutinasFotoSocio);
            this.groupBox7.Controls.Add(this.txtRutinasClaveSocio);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.txtRutinasNombreSocio);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.rdbtnRutinasBuscarSocioNombre);
            this.groupBox7.Controls.Add(this.rdbtnRutinasBusarSocioClave);
            this.groupBox7.Controls.Add(this.btnRutinasBuscarSocio);
            this.groupBox7.Controls.Add(this.txtRutinasBuscarSocio);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(573, 312);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Socio";
            // 
            // pctbRutinasFotoSocio
            // 
            this.pctbRutinasFotoSocio.Location = new System.Drawing.Point(6, 26);
            this.pctbRutinasFotoSocio.Name = "pctbRutinasFotoSocio";
            this.pctbRutinasFotoSocio.Size = new System.Drawing.Size(184, 226);
            this.pctbRutinasFotoSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbRutinasFotoSocio.TabIndex = 37;
            this.pctbRutinasFotoSocio.TabStop = false;
            // 
            // txtRutinasClaveSocio
            // 
            this.txtRutinasClaveSocio.Location = new System.Drawing.Point(270, 77);
            this.txtRutinasClaveSocio.Name = "txtRutinasClaveSocio";
            this.txtRutinasClaveSocio.ReadOnly = true;
            this.txtRutinasClaveSocio.Size = new System.Drawing.Size(121, 20);
            this.txtRutinasClaveSocio.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "ID:";
            // 
            // txtRutinasNombreSocio
            // 
            this.txtRutinasNombreSocio.Location = new System.Drawing.Point(270, 118);
            this.txtRutinasNombreSocio.Name = "txtRutinasNombreSocio";
            this.txtRutinasNombreSocio.ReadOnly = true;
            this.txtRutinasNombreSocio.Size = new System.Drawing.Size(246, 20);
            this.txtRutinasNombreSocio.TabIndex = 34;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(206, 121);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 13);
            this.label30.TabIndex = 33;
            this.label30.Text = "Nombre(s):";
            // 
            // rdbtnRutinasBuscarSocioNombre
            // 
            this.rdbtnRutinasBuscarSocioNombre.AutoSize = true;
            this.rdbtnRutinasBuscarSocioNombre.Location = new System.Drawing.Point(397, 47);
            this.rdbtnRutinasBuscarSocioNombre.Name = "rdbtnRutinasBuscarSocioNombre";
            this.rdbtnRutinasBuscarSocioNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbtnRutinasBuscarSocioNombre.TabIndex = 28;
            this.rdbtnRutinasBuscarSocioNombre.TabStop = true;
            this.rdbtnRutinasBuscarSocioNombre.Text = "Nombre";
            this.rdbtnRutinasBuscarSocioNombre.UseVisualStyleBackColor = true;
            // 
            // rdbtnRutinasBusarSocioClave
            // 
            this.rdbtnRutinasBusarSocioClave.AutoSize = true;
            this.rdbtnRutinasBusarSocioClave.Location = new System.Drawing.Point(270, 45);
            this.rdbtnRutinasBusarSocioClave.Name = "rdbtnRutinasBusarSocioClave";
            this.rdbtnRutinasBusarSocioClave.Size = new System.Drawing.Size(52, 17);
            this.rdbtnRutinasBusarSocioClave.TabIndex = 27;
            this.rdbtnRutinasBusarSocioClave.TabStop = true;
            this.rdbtnRutinasBusarSocioClave.Text = "Clave";
            this.rdbtnRutinasBusarSocioClave.UseVisualStyleBackColor = true;
            // 
            // btnRutinasBuscarSocio
            // 
            this.btnRutinasBuscarSocio.Location = new System.Drawing.Point(397, 18);
            this.btnRutinasBuscarSocio.Name = "btnRutinasBuscarSocio";
            this.btnRutinasBuscarSocio.Size = new System.Drawing.Size(75, 23);
            this.btnRutinasBuscarSocio.TabIndex = 21;
            this.btnRutinasBuscarSocio.Text = "Buscar";
            this.btnRutinasBuscarSocio.UseVisualStyleBackColor = true;
            this.btnRutinasBuscarSocio.Click += new System.EventHandler(this.btnRutinasBuscarSocio_Click);
            // 
            // txtRutinasBuscarSocio
            // 
            this.txtRutinasBuscarSocio.Location = new System.Drawing.Point(270, 22);
            this.txtRutinasBuscarSocio.Name = "txtRutinasBuscarSocio";
            this.txtRutinasBuscarSocio.Size = new System.Drawing.Size(121, 20);
            this.txtRutinasBuscarSocio.TabIndex = 9;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(206, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "Socio:";
            // 
            // dgvRutinasDias
            // 
            this.dgvRutinasDias.AllowUserToAddRows = false;
            this.dgvRutinasDias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutinasDias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRutinasDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutinasDias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Ejercicio,
            this.domingo,
            this.lunes,
            this.martes,
            this.miercoles,
            this.jueves,
            this.viernes,
            this.sabado});
            this.dgvRutinasDias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRutinasDias.Location = new System.Drawing.Point(585, 330);
            this.dgvRutinasDias.Name = "dgvRutinasDias";
            this.dgvRutinasDias.ReadOnly = true;
            this.dgvRutinasDias.Size = new System.Drawing.Size(675, 293);
            this.dgvRutinasDias.TabIndex = 22;
            // 
            // id
            // 
            this.id.HeaderText = "idejercicio";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Ejercicio
            // 
            this.Ejercicio.HeaderText = "Ejercicio";
            this.Ejercicio.Name = "Ejercicio";
            this.Ejercicio.ReadOnly = true;
            // 
            // domingo
            // 
            this.domingo.HeaderText = "Domingo";
            this.domingo.Name = "domingo";
            this.domingo.ReadOnly = true;
            // 
            // lunes
            // 
            this.lunes.HeaderText = "Lunes";
            this.lunes.Name = "lunes";
            this.lunes.ReadOnly = true;
            // 
            // martes
            // 
            this.martes.HeaderText = "Martes";
            this.martes.Name = "martes";
            this.martes.ReadOnly = true;
            // 
            // miercoles
            // 
            this.miercoles.HeaderText = "Miercoles";
            this.miercoles.Name = "miercoles";
            this.miercoles.ReadOnly = true;
            // 
            // jueves
            // 
            this.jueves.HeaderText = "Jueves";
            this.jueves.Name = "jueves";
            this.jueves.ReadOnly = true;
            // 
            // viernes
            // 
            this.viernes.HeaderText = "Viernes";
            this.viernes.Name = "viernes";
            this.viernes.ReadOnly = true;
            // 
            // sabado
            // 
            this.sabado.HeaderText = "Sabado";
            this.sabado.Name = "sabado";
            this.sabado.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRutinasAgregarARutina);
            this.groupBox4.Controls.Add(this.chkRutinasSabado);
            this.groupBox4.Controls.Add(this.chkRutinasViernes);
            this.groupBox4.Controls.Add(this.chkRutinasJueves);
            this.groupBox4.Controls.Add(this.chkRutinasMiercoles);
            this.groupBox4.Controls.Add(this.chkRutinasMartes);
            this.groupBox4.Controls.Add(this.chkRutinasLunes);
            this.groupBox4.Controls.Add(this.chkRutinasDomingo);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtRutinasTipoEjercicio);
            this.groupBox4.Controls.Add(this.btnRutinasBuscarEjercicio);
            this.groupBox4.Controls.Add(this.txtRutinasRepeticionesEjercicio);
            this.groupBox4.Controls.Add(this.txtRutinasSeriesEjercicio);
            this.groupBox4.Controls.Add(this.txtRutinasDescripcionEjercicio);
            this.groupBox4.Controls.Add(this.txtRutinasNombreEjercicio);
            this.groupBox4.Controls.Add(this.txtRutinasBuscarEjercicio);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Location = new System.Drawing.Point(585, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(675, 318);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ejercicio";
            // 
            // btnRutinasAgregarARutina
            // 
            this.btnRutinasAgregarARutina.Location = new System.Drawing.Point(553, 289);
            this.btnRutinasAgregarARutina.Name = "btnRutinasAgregarARutina";
            this.btnRutinasAgregarARutina.Size = new System.Drawing.Size(116, 23);
            this.btnRutinasAgregarARutina.TabIndex = 31;
            this.btnRutinasAgregarARutina.Text = "Agregar a la Rutina";
            this.btnRutinasAgregarARutina.UseVisualStyleBackColor = true;
            this.btnRutinasAgregarARutina.Click += new System.EventHandler(this.btnRutinasAgregarARutina_Click);
            // 
            // chkRutinasSabado
            // 
            this.chkRutinasSabado.AutoSize = true;
            this.chkRutinasSabado.Location = new System.Drawing.Point(470, 179);
            this.chkRutinasSabado.Name = "chkRutinasSabado";
            this.chkRutinasSabado.Size = new System.Drawing.Size(63, 17);
            this.chkRutinasSabado.TabIndex = 30;
            this.chkRutinasSabado.Text = "Sabado";
            this.chkRutinasSabado.UseVisualStyleBackColor = true;
            // 
            // chkRutinasViernes
            // 
            this.chkRutinasViernes.AutoSize = true;
            this.chkRutinasViernes.Location = new System.Drawing.Point(403, 179);
            this.chkRutinasViernes.Name = "chkRutinasViernes";
            this.chkRutinasViernes.Size = new System.Drawing.Size(61, 17);
            this.chkRutinasViernes.TabIndex = 29;
            this.chkRutinasViernes.Text = "Viernes";
            this.chkRutinasViernes.UseVisualStyleBackColor = true;
            // 
            // chkRutinasJueves
            // 
            this.chkRutinasJueves.AutoSize = true;
            this.chkRutinasJueves.Location = new System.Drawing.Point(337, 179);
            this.chkRutinasJueves.Name = "chkRutinasJueves";
            this.chkRutinasJueves.Size = new System.Drawing.Size(60, 17);
            this.chkRutinasJueves.TabIndex = 28;
            this.chkRutinasJueves.Text = "Jueves";
            this.chkRutinasJueves.UseVisualStyleBackColor = true;
            // 
            // chkRutinasMiercoles
            // 
            this.chkRutinasMiercoles.AutoSize = true;
            this.chkRutinasMiercoles.Location = new System.Drawing.Point(264, 179);
            this.chkRutinasMiercoles.Name = "chkRutinasMiercoles";
            this.chkRutinasMiercoles.Size = new System.Drawing.Size(71, 17);
            this.chkRutinasMiercoles.TabIndex = 27;
            this.chkRutinasMiercoles.Text = "Miercoles";
            this.chkRutinasMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkRutinasMartes
            // 
            this.chkRutinasMartes.AutoSize = true;
            this.chkRutinasMartes.Location = new System.Drawing.Point(197, 179);
            this.chkRutinasMartes.Name = "chkRutinasMartes";
            this.chkRutinasMartes.Size = new System.Drawing.Size(58, 17);
            this.chkRutinasMartes.TabIndex = 26;
            this.chkRutinasMartes.Text = "Martes";
            this.chkRutinasMartes.UseVisualStyleBackColor = true;
            // 
            // chkRutinasLunes
            // 
            this.chkRutinasLunes.AutoSize = true;
            this.chkRutinasLunes.Location = new System.Drawing.Point(136, 179);
            this.chkRutinasLunes.Name = "chkRutinasLunes";
            this.chkRutinasLunes.Size = new System.Drawing.Size(55, 17);
            this.chkRutinasLunes.TabIndex = 25;
            this.chkRutinasLunes.Text = "Lunes";
            this.chkRutinasLunes.UseVisualStyleBackColor = true;
            // 
            // chkRutinasDomingo
            // 
            this.chkRutinasDomingo.AutoSize = true;
            this.chkRutinasDomingo.Location = new System.Drawing.Point(62, 179);
            this.chkRutinasDomingo.Name = "chkRutinasDomingo";
            this.chkRutinasDomingo.Size = new System.Drawing.Size(68, 17);
            this.chkRutinasDomingo.TabIndex = 24;
            this.chkRutinasDomingo.Text = "Domingo";
            this.chkRutinasDomingo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Dias:";
            // 
            // txtRutinasTipoEjercicio
            // 
            this.txtRutinasTipoEjercicio.Location = new System.Drawing.Point(470, 103);
            this.txtRutinasTipoEjercicio.Name = "txtRutinasTipoEjercicio";
            this.txtRutinasTipoEjercicio.ReadOnly = true;
            this.txtRutinasTipoEjercicio.Size = new System.Drawing.Size(138, 20);
            this.txtRutinasTipoEjercicio.TabIndex = 22;
            // 
            // btnRutinasBuscarEjercicio
            // 
            this.btnRutinasBuscarEjercicio.Location = new System.Drawing.Point(270, 19);
            this.btnRutinasBuscarEjercicio.Name = "btnRutinasBuscarEjercicio";
            this.btnRutinasBuscarEjercicio.Size = new System.Drawing.Size(75, 23);
            this.btnRutinasBuscarEjercicio.TabIndex = 21;
            this.btnRutinasBuscarEjercicio.Text = "Buscar";
            this.btnRutinasBuscarEjercicio.UseVisualStyleBackColor = true;
            this.btnRutinasBuscarEjercicio.Click += new System.EventHandler(this.btnRutinasBuscarEjercicio_Click);
            // 
            // txtRutinasRepeticionesEjercicio
            // 
            this.txtRutinasRepeticionesEjercicio.Location = new System.Drawing.Point(470, 63);
            this.txtRutinasRepeticionesEjercicio.Name = "txtRutinasRepeticionesEjercicio";
            this.txtRutinasRepeticionesEjercicio.ReadOnly = true;
            this.txtRutinasRepeticionesEjercicio.Size = new System.Drawing.Size(138, 20);
            this.txtRutinasRepeticionesEjercicio.TabIndex = 14;
            // 
            // txtRutinasSeriesEjercicio
            // 
            this.txtRutinasSeriesEjercicio.Location = new System.Drawing.Point(470, 21);
            this.txtRutinasSeriesEjercicio.Name = "txtRutinasSeriesEjercicio";
            this.txtRutinasSeriesEjercicio.ReadOnly = true;
            this.txtRutinasSeriesEjercicio.Size = new System.Drawing.Size(138, 20);
            this.txtRutinasSeriesEjercicio.TabIndex = 13;
            // 
            // txtRutinasDescripcionEjercicio
            // 
            this.txtRutinasDescripcionEjercicio.Location = new System.Drawing.Point(122, 103);
            this.txtRutinasDescripcionEjercicio.Multiline = true;
            this.txtRutinasDescripcionEjercicio.Name = "txtRutinasDescripcionEjercicio";
            this.txtRutinasDescripcionEjercicio.ReadOnly = true;
            this.txtRutinasDescripcionEjercicio.Size = new System.Drawing.Size(223, 61);
            this.txtRutinasDescripcionEjercicio.TabIndex = 11;
            // 
            // txtRutinasNombreEjercicio
            // 
            this.txtRutinasNombreEjercicio.Location = new System.Drawing.Point(122, 65);
            this.txtRutinasNombreEjercicio.Name = "txtRutinasNombreEjercicio";
            this.txtRutinasNombreEjercicio.ReadOnly = true;
            this.txtRutinasNombreEjercicio.Size = new System.Drawing.Size(223, 20);
            this.txtRutinasNombreEjercicio.TabIndex = 10;
            // 
            // txtRutinasBuscarEjercicio
            // 
            this.txtRutinasBuscarEjercicio.Location = new System.Drawing.Point(122, 23);
            this.txtRutinasBuscarEjercicio.Name = "txtRutinasBuscarEjercicio";
            this.txtRutinasBuscarEjercicio.Size = new System.Drawing.Size(142, 20);
            this.txtRutinasBuscarEjercicio.TabIndex = 9;
            this.txtRutinasBuscarEjercicio.TextChanged += new System.EventHandler(this.txtRutinasBuscarEjercicio_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(391, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Tipo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Ejercicio:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Nombre:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(391, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Repeticiones:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(391, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Series:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Descripción:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMembresias);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.textBox13);
            this.tabPage1.Controls.Add(this.btnMembresiasEliminar);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1268, 631);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Renovar Membresia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvMembresias
            // 
            this.dgvMembresias.AllowUserToAddRows = false;
            this.dgvMembresias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembresias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMembresias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembresias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMembresias.Location = new System.Drawing.Point(6, 306);
            this.dgvMembresias.Name = "dgvMembresias";
            this.dgvMembresias.ReadOnly = true;
            this.dgvMembresias.Size = new System.Drawing.Size(1254, 315);
            this.dgvMembresias.TabIndex = 38;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtPorciento);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txtCambio);
            this.groupBox6.Controls.Add(this.txtCobro);
            this.groupBox6.Controls.Add(this.lblDescuento);
            this.groupBox6.Controls.Add(this.txtDescripcion);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtMembresia);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.txtCostoNeto);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.dtmFechaFInal);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.btnBuscarMembresia);
            this.groupBox6.Controls.Add(this.dtmFechaInicio);
            this.groupBox6.Controls.Add(this.txtCodigoDescuento);
            this.groupBox6.Controls.Add(this.txtCostoMembresia);
            this.groupBox6.Controls.Add(this.txtBuscarTipoMembresia);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.btnRenovarMembresiaMembresia);
            this.groupBox6.Location = new System.Drawing.Point(643, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(617, 250);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Membresia";
            // 
            // btnRenovarMembresiaMembresia
            // 
            this.btnRenovarMembresiaMembresia.Location = new System.Drawing.Point(496, 218);
            this.btnRenovarMembresiaMembresia.Name = "btnRenovarMembresiaMembresia";
            this.btnRenovarMembresiaMembresia.Size = new System.Drawing.Size(115, 23);
            this.btnRenovarMembresiaMembresia.TabIndex = 59;
            this.btnRenovarMembresiaMembresia.Text = "Renovar Membresia";
            this.btnRenovarMembresiaMembresia.UseVisualStyleBackColor = true;
            this.btnRenovarMembresiaMembresia.Click += new System.EventHandler(this.btnRenovarMembresiaMembresia_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(984, 262);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(200, 20);
            this.textBox13.TabIndex = 19;
            // 
            // btnMembresiasEliminar
            // 
            this.btnMembresiasEliminar.Location = new System.Drawing.Point(233, 259);
            this.btnMembresiasEliminar.Name = "btnMembresiasEliminar";
            this.btnMembresiasEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnMembresiasEliminar.TabIndex = 18;
            this.btnMembresiasEliminar.Text = "Eliminar";
            this.btnMembresiasEliminar.UseVisualStyleBackColor = true;
            this.btnMembresiasEliminar.Click += new System.EventHandler(this.btnMembresiasEliminar_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1190, 259);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 17;
            this.button15.Text = "Buscar";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuscarSocio);
            this.groupBox5.Controls.Add(this.txtBuscarSocio);
            this.groupBox5.Controls.Add(this.txtIdSocio);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtNombreSocio);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.pctbMembresiaFotoSocio);
            this.groupBox5.Location = new System.Drawing.Point(8, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(629, 250);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Socio";
            // 
            // pctbMembresiaFotoSocio
            // 
            this.pctbMembresiaFotoSocio.Location = new System.Drawing.Point(6, 15);
            this.pctbMembresiaFotoSocio.Name = "pctbMembresiaFotoSocio";
            this.pctbMembresiaFotoSocio.Size = new System.Drawing.Size(184, 226);
            this.pctbMembresiaFotoSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbMembresiaFotoSocio.TabIndex = 37;
            this.pctbMembresiaFotoSocio.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.controlDeAccesoToolStripMenuItem,
            this.tiposDeMembresiasToolStripMenuItem,
            this.rutinasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutinasAsignadasToolStripMenuItem,
            this.pagarMembresiaToolStripMenuItem,
            this.tsmAgregarSocio,
            this.buscarToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // rutinasAsignadasToolStripMenuItem
            // 
            this.rutinasAsignadasToolStripMenuItem.Name = "rutinasAsignadasToolStripMenuItem";
            this.rutinasAsignadasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.rutinasAsignadasToolStripMenuItem.Text = "Asignar Rutina";
            this.rutinasAsignadasToolStripMenuItem.Click += new System.EventHandler(this.rutinasAsignadasToolStripMenuItem_Click);
            // 
            // pagarMembresiaToolStripMenuItem
            // 
            this.pagarMembresiaToolStripMenuItem.Name = "pagarMembresiaToolStripMenuItem";
            this.pagarMembresiaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pagarMembresiaToolStripMenuItem.Text = "Renovar Membresia";
            this.pagarMembresiaToolStripMenuItem.Click += new System.EventHandler(this.pagarMembresiaToolStripMenuItem_Click);
            // 
            // tsmAgregarSocio
            // 
            this.tsmAgregarSocio.Name = "tsmAgregarSocio";
            this.tsmAgregarSocio.Size = new System.Drawing.Size(179, 22);
            this.tsmAgregarSocio.Text = "Agregar";
            this.tsmAgregarSocio.Click += new System.EventHandler(this.tsmAgregarSocio_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // controlDeAccesoToolStripMenuItem
            // 
            this.controlDeAccesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstmControlAccesoAbrir});
            this.controlDeAccesoToolStripMenuItem.Name = "controlDeAccesoToolStripMenuItem";
            this.controlDeAccesoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.controlDeAccesoToolStripMenuItem.Text = "Control de Acceso";
            // 
            // tstmControlAccesoAbrir
            // 
            this.tstmControlAccesoAbrir.Name = "tstmControlAccesoAbrir";
            this.tstmControlAccesoAbrir.Size = new System.Drawing.Size(100, 22);
            this.tstmControlAccesoAbrir.Text = "Abrir";
            this.tstmControlAccesoAbrir.Click += new System.EventHandler(this.tstmControlAccesoAbrir_Click);
            // 
            // tiposDeMembresiasToolStripMenuItem
            // 
            this.tiposDeMembresiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTipoDeMembresiaToolStripMenuItem,
            this.mostrarTiposDeMembresiasToolStripMenuItem});
            this.tiposDeMembresiasToolStripMenuItem.Name = "tiposDeMembresiasToolStripMenuItem";
            this.tiposDeMembresiasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.tiposDeMembresiasToolStripMenuItem.Text = "Membresias";
            // 
            // agregarTipoDeMembresiaToolStripMenuItem
            // 
            this.agregarTipoDeMembresiaToolStripMenuItem.Name = "agregarTipoDeMembresiaToolStripMenuItem";
            this.agregarTipoDeMembresiaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarTipoDeMembresiaToolStripMenuItem.Text = "Agregar";
            this.agregarTipoDeMembresiaToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoDeMembresiaToolStripMenuItem_Click);
            // 
            // mostrarTiposDeMembresiasToolStripMenuItem
            // 
            this.mostrarTiposDeMembresiasToolStripMenuItem.Name = "mostrarTiposDeMembresiasToolStripMenuItem";
            this.mostrarTiposDeMembresiasToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.mostrarTiposDeMembresiasToolStripMenuItem.Text = "Mostrar";
            // 
            // rutinasToolStripMenuItem
            // 
            this.rutinasToolStripMenuItem.Name = "rutinasToolStripMenuItem";
            this.rutinasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.rutinasToolStripMenuItem.Text = "Rutinas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // btnSociosRenoarMembresia
            // 
            this.btnSociosRenoarMembresia.Location = new System.Drawing.Point(893, 251);
            this.btnSociosRenoarMembresia.Name = "btnSociosRenoarMembresia";
            this.btnSociosRenoarMembresia.Size = new System.Drawing.Size(183, 31);
            this.btnSociosRenoarMembresia.TabIndex = 32;
            this.btnSociosRenoarMembresia.Text = "Renovar Membresia";
            this.btnSociosRenoarMembresia.UseVisualStyleBackColor = true;
            // 
            // btnSociosAgregarRutinas
            // 
            this.btnSociosAgregarRutinas.Location = new System.Drawing.Point(1077, 251);
            this.btnSociosAgregarRutinas.Name = "btnSociosAgregarRutinas";
            this.btnSociosAgregarRutinas.Size = new System.Drawing.Size(183, 31);
            this.btnSociosAgregarRutinas.TabIndex = 33;
            this.btnSociosAgregarRutinas.Text = "Agregar Rutinas";
            this.btnSociosAgregarRutinas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(893, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 239);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Membresia";
            // 
            // btnBuscarSocio
            // 
            this.btnBuscarSocio.Location = new System.Drawing.Point(398, 12);
            this.btnBuscarSocio.Name = "btnBuscarSocio";
            this.btnBuscarSocio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarSocio.TabIndex = 46;
            this.btnBuscarSocio.Text = "Buscar";
            this.btnBuscarSocio.UseVisualStyleBackColor = true;
            // 
            // txtBuscarSocio
            // 
            this.txtBuscarSocio.Location = new System.Drawing.Point(196, 15);
            this.txtBuscarSocio.Name = "txtBuscarSocio";
            this.txtBuscarSocio.Size = new System.Drawing.Size(182, 20);
            this.txtBuscarSocio.TabIndex = 45;
            // 
            // txtIdSocio
            // 
            this.txtIdSocio.Enabled = false;
            this.txtIdSocio.Location = new System.Drawing.Point(257, 41);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.ReadOnly = true;
            this.txtIdSocio.Size = new System.Drawing.Size(121, 20);
            this.txtIdSocio.TabIndex = 44;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(193, 44);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(21, 13);
            this.label26.TabIndex = 43;
            this.label26.Text = "ID:";
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Enabled = false;
            this.txtNombreSocio.Location = new System.Drawing.Point(257, 67);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(246, 20);
            this.txtNombreSocio.TabIndex = 42;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(193, 70);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Nombre(s):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "%";
            // 
            // txtPorciento
            // 
            this.txtPorciento.Enabled = false;
            this.txtPorciento.Location = new System.Drawing.Point(252, 112);
            this.txtPorciento.Name = "txtPorciento";
            this.txtPorciento.ReadOnly = true;
            this.txtPorciento.Size = new System.Drawing.Size(36, 20);
            this.txtPorciento.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Cambio:";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(420, 171);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(177, 20);
            this.txtCambio.TabIndex = 89;
            // 
            // txtCobro
            // 
            this.txtCobro.Location = new System.Drawing.Point(420, 144);
            this.txtCobro.Name = "txtCobro";
            this.txtCobro.Size = new System.Drawing.Size(177, 20);
            this.txtCobro.TabIndex = 88;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(315, 115);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(0, 13);
            this.lblDescuento.TabIndex = 87;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(420, 23);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(177, 83);
            this.txtDescripcion.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Descripcion::";
            // 
            // txtMembresia
            // 
            this.txtMembresia.Enabled = false;
            this.txtMembresia.Location = new System.Drawing.Point(110, 60);
            this.txtMembresia.Name = "txtMembresia";
            this.txtMembresia.ReadOnly = true;
            this.txtMembresia.Size = new System.Drawing.Size(199, 20);
            this.txtMembresia.TabIndex = 84;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 63);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(61, 13);
            this.label29.TabIndex = 83;
            this.label29.Text = "Membresia:";
            // 
            // txtCostoNeto
            // 
            this.txtCostoNeto.Enabled = false;
            this.txtCostoNeto.Location = new System.Drawing.Point(420, 115);
            this.txtCostoNeto.Name = "txtCostoNeto";
            this.txtCostoNeto.ReadOnly = true;
            this.txtCostoNeto.Size = new System.Drawing.Size(177, 20);
            this.txtCostoNeto.TabIndex = 82;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(345, 118);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 13);
            this.label27.TabIndex = 81;
            this.label27.Text = "Costo Neto:";
            // 
            // dtmFechaFInal
            // 
            this.dtmFechaFInal.Location = new System.Drawing.Point(109, 168);
            this.dtmFechaFInal.Name = "dtmFechaFInal";
            this.dtmFechaFInal.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaFInal.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "Fecha Final:";
            // 
            // btnBuscarMembresia
            // 
            this.btnBuscarMembresia.Location = new System.Drawing.Point(252, 17);
            this.btnBuscarMembresia.Name = "btnBuscarMembresia";
            this.btnBuscarMembresia.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMembresia.TabIndex = 78;
            this.btnBuscarMembresia.Text = "Buscar";
            this.btnBuscarMembresia.UseVisualStyleBackColor = true;
            // 
            // dtmFechaInicio
            // 
            this.dtmFechaInicio.Location = new System.Drawing.Point(109, 138);
            this.dtmFechaInicio.Name = "dtmFechaInicio";
            this.dtmFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaInicio.TabIndex = 77;
            // 
            // txtCodigoDescuento
            // 
            this.txtCodigoDescuento.Location = new System.Drawing.Point(109, 112);
            this.txtCodigoDescuento.Name = "txtCodigoDescuento";
            this.txtCodigoDescuento.Size = new System.Drawing.Size(137, 20);
            this.txtCodigoDescuento.TabIndex = 76;
            // 
            // txtCostoMembresia
            // 
            this.txtCostoMembresia.Enabled = false;
            this.txtCostoMembresia.Location = new System.Drawing.Point(109, 86);
            this.txtCostoMembresia.Name = "txtCostoMembresia";
            this.txtCostoMembresia.ReadOnly = true;
            this.txtCostoMembresia.Size = new System.Drawing.Size(200, 20);
            this.txtCostoMembresia.TabIndex = 75;
            // 
            // txtBuscarTipoMembresia
            // 
            this.txtBuscarTipoMembresia.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarTipoMembresia.Name = "txtBuscarTipoMembresia";
            this.txtBuscarTipoMembresia.Size = new System.Drawing.Size(224, 20);
            this.txtBuscarTipoMembresia.TabIndex = 74;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 144);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 13);
            this.label28.TabIndex = 71;
            this.label28.Text = "Fecha Inicio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 73;
            this.label15.Text = "Codigo descuento:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 13);
            this.label20.TabIndex = 72;
            this.label20.Text = "Costo Membresia:";
            // 
            // FrmAdministracionGimnasio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 681);
            this.Controls.Add(this.tbAdmin);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAdministracionGimnasio";
            this.Text = "Administracion Gimasio";
            this.Load += new System.EventHandler(this.FrmAdministracionGimnasio_Load);
            this.tbAdmin.ResumeLayout(false);
            this.tbpSocios.ResumeLayout(false);
            this.tbpSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioPruebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbSociosFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpRutinas.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRutinasFotoSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutinasDias)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresias)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMembresiaFotoSocio)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbAdmin;
        private System.Windows.Forms.TabPage tbpSocios;
        private System.Windows.Forms.TabPage tbpRutinas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem controlDeAccesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstmControlAccesoAbrir;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctbSociosFoto;
        private System.Windows.Forms.DateTimePicker dtpSociosFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbSociosSexo;
        private System.Windows.Forms.TextBox txtSociosEmail;
        private System.Windows.Forms.TextBox txtSociosTelefono;
        private System.Windows.Forms.TextBox txtSociosApellidoMaterno;
        private System.Windows.Forms.TextBox txtSociosApellidoPaterno;
        private System.Windows.Forms.TextBox txtSociosNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSociosBuscar;
        private System.Windows.Forms.Button btnSociosNuevo;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Button btnSociosEliminar;
        private System.Windows.Forms.Button btnSociosAnadirFotografia;
        private System.Windows.Forms.TextBox txtSociosBuscar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRutinasGurdarRutina;
        private System.Windows.Forms.Button btnRutinasAgregarARutina;
        private System.Windows.Forms.CheckBox chkRutinasSabado;
        private System.Windows.Forms.CheckBox chkRutinasViernes;
        private System.Windows.Forms.CheckBox chkRutinasJueves;
        private System.Windows.Forms.CheckBox chkRutinasMiercoles;
        private System.Windows.Forms.CheckBox chkRutinasMartes;
        private System.Windows.Forms.CheckBox chkRutinasLunes;
        private System.Windows.Forms.CheckBox chkRutinasDomingo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRutinasTipoEjercicio;
        private System.Windows.Forms.Button btnRutinasBuscarEjercicio;
        private System.Windows.Forms.TextBox txtRutinasRepeticionesEjercicio;
        private System.Windows.Forms.TextBox txtRutinasSeriesEjercicio;
        private System.Windows.Forms.TextBox txtRutinasDescripcionEjercicio;
        private System.Windows.Forms.TextBox txtRutinasNombreEjercicio;
        private System.Windows.Forms.TextBox txtRutinasBuscarEjercicio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutinasAsignadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeMembresiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoDeMembresiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTiposDeMembresiasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSociosClave;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button btnMembresiasEliminar;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSociosAgregar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRenovarMembresiaMembresia;
        private System.Windows.Forms.PictureBox pctbMembresiaFotoSocio;
        private System.Windows.Forms.RadioButton rdbtnSociosBuscarNombre;
        private System.Windows.Forms.RadioButton rdbtnSociosBuscarClave;
        private System.Windows.Forms.Button btnSociosMostrarTodos;
        private System.Windows.Forms.DataGridView dgvMembresias;
        private System.Windows.Forms.DataGridView dgvRutinasDias;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker dtpRutinasFin;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker dtpRutinasInicio;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtRutinasNotas;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pctbRutinasFotoSocio;
        private System.Windows.Forms.TextBox txtRutinasClaveSocio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRutinasNombreSocio;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RadioButton rdbtnRutinasBuscarSocioNombre;
        private System.Windows.Forms.RadioButton rdbtnRutinasBusarSocioClave;
        private System.Windows.Forms.Button btnRutinasBuscarSocio;
        private System.Windows.Forms.TextBox txtRutinasBuscarSocio;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejercicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn domingo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lunes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn martes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn miercoles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jueves;
        private System.Windows.Forms.DataGridViewCheckBoxColumn viernes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sabado;
        private System.Windows.Forms.ToolStripMenuItem pagarMembresiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarSocio;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutinasToolStripMenuItem;
        private GimnasioPruebasDataSet gimnasioPruebasDataSet;
        private System.Windows.Forms.BindingSource sociosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeNacimiento;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSociosAgregarRutinas;
        private System.Windows.Forms.Button btnSociosRenoarMembresia;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.TextBox txtBuscarSocio;
        private System.Windows.Forms.TextBox txtIdSocio;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPorciento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtCobro;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMembresia;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtCostoNeto;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dtmFechaFInal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscarMembresia;
        private System.Windows.Forms.DateTimePicker dtmFechaInicio;
        private System.Windows.Forms.TextBox txtCodigoDescuento;
        private System.Windows.Forms.TextBox txtCostoMembresia;
        private System.Windows.Forms.TextBox txtBuscarTipoMembresia;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
    }
}

