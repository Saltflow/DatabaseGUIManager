using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseUIManager
{
    public partial class ColumnManip : Form
    {
        DataGridView dataGridView1 = null;
        Management management;
        int ColumnIndex;
        string nowTable;
        public ColumnManip(Management management,DataGridView dataGridView, int ColumnInd,string nowTb)
        {
            InitializeComponent();
            this.dataGridView1 = dataGridView;
            this.ColumnIndex = ColumnInd;
            this.nowTable = nowTb;
            this.label1.Text = dataGridView1.Columns[ColumnInd].Name;
            this.management = management;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            string columName = dataGridView1.Columns[ColumnIndex].Name;
            if (MessageBox.Show("Sure to DELETE column " + columName + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AskPgSQL.deleteCol(nowTable, columName);
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] numbers = { "integer", "real", "numeric" };
            this.Size = new System.Drawing.Size(500, 200);
            this.delButton.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.atpButton.Hide();
            if (!numbers.Contains(dataGridView1.Columns[ColumnIndex].DataPropertyName))
            {
                this.more.Visible = false;
                this.less.Visible = false;
            }
        }

        private void qurButton_Click(object sender, EventArgs e)
        {
            string constype = "";
            string[] numbers = { "integer", "real", "numeric" };
            if (less.Checked) constype = "<";
            if (more.Checked) constype = ">";
            if (equal.Checked) constype = "=";
            if (numbers.Contains(dataGridView1.Columns[ColumnIndex].DataPropertyName))
            {
                try
                {

                    constype += int.Parse(consText.Text);
                }
                catch (FormatException)
                {
                    constype += float.Parse(consText.Text);
                }
            }
            else constype += '\'' + consText.Text + '\'';
            string constraint = dataGridView1.Columns[ColumnIndex].Name + " " + constype;
            management.ldTable(nowTable, constraint);
            this.Close();
        }

        private void ColumnManip_Deactivate(object sender, EventArgs e)
        {
            management.columnManip = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] numbers = { "integer", "real", "numeric" };
            this.Size = new System.Drawing.Size(500, 230);
            this.delButton.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.qurButton.Hide();
            this.atpButton.Hide();
            if (!numbers.Contains(dataGridView1.Columns[ColumnIndex].DataPropertyName))
            {
                this.more.Visible = false;
                this.less.Visible = false;
            }
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            string constype = "";
            string[] numbers = { "integer", "real", "numeric" };
            if (less.Checked) constype = "<";
            if (more.Checked) constype = ">";
            if (equal.Checked) constype = "=";
            constype += consText.Text;
            string constraint = dataGridView1.Columns[ColumnIndex].Name + " " + constype;
            string condition = dataGridView1.Columns[ColumnIndex].Name +" "+ updText.Text;
            AskPgSQL.updateCell(nowTable, constraint, dataGridView1.Columns[ColumnIndex].Name, condition,
                numbers.Contains(dataGridView1.Columns[ColumnIndex].DataPropertyName));
            management.ldTable(nowTable,"");
            this.Close();
        }

        private void atpButton_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(500, 200);
            this.groupBox1.Hide();
            this.label1.Text = "type";
            this.confrimAltButton.Show();
        }

        private void confrimAltButton_Click(object sender, EventArgs e)
        {
          if( AskPgSQL.altetColType(nowTable, dataGridView1.Columns[ColumnIndex].Name, consText.Text)!= -1)
                MessageBox.Show("Alter into "+consText.Text+" Succeed");
            this.Close();
        }
    }
}
