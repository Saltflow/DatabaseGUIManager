namespace DatabaseUIManager
{
    partial class ColumnManip
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
            this.delButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.consText = new System.Windows.Forms.TextBox();
            this.qurButton = new System.Windows.Forms.Button();
            this.more = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.equal = new System.Windows.Forms.RadioButton();
            this.less = new System.Windows.Forms.RadioButton();
            this.updText = new System.Windows.Forms.TextBox();
            this.modButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.atpButton = new System.Windows.Forms.Button();
            this.confrimAltButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(243, 19);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(103, 47);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Conditional Modify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Conditional Query";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // consText
            // 
            this.consText.Location = new System.Drawing.Point(266, 94);
            this.consText.Name = "consText";
            this.consText.Size = new System.Drawing.Size(127, 25);
            this.consText.TabIndex = 3;
            // 
            // qurButton
            // 
            this.qurButton.Location = new System.Drawing.Point(399, 94);
            this.qurButton.Name = "qurButton";
            this.qurButton.Size = new System.Drawing.Size(81, 25);
            this.qurButton.TabIndex = 4;
            this.qurButton.Text = "Query";
            this.qurButton.UseVisualStyleBackColor = true;
            this.qurButton.Click += new System.EventHandler(this.qurButton_Click);
            // 
            // more
            // 
            this.more.AutoSize = true;
            this.more.Location = new System.Drawing.Point(6, 24);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(36, 19);
            this.more.TabIndex = 5;
            this.more.TabStop = true;
            this.more.Text = ">";
            this.more.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.equal);
            this.groupBox1.Controls.Add(this.less);
            this.groupBox1.Controls.Add(this.more);
            this.groupBox1.Location = new System.Drawing.Point(112, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(106, 24);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(36, 19);
            this.equal.TabIndex = 7;
            this.equal.TabStop = true;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            // 
            // less
            // 
            this.less.AutoSize = true;
            this.less.Location = new System.Drawing.Point(49, 24);
            this.less.Name = "less";
            this.less.Size = new System.Drawing.Size(36, 19);
            this.less.TabIndex = 6;
            this.less.TabStop = true;
            this.less.Text = "<";
            this.less.UseVisualStyleBackColor = true;
            // 
            // updText
            // 
            this.updText.Location = new System.Drawing.Point(81, 129);
            this.updText.Name = "updText";
            this.updText.Size = new System.Drawing.Size(312, 25);
            this.updText.TabIndex = 7;
            // 
            // modButton
            // 
            this.modButton.Location = new System.Drawing.Point(399, 131);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(81, 23);
            this.modButton.TabIndex = 8;
            this.modButton.Text = "Update";
            this.modButton.UseVisualStyleBackColor = true;
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Constraint";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Value";
            // 
            // atpButton
            // 
            this.atpButton.Location = new System.Drawing.Point(352, 19);
            this.atpButton.Name = "atpButton";
            this.atpButton.Size = new System.Drawing.Size(103, 46);
            this.atpButton.TabIndex = 10;
            this.atpButton.Text = "Alter Type";
            this.atpButton.UseVisualStyleBackColor = true;
            this.atpButton.Click += new System.EventHandler(this.atpButton_Click);
            // 
            // confrimAltButton
            // 
            this.confrimAltButton.Location = new System.Drawing.Point(399, 94);
            this.confrimAltButton.Name = "confrimAltButton";
            this.confrimAltButton.Size = new System.Drawing.Size(81, 25);
            this.confrimAltButton.TabIndex = 8;
            this.confrimAltButton.Text = "Alter";
            this.confrimAltButton.UseVisualStyleBackColor = true;
            this.confrimAltButton.Visible = false;
            this.confrimAltButton.Click += new System.EventHandler(this.confrimAltButton_Click);
            // 
            // ColumnManip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 78);
            this.Controls.Add(this.confrimAltButton);
            this.Controls.Add(this.atpButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.updText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.qurButton);
            this.Controls.Add(this.consText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColumnManip";
            this.Text = "Column Manipulation";
            this.Deactivate += new System.EventHandler(this.ColumnManip_Deactivate);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox consText;
        private System.Windows.Forms.Button qurButton;
        private System.Windows.Forms.RadioButton more;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton equal;
        private System.Windows.Forms.RadioButton less;
        private System.Windows.Forms.TextBox updText;
        private System.Windows.Forms.Button modButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button atpButton;
        private System.Windows.Forms.Button confrimAltButton;
    }
}