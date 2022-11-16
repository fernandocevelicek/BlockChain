namespace LibroContable
{
    partial class CargaCuentaView
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
            this.btnCargarCuenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.labelCodigoCuenta = new System.Windows.Forms.Label();
            this.labelDenominacion = new System.Windows.Forms.Label();
            this.txtCodigoCuenta = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargarCuenta
            // 
            this.btnCargarCuenta.Location = new System.Drawing.Point(485, 190);
            this.btnCargarCuenta.Name = "btnCargarCuenta";
            this.btnCargarCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnCargarCuenta.TabIndex = 0;
            this.btnCargarCuenta.Text = "Cargar";
            this.btnCargarCuenta.UseVisualStyleBackColor = true;
            this.btnCargarCuenta.Click += new System.EventHandler(this.btnCargarCuenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // labelCodigoCuenta
            // 
            this.labelCodigoCuenta.AutoSize = true;
            this.labelCodigoCuenta.Location = new System.Drawing.Point(244, 158);
            this.labelCodigoCuenta.Name = "labelCodigoCuenta";
            this.labelCodigoCuenta.Size = new System.Drawing.Size(90, 15);
            this.labelCodigoCuenta.TabIndex = 2;
            this.labelCodigoCuenta.Text = "Codigo Cuenta:";
            // 
            // labelDenominacion
            // 
            this.labelDenominacion.AutoSize = true;
            this.labelDenominacion.Location = new System.Drawing.Point(244, 193);
            this.labelDenominacion.Name = "labelDenominacion";
            this.labelDenominacion.Size = new System.Drawing.Size(88, 15);
            this.labelDenominacion.TabIndex = 3;
            this.labelDenominacion.Text = "Denominacion:";
            // 
            // txtCodigoCuenta
            // 
            this.txtCodigoCuenta.Location = new System.Drawing.Point(340, 155);
            this.txtCodigoCuenta.Name = "txtCodigoCuenta";
            this.txtCodigoCuenta.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoCuenta.TabIndex = 4;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(340, 190);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(100, 23);
            this.txtDenominacion.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(244, 76);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 21);
            this.lblError.TabIndex = 10;
            // 
            // CargaCuentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtCodigoCuenta);
            this.Controls.Add(this.labelDenominacion);
            this.Controls.Add(this.labelCodigoCuenta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargarCuenta);
            this.Name = "CargaCuentaView";
            this.Text = "Carga Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCargarCuenta;
        private Button btnVolver;
        private Label labelCodigoCuenta;
        private Label labelDenominacion;
        private TextBox txtCodigoCuenta;
        private TextBox txtDenominacion;
        private Label lblError;
    }
}