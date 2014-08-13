namespace RepoAssistant
{
    partial class FrmRepoAssistant
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.BtnSelectDllFile = new System.Windows.Forms.Button();
            this.TxtSql = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClbRepo = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClbProperty = new System.Windows.Forms.CheckedListBox();
            this.GbProperty = new System.Windows.Forms.GroupBox();
            this.TxtVarchar = new System.Windows.Forms.TextBox();
            this.TxtTinyInt = new System.Windows.Forms.TextBox();
            this.TxtBigInt = new System.Windows.Forms.TextBox();
            this.TxtInt = new System.Windows.Forms.TextBox();
            this.RbtnLongText = new System.Windows.Forms.RadioButton();
            this.RbtnText = new System.Windows.Forms.RadioButton();
            this.RbtnDateTime = new System.Windows.Forms.RadioButton();
            this.RbtnVarchar = new System.Windows.Forms.RadioButton();
            this.RbtnTinyInt = new System.Windows.Forms.RadioButton();
            this.RbtnBigInt = new System.Windows.Forms.RadioButton();
            this.RbtnInt = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PnConstraint = new System.Windows.Forms.Panel();
            this.CbAutoIncrement = new System.Windows.Forms.CheckBox();
            this.CbPrimaryKey = new System.Windows.Forms.CheckBox();
            this.BtnApply = new System.Windows.Forms.Button();
            this.RbtnNull = new System.Windows.Forms.RadioButton();
            this.RbtnNotNull = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCreateTables = new System.Windows.Forms.Button();
            this.RbtnModifyColumn = new System.Windows.Forms.RadioButton();
            this.RbtnCreateTable = new System.Windows.Forms.RadioButton();
            this.RbtnAddColumn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GbProperty.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.PnConstraint.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtFilePath);
            this.panel1.Controls.Add(this.BtnSelectDllFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(594, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 40);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据库连接：";
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(84, 8);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.ReadOnly = true;
            this.TxtFilePath.Size = new System.Drawing.Size(432, 21);
            this.TxtFilePath.TabIndex = 1;
            // 
            // BtnSelectDllFile
            // 
            this.BtnSelectDllFile.Location = new System.Drawing.Point(3, 8);
            this.BtnSelectDllFile.Name = "BtnSelectDllFile";
            this.BtnSelectDllFile.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectDllFile.TabIndex = 0;
            this.BtnSelectDllFile.Text = "选择文件";
            this.BtnSelectDllFile.UseVisualStyleBackColor = true;
            this.BtnSelectDllFile.Click += new System.EventHandler(this.BtnSelectDllFile_Click);
            // 
            // TxtSql
            // 
            this.TxtSql.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtSql.Location = new System.Drawing.Point(0, 418);
            this.TxtSql.Multiline = true;
            this.TxtSql.Name = "TxtSql";
            this.TxtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSql.Size = new System.Drawing.Size(1008, 312);
            this.TxtSql.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClbRepo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 378);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repo";
            // 
            // ClbRepo
            // 
            this.ClbRepo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClbRepo.FormattingEnabled = true;
            this.ClbRepo.Location = new System.Drawing.Point(3, 17);
            this.ClbRepo.Name = "ClbRepo";
            this.ClbRepo.Size = new System.Drawing.Size(232, 358);
            this.ClbRepo.TabIndex = 0;
            this.ClbRepo.SelectedIndexChanged += new System.EventHandler(this.ClbRepo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClbProperty);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(238, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 378);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property";
            // 
            // ClbProperty
            // 
            this.ClbProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClbProperty.FormattingEnabled = true;
            this.ClbProperty.Location = new System.Drawing.Point(3, 17);
            this.ClbProperty.Name = "ClbProperty";
            this.ClbProperty.Size = new System.Drawing.Size(233, 358);
            this.ClbProperty.TabIndex = 0;
            this.ClbProperty.SelectedIndexChanged += new System.EventHandler(this.ClbProperty_SelectedIndexChanged);
            // 
            // GbProperty
            // 
            this.GbProperty.Controls.Add(this.TxtVarchar);
            this.GbProperty.Controls.Add(this.TxtTinyInt);
            this.GbProperty.Controls.Add(this.TxtBigInt);
            this.GbProperty.Controls.Add(this.TxtInt);
            this.GbProperty.Controls.Add(this.RbtnLongText);
            this.GbProperty.Controls.Add(this.RbtnText);
            this.GbProperty.Controls.Add(this.RbtnDateTime);
            this.GbProperty.Controls.Add(this.RbtnVarchar);
            this.GbProperty.Controls.Add(this.RbtnTinyInt);
            this.GbProperty.Controls.Add(this.RbtnBigInt);
            this.GbProperty.Controls.Add(this.RbtnInt);
            this.GbProperty.Dock = System.Windows.Forms.DockStyle.Left;
            this.GbProperty.Location = new System.Drawing.Point(477, 40);
            this.GbProperty.Name = "GbProperty";
            this.GbProperty.Size = new System.Drawing.Size(249, 378);
            this.GbProperty.TabIndex = 4;
            this.GbProperty.TabStop = false;
            this.GbProperty.Text = "Type";
            // 
            // TxtVarchar
            // 
            this.TxtVarchar.Location = new System.Drawing.Point(128, 119);
            this.TxtVarchar.Name = "TxtVarchar";
            this.TxtVarchar.Size = new System.Drawing.Size(100, 21);
            this.TxtVarchar.TabIndex = 1;
            // 
            // TxtTinyInt
            // 
            this.TxtTinyInt.Location = new System.Drawing.Point(128, 81);
            this.TxtTinyInt.Name = "TxtTinyInt";
            this.TxtTinyInt.Size = new System.Drawing.Size(100, 21);
            this.TxtTinyInt.TabIndex = 1;
            // 
            // TxtBigInt
            // 
            this.TxtBigInt.Location = new System.Drawing.Point(128, 48);
            this.TxtBigInt.Name = "TxtBigInt";
            this.TxtBigInt.Size = new System.Drawing.Size(100, 21);
            this.TxtBigInt.TabIndex = 1;
            // 
            // TxtInt
            // 
            this.TxtInt.Location = new System.Drawing.Point(128, 17);
            this.TxtInt.Name = "TxtInt";
            this.TxtInt.Size = new System.Drawing.Size(100, 21);
            this.TxtInt.TabIndex = 1;
            // 
            // RbtnLongText
            // 
            this.RbtnLongText.AutoSize = true;
            this.RbtnLongText.Location = new System.Drawing.Point(18, 219);
            this.RbtnLongText.Name = "RbtnLongText";
            this.RbtnLongText.Size = new System.Drawing.Size(71, 16);
            this.RbtnLongText.TabIndex = 0;
            this.RbtnLongText.TabStop = true;
            this.RbtnLongText.Text = "longtext";
            this.RbtnLongText.UseVisualStyleBackColor = true;
            // 
            // RbtnText
            // 
            this.RbtnText.AutoSize = true;
            this.RbtnText.Location = new System.Drawing.Point(18, 188);
            this.RbtnText.Name = "RbtnText";
            this.RbtnText.Size = new System.Drawing.Size(47, 16);
            this.RbtnText.TabIndex = 0;
            this.RbtnText.TabStop = true;
            this.RbtnText.Text = "text";
            this.RbtnText.UseVisualStyleBackColor = true;
            // 
            // RbtnDateTime
            // 
            this.RbtnDateTime.AutoSize = true;
            this.RbtnDateTime.Location = new System.Drawing.Point(18, 155);
            this.RbtnDateTime.Name = "RbtnDateTime";
            this.RbtnDateTime.Size = new System.Drawing.Size(71, 16);
            this.RbtnDateTime.TabIndex = 0;
            this.RbtnDateTime.TabStop = true;
            this.RbtnDateTime.Text = "datetime";
            this.RbtnDateTime.UseVisualStyleBackColor = true;
            // 
            // RbtnVarchar
            // 
            this.RbtnVarchar.AutoSize = true;
            this.RbtnVarchar.Location = new System.Drawing.Point(18, 122);
            this.RbtnVarchar.Name = "RbtnVarchar";
            this.RbtnVarchar.Size = new System.Drawing.Size(65, 16);
            this.RbtnVarchar.TabIndex = 0;
            this.RbtnVarchar.TabStop = true;
            this.RbtnVarchar.Text = "varchar";
            this.RbtnVarchar.UseVisualStyleBackColor = true;
            // 
            // RbtnTinyInt
            // 
            this.RbtnTinyInt.AutoSize = true;
            this.RbtnTinyInt.Location = new System.Drawing.Point(18, 84);
            this.RbtnTinyInt.Name = "RbtnTinyInt";
            this.RbtnTinyInt.Size = new System.Drawing.Size(65, 16);
            this.RbtnTinyInt.TabIndex = 0;
            this.RbtnTinyInt.TabStop = true;
            this.RbtnTinyInt.Text = "tinyint";
            this.RbtnTinyInt.UseVisualStyleBackColor = true;
            // 
            // RbtnBigInt
            // 
            this.RbtnBigInt.AutoSize = true;
            this.RbtnBigInt.Location = new System.Drawing.Point(18, 51);
            this.RbtnBigInt.Name = "RbtnBigInt";
            this.RbtnBigInt.Size = new System.Drawing.Size(59, 16);
            this.RbtnBigInt.TabIndex = 0;
            this.RbtnBigInt.TabStop = true;
            this.RbtnBigInt.Text = "bigint";
            this.RbtnBigInt.UseVisualStyleBackColor = true;
            // 
            // RbtnInt
            // 
            this.RbtnInt.AutoSize = true;
            this.RbtnInt.Location = new System.Drawing.Point(18, 20);
            this.RbtnInt.Name = "RbtnInt";
            this.RbtnInt.Size = new System.Drawing.Size(41, 16);
            this.RbtnInt.TabIndex = 0;
            this.RbtnInt.TabStop = true;
            this.RbtnInt.Text = "int";
            this.RbtnInt.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "C# Dll文件|*.dll";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PnConstraint);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(726, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 378);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Constraint";
            // 
            // PnConstraint
            // 
            this.PnConstraint.Controls.Add(this.CbAutoIncrement);
            this.PnConstraint.Controls.Add(this.CbPrimaryKey);
            this.PnConstraint.Controls.Add(this.BtnApply);
            this.PnConstraint.Controls.Add(this.RbtnNull);
            this.PnConstraint.Controls.Add(this.RbtnNotNull);
            this.PnConstraint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnConstraint.Location = new System.Drawing.Point(3, 17);
            this.PnConstraint.Name = "PnConstraint";
            this.PnConstraint.Size = new System.Drawing.Size(276, 264);
            this.PnConstraint.TabIndex = 4;
            // 
            // CbAutoIncrement
            // 
            this.CbAutoIncrement.AutoSize = true;
            this.CbAutoIncrement.Location = new System.Drawing.Point(3, 26);
            this.CbAutoIncrement.Name = "CbAutoIncrement";
            this.CbAutoIncrement.Size = new System.Drawing.Size(108, 16);
            this.CbAutoIncrement.TabIndex = 0;
            this.CbAutoIncrement.Text = "AUTO_INCREMENT";
            this.CbAutoIncrement.UseVisualStyleBackColor = true;
            // 
            // CbPrimaryKey
            // 
            this.CbPrimaryKey.AutoSize = true;
            this.CbPrimaryKey.Location = new System.Drawing.Point(3, 1);
            this.CbPrimaryKey.Name = "CbPrimaryKey";
            this.CbPrimaryKey.Size = new System.Drawing.Size(90, 16);
            this.CbPrimaryKey.TabIndex = 0;
            this.CbPrimaryKey.Text = "Primary Key";
            this.CbPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(114, 98);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 2;
            this.BtnApply.Text = "应  用";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // RbtnNull
            // 
            this.RbtnNull.AutoSize = true;
            this.RbtnNull.Location = new System.Drawing.Point(3, 54);
            this.RbtnNull.Name = "RbtnNull";
            this.RbtnNull.Size = new System.Drawing.Size(47, 16);
            this.RbtnNull.TabIndex = 1;
            this.RbtnNull.TabStop = true;
            this.RbtnNull.Text = "Null";
            this.RbtnNull.UseVisualStyleBackColor = true;
            // 
            // RbtnNotNull
            // 
            this.RbtnNotNull.AutoSize = true;
            this.RbtnNotNull.Location = new System.Drawing.Point(114, 54);
            this.RbtnNotNull.Name = "RbtnNotNull";
            this.RbtnNotNull.Size = new System.Drawing.Size(71, 16);
            this.RbtnNotNull.TabIndex = 1;
            this.RbtnNotNull.TabStop = true;
            this.RbtnNotNull.Text = "Not Null";
            this.RbtnNotNull.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RbtnAddColumn);
            this.panel3.Controls.Add(this.BtnCreateTables);
            this.panel3.Controls.Add(this.RbtnModifyColumn);
            this.panel3.Controls.Add(this.RbtnCreateTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 94);
            this.panel3.TabIndex = 3;
            // 
            // BtnCreateTables
            // 
            this.BtnCreateTables.Location = new System.Drawing.Point(124, 64);
            this.BtnCreateTables.Name = "BtnCreateTables";
            this.BtnCreateTables.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateTables.TabIndex = 2;
            this.BtnCreateTables.Text = "生成Sql";
            this.BtnCreateTables.UseVisualStyleBackColor = true;
            this.BtnCreateTables.Click += new System.EventHandler(this.BtnCreateTables_Click);
            // 
            // RbtnModifyColumn
            // 
            this.RbtnModifyColumn.AutoSize = true;
            this.RbtnModifyColumn.Location = new System.Drawing.Point(124, 36);
            this.RbtnModifyColumn.Name = "RbtnModifyColumn";
            this.RbtnModifyColumn.Size = new System.Drawing.Size(101, 16);
            this.RbtnModifyColumn.TabIndex = 1;
            this.RbtnModifyColumn.TabStop = true;
            this.RbtnModifyColumn.Text = "Modify Column";
            this.RbtnModifyColumn.UseVisualStyleBackColor = true;
            // 
            // RbtnCreateTable
            // 
            this.RbtnCreateTable.AutoSize = true;
            this.RbtnCreateTable.Location = new System.Drawing.Point(8, 4);
            this.RbtnCreateTable.Name = "RbtnCreateTable";
            this.RbtnCreateTable.Size = new System.Drawing.Size(95, 16);
            this.RbtnCreateTable.TabIndex = 0;
            this.RbtnCreateTable.TabStop = true;
            this.RbtnCreateTable.Text = "Create Table";
            this.RbtnCreateTable.UseVisualStyleBackColor = true;
            // 
            // RbtnAddColumn
            // 
            this.RbtnAddColumn.AutoSize = true;
            this.RbtnAddColumn.Location = new System.Drawing.Point(8, 36);
            this.RbtnAddColumn.Name = "RbtnAddColumn";
            this.RbtnAddColumn.Size = new System.Drawing.Size(83, 16);
            this.RbtnAddColumn.TabIndex = 3;
            this.RbtnAddColumn.TabStop = true;
            this.RbtnAddColumn.Text = "Add Column";
            this.RbtnAddColumn.UseVisualStyleBackColor = true;
            // 
            // FrmRepoAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GbProperty);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtSql);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FrmRepoAssistant";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepoAssistant(MySql)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRepoAssistant_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.GbProperty.ResumeLayout(false);
            this.GbProperty.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.PnConstraint.ResumeLayout(false);
            this.PnConstraint.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.Button BtnSelectDllFile;
        private System.Windows.Forms.TextBox TxtSql;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox ClbRepo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox ClbProperty;
        private System.Windows.Forms.GroupBox GbProperty;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtVarchar;
        private System.Windows.Forms.TextBox TxtBigInt;
        private System.Windows.Forms.TextBox TxtInt;
        private System.Windows.Forms.RadioButton RbtnVarchar;
        private System.Windows.Forms.RadioButton RbtnBigInt;
        private System.Windows.Forms.RadioButton RbtnInt;
        private System.Windows.Forms.RadioButton RbtnDateTime;
        private System.Windows.Forms.TextBox TxtTinyInt;
        private System.Windows.Forms.RadioButton RbtnText;
        private System.Windows.Forms.RadioButton RbtnTinyInt;
        private System.Windows.Forms.RadioButton RbtnLongText;
        private System.Windows.Forms.CheckBox CbPrimaryKey;
        private System.Windows.Forms.CheckBox CbAutoIncrement;
        private System.Windows.Forms.RadioButton RbtnNotNull;
        private System.Windows.Forms.RadioButton RbtnNull;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RbtnModifyColumn;
        private System.Windows.Forms.RadioButton RbtnCreateTable;
        private System.Windows.Forms.Button BtnCreateTables;
        private System.Windows.Forms.Panel PnConstraint;
        private System.Windows.Forms.RadioButton RbtnAddColumn;

    }
}

