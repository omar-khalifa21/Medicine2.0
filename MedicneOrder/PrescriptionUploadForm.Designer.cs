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

            // lblPrescriptionID
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Location = new System.Drawing.Point(30, 30);
            this.lblPrescriptionID.Text = "Prescription ID";

            // txtPrescriptionID
            this.txtPrescriptionID.Location = new System.Drawing.Point(30, 50);
            this.txtPrescriptionID.Size = new System.Drawing.Size(300, 22);

            // lblUserID
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(30, 90);
            this.lblUserID.Text = "User ID";

            // txtUserID
            this.txtUserID.Location = new System.Drawing.Point(30, 110);
            this.txtUserID.Size = new System.Drawing.Size(300, 22);

            // lblUploadDate
            this.lblUploadDate.AutoSize = true;
            this.lblUploadDate.Location = new System.Drawing.Point(30, 150);
            this.lblUploadDate.Text = "Upload Date";

            // dateTimePickerUploadDate
            this.dateTimePickerUploadDate.Location = new System.Drawing.Point(30, 170);
            this.dateTimePickerUploadDate.Size = new System.Drawing.Size(300, 22);

            // lblPatientName
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(30, 210);
            this.lblPatientName.Text = "Patient Name";

            // txtPatientName
            this.txtPatientName.Location = new System.Drawing.Point(30, 230);
            this.txtPatientName.Size = new System.Drawing.Size(300, 22);

            // lblMedicineName
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Location = new System.Drawing.Point(30, 270);
            this.lblMedicineName.Text = "Medicine Name";

            // txtMedicineName
            this.txtMedicineName.Location = new System.Drawing.Point(30, 290);
            this.txtMedicineName.Size = new System.Drawing.Size(300, 22);

            // lblDosage
            this.lblDosage.AutoSize = true;
            this.lblDosage.Location = new System.Drawing.Point(30, 330);
            this.lblDosage.Text = "Dosage";

            // txtDosage
            this.txtDosage.Location = new System.Drawing.Point(30, 350);
            this.txtDosage.Size = new System.Drawing.Size(300, 22);

            // btnUpload
            this.btnUpload.Location = new System.Drawing.Point(30, 390);
            this.btnUpload.Size = new System.Drawing.Size(300, 35);
            this.btnUpload.Text = "Upload Prescription";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);

            // Form Settings
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
