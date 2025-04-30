namespace MedicneOrder
{
    partial class DisconnectedUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMedicineID;
        private System.Windows.Forms.TextBox txtMedicineID;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnUpdate;

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
            this.lblMedicineID = new System.Windows.Forms.Label();
            this.txtMedicineID = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblMedicineID
            this.lblMedicineID.AutoSize = true;
            this.lblMedicineID.Location = new System.Drawing.Point(30, 30);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(83, 17);
            this.lblMedicineID.TabIndex = 0;
            this.lblMedicineID.Text = "Medicine ID:";

            // txtMedicineID
            this.txtMedicineID.Location = new System.Drawing.Point(140, 27);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.Size = new System.Drawing.Size(200, 22);
            this.txtMedicineID.TabIndex = 1;

            // btnLoad
            this.btnLoad.Location = new System.Drawing.Point(370, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 26);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(140, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 4;

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 130);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";

            // txtCategory
            this.txtCategory.Location = new System.Drawing.Point(140, 127);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(200, 22);
            this.txtCategory.TabIndex = 6;

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(140, 177);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 8;

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(30, 230);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(104, 17);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity in stock:";

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(140, 227);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 10;

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(140, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // DisconnectedUpdateForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtMedicineID);
            this.Controls.Add(this.lblMedicineID);
            this.Name = "DisconnectedUpdateForm";
            this.Text = "Update Medicine";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}