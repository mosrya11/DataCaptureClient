namespace BayerDataClient_v4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.grpTreater = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpChem = new System.Windows.Forms.GroupBox();
            this.txtChem1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkChem = new System.Windows.Forms.CheckBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnCustomQuery = new System.Windows.Forms.Button();
            this.grpJob = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCert = new System.Windows.Forms.TextBox();
            this.chkCert = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.chkJob = new System.Windows.Forms.CheckBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabExport = new BayerDataClient_v4.TablessControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTreater.SuspendLayout();
            this.grpChem.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpJob.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 500);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.tabPage1);
            this.tabData.Location = new System.Drawing.Point(24, 548);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1201, 165);
            this.tabData.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpTreater);
            this.tabPage1.Controls.Add(this.grpChem);
            this.tabPage1.Controls.Add(this.grpSearch);
            this.tabPage1.Controls.Add(this.grpJob);
            this.tabPage1.Controls.Add(this.grpDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1193, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Treater Reports";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSummary);
            this.groupBox1.Location = new System.Drawing.Point(1084, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 103);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // btnSummary
            // 
            this.btnSummary.BackgroundImage = global::BayerDataClient_v4.Properties.Resources.summary2;
            this.btnSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(6, 19);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(91, 76);
            this.btnSummary.TabIndex = 16;
            this.btnSummary.Text = "Summary";
            this.btnSummary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // grpTreater
            // 
            this.grpTreater.Controls.Add(this.label1);
            this.grpTreater.Controls.Add(this.comboBox1);
            this.grpTreater.Location = new System.Drawing.Point(17, 17);
            this.grpTreater.Name = "grpTreater";
            this.grpTreater.Size = new System.Drawing.Size(132, 103);
            this.grpTreater.TabIndex = 27;
            this.grpTreater.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Treater";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // grpChem
            // 
            this.grpChem.Controls.Add(this.txtChem1);
            this.grpChem.Controls.Add(this.label4);
            this.grpChem.Controls.Add(this.chkChem);
            this.grpChem.Location = new System.Drawing.Point(849, 17);
            this.grpChem.Name = "grpChem";
            this.grpChem.Size = new System.Drawing.Size(121, 103);
            this.grpChem.TabIndex = 16;
            this.grpChem.TabStop = false;
            // 
            // txtChem1
            // 
            this.txtChem1.Location = new System.Drawing.Point(6, 56);
            this.txtChem1.Name = "txtChem1";
            this.txtChem1.Size = new System.Drawing.Size(103, 20);
            this.txtChem1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Chemical";
            // 
            // chkChem
            // 
            this.chkChem.AutoSize = true;
            this.chkChem.Location = new System.Drawing.Point(6, 27);
            this.chkChem.Name = "chkChem";
            this.chkChem.Size = new System.Drawing.Size(15, 14);
            this.chkChem.TabIndex = 0;
            this.chkChem.UseVisualStyleBackColor = true;
            this.chkChem.CheckedChanged += new System.EventHandler(this.chkChem_CheckedChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnCustomQuery);
            this.grpSearch.Location = new System.Drawing.Point(976, 17);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(102, 103);
            this.grpSearch.TabIndex = 14;
            this.grpSearch.TabStop = false;
            // 
            // btnCustomQuery
            // 
            this.btnCustomQuery.BackgroundImage = global::BayerDataClient_v4.Properties.Resources.search_icon_md;
            this.btnCustomQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomQuery.Location = new System.Drawing.Point(6, 19);
            this.btnCustomQuery.Name = "btnCustomQuery";
            this.btnCustomQuery.Size = new System.Drawing.Size(92, 76);
            this.btnCustomQuery.TabIndex = 13;
            this.btnCustomQuery.UseVisualStyleBackColor = true;
            this.btnCustomQuery.Click += new System.EventHandler(this.btnCustomQuery_Click);
            // 
            // grpJob
            // 
            this.grpJob.Controls.Add(this.label8);
            this.grpJob.Controls.Add(this.txtCert);
            this.grpJob.Controls.Add(this.chkCert);
            this.grpJob.Controls.Add(this.label2);
            this.grpJob.Controls.Add(this.txtJob);
            this.grpJob.Controls.Add(this.chkJob);
            this.grpJob.Location = new System.Drawing.Point(155, 17);
            this.grpJob.Name = "grpJob";
            this.grpJob.Size = new System.Drawing.Size(231, 103);
            this.grpJob.TabIndex = 13;
            this.grpJob.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cert No.";
            // 
            // txtCert
            // 
            this.txtCert.Location = new System.Drawing.Point(130, 57);
            this.txtCert.Name = "txtCert";
            this.txtCert.Size = new System.Drawing.Size(91, 20);
            this.txtCert.TabIndex = 17;
            // 
            // chkCert
            // 
            this.chkCert.AutoSize = true;
            this.chkCert.Location = new System.Drawing.Point(130, 25);
            this.chkCert.Name = "chkCert";
            this.chkCert.Size = new System.Drawing.Size(15, 14);
            this.chkCert.TabIndex = 16;
            this.chkCert.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Job No.";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(11, 57);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(91, 20);
            this.txtJob.TabIndex = 14;
            // 
            // chkJob
            // 
            this.chkJob.AutoSize = true;
            this.chkJob.Location = new System.Drawing.Point(11, 25);
            this.chkJob.Name = "chkJob";
            this.chkJob.Size = new System.Drawing.Size(15, 14);
            this.chkJob.TabIndex = 13;
            this.chkJob.UseVisualStyleBackColor = true;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.dateTimePicker4);
            this.grpDate.Controls.Add(this.dateTimePicker3);
            this.grpDate.Controls.Add(this.label5);
            this.grpDate.Controls.Add(this.label3);
            this.grpDate.Controls.Add(this.chkDate);
            this.grpDate.Controls.Add(this.dateTimePicker2);
            this.grpDate.Controls.Add(this.dateTimePicker1);
            this.grpDate.Location = new System.Drawing.Point(392, 17);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(451, 103);
            this.grpDate.TabIndex = 11;
            this.grpDate.TabStop = false;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(347, 57);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker4.TabIndex = 20;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(109, 57);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date";
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(12, 25);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(15, 14);
            this.chkDate.TabIndex = 12;
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(245, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // txtQuery
            // 
            this.txtQuery.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtQuery.ForeColor = System.Drawing.Color.White;
            this.txtQuery.Location = new System.Drawing.Point(24, 519);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1310, 20);
            this.txtQuery.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV (*.csv)|*.csv";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 74);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 74);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.tabPage6);
            this.tabExport.Location = new System.Drawing.Point(1231, 548);
            this.tabExport.Name = "tabExport";
            this.tabExport.SelectedIndex = 0;
            this.tabExport.Size = new System.Drawing.Size(103, 165);
            this.tabExport.TabIndex = 27;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnBrowse);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(95, 139);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = global::BayerDataClient_v4.Properties.Resources.csv_icon_128x128;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.Location = new System.Drawing.Point(6, 37);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 76);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 24);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 766);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabExport);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.tabData);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bayer Data Capture";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpTreater.ResumeLayout(false);
            this.grpTreater.PerformLayout();
            this.grpChem.ResumeLayout(false);
            this.grpChem.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpJob.ResumeLayout(false);
            this.grpJob.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.tabExport.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnCustomQuery;
        private System.Windows.Forms.GroupBox grpJob;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.CheckBox chkJob;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpChem;
        private System.Windows.Forms.TextBox txtChem1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkChem;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private TablessControl tabExport;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.GroupBox grpTreater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.TextBox txtCert;
        private System.Windows.Forms.CheckBox chkCert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;

    }
}

