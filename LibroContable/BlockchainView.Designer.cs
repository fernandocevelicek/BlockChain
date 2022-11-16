namespace LibroContable
{
    partial class BlockchainView
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
            this.flowLayoutBlochainItem = new System.Windows.Forms.FlowLayoutPanel();
            this.blockChainItem1 = new LibroContable.View.BlockChainItem();
            this.lblTitleBlockchain = new System.Windows.Forms.Label();
            this.flowLayoutBlochainItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutBlochainItem
            // 
            this.flowLayoutBlochainItem.AutoScroll = true;
            this.flowLayoutBlochainItem.Controls.Add(this.blockChainItem1);
            this.flowLayoutBlochainItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutBlochainItem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutBlochainItem.Location = new System.Drawing.Point(0, 104);
            this.flowLayoutBlochainItem.Name = "flowLayoutBlochainItem";
            this.flowLayoutBlochainItem.Size = new System.Drawing.Size(800, 477);
            this.flowLayoutBlochainItem.TabIndex = 0;
            this.flowLayoutBlochainItem.WrapContents = false;
            // 
            // blockChainItem1
            // 
            this.blockChainItem1.Asientos = null;
            this.blockChainItem1.FechaLibro = null;
            this.blockChainItem1.IdLibro = null;
            this.blockChainItem1.Location = new System.Drawing.Point(3, 3);
            this.blockChainItem1.Name = "blockChainItem1";
            this.blockChainItem1.Size = new System.Drawing.Size(797, 359);
            this.blockChainItem1.TabIndex = 0;
            // 
            // lblTitleBlockchain
            // 
            this.lblTitleBlockchain.AutoSize = true;
            this.lblTitleBlockchain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleBlockchain.Location = new System.Drawing.Point(3, 42);
            this.lblTitleBlockchain.Name = "lblTitleBlockchain";
            this.lblTitleBlockchain.Size = new System.Drawing.Size(201, 32);
            this.lblTitleBlockchain.TabIndex = 1;
            this.lblTitleBlockchain.Text = "Listado Bloques:";
            // 
            // BlockchainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.lblTitleBlockchain);
            this.Controls.Add(this.flowLayoutBlochainItem);
            this.Name = "BlockchainView";
            this.RightToLeftLayout = true;
            this.Text = "BlockChain";
            this.flowLayoutBlochainItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutBlochainItem;
        private View.BlockChainItem blockChainItem1;
        private Label lblTitleBlockchain;
    }
}