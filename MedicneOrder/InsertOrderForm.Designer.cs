namespace MedicneOrder
{
    partial class InsertOrderForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(513, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(513, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 22);
            this.textBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(298, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "MedicineID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "UserID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Placement Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update/Place";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "InsertOrderForm";
            this.Text = "InsertOrderForm";
            this.Load += new System.EventHandler(this.InsertOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}