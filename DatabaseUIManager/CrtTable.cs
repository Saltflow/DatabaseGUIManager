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
    public partial class CrtTable : Form
    {
        public CrtTable()
        {
            InitializeComponent();
            col = new List<string>();
            load_constraints();
            load_type();
        }
        private List<string> col = null;
        private string priKey = "";
        
        private string generate_sqlCommand()
        {
            string init = "CREATE TABLE " + tblName.Text + "(";
            for(int i=0; i<col.Count; i++)
            {
                init = init + col[i];
                if (i != col.Count - 1) init = init + ",";
            }
            if (priKey != "") init += ",PRIMARY KEY" + " (" + priKey+")";
            return init+")";
        }

        private void conSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] need_Scale = { "CHECK", "DEFAULT"};
            if (need_Scale.Contains(conSelect.Text))
                consAttribute.Show();
            else consAttribute.Hide();
        }

        private void load_constraints()
        {
            var items = conSelect.Items;
            items.Add("NOT NULL");
            items.Add("PRIMARY KEY");
            items.Add("DEFAULT");
            items.Add("UNIQUE");
            items.Add("CHECK");
        }
        private void load_type()
        {
            var items = typeSelect.Items;
            items.Add("integer");
            items.Add("numeric");
            items.Add("varchar");
            items.Add("text");
            items.Add("char");
            typeSelect.Text = "integer";
        }

        private void clear_col_settings()
        {
            typeSelect.Text = "integer";
            conSelect.Text = "";
            colName.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Width = flowLayoutPanel1.Size.Width;
            
            string typetext = typeSelect.Text;
            string constext = conSelect.Text;
            try
            {
                if (typAttribute.Visible == true)
                {
                    typetext = typetext + "(" + int.Parse(typAttribute.Text) + ")";
                }
                if (consAttribute.Visible == true)
                {               
                    constext = constext + consAttribute.Text; 
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Wrong Attribute");
            }
            if(colName.Text == "")
            {
                MessageBox.Show("Column MUST have name");
                return;
            }
            if (conSelect.Text == "PRIMARY KEY")
            {
                if (priKey != "") priKey = priKey + ',';
                priKey += colName.Text;
            }
                string text = colName.Text + " " + typetext + " " + constext;
            label.Text = text;
            flowLayoutPanel1.Controls.Add(label);
            if (conSelect.Text == "PRIMARY KEY") text = colName.Text + " " + typetext;
            clear_col_settings();
            col.Add(text);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            AskPgSQL.creatTable(generate_sqlCommand());
            this.Close();
        }

        private void typeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] need_Scale = { "varchar", "text", "char" };

            if (need_Scale.Contains(typeSelect.Text))
            {
                typAttribute.Visible=true;
            }
            else typAttribute.Visible=false;
        }
    }
}
