namespace MedicneOrder
{
    partial class DisconnectedSelectedForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFilter;

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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(130, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 0;

            // cmbFilter
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(130, 65);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(250, 24);
            this.cmbFilter.TabIndex = 1;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(400, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // dgvResults
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(25, 110);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(750, 350);
            this.dgvResults.TabIndex = 3;

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(25, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 17);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search Term:";

            // lblFilter
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(25, 68);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(82, 17);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Filter by:";

            // DisconnectedSelectForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtSearch);
            this.Name = "DisconnectedSelectForm";
            this.Text = "Search Medicines";
            this.Load += new System.EventHandler(this.DisconnectedSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
