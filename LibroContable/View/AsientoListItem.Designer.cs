namespace LibroContable.View
{
    partial class AsientoListItem
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAsiento = new System.Windows.Forms.Label();
            this.dataGridMovimientos = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dataLabelAsientoID = new System.Windows.Forms.Label();
            this.dataLabelConcepto = new System.Windows.Forms.Label();
            this.dataLabelFecha = new System.Windows.Forms.Label();
            this.lblLineBreak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsiento
            // 
            this.lblAsiento.AutoSize = true;
            this.lblAsiento.Location = new System.Drawing.Point(3, 15);
            this.lblAsiento.Name = "lblAsiento";
            this.lblAsiento.Size = new System.Drawing.Size(50, 15);
            this.lblAsiento.TabIndex = 0;
            this.lblAsiento.Text = "Asiento:";
            // 
            // dataGridMovimientos
            // 
            this.dataGridMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Descripcion,
            this.Debe,
            this.Haber});
            this.dataGridMovimientos.Location = new System.Drawing.Point(3, 73);
            this.dataGridMovimientos.Name = "dataGridMovimientos";
            this.dataGridMovimientos.RowTemplate.Height = 25;
            this.dataGridMovimientos.Size = new System.Drawing.Size(784, 150);
            this.dataGridMovimientos.TabIndex = 1;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.Name = "Haber";
            this.Haber.ReadOnly = true;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(297, 15);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(62, 15);
            this.lblConcepto.TabIndex = 2;
            this.lblConcepto.Text = "Concepto:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(3, 44);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // dataLabelAsientoID
            // 
            this.dataLabelAsientoID.Location = new System.Drawing.Point(71, 15);
            this.dataLabelAsientoID.Name = "dataLabelAsientoID";
            this.dataLabelAsientoID.Size = new System.Drawing.Size(220, 15);
            this.dataLabelAsientoID.TabIndex = 4;
            this.dataLabelAsientoID.Text = "ID";
            // 
            // dataLabelConcepto
            // 
            this.dataLabelConcepto.Location = new System.Drawing.Point(365, 15);
            this.dataLabelConcepto.Name = "dataLabelConcepto";
            this.dataLabelConcepto.Size = new System.Drawing.Size(408, 15);
            this.dataLabelConcepto.TabIndex = 5;
            this.dataLabelConcepto.Text = "CONCEPTO";
            // 
            // dataLabelFecha
            // 
            this.dataLabelFecha.Location = new System.Drawing.Point(71, 44);
            this.dataLabelFecha.Name = "dataLabelFecha";
            this.dataLabelFecha.Size = new System.Drawing.Size(162, 15);
            this.dataLabelFecha.TabIndex = 6;
            this.dataLabelFecha.Text = "AAAA/MM/DD";
            // 
            // lblLineBreak
            // 
            this.lblLineBreak.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLineBreak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLineBreak.Location = new System.Drawing.Point(0, 228);
            this.lblLineBreak.Name = "lblLineBreak";
            this.lblLineBreak.Size = new System.Drawing.Size(790, 1);
            this.lblLineBreak.TabIndex = 7;
            // 
            // AsientoListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLineBreak);
            this.Controls.Add(this.dataLabelFecha);
            this.Controls.Add(this.dataLabelConcepto);
            this.Controls.Add(this.dataLabelAsientoID);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.dataGridMovimientos);
            this.Controls.Add(this.lblAsiento);
            this.Name = "AsientoListItem";
            this.Size = new System.Drawing.Size(790, 233);
            this.Load += new System.EventHandler(this.AsientoListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAsiento;
        private DataGridView dataGridMovimientos;
        private Label lblConcepto;
        private Label lblFecha;
        private Label dataLabelAsientoID;
        private Label dataLabelConcepto;
        private Label dataLabelFecha;
        private DataGridViewTextBoxColumn Cuenta;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Debe;
        private DataGridViewTextBoxColumn Haber;
        private Label lblLineBreak;
    }
}
