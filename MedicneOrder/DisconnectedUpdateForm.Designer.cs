namespace MedicneOrder
{
    partial class DisconnectedUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.Button btnUpdate;
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
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(30, 30);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.Size = new System.Drawing.Size(740, 300);
            this.dgvMedicines.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(180, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Save Updates";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(340, 360);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 35);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload Data";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(500, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DisconnectedUpdateForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClose);
            this.Name = "DisconnectedUpdateForm";
            this.Text = "Update Medicines (Disconnected)";
            this.Load += new System.EventHandler(this.DisconnectedUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.ResumeLayout(false);
        }
    }
}