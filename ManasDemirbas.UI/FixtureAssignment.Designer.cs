namespace ManasDemirbas.UI
{
    partial class FixtureAssignment
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
            this.uxEmployees = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxSuccessMessage = new System.Windows.Forms.Label();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxCategories = new System.Windows.Forms.ComboBox();
            this.uxEmployeeFixtures = new System.Windows.Forms.CheckedListBox();
            this.uxAvailableFixtures = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uxDepartmentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxEmployees
            // 
            this.uxEmployees.FormattingEnabled = true;
            this.uxEmployees.Location = new System.Drawing.Point(138, 15);
            this.uxEmployees.Name = "uxEmployees";
            this.uxEmployees.Size = new System.Drawing.Size(139, 21);
            this.uxEmployees.TabIndex = 0;
            this.uxEmployees.SelectionChangeCommitted += new System.EventHandler(this.uxEmployees_SelectionChangeCommitted);
            this.uxEmployees.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.uxEmployees_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Seçiniz:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(252, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 391);
            this.label2.TabIndex = 2;
            // 
            // uxSuccessMessage
            // 
            this.uxSuccessMessage.AutoSize = true;
            this.uxSuccessMessage.ForeColor = System.Drawing.Color.Green;
            this.uxSuccessMessage.Location = new System.Drawing.Point(199, 455);
            this.uxSuccessMessage.Name = "uxSuccessMessage";
            this.uxSuccessMessage.Size = new System.Drawing.Size(114, 13);
            this.uxSuccessMessage.TabIndex = 6;
            this.uxSuccessMessage.Text = "Değişiklikler Kaydedildi";
            this.uxSuccessMessage.Visible = false;
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(264, 510);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 5;
            this.uxCancel.Text = "&Tamam";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxOk
            // 
            this.uxOk.Location = new System.Drawing.Point(173, 510);
            this.uxOk.Name = "uxOk";
            this.uxOk.Size = new System.Drawing.Size(75, 23);
            this.uxOk.TabIndex = 4;
            this.uxOk.Text = "&Onayla";
            this.uxOk.UseVisualStyleBackColor = true;
            this.uxOk.Click += new System.EventHandler(this.uxOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Atanan Demirbaşlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Atanmamış Demirbaşlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kategori:";
            // 
            // uxCategories
            // 
            this.uxCategories.FormattingEnabled = true;
            this.uxCategories.Location = new System.Drawing.Point(339, 132);
            this.uxCategories.Name = "uxCategories";
            this.uxCategories.Size = new System.Drawing.Size(131, 21);
            this.uxCategories.TabIndex = 8;
            this.uxCategories.SelectionChangeCommitted += new System.EventHandler(this.uxCategories_SelectionChangeCommitted);
            // 
            // uxEmployeeFixtures
            // 
            this.uxEmployeeFixtures.FormattingEnabled = true;
            this.uxEmployeeFixtures.Location = new System.Drawing.Point(45, 159);
            this.uxEmployeeFixtures.Name = "uxEmployeeFixtures";
            this.uxEmployeeFixtures.Size = new System.Drawing.Size(191, 244);
            this.uxEmployeeFixtures.TabIndex = 9;
            // 
            // uxAvailableFixtures
            // 
            this.uxAvailableFixtures.FormattingEnabled = true;
            this.uxAvailableFixtures.Location = new System.Drawing.Point(279, 159);
            this.uxAvailableFixtures.Name = "uxAvailableFixtures";
            this.uxAvailableFixtures.Size = new System.Drawing.Size(191, 244);
            this.uxAvailableFixtures.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(55, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 55);
            this.label6.TabIndex = 11;
            this.label6.Text = "Demirbaşı personel üzerinden almak için tik işaretini kaldırıp onaylayın.";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(276, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Atamak istediğiniz demirbaşları seçiniz";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(118, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Yaptığınız her değişikliği \"Onayla\" butonu ile kaydedebilirsiniz.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Departman:";
            // 
            // uxDepartmentName
            // 
            this.uxDepartmentName.AutoSize = true;
            this.uxDepartmentName.Location = new System.Drawing.Point(366, 18);
            this.uxDepartmentName.Name = "uxDepartmentName";
            this.uxDepartmentName.Size = new System.Drawing.Size(101, 13);
            this.uxDepartmentName.TabIndex = 15;
            this.uxDepartmentName.Text = "uxDepartmentName";
            // 
            // FixtureAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 550);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxSuccessMessage);
            this.Controls.Add(this.uxOk);
            this.Controls.Add(this.uxDepartmentName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxAvailableFixtures);
            this.Controls.Add(this.uxEmployeeFixtures);
            this.Controls.Add(this.uxCategories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxEmployees);
            this.MaximizeBox = false;
            this.Name = "FixtureAssignment";
            this.Text = "Personel -> Demirbaş Atama";
            this.Load += new System.EventHandler(this.FixtureAssignment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uxCategories;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxOk;
        private System.Windows.Forms.CheckedListBox uxEmployeeFixtures;
        private System.Windows.Forms.CheckedListBox uxAvailableFixtures;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label uxSuccessMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label uxDepartmentName;
    }
}