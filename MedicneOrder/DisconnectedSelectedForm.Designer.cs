namespace MedicneOrder
{
    partial class DisconnectedSelectedForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSelectedMedicines;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSelectedMedicines = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectedMedicines
            // 
            this.dgvSelectedMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedMedicines.Location = new System.Drawing.Point(30, 30);
            this.dgvSelectedMedicines.Name = "dgvSelectedMedicines";
            this.dgvSelectedMedicines.Size = new System.Drawing.Size(740, 300);
            this.dgvSelectedMedicines.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(250, 360);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 35);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload Data";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(430, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DisconnectedSelectedForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.dgvSelectedMedicines);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClose);
            this.Name = "DisconnectedSelectedForm";
            this.Text = "View Selected Medicines";
            this.Load += new System.EventHandler(this.DisconnectedSelectedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedMedicines)).EndInit();
            this.ResumeLayout(false);
        }
    }
}