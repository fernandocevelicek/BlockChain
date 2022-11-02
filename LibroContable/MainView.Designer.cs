namespace LibroContable
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.BtnAgregarCuenta = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnAgregarAsiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(23, 229);
            this.Grilla.Name = "Grilla";
            this.Grilla.RowTemplate.Height = 25;
            this.Grilla.Size = new System.Drawing.Size(765, 209);
            this.Grilla.TabIndex = 4;
            // 
            // BtnAgregarCuenta
            // 
            this.BtnAgregarCuenta.Location = new System.Drawing.Point(684, 37);
            this.BtnAgregarCuenta.Name = "BtnAgregarCuenta";
            this.BtnAgregarCuenta.Size = new System.Drawing.Size(104, 23);
            this.BtnAgregarCuenta.TabIndex = 5;
            this.BtnAgregarCuenta.Text = "Cargar Cuenta";
            this.BtnAgregarCuenta.UseVisualStyleBackColor = true;
            this.BtnAgregarCuenta.Click += new System.EventHandler(this.BtnAgregarCuenta_Click);
            // 
            // btnAgregarAsiento
            // 
            this.btnAgregarAsiento.Location = new System.Drawing.Point(684, 76);
            this.btnAgregarAsiento.Name = "btnAgregarAsiento";
            this.btnAgregarAsiento.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarAsiento.TabIndex = 6;
            this.btnAgregarAsiento.Text = "Agregar Asiento";
            this.btnAgregarAsiento.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarAsiento);
            this.Controls.Add(this.BtnAgregarCuenta);
            this.Controls.Add(this.Grilla);
            this.Name = "MainView";
            this.Text = "LibroDiario";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView Grilla;
        private Button BtnAgregarCuenta;
        private PageSetupDialog pageSetupDialog1;
        private Button btnAgregarAsiento;
    }
}