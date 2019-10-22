namespace DatabaseUIManager
{
    partial class CrtTable
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
            this.TabLab = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.conSelect = new System.Windows.Forms.ComboBox();
            this.typeSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.typAttribute = new System.Windows.Forms.TextBox();
            this.consAttribute = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabLab
            // 
            this.TabLab.AutoSize = true;
            this.TabLab.Location = new System.Drawing.Point(6, 21);
            this.TabLab.Name = "TabLab";
            this.TabLab.Size = new System.Drawing.Size(87, 15);
            this.TabLab.TabIndex = 0;
            this.TabLab.Text = "Table Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createBtn);
            this.groupBox1.Controls.Add(this.tblName);
            this.groupBox1.Controls.Add(this.TabLab);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tblName
            // 
            this.tblName.Location = new System.Drawing.Point(7, 48);
            this.tblName.Name = "tblName";
            this.tblName.Size = new System.Drawing.Size(151, 25);
            this.tblName.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 340);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // conSelect
            // 
            this.conSelect.FormattingEnabled = true;
            this.conSelect.Location = new System.Drawing.Point(235, 489);
            this.conSelect.Name = "conSelect";
            this.conSelect.Size = new System.Drawing.Size(121, 23);
            this.conSelect.TabIndex = 3;
            this.conSelect.SelectedIndexChanged += new System.EventHandler(this.conSelect_SelectedIndexChanged);
            // 
            // typeSelect
            // 
            this.typeSelect.FormattingEnabled = true;
            this.typeSelect.Location = new System.Drawing.Point(235, 518);
            this.typeSelect.Name = "typeSelect";
            this.typeSelect.Size = new System.Drawing.Size(121, 23);
            this.typeSelect.TabIndex = 4;
            this.typeSelect.SelectedIndexChanged += new System.EventHandler(this.typeSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Constraints";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // colName
            // 
            this.colName.Location = new System.Drawing.Point(107, 443);
            this.colName.Name = "colName";
            this.colName.Size = new System.Drawing.Size(249, 25);
            this.colName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Column Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Column";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typAttribute
            // 
            this.typAttribute.Location = new System.Drawing.Point(137, 516);
            this.typAttribute.Name = "typAttribute";
            this.typAttribute.Size = new System.Drawing.Size(59, 25);
            this.typAttribute.TabIndex = 10;
            this.typAttribute.Visible = false;
            // 
            // consAttribute
            // 
            this.consAttribute.Location = new System.Drawing.Point(179, 488);
            this.consAttribute.Name = "consAttribute";
            this.consAttribute.Size = new System.Drawing.Size(39, 25);
            this.consAttribute.TabIndex = 11;
            this.consAttribute.Visible = false;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(219, 25);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(106, 48);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // CrtTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.consAttribute);
            this.Controls.Add(this.typAttribute);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeSelect);
            this.Controls.Add(this.conSelect);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrtTable";
            this.Text = "Create Table";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TabLab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tblName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox conSelect;
        private System.Windows.Forms.ComboBox typeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox typAttribute;
        private System.Windows.Forms.TextBox consAttribute;
        private System.Windows.Forms.Button createBtn;
    }
}