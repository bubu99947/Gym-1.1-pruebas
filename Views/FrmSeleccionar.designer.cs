namespace Gym_1_1_pruebas.Views
{ 
    partial class FrmSeleccionar
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
            this.dgvSelecciona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecciona)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelecciona
            // 
            this.dgvSelecciona.AllowUserToAddRows = false;
            this.dgvSelecciona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelecciona.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSelecciona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelecciona.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSelecciona.Location = new System.Drawing.Point(12, 12);
            this.dgvSelecciona.Name = "dgvSelecciona";
            this.dgvSelecciona.ReadOnly = true;
            this.dgvSelecciona.Size = new System.Drawing.Size(599, 508);
            this.dgvSelecciona.TabIndex = 39;
            this.dgvSelecciona.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSelecciona_CellMouseDoubleClick);
            // 
            // FrmSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 532);
            this.Controls.Add(this.dgvSelecciona);
            this.Name = "FrmSeleccionar";
            this.Text = "FrmSeleccionar";
            this.Load += new System.EventHandler(this.FrmSeleccionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecciona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelecciona;
    }
}