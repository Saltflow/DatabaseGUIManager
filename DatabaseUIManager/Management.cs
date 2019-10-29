using Npgsql;
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
    public partial class Management : Form
    {
        private NpgsqlDataReader reader;
        private string nowTable;

        public Management()
        {
            InitializeComponent();
            load_database();
        }

        //input : table that should be loaded to dataGridView, data constrain
        //this function should load the given table, in a given condition
        public void ldTable(string tblName,string constraint)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }
            catch (InvalidOperationException) { }
            this.reader = AskPgSQL.Fullinq(tblName,constraint);
            if (this.reader == null) return;
            nowTable = tblName;
            for (int i = 0; i < reader.VisibleFieldCount; i++)
            {
                Create_NewCol(reader.GetName(i), reader.GetDataTypeName(i).ToString());
            }

            while (reader.Read())
            {
                int newrows = dataGridView1.Rows.Add();
                for (int i = 0; i < reader.VisibleFieldCount; i++)
                {

                    readerJudge(this.reader, newrows, i);
                }
                if (dataGridView1.Rows.Count > 100) break;
            }
        }

        //input: the name of a column 
        //this function should create a new column with given name
        public void Create_NewCol(String colName,String colType)
        {
            
            DataGridViewTextBoxColumn dataGrid = new DataGridViewTextBoxColumn();
            dataGrid.Name = colName;
            dataGrid.HeaderText = colName;
            dataGrid.DataPropertyName = colType;
            this.dataGridView1.Columns.Add(dataGrid);
        }

        //load the name of the database into the selection list
        private void load_database()
        {
            this.reader = AskPgSQL.dbNameinq();
            while (reader.Read())
            {
                string dbName = reader.GetString(0);
                if (listBox1.Items.Contains(dbName) == false)
                    listBox1.Items.Add(dbName);
            }
        }
        //load the table name of the database into the selection list
        private void load_tableName()
        {
            int initialNum = listBox1.Items.Count;
            this.reader = AskPgSQL.tableNameinq();
            while (reader.Read())
            {
                int i = 1;
                string tableName = "-" + reader.GetString(0);
                if (listBox1.Items.Contains(tableName) == false)
                {
                    listBox1.Items.Insert(listBox1.SelectedIndex + i, tableName);
                    i++;
                }
            }
        }

        //answer to the button 'Query' ,load the table for dataGridView
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedTable = listBox1.SelectedItem.ToString();
                if (selectedTable[0] != '-')
                {
                    AskPgSQL.connection(selectedTable);
                    load_tableName();
                    return;
                }
                selectedTable = selectedTable.Substring(1);
                ldTable(selectedTable, "");
            }
            catch(NullReferenceException)
            {
                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("clicked columns");
            Console.WriteLine(dataGridView1.Columns[e.ColumnIndex].Name);
        }

        //try multiple format to read into the cell
        private void readerJudge(NpgsqlDataReader rd, int row, int column)
        {
            try
            {
                this.dataGridView1.Rows[row].Cells[column].Value = rd.GetString(column);
            }
            catch (InvalidCastException)
            {
                try
                {
                    this.dataGridView1.Rows[row].Cells[column].Value = rd.GetFloat(column);
                }
                catch (InvalidCastException)
                {

                }
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //answer the button 'Create Table', open a Form to set the new Table
        private void button2_Click(object sender, EventArgs e)
        {
        
            Form form = new CrtTable();
            form.Show();
        }
        public ColumnManip columnManip = null;
        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.columnManip == null)
            {
                columnManip = new ColumnManip(this, dataGridView1, e.ColumnIndex, nowTable);
                columnManip.Show();
            }

        }
        //store the value of the cell,which will later be updated to the database
        private string txtBeforeEdit;

        //Update the database by editing the grid cell
        private void UpdateCellData(DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Sure to edit" + txtBeforeEdit + "to" + dataGridView1[e.ColumnIndex, e.RowIndex].Value + " ?",
               "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string constraint = constraintSelection(e.RowIndex, e.ColumnIndex);
            // Console.WriteLine(constraint.Substring(0,constraint.Length-1));
            string[] numbers = { "integer", "real", "numeric" };
            string txtBeforeEditn = txtBeforeEdit;
            if (!numbers.Contains(dataGridView1.Columns[e.ColumnIndex].DataPropertyName))
                txtBeforeEditn = '\'' + txtBeforeEdit + '\'';
            else
            {
                try
                {
                    int.Parse(txtBeforeEdit);
                    constraint = constraint + dataGridView1.Columns[e.ColumnIndex].Name + " = " + txtBeforeEditn;
                }
                catch (FormatException)
                {
                }
            }
            while (constraint.Substring(constraint.Length - 4) == "AND ")
                constraint = constraint.Substring(0, constraint.Length - 4); 
            if (AskPgSQL.updateCell(nowTable, constraint, dataGridView1.Columns[e.ColumnIndex].Name,
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),
                numbers.Contains(dataGridView1.Columns[e.ColumnIndex].DataPropertyName))
                == -1)
            {
                MessageBox.Show("Update Error");
                ldTable(nowTable,"");
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                return;
            string[] numbers = { "integer", "real", "numeric" };
            bool is_empty = true;
            Console.WriteLine(e.RowIndex + " " + dataGridView1.RowCount);
            for(int i=0;i<dataGridView1.Rows[e.RowIndex].Cells.Count;i++)
            {
                if (i == e.ColumnIndex) continue;
                if (dataGridView1.Rows[e.RowIndex].Cells[i].Value != null)
                {
                    is_empty = false;
                    break;
                }
            }
            if (e.RowIndex == dataGridView1.RowCount - 2&& is_empty)
            {
                MessageBox.Show("New Line!");
                AskPgSQL.insertRow(nowTable, dataGridView1.Columns[e.ColumnIndex].Name, dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString(),
                    numbers.Contains(dataGridView1.Columns[e.ColumnIndex].DataPropertyName));
                ldTable(nowTable,"");
            }
            else
            {
                UpdateCellData(e);
            }
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            TypeNoticeLabel.Text = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            try
            {
                txtBeforeEdit = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            catch(NullReferenceException)
            {
                txtBeforeEdit = "";
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string constraint = "";
            string[] numbers = { "integer", "real", "numeric" };
            if (MessageBox.Show("Delete row " +  "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                constraint = constraintSelection(e.RowIndex, e.ColumnIndex); 
                
            
                AskPgSQL.deleteRow(nowTable,constraint.Substring(0,constraint.Length-4));
                ldTable(nowTable,"");
            }
        }

        private string constraintSelection(int eRowIndex,int eColumnIndex)
        {
            string[] numbers = { "integer", "real", "numeric" };
            var cells = dataGridView1.Rows[eRowIndex].Cells;
            string constraint = "";
            for (int i = 0; i < cells.Count; i++)
            {
                bool isFloat = false;
                string singleconstraint = "";
                if (i == eColumnIndex) continue;
                if (cells[i].Value == null)
                {
                    constraint += dataGridView1.Columns[i].Name + " IS NULL " + " AND ";
                    continue;
                }
                singleconstraint += dataGridView1.Columns[i].Name + "=";
                if (numbers.Contains(dataGridView1.Columns[i].DataPropertyName))
                {
                    try
                    {

                        singleconstraint += int.Parse(cells[i].Value.ToString());
                        constraint += singleconstraint;
                    }
                    catch (FormatException)
                    {
                        isFloat = true;
                    }
                }
                else constraint += singleconstraint + '\'' + cells[i].Value.ToString() + '\'';
                if (!isFloat) constraint = constraint + " AND ";
            }
            return constraint;
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            if (listBox1.SelectedItem.ToString()[0] == '-')
            {
                drpTabel.Visible = true;
            }
            else drpTabel.Visible = false;
        }

        private void drpTabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure to DROP" + listBox1.SelectedItem.ToString().Substring(1) + " ?",
            "", MessageBoxButtons.YesNo) == DialogResult.No) return;
            else AskPgSQL.dropTable(listBox1.SelectedItem.ToString().Substring(1));
            listBox1.Items.Clear();
            load_database();
            MessageBox.Show("Table dropped");
        }
        // shows the options to create a new column
        private void arButton_Click(object sender, EventArgs e)
        {
            this.acButton.Hide();
            this.confAddButton.Show();
            this.ColNameLabel.Show();
            this.ColTypeLabel.Show();
            this.addColSelect.Show();
            this.ColNameText.Show();
            if(addColSelect.Items.Count==0)
            {
                var items = addColSelect.Items;
                items.Add("integer");
                items.Add("numeric");
                items.Add("varchar");
                items.Add("text");
                items.Add("char");
                addColSelect.Text = "integer";
            }
                
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Console.WriteLine(openFileDialog1.FileName);
            AskPgSQL.copyFrom(nowTable, openFileDialog1.FileName);
        }

        private void confAddButton_Click(object sender, EventArgs e)
        {
            string AddType = addColSelect.Text;
            if(ColNameText.Text == "")
            {
                MessageBox.Show("need Column name as attribute!");
                goto ret;
            }
            if (attribText.Visible) AddType = AddType + "(" + attribText.Text + ")";
            if(AskPgSQL.addColumn(nowTable,ColNameText.Text,AddType)!= -1)
            {
                MessageBox.Show("add succeed");
                ldTable(nowTable,"");
            }
            ret:
            this.acButton.Show();
            this.confAddButton.Hide();
            this.ColNameLabel.Hide();
            this.ColTypeLabel.Hide();
            this.addColSelect.Hide();
            this.ColNameText.Hide();
            this.attribText.Hide();
        }

        private void addColSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] need_Scale = { "varchar", "text", "char" };

            if (need_Scale.Contains(addColSelect.Text))
            {
                attribText.Visible = true;
                attribText.Text = "10";
            }
            else attribText.Visible = false;
        }

        private void ExcelMod_Click(object sender, EventArgs e)
        {
            this.acButton.Show();
            this.confAddButton.Hide();
            this.ColNameLabel.Hide();
            this.ColTypeLabel.Hide();
            this.addColSelect.Hide();
            this.ColNameText.Hide();
            this.attribText.Hide();
            this.button1.Hide();
            this.button2.Hide();
            this.drpTabel.Hide();
            this.dataGridView1.DataSource = AskExcel.getData();
        }
    }
};
