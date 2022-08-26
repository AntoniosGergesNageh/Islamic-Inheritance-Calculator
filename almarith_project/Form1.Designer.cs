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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Edit = new Guna.UI2.WinForms.Guna2Button();
            this.Save = new Guna.UI2.WinForms.Guna2Button();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.added = new Guna.UI2.WinForms.Guna2Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.added);
            this.panel1.Location = new System.Drawing.Point(27, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 58);
            this.panel1.TabIndex = 98;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Edit
            // 
            this.Edit.BorderRadius = 5;
            this.Edit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Edit.FillColor = System.Drawing.Color.White;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit.ForeColor = System.Drawing.Color.Black;
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Location = new System.Drawing.Point(553, 8);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(72, 40);
            this.Edit.TabIndex = 105;
            this.Edit.Text = "تعديل";
            this.Edit.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // Save
            // 
            this.Save.BorderRadius = 5;
            this.Save.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Save.FillColor = System.Drawing.Color.White;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Location = new System.Drawing.Point(209, 8);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(72, 40);
            this.Save.TabIndex = 104;
            this.Save.Text = "حفظ";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.BorderRadius = 5;
            this.Delete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.FillColor = System.Drawing.Color.White;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Image = global::almarith_project.Properties.Resources.delete_32;
            this.Delete.Location = new System.Drawing.Point(381, 8);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(72, 40);
            this.Delete.TabIndex = 102;
            this.Delete.Text = "حذف";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Cancel
            // 
            this.Cancel.BorderRadius = 5;
            this.Cancel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancel.FillColor = System.Drawing.Color.White;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.Location = new System.Drawing.Point(37, 8);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(72, 40);
            this.Cancel.TabIndex = 101;
            this.Cancel.Text = "الغاء";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // added
            // 
            this.added.BorderRadius = 5;
            this.added.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.added.Cursor = System.Windows.Forms.Cursors.Hand;
            this.added.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.added.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.added.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.added.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.added.FillColor = System.Drawing.Color.White;
            this.added.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.added.ForeColor = System.Drawing.Color.Black;
            this.added.Image = ((System.Drawing.Image)(resources.GetObject("added.Image")));
            this.added.Location = new System.Drawing.Point(725, 8);
            this.added.Name = "added";
            this.added.Size = new System.Drawing.Size(72, 40);
            this.added.TabIndex = 100;
            this.added.Text = "اضافه";
            this.added.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.take,
            this.The_ratio,
            this.ID,
            this.الاسم,
            this.relation});
            this.dataGridView1.Location = new System.Drawing.Point(27, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(825, 254);
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
            this.The_ratio.Width = 130;
            // 
            // ID
            // 
            this.ID.HeaderText = "رقم البطاقه";
            this.ID.Name = "ID";
            this.ID.Width = 200;
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
            this.relation.Width = 130;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.Location = new System.Drawing.Point(27, 526);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(825, 194);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // update
            // 
            this.update.BorderRadius = 8;
            this.update.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.update.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Image = global::almarith_project.Properties.Resources.bundle_32x32x32b;
            this.update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.update.Location = new System.Drawing.Point(744, 488);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(108, 32);
            this.update.TabIndex = 105;
            this.update.Text = "حساب";
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ID_Elmwtafi
            // 
            this.ID_Elmwtafi.AccessibleName = "tarka";
            this.ID_Elmwtafi.BackColor = System.Drawing.Color.White;
            this.ID_Elmwtafi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_Elmwtafi.Location = new System.Drawing.Point(420, 89);
            this.ID_Elmwtafi.MaxLength = 14;
            this.ID_Elmwtafi.Name = "ID_Elmwtafi";
            this.ID_Elmwtafi.Size = new System.Drawing.Size(291, 29);
            this.ID_Elmwtafi.TabIndex = 124;
            this.ID_Elmwtafi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_Elmwtafi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarka_KeyPress);
            // 
            // Name_elmotawfi
            // 
            this.Name_elmotawfi.BackColor = System.Drawing.Color.White;
            this.Name_elmotawfi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_elmotawfi.Location = new System.Drawing.Point(420, 33);
            this.Name_elmotawfi.MaxLength = 40;
            this.Name_elmotawfi.Name = "Name_elmotawfi";
            this.Name_elmotawfi.Size = new System.Drawing.Size(291, 29);
            this.Name_elmotawfi.TabIndex = 122;
            this.Name_elmotawfi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(774, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 121;
            this.label4.Text = "الاسم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(255, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "قيمة التركه";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.White;
            this.Female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Female.Location = new System.Drawing.Point(76, 91);
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
            this.Male.BackColor = System.Drawing.Color.White;
            this.Male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Male.Location = new System.Drawing.Point(155, 91);
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
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(234, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 116;
            this.label6.Text = "جنس المتوفي";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(27, 228);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(825, 254);
            this.dataGridView3.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(735, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 127;
            this.label2.Text = "رقم البطاقه";
            // 
            // Tarka
            // 
            this.Tarka.AccessibleName = "tarka";
            this.Tarka.BackColor = System.Drawing.Color.White;
            this.Tarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tarka.Location = new System.Drawing.Point(6, 33);
            this.Tarka.MaxLength = 10;
            this.Tarka.Name = "Tarka";
            this.Tarka.Size = new System.Drawing.Size(243, 29);
            this.Tarka.TabIndex = 128;
            this.Tarka.Text = " ";
            this.Tarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarka_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Name_elmotawfi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Tarka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.ID_Elmwtafi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(27, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(825, 135);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المتوفى";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "tarka";
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(161, 488);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "  ابحث باستخدام رقم البطاقه ";
            this.textBox1.Size = new System.Drawing.Size(367, 33);
            this.textBox1.TabIndex = 132;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarka_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(877, 749);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Save;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button Cancel;
        private Guna.UI2.WinForms.Guna2Button added;
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
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn take;
        private DataGridViewTextBoxColumn The_ratio;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn الاسم;
        private DataGridViewComboBoxColumn relation;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button Edit;
    }
}