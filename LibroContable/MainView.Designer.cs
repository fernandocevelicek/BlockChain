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
            this.BtnAgregarCuenta = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnAgregarAsiento = new System.Windows.Forms.Button();
            this.flowLayoutPanelAsientos = new System.Windows.Forms.FlowLayoutPanel();
            this.asientoListItem1 = new LibroContable.View.AsientoListItem();
            this.btnConfirmarLibro = new System.Windows.Forms.Button();
            this.btnVerBlockchain = new System.Windows.Forms.Button();
            this.flowLayoutPanelAsientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAgregarCuenta
            // 
            this.BtnAgregarCuenta.Location = new System.Drawing.Point(684, 12);
            this.BtnAgregarCuenta.Name = "BtnAgregarCuenta";
            this.BtnAgregarCuenta.Size = new System.Drawing.Size(104, 23);
            this.BtnAgregarCuenta.TabIndex = 5;
            this.BtnAgregarCuenta.Text = "Cargar Cuenta";
            this.BtnAgregarCuenta.UseVisualStyleBackColor = true;
            this.BtnAgregarCuenta.Click += new System.EventHandler(this.BtnAgregarCuenta_Click);
            // 
            // btnAgregarAsiento
            // 
            this.btnAgregarAsiento.Location = new System.Drawing.Point(684, 51);
            this.btnAgregarAsiento.Name = "btnAgregarAsiento";
            this.btnAgregarAsiento.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarAsiento.TabIndex = 6;
            this.btnAgregarAsiento.Text = "Agregar Asiento";
            this.btnAgregarAsiento.UseVisualStyleBackColor = true;
            this.btnAgregarAsiento.Click += new System.EventHandler(this.btnAgregarAsiento_Click);
            // 
            // flowLayoutPanelAsientos
            // 
            this.flowLayoutPanelAsientos.AutoScroll = true;
            this.flowLayoutPanelAsientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelAsientos.Controls.Add(this.asientoListItem1);
            this.flowLayoutPanelAsientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelAsientos.Location = new System.Drawing.Point(0, 98);
            this.flowLayoutPanelAsientos.Name = "flowLayoutPanelAsientos";
            this.flowLayoutPanelAsientos.Size = new System.Drawing.Size(800, 352);
            this.flowLayoutPanelAsientos.TabIndex = 7;
            // 
            // asientoListItem1
            // 
            this.asientoListItem1.asiento = null;
            this.asientoListItem1.Concepto = null;
            this.asientoListItem1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.asientoListItem1.Fecha = null;
            this.asientoListItem1.IdAsiento = null;
            this.asientoListItem1.Location = new System.Drawing.Point(3, 3);
            this.asientoListItem1.Movimientos = null;
            this.asientoListItem1.Name = "asientoListItem1";
            this.asientoListItem1.Size = new System.Drawing.Size(790, 226);
            this.asientoListItem1.TabIndex = 0;
            // 
            // btnConfirmarLibro
            // 
            this.btnConfirmarLibro.Location = new System.Drawing.Point(542, 12);
            this.btnConfirmarLibro.Name = "btnConfirmarLibro";
            this.btnConfirmarLibro.Size = new System.Drawing.Size(111, 62);
            this.btnConfirmarLibro.TabIndex = 8;
            this.btnConfirmarLibro.Text = "Confirmar Libro";
            this.btnConfirmarLibro.UseVisualStyleBackColor = true;
            this.btnConfirmarLibro.Click += new System.EventHandler(this.btnConfirmarLibro_Click);
            // 
            // btnVerBlockchain
            // 
            this.btnVerBlockchain.Location = new System.Drawing.Point(4, 12);
            this.btnVerBlockchain.Name = "btnVerBlockchain";
            this.btnVerBlockchain.Size = new System.Drawing.Size(178, 62);
            this.btnVerBlockchain.TabIndex = 9;
            this.btnVerBlockchain.Text = "Ver Blockchain";
            this.btnVerBlockchain.UseVisualStyleBackColor = true;
            this.btnVerBlockchain.Click += new System.EventHandler(this.btnVerBlockchain_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerBlockchain);
            this.Controls.Add(this.btnConfirmarLibro);
            this.Controls.Add(this.flowLayoutPanelAsientos);
            this.Controls.Add(this.btnAgregarAsiento);
            this.Controls.Add(this.BtnAgregarCuenta);
            this.Name = "MainView";
            this.Text = "LibroDiario";
            this.flowLayoutPanelAsientos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnAgregarCuenta;
        private PageSetupDialog pageSetupDialog1;
        private Button btnAgregarAsiento;
        private FlowLayoutPanel flowLayoutPanelAsientos;
        private View.AsientoListItem asientoListItem1;
        private Button btnConfirmarLibro;
        private Button btnVerBlockchain;
    }
}