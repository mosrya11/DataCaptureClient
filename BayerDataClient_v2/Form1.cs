using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace BayerDataClient_v4
{
    public partial class Form1 : Form
    {

        Configuration config;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridDataError);

            config = new Configuration("Z:\\Software Records_Current\\cd_build\\Bayer\\R And D\\Agrii_Data_Capture\\test_config_file.xml");
            
        }

        private void DataGridDataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            //MessageBox.Show("error caught =    " + e.Exception );

        }


        private void Form1_Load(object sender, EventArgs e)
        {            
            CreateTreaters();

            tabData.Top = this.Height - (tabData.Height + 40);
            //tabTreater.Top = tabData.Top + 20;
            tabExport.Top = tabData.Top + 20;

            //tabTreater.Height = tabData.Height - 20;
            tabExport.Height = tabData.Height - 20;

            dataGridView1.Height = this.Height - 250;
            dataGridView1.Width = this.Width - 50;
            txtQuery.Width = this.Width - 50;

            txtQuery.Top = dataGridView1.Top + (dataGridView1.Height + 5);
            
        }

        private void CreateTreaters()
        {
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";

            this.comboBox1.DataSource = config.Treaters;


        }
        

        private string clause(int number)
        {
            if (number == 0)
                return " WHERE ";
            else
                return " AND ";
        }


        // ---------------------------- SAVE FILE FUNCTIONS ETC -----------------------------


        private void CSVExport(string FilePath)
        {
            StreamWriter str = new StreamWriter(FilePath);  //"C:\\testoutput.csv");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == 0)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        str.Write(dataGridView1.Columns[cell.ColumnIndex].Name + ",");
                    }
                    str.WriteLine();
                }

                foreach (DataGridViewCell cell in row.Cells)
                {
                    
                    try
                    {
                        str.Write(cell.Value.ToString() + ",");
                    }
                    catch
                    {
 
                    }
                }
                str.WriteLine();
            }
            str.Flush();
            str.Close();
            MessageBox.Show("File complete!!  Saved to -  " + FilePath);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            CSVExport(saveFileDialog1.FileName); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = (comboBox1.SelectedValue as EVO_DataLog).Summary();
        }


        private void btnCustomQuery_Click(object sender, EventArgs e)
        {
            //try
            //{
            //string SQLQuery = "SELECT * FROM EVO_SAMPLE_DATA ";

            EVO_DataLog Treater = comboBox1.SelectedValue as EVO_DataLog;
            string SQLQuery; 

            if (config.British == "TRUE")
                SQLQuery = "SET LANGUAGE BRITISH; SELECT " + Treater.ColumnNames(true) + " FROM " + Treater.sTable; //comboBox1.Text; //" FROM EVO_12 ";
            else
                SQLQuery = "SELECT " + Treater.ColumnNames(true) + " FROM " + Treater.sTable; //comboBox1.Text; //" FROM EVO_12 ";
            
            string StartDate = "";
            string EndDate = "";

            int clauses = 0;

            if (chkDate.Checked)
            {
                SQLQuery = SQLQuery + clause(clauses);
                clauses++;
                StartDate = dateTimePicker1.Value.ToShortDateString() + " " + dateTimePicker3.Value.ToShortTimeString();
                EndDate = dateTimePicker2.Value.ToShortDateString() + " " + dateTimePicker4.Value.ToShortTimeString();

                //MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
                SQLQuery = SQLQuery + " (" + "_System__DateTimeLocal_TIMESTAMP" + " BETWEEN '" + StartDate + "' and '" + EndDate + "')";

            }

            if (chkJob.Checked)
            {
                SQLQuery = SQLQuery + clause(clauses);
                clauses++;
                SQLQuery = SQLQuery + Treater.Prefix + "JOBNUMBER" + Treater.Suffix + "=" + txtJob.Text;
            }

            if (chkCert.Checked)
            {
                SQLQuery = SQLQuery + clause(clauses);
                clauses++;
                SQLQuery = SQLQuery + Treater.Prefix + "SeedRef" + Treater.Suffix + "='" + txtCert.Text+"'";
            }

            if (chkChem.Checked)
            {
                SQLQuery = SQLQuery + clause(clauses);
                clauses++;

                SQLQuery = SQLQuery + "(";
                

                //-----------------------------------------------------------------------
                if ((comboBox1.SelectedValue as EVO_DataLog).iFlowMeters >= 1)
                {
                    SQLQuery = SQLQuery + " " + Treater.Prefix + "ChemNameA1"    + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameA2" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameA3" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameA4" + Treater.Suffix + " ='" + txtChem1.Text + "'";

                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDA1" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDA2" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDA3" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDA4" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                }
                if ((comboBox1.SelectedValue as EVO_DataLog).iFlowMeters >= 2)
                {
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameB1" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameB2" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameB3" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameB4" + Treater.Suffix + " ='" + txtChem1.Text + "'";

                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDB1" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDB2" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDB3" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDB4" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                }
                if ((comboBox1.SelectedValue as EVO_DataLog).iFlowMeters >= 3)
                {
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameC1" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameC2" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameC3" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameC4" + Treater.Suffix + " ='" + txtChem1.Text + "'";

                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDC1" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDC2" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDC3" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDC4" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                }
                if ((comboBox1.SelectedValue as EVO_DataLog).iFlowMeters >= 4)
                {
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameD1" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameD2" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameD3" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemNameD4" + Treater.Suffix + " ='" + txtChem1.Text + "'";

                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDD1" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDD2" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDD3" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                    SQLQuery = SQLQuery + " OR " + Treater.Prefix + "ChemIDD4" + Treater.Suffix + " ='" + txtChem1.Text + "'";
                }

                SQLQuery = SQLQuery + ")";

            }

            txtQuery.Text = SQLQuery;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = (comboBox1.SelectedValue as EVO_DataLog).CustomQuery(SQLQuery);
            //}
            //catch 
            //{
            //MessageBox.Show("Error Filling the DataGrid");
            //}
        }

        private void chkChem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender,
                       DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType != ListChangedType.ItemDeleted)
            {
                DataGridViewCellStyle red = dataGridView1.DefaultCellStyle.Clone();
                red.BackColor = Color.Red;

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells["FollowedUp"].Value.ToString()
                           .ToUpper().Contains("NO"))
                    {
                        r.DefaultCellStyle = red;
                    }
                }
            }
        }






    }
}
