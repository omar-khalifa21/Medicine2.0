namespace MedicneOrder
{
    partial class PrescriptionUploadForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.txtPrescriptionID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUploadDate = new System.Windows.Forms.Label();
            this.dateTimePickerUploadDate = new System.Windows.Forms.DateTimePicker();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.lblDosage = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Location = new System.Drawing.Point(30, 30);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(113, 20);
            this.lblPrescriptionID.TabIndex = 0;
            this.lblPrescriptionID.Text = "Prescription ID";
            // 
            // txtPrescriptionID
            // 
            this.txtPrescriptionID.Location = new System.Drawing.Point(30, 50);
            this.txtPrescriptionID.Name = "txtPrescriptionID";
            this.txtPrescriptionID.Size = new System.Drawing.Size(300, 26);
            this.txtPrescriptionID.TabIndex = 1;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(30, 90);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(64, 20);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(30, 110);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(300, 26);
            this.txtUserID.TabIndex = 3;
            // 
            // lblUploadDate
            // 
            this.lblUploadDate.AutoSize = true;
            this.lblUploadDate.Location = new System.Drawing.Point(30, 150);
            this.lblUploadDate.Name = "lblUploadDate";
            this.lblUploadDate.Size = new System.Drawing.Size(99, 20);
            this.lblUploadDate.TabIndex = 4;
            this.lblUploadDate.Text = "Upload Date";
            // 
            // dateTimePickerUploadDate
            // 
            this.dateTimePickerUploadDate.Location = new System.Drawing.Point(30, 170);
            this.dateTimePickerUploadDate.Name = "dateTimePickerUploadDate";
            this.dateTimePickerUploadDate.Size = new System.Drawing.Size(300, 26);
            this.dateTimePickerUploadDate.TabIndex = 5;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(30, 210);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(105, 20);
            this.lblPatientName.TabIndex = 6;
            this.lblPatientName.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(30, 230);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(300, 26);
            this.txtPatientName.TabIndex = 7;
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Location = new System.Drawing.Point(30, 270);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(118, 20);
            this.lblMedicineName.TabIndex = 8;
            this.lblMedicineName.Text = "Medicine Name";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(30, 290);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(300, 26);
            this.txtMedicineName.TabIndex = 9;
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.Location = new System.Drawing.Point(30, 330);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(65, 20);
            this.lblDosage.TabIndex = 10;
            this.lblDosage.Text = "Dosage";
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(30, 350);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(300, 26);
            this.txtDosage.TabIndex = 11;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(30, 390);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(300, 35);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload Prescription";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // PrescriptionUploadForm
            // 
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.lblPrescriptionID);
            this.Controls.Add(this.txtPrescriptionID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUploadDate);
            this.Controls.Add(this.dateTimePickerUploadDate);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblMedicineName);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblDosage);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.btnUpload);
            this.Name = "PrescriptionUploadForm";
            this.Text = "Upload Prescription";
            this.Load += new System.EventHandler(this.PrescriptionUploadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrescriptionID;
        private System.Windows.Forms.TextBox txtPrescriptionID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUploadDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerUploadDate;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Button btnUpload;
    }
}
