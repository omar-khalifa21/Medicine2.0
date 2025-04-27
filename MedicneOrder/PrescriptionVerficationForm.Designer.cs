namespace MedicneOrder
{
    partial class PrescriptionVerificationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnSaveChanges;
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
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.Location = new System.Drawing.Point(30, 30);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.Size = new System.Drawing.Size(740, 300);
            this.dgvPrescriptions.TabIndex = 0;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(100, 360);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(100, 35);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(220, 360);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(100, 35);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(340, 360);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 35);
            this.btnSaveChanges.TabIndex = 3;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(480, 360);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 35);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(600, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PrescriptionVerificationForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.dgvPrescriptions);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClose);
            this.Name = "PrescriptionVerificationForm";
            this.Text = "Verify Prescriptions";
            this.Load += new System.EventHandler(this.PrescriptionVerificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
