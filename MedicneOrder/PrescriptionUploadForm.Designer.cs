namespace MedicneOrder
{
    partial class PrescriptionUploadForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;

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
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(30, 30);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(86, 17);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Selected File:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(33, 59);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(400, 24);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(450, 58);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(120, 25);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload Prescription";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(200, 120);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 30);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PrescriptionUploadForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 200);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "PrescriptionUploadForm";
            this.Text = "Upload Prescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}