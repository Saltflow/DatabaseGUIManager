namespace DatabaseUIManager
{
    partial class Management
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.drpTabel = new System.Windows.Forms.Button();
            this.acButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileButton = new System.Windows.Forms.Button();
            this.confAddButton = new System.Windows.Forms.Button();
            this.ColNameLabel = new System.Windows.Forms.Label();
            this.ColTypeLabel = new System.Windows.Forms.Label();
            this.addColSelect = new System.Windows.Forms.ComboBox();
            this.ColNameText = new System.Windows.Forms.TextBox();
            this.attribText = new System.Windows.Forms.TextBox();
            this.TypeNoticeLabel = new System.Windows.Forms.Label();
            this.ExcelMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(26, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(800, 600);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(26, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 364);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(26, 622);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Table";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drpTabel
            // 
            this.drpTabel.Location = new System.Drawing.Point(26, 697);
            this.drpTabel.Name = "drpTabel";
            this.drpTabel.Size = new System.Drawing.Size(187, 41);
            this.drpTabel.TabIndex = 4;
            this.drpTabel.Text = "Drop Table";
            this.drpTabel.UseVisualStyleBackColor = true;
            this.drpTabel.Visible = false;
            this.drpTabel.Click += new System.EventHandler(this.drpTabel_Click);
            // 
            // acButton
            // 
            this.acButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acButton.Location = new System.Drawing.Point(1117, 138);
            this.acButton.Name = "acButton";
            this.acButton.Size = new System.Drawing.Size(114, 61);
            this.acButton.TabIndex = 5;
            this.acButton.Text = "Add Column";
            this.acButton.UseVisualStyleBackColor = true;
            this.acButton.Click += new System.EventHandler(this.arButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileButton
            // 
            this.fileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileButton.Location = new System.Drawing.Point(1113, 220);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(118, 61);
            this.fileButton.TabIndex = 6;
            this.fileButton.Text = "Import From File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // confAddButton
            // 
            this.confAddButton.Location = new System.Drawing.Point(1113, 220);
            this.confAddButton.Name = "confAddButton";
            this.confAddButton.Size = new System.Drawing.Size(118, 61);
            this.confAddButton.TabIndex = 7;
            this.confAddButton.Text = "Confirm";
            this.confAddButton.UseVisualStyleBackColor = true;
            this.confAddButton.Visible = false;
            this.confAddButton.Click += new System.EventHandler(this.confAddButton_Click);
            // 
            // ColNameLabel
            // 
            this.ColNameLabel.AutoSize = true;
            this.ColNameLabel.Location = new System.Drawing.Point(1117, 323);
            this.ColNameLabel.Name = "ColNameLabel";
            this.ColNameLabel.Size = new System.Drawing.Size(95, 15);
            this.ColNameLabel.TabIndex = 8;
            this.ColNameLabel.Text = "Column Name";
            this.ColNameLabel.Visible = false;
            // 
            // ColTypeLabel
            // 
            this.ColTypeLabel.AutoSize = true;
            this.ColTypeLabel.Location = new System.Drawing.Point(1114, 388);
            this.ColTypeLabel.Name = "ColTypeLabel";
            this.ColTypeLabel.Size = new System.Drawing.Size(95, 15);
            this.ColTypeLabel.TabIndex = 9;
            this.ColTypeLabel.Text = "Column Type";
            this.ColTypeLabel.Visible = false;
            // 
            // addColSelect
            // 
            this.addColSelect.FormattingEnabled = true;
            this.addColSelect.Location = new System.Drawing.Point(1110, 433);
            this.addColSelect.Name = "addColSelect";
            this.addColSelect.Size = new System.Drawing.Size(121, 23);
            this.addColSelect.TabIndex = 10;
            this.addColSelect.Visible = false;
            this.addColSelect.SelectedIndexChanged += new System.EventHandler(this.addColSelect_SelectedIndexChanged);
            // 
            // ColNameText
            // 
            this.ColNameText.Location = new System.Drawing.Point(1117, 341);
            this.ColNameText.Name = "ColNameText";
            this.ColNameText.Size = new System.Drawing.Size(100, 25);
            this.ColNameText.TabIndex = 11;
            this.ColNameText.Visible = false;
            // 
            // attribText
            // 
            this.attribText.Location = new System.Drawing.Point(1110, 477);
            this.attribText.Name = "attribText";
            this.attribText.Size = new System.Drawing.Size(100, 25);
            this.attribText.TabIndex = 12;
            this.attribText.Visible = false;
            // 
            // TypeNoticeLabel
            // 
            this.TypeNoticeLabel.AutoSize = true;
            this.TypeNoticeLabel.Location = new System.Drawing.Point(254, 101);
            this.TypeNoticeLabel.Name = "TypeNoticeLabel";
            this.TypeNoticeLabel.Size = new System.Drawing.Size(0, 15);
            this.TypeNoticeLabel.TabIndex = 13;
            // 
            // ExcelMod
            // 
            this.ExcelMod.Location = new System.Drawing.Point(1117, 569);
            this.ExcelMod.Name = "ExcelMod";
            this.ExcelMod.Size = new System.Drawing.Size(114, 58);
            this.ExcelMod.TabIndex = 14;
            this.ExcelMod.Text = "Excel";
            this.ExcelMod.UseVisualStyleBackColor = true;
            this.ExcelMod.Click += new System.EventHandler(this.ExcelMod_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 913);
            this.Controls.Add(this.ExcelMod);
            this.Controls.Add(this.TypeNoticeLabel);
            this.Controls.Add(this.attribText);
            this.Controls.Add(this.ColNameText);
            this.Controls.Add(this.addColSelect);
            this.Controls.Add(this.ColTypeLabel);
            this.Controls.Add(this.ColNameLabel);
            this.Controls.Add(this.confAddButton);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.acButton);
            this.Controls.Add(this.drpTabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Management";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button drpTabel;
        private System.Windows.Forms.Button acButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Button confAddButton;
        private System.Windows.Forms.Label ColNameLabel;
        private System.Windows.Forms.Label ColTypeLabel;
        private System.Windows.Forms.ComboBox addColSelect;
        private System.Windows.Forms.TextBox ColNameText;
        private System.Windows.Forms.TextBox attribText;
        private System.Windows.Forms.Label TypeNoticeLabel;
        private System.Windows.Forms.Button ExcelMod;
    }
}

