namespace almarith_project
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel16 = new System.Windows.Forms.Panel();
            this.femail = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.tarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Teal;
            this.panel16.Controls.Add(this.femail);
            this.panel16.Controls.Add(this.male);
            this.panel16.Controls.Add(this.label24);
            this.panel16.Controls.Add(this.tarka);
            this.panel16.Controls.Add(this.label3);
            this.panel16.Controls.Add(this.label2);
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1057, 274);
            this.panel16.TabIndex = 98;
            // 
            // femail
            // 
            this.femail.AutoSize = true;
            this.femail.BackColor = System.Drawing.Color.Teal;
            this.femail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.femail.Location = new System.Drawing.Point(30, 67);
            this.femail.Name = "femail";
            this.femail.Size = new System.Drawing.Size(55, 25);
            this.femail.TabIndex = 97;
            this.femail.TabStop = true;
            this.femail.Text = "أنثى";
            this.femail.UseVisualStyleBackColor = false;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackColor = System.Drawing.Color.Teal;
            this.male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.male.Location = new System.Drawing.Point(124, 67);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(51, 25);
            this.male.TabIndex = 96;
            this.male.TabStop = true;
            this.male.Text = "ذكر";
            this.male.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Teal;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(223, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 25);
            this.label24.TabIndex = 95;
            this.label24.Text = "جنس المتوفي";
            // 
            // tarka
            // 
            this.tarka.AccessibleName = "tarka";
            this.tarka.BackColor = System.Drawing.Color.Beige;
            this.tarka.Location = new System.Drawing.Point(78, 119);
            this.tarka.Name = "tarka";
            this.tarka.Size = new System.Drawing.Size(111, 23);
            this.tarka.TabIndex = 77;
            this.tarka.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(223, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "قيمة التركه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 75;
            this.label2.Text = "معلومات عن المتوفى";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel16);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1063, 280);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel16;
        private RadioButton femail;
        private RadioButton male;
        private Label label24;
        private TextBox tarka;
        private Label label3;
        private Label label2;
    }
}
