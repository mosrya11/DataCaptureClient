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


        //string sql = "server=GBAGFINM2734L\\BAYERDATACAPTURE;" +
        //                               "Integrated Security=true;" +
        //                               "database=BAYER_FINMERE; " +
        //                               "connection timeout=20";

        //string sql = "server=DBBrooks-PC\\DBB_SQL_SERVER;" +
        //                               "Integrated Security=true;" +
        //                               "database=BAYER_FINMERE; " +
        //                               "connection timeout=20";

        string sql = "server=GBAGEAST2465D-7\\BAYERDATACAPTURE;" +
                               "Integrated Security=true;" +
                               "database=BAYER; " +
                               "connection timeout=20";

        //string sql = "user id=Ryan;" +
        //                               "password=sn0wboard;server=7.48.56.85\\BAYERDATACAPTURE;" +  // 
        //                               "database=BAYER; " +
        //                               "connection timeout=20";

        EVO_DataLog EVO2_001;

        EVO_DataLog VANG_A;
        EVO_DataLog VANG_B;
        EVO_DataLog PLATFORMS;

        Configuration config;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridDataError);

            config = new Configuration("Z:\\Software Records_Current\\cd_build\\Bayer\\R And D\\Agrii_Data_Capture\\test_config_file.xml");
            
            // Set the Format type and the CustomFormat string.
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";


            // Set the Format type and the CustomFormat string.
            //dateTimePicker2.Format = DateTimePickerFormat.Custom;
            //dateTimePicker2.CustomFormat = "MMMM dd, yyyy - dddd";
        }

        private void DataGridDataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            //MessageBox.Show("error caught =    " + e.Exception );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ///MessageBox.Show(EVO_12.SQLConnectionString + "   " + EVO_12.SQLStatement);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = EVO_12.AllData();

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
            txtQuery.Top = dataGridView1.Top + (dataGridView1.Height + 5);
            
        }

        private void CreateTreaters()
        {
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";

            foreach (EVO_DataLog t in config.Treaters)
            { Console.WriteLine(t.sTable); }


            var items = new[] { 
            new { Text = "EVO_2_001", Value = EVO2_001 = new EVO_DataLog(sql, 4, "EVO2_001_2016", "EVO2_001_Evo_", "_Value")}, 
            new { Text = "VANG_SIDE_A", Value = VANG_A = new EVO_DataLog(sql, 3, "VANG_15_A_2016", "VANGUARD_SIDE_A_SA_", "_Value")}, 
            new { Text = "VANG_SIDE_B", Value = VANG_B = new EVO_DataLog(sql, 3, "VANG_15_B_2016", "VANGUARD_SIDE_A_SB_", "_Value")}, 
            //new { Text = "EVO 19", Value = EVO_19 = new EVO_DataLog(sql, 2, "EVO19", "EVO19_Evo19_", "_Value")}, 

            };

            this.comboBox1.DataSource = config.Treaters;


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = VANG_A.Summary();
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

            //string SQLQuery = "SET LANGUAGE BRITISH; SELECT " + Treater.ColumnNames(true) + " FROM " + Treater.sTable; //comboBox1.Text; //" FROM EVO_12 ";
            string SQLQuery = "SELECT " + Treater.ColumnNames(true) + " FROM " + Treater.sTable; //comboBox1.Text; //" FROM EVO_12 ";
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

        //private void btnPlatformScales_Click(object sender, EventArgs e)
        //{

        //    string SQLQuery = "";
        //    string StartDate = "";
        //    string EndDate = "";

        //    SQLQuery = "Select AGRII_LINCOLN_Platform_Scales_NetWeight1_TIMESTAMP AS DATE, " +
        //                      "AGRII_LINCOLN_Platform_Scales_ChemName1_VALUE AS PLATFORM_1_CHEMICAL, " +
        //                      "AGRII_LINCOLN_Platform_Scales_NetWeight1_VALUE AS PLATFORM_1_NET_WEIGHT, " +
        //                      "AGRII_LINCOLN_Platform_Scales_ChemName2_VALUE AS PLATFORM_2_CHEMICAL, " +
        //                      "AGRII_LINCOLN_Platform_Scales_NetWeight2_VALUE AS PLATFORM_2_NET_WEIGHT from PLATFORM_SCALES";
            
        //    if (chkPlatDate.Checked)
        //    {
        //        SQLQuery = SQLQuery + " WHERE ";

        //        StartDate = datePlat1.Value.ToShortDateString() + " " + timePlat1.Value.ToShortTimeString();
        //        EndDate = datePlat2.Value.ToShortDateString() + " " + timePlat2.Value.ToShortTimeString();

        //        SQLQuery = SQLQuery + " (AGRII_LINCOLN_Platform_Scales_NetWeight1_TIMESTAMP BETWEEN '" + StartDate + "' and '" + EndDate + "')";

        //    }

        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = (comboBox1.SelectedValue as EVO_DataLog).CustomQuery(SQLQuery);

        //}

        private void btnManual_Click(object sender, EventArgs e)
        {
            // TODO: THIS IS A COMPLETE MANUAL QUERY. MAYBE WE CAN KEEP THIS IN...
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = EVO_12.CustomQuery(txtManual.Text);
        }

        private void chkChem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Configuration config = new Configuration("Z:\\Software Records_Current\\cd_build\\Bayer\\R And D\\Agrii_Data_Capture\\test_config_file.xml");
        }





    }
}
