namespace almarith_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new Guna.UI2.WinForms.Guna2Button();
            this.Edit = new Guna.UI2.WinForms.Guna2Button();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.newmotawfi = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.take = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.The_ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الاسم = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.update = new Guna.UI2.WinForms.Guna2Button();
            this.ID_Elmwtafi = new System.Windows.Forms.TextBox();
            this.Name_elmotawfi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Tarka = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.newmotawfi);
            this.panel1.Location = new System.Drawing.Point(8, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 58);
            this.panel1.TabIndex = 98;
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Save.FillColor = System.Drawing.Color.White;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(329, 11);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 40);
            this.Save.TabIndex = 104;
            this.Save.Text = "حفظ";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Edit
            // 
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Edit.FillColor = System.Drawing.Color.White;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit.ForeColor = System.Drawing.Color.Black;
            this.Edit.Location = new System.Drawing.Point(477, 11);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 40);
            this.Edit.TabIndex = 103;
            this.Edit.Text = "تعديل";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.FillColor = System.Drawing.Color.White;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(181, 11);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 40);
            this.Delete.TabIndex = 102;
            this.Delete.Text = "حذف";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancel.FillColor = System.Drawing.Color.White;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(33, 11);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 40);
            this.Cancel.TabIndex = 101;
            this.Cancel.Text = "الغاء";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // newmotawfi
            // 
            this.newmotawfi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newmotawfi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newmotawfi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newmotawfi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newmotawfi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newmotawfi.FillColor = System.Drawing.Color.White;
            this.newmotawfi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newmotawfi.ForeColor = System.Drawing.Color.Black;
            this.newmotawfi.Location = new System.Drawing.Point(625, 11);
            this.newmotawfi.Name = "newmotawfi";
            this.newmotawfi.Size = new System.Drawing.Size(75, 40);
            this.newmotawfi.TabIndex = 100;
            this.newmotawfi.Text = "اضافه";
            this.newmotawfi.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.take,
            this.The_ratio,
            this.ID,
            this.الاسم,
            this.relation});
            this.dataGridView1.Location = new System.Drawing.Point(27, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(763, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // take
            // 
            this.take.HeaderText = "النصيب";
            this.take.Name = "take";
            this.take.ReadOnly = true;
            this.take.Width = 120;
            // 
            // The_ratio
            // 
            this.The_ratio.HeaderText = "نسبة الورث";
            this.The_ratio.Name = "The_ratio";
            this.The_ratio.ReadOnly = true;
            this.The_ratio.Width = 120;
            // 
            // ID
            // 
            this.ID.HeaderText = "رقم البطاقه";
            this.ID.Name = "ID";
            this.ID.Width = 180;
            // 
            // الاسم
            // 
            this.الاسم.HeaderText = "الاسم";
            this.الاسم.Name = "الاسم";
            this.الاسم.Width = 200;
            // 
            // relation
            // 
            this.relation.HeaderText = "صلة القرابة";
            this.relation.Items.AddRange(new object[] {
            "ابن",
            "ابنه",
            "اب",
            "ام",
            "اخ",
            "اخت",
            "زوج",
            "زوجه"});
            this.relation.Name = "relation";
            this.relation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.relation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 463);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(763, 249);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update.FillColor = System.Drawing.Color.CadetBlue;
            this.update.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Location = new System.Drawing.Point(628, 425);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(83, 32);
            this.update.TabIndex = 105;
            this.update.Text = "حساب";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ID_Elmwtafi
            // 
            this.ID_Elmwtafi.AccessibleName = "tarka";
            this.ID_Elmwtafi.BackColor = System.Drawing.Color.White;
            this.ID_Elmwtafi.Location = new System.Drawing.Point(380, 105);
            this.ID_Elmwtafi.Name = "ID_Elmwtafi";
            this.ID_Elmwtafi.Size = new System.Drawing.Size(128, 23);
            this.ID_Elmwtafi.TabIndex = 124;
            this.ID_Elmwtafi.Text = "0";
            // 
            // Name_elmotawfi
            // 
            this.Name_elmotawfi.Location = new System.Drawing.Point(579, 106);
            this.Name_elmotawfi.Name = "Name_elmotawfi";
            this.Name_elmotawfi.Size = new System.Drawing.Size(113, 23);
            this.Name_elmotawfi.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(579, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 121;
            this.label4.Text = "اسم المتوفي";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CadetBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "قيمة التركه";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.CadetBlue;
            this.Female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Female.Location = new System.Drawing.Point(211, 105);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(55, 25);
            this.Female.TabIndex = 118;
            this.Female.TabStop = true;
            this.Female.Text = "أنثى";
            this.Female.UseVisualStyleBackColor = false;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.CadetBlue;
            this.Male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Male.Location = new System.Drawing.Point(290, 105);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(51, 25);
            this.Male.TabIndex = 117;
            this.Male.TabStop = true;
            this.Male.Text = "ذكر";
            this.Male.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(211, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 116;
            this.label6.Text = "جنس المتوفي";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(27, 146);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(763, 260);
            this.dataGridView3.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(391, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 127;
            this.label2.Text = "رقم البطاقه";
            // 
            // Tarka
            // 
            this.Tarka.AccessibleName = "tarka";
            this.Tarka.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tarka.Location = new System.Drawing.Point(41, 107);
            this.Tarka.MaxLength = 10;
            this.Tarka.Name = "Tarka";
            this.Tarka.Size = new System.Drawing.Size(111, 23);
            this.Tarka.TabIndex = 128;
            this.Tarka.Text = " ";
            this.Tarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarka_KeyPress);
            // 
            // search
            // 
            this.search.AccessibleName = "tarka";
            this.search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.search.Location = new System.Drawing.Point(181, 425);
            this.search.MaxLength = 15;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(188, 23);
            this.search.TabIndex = 129;
            this.search.Text = " ";
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarka_KeyPress);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.CadetBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(95, 420);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(62, 32);
            this.guna2Button1.TabIndex = 130;
            this.guna2Button1.Text = "بحث";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(877, 749);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Tarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.ID_Elmwtafi);
            this.Controls.Add(this.Name_elmotawfi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Save;
        private Guna.UI2.WinForms.Guna2Button Edit;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button Cancel;
        private Guna.UI2.WinForms.Guna2Button newmotawfi;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2Button update;
        private TextBox ID_Elmwtafi;
        private TextBox Name_elmotawfi;
        private Label label4;
        private Label label5;
        private RadioButton Female;
        private RadioButton Male;
        private Label label6;
        private DataGridView dataGridView3;
        private Label label2;
        private TextBox Tarka;
        private TextBox search;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridViewTextBoxColumn take;
        private DataGridViewTextBoxColumn The_ratio;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn الاسم;
        private DataGridViewComboBoxColumn relation;
    }
}