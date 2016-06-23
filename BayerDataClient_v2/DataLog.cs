using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace BayerDataClient_v4
{
    class EVO_DataLog : DataLog
    {
        public int iFlowMeters = 1;

        public string sTable;

        public string Prefix = "";
        public string Suffix = "";
        
        public List<string> StandardColumns = new List<string> {
                                                    "Date",
                                                    "JobNumber",
                                                    "BatchNumber",
                                                    "SeedRef",
                                                    "SeedVariey",
                                                    "BatchWeight",
                                                    "MixTime",
                                                    };

        public List<string> FlowMetersA = new List<string> {
                                                    "ChemNameA1", "ChemIDA1", "ChemReqA1", "ChemActA1",
                                                    "ChemNameA2", "ChemIDA2", "ChemReqA2", "ChemActA2",
                                                    "ChemNameA3", "ChemIDA3", "ChemReqA3", "ChemActA3",
                                                    "ChemNameA4", "ChemIDA4", "ChemReqA4", "ChemActA4",
                                                    };

        public List<string> FlowMetersB = new List<string> {
                                                    "ChemNameB1", "ChemIDB1", "ChemReqB1", "ChemActB1",
                                                    "ChemNameB2", "ChemIDB2", "ChemReqB2", "ChemActB2",
                                                    "ChemNameB3", "ChemIDB3", "ChemReqB3", "ChemActB3",
                                                    "ChemNameB4", "ChemIDB4", "ChemReqB4", "ChemActB4",
                                                    };

        public List<string> FlowMetersC = new List<string> {
                                                    "ChemNameC1", "ChemIDC1", "ChemReqC1", "ChemActC1",
                                                    "ChemNameC2", "ChemIDC2", "ChemReqC2", "ChemActC2",
                                                    "ChemNameC3", "ChemIDC3", "ChemReqC3", "ChemActC3",
                                                    "ChemNameC4", "ChemIDC4", "ChemReqC4", "ChemActC4",
                                                    };

        public List<string> FlowMetersD = new List<string> {
                                                    "ChemNameD1", "ChemIDD1", "ChemReqD1", "ChemActD1",
                                                    "ChemNameD2", "ChemIDD2", "ChemReqD2", "ChemActD2",
                                                    "ChemNameD3", "ChemIDD3", "ChemReqD3", "ChemActD3",
                                                    "ChemNameD4", "ChemIDD4", "ChemReqD4", "ChemActD4",
                                                    };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ConnectionString">Connection string to database</param>
        /// <param name="Flowmeters">How many flowmeters in sets (eg. 1 = 1 set of 4 fms)</param>
        /// <param name="Table">Table name of the data</param>
        public EVO_DataLog(string ConnectionString, int Flowmeters, string Table)
            : base(ConnectionString, "SQL")
        {
            iFlowMeters = Flowmeters;
            sTable = Table;
        }

        public EVO_DataLog(string ConnectionString, int Flowmeters, string Table, string sPrefix, string sSuffix)
            : base(ConnectionString, "SQL")
        {
            iFlowMeters = Flowmeters;
            sTable = Table;
            Prefix = sPrefix;
            Suffix = sSuffix;
        }



        /// <summary>
        /// Outputs Evo Column Names, but prefixed with a machine number. (For Kepware)
        /// </summary>
        /// <param name="Prefix">Characters before standard Column</param>
        /// <param name="Suffix">Characters after (Leave blank if not required)</param>
        /// <returns>List of columns in data table</returns>
        public string ColumnNames()
        {
            string output = "";

            foreach (string str in StandardColumns)
            {
                if (str == "Date")
                {
                    output = output + "_System__DateTimeLocal_TIMESTAMP" + " as Date,";
                }
                else if (str == "SeedRef")
                {
                    output = output + Prefix + str + Suffix + " as Cert_Number,";
                }
                else if (str == "BatchWeight")
                {
                    output = output + "Cast(" + Prefix + str + Suffix + " as decimal(20,1))as BatchWeight,";
                }
                else
                {
                    output = output + Prefix + str + Suffix + " as " + str + ",";
                }
            }

            if (iFlowMeters >= 1)
            {
                foreach (string str in FlowMetersA)
                {
                    output = output + Prefix + str + Suffix + ",";
                }
            }

            if (iFlowMeters >= 2)
            {
                foreach (string str in FlowMetersB)
                {
                    output = output + Prefix + str + Suffix + ",";
                }
            }

            if (iFlowMeters >= 3)
            {
                foreach (string str in FlowMetersC)
                {
                    output = output + Prefix + str + Suffix + ",";
                }
            }

            if (iFlowMeters >= 4)
            {
                foreach (string str in FlowMetersD)
                {
                    output = output + Prefix + str + Suffix + ",";
                }
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }


        /// <summary>
        /// Outputs Evo Column Names, but prefixed with a machine number. (For Kepware)
        /// </summary>
        /// <param name="Prefix">Characters before standard Column</param>
        /// <param name="Suffix">Characters after (Leave blank if not required)</param>
        /// <returns>List of columns in data table</returns>
        public string ColumnNames(bool asdf)
        {
            string output = "";

            foreach (string str in StandardColumns)
            {
                if (str == "Date")
                {
                    output = output + "_System__DateTimeLocal_TIMESTAMP" + " as Date,";
                }
                else if (str == "SeedRef")
                {
                    output = output + Prefix + str + Suffix + " as Cert_Number,";
                }
                else if (str == "BatchWeight")
                {
                    output = output + "Cast(" + Prefix + str + Suffix + " as decimal(20,1))as BatchWeight,";
                }
                else
                {
                    output = output + Prefix + str + Suffix + " as " + str + ",";
                }
            }

            if (iFlowMeters >= 1)
            {
                foreach (string str in FlowMetersA)
                {
                    output = output + Prefix + str + Suffix + " as " + str + ",";
                }
            }

            if (iFlowMeters >= 2)
            {
                foreach (string str in FlowMetersB)
                {
                    output = output + Prefix + str + Suffix + " as " + str + ",";
                }
            }

            if (iFlowMeters >= 3)
            {
                foreach (string str in FlowMetersC)
                {
                    output = output + Prefix + str + Suffix + " as " + str + ",";
                }
            }

            if (iFlowMeters >= 4)
            {
                foreach (string str in FlowMetersD)
                {
                    output = output + Prefix + str + Suffix + " as " + str + ",";
                }
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        /// <summary>
        /// Produces a standard bayer job summary file
        /// </summary>
        /// <returns>DataTable of the job summary file</returns>
        public DataTable Summary()
        {
            //"Select Min(" + Prefix + "Date" + Suffix + ") as Date" +

            SQLStatement = "Select Min(_System__DateTimeLocal_TIMESTAMP) as Date" +
                                "," + Prefix + "JobNumber" + Suffix + " as JobNumber" +
                                ",count(*) as Batches" +
                                ",Max(" + Prefix + "SeedRef" + Suffix +") AS Cert_Number" + 
                                ",Cast(sum(" + Prefix + "BatchWeight" + Suffix +") as decimal(20,1)) as Total_Weight_Kg";

            
                if (iFlowMeters >= 1)
                    for (int i = 1 ; i <= 4; i++)
                        SQLStatement = SQLStatement 
                            + ",max([" + Prefix + "ChemNameA" + i + Suffix + "]) as A" + i + "_Chemical"
                            + ",max([" + Prefix + "ChemIDA" + i + Suffix + "]) as A" + i + "_Chemical_ID" 
                            + ",sum([" + Prefix + "ChemReqA" + i + Suffix + "])as A" + i + "_Req" 
                            + ",sum([" + Prefix + "ChemActA" + i + Suffix + "])as A" + i + "_Act ";

                if (iFlowMeters >= 2)
                    for (int i = 1; i <= 4; i++)
                        SQLStatement = SQLStatement 
                            + ",max([" + Prefix + "ChemNameB" + i + Suffix + "]) as B" + i + "_Chemical"
                            + ",max([" + Prefix + "ChemIDB" + i + Suffix + "]) as B" + i + "_Chemical_ID" 
                            + ",sum([" + Prefix + "ChemReqB" + i + Suffix + "])as B" + i + "_Req" 
                            + ",sum([" + Prefix + "ChemActB" + i + Suffix + "])as B" + i + "_Act ";

                if (iFlowMeters >= 3)
                    for (int i = 1; i <= 4; i++)
                        SQLStatement = SQLStatement 
                            + ",max([" + Prefix + "ChemNameC" + i + Suffix + "]) as C" + i + "_Chemical"
                            + ",max([" + Prefix + "ChemIDC" + i + Suffix + "]) as C" + i + "_Chemical_ID" 
                            + ",sum([" + Prefix + "ChemReqC" + i + Suffix + "])as C" + i + "_Req" 
                            + ",sum([" + Prefix + "ChemActC" + i + Suffix + "])as C" + i + "_Act ";

                if (iFlowMeters >= 4)
                    for (int i = 1; i <= 4; i++)
                        SQLStatement = SQLStatement 
                            + ",max([" + Prefix + "ChemNameD" + i + Suffix + "]) as D" + i + "_Chemical"
                            + ",max([" + Prefix + "ChemIDD" + i + Suffix + "]) as D" + i + "_Chemical_ID" 
                            + ",sum([" + Prefix + "ChemReqD" + i + Suffix + "])as D" + i + "_Req" 
                            + ",sum([" + Prefix + "ChemActD" + i + Suffix + "])as D" + i + "_Act ";


                SQLStatement = SQLStatement + " from " + sTable + " GROUP BY " + Prefix + "JobNumber"+ Suffix;
                SQLStatement = SQLStatement + " ORDER BY  Min(_System__DateTimeLocal_TIMESTAMP)";
            return GetData();
        }

        public DataTable AllData()
        {
            SQLStatement = "Select * from " + sTable;
            return GetData();
        }

        /// <summary>
        /// Allows a completely manual sql statement to be executed
        /// </summary>
        /// <param name="sSQLStatement">SQL statement to execute</param>
        /// <returns></returns>
        public DataTable CustomQuery(string sSQLStatement)
        {
            SQLStatement = sSQLStatement;
            return GetData();
        }


    }

    class DataLog
    {
        public string SQLStatement;

        public string SQLConnectionString;

        DataSet ds;

        public DataLog(string sSQLConnectionString, string sSQLStatement)
        {
            SQLConnectionString = sSQLConnectionString;
            SQLStatement = sSQLStatement;
            ds = new DataSet();
        }

        /// <summary>
        /// Executes the SQL Statement and refreshes the DataTable with the result
        /// </summary>
        public void Refresh()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(SQLConnectionString))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SQLStatement, sqlConnection))
                    {
                        ds.Clear();
                        ds.Reset();
                        dataAdapter.Fill(ds);
                    }
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message); 
            }
            
        }

        public DataTable GetData()
        {
            this.Refresh();
            try
            {
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                DataTable empty = new DataTable();

                return empty;
                //MessageBox.Show("");
            }
        }

        /// <summary>
        /// Used during testing. No longer to be used?
        /// </summary>
        /// <returns></returns>
        public string GetDataTest()
        {
            this.Refresh();
            return ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }
    }
}
