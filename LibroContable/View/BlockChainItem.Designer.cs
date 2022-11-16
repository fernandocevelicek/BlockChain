namespace LibroContable.View
{
    partial class BlockChainItem
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dataLabelFecha = new System.Windows.Forms.Label();
            this.dataLabelIndice = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.dataGridViewAsiento = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLineBreak = new System.Windows.Forms.Label();
            this.lblAsientos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsiento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(21, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // dataLabelFecha
            // 
            this.dataLabelFecha.AutoSize = true;
            this.dataLabelFecha.Location = new System.Drawing.Point(68, 46);
            this.dataLabelFecha.Name = "dataLabelFecha";
            this.dataLabelFecha.Size = new System.Drawing.Size(83, 15);
            this.dataLabelFecha.TabIndex = 1;
            this.dataLabelFecha.Text = "DD/MM/YYYY";
            // 
            // dataLabelIndice
            // 
            this.dataLabelIndice.AutoSize = true;
            this.dataLabelIndice.Location = new System.Drawing.Point(48, 13);
            this.dataLabelIndice.Name = "dataLabelIndice";
            this.dataLabelIndice.Size = new System.Drawing.Size(14, 15);
            this.dataLabelIndice.TabIndex = 3;
            this.dataLabelIndice.Text = "#";
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(21, 13);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(21, 15);
            this.lblIndice.TabIndex = 2;
            this.lblIndice.Text = "ID:";
            // 
            // dataGridViewAsiento
            // 
            this.dataGridViewAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Concepto});
            this.dataGridViewAsiento.Location = new System.Drawing.Point(21, 109);
            this.dataGridViewAsiento.Name = "dataGridViewAsiento";
            this.dataGridViewAsiento.RowTemplate.Height = 25;
            this.dataGridViewAsiento.Size = new System.Drawing.Size(593, 215);
            this.dataGridViewAsiento.TabIndex = 4;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // lblLineBreak
            // 
            this.lblLineBreak.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLineBreak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLineBreak.Location = new System.Drawing.Point(0, 343);
            this.lblLineBreak.Name = "lblLineBreak";
            this.lblLineBreak.Size = new System.Drawing.Size(634, 1);
            this.lblLineBreak.TabIndex = 8;
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(21, 91);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(52, 15);
            this.lblAsientos.TabIndex = 9;
            this.lblAsientos.Text = "Asientos";
            // 
            // BlockChainItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAsientos);
            this.Controls.Add(this.lblLineBreak);
            this.Controls.Add(this.dataGridViewAsiento);
            this.Controls.Add(this.dataLabelIndice);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.dataLabelFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "BlockChainItem";
            this.Size = new System.Drawing.Size(637, 359);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFecha;
        private Label dataLabelFecha;
        private Label dataLabelIndice;
        private Label lblIndice;
        private DataGridView dataGridViewAsiento;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Concepto;
        private Label lblLineBreak;
        private Label lblAsientos;
    }
}
