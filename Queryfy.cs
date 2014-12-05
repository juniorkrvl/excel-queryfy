using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFromXCL
{
    public partial class Queryfy : Form
    {
        System.Data.OleDb.OleDbConnection myConn;
        System.Data.DataSet ds;
        System.Data.OleDb.OleDbDataAdapter MyCommand;

        public Queryfy()
        {
            InitializeComponent();
            btnExecute.Click += btnExecute_Click;
            btnLoad.Click += btnLoad_Click;
            this.KeyDown += Queryfy_KeyDown;
        }

        void Queryfy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                btnExecute.PerformClick();

        }

        void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdExcel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofdExcel.FileName;
                myConn = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + path + "\";Extended Properties=Excel 8.0;");

                try
                {
                    myConn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                lblPath.Text = path;

                btnExecute.Enabled = true;
                txtQuery.Enabled = true;
                //var name = myConn.GetSchema("Tables").Rows[0]["TABLE_NAME"];
            }
        }

        void btnExecute_Click(object sender, EventArgs e)
        {

            try
            {
                var name = myConn.GetSchema("Tables").Rows[0]["TABLE_NAME"];

                MyCommand = new System.Data.OleDb.OleDbDataAdapter(txtQuery.Text, myConn);
                MyCommand.TableMappings.Add("Table", "TableName");
                ds = new System.Data.DataSet();
                MyCommand.Fill(ds);
                DataTable dt = ds.Tables[0];

                if (ckRowNumber.Checked)
                {
                    dt.Columns.Add("RowNumber").SetOrdinal(0);
                    int count = 1;
                    foreach (DataRow dr in dt.Rows)
                        dr["RowNumber"] = count++;
                }
                dgResult.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder();
            DataTable dt = (DataTable)dgResult.DataSource;
            foreach (DataRow item in dt.Rows)
                query.Append(String.Join(",", item.ItemArray) + "\n");

            if (svFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                System.IO.File.WriteAllText(svFile.FileName, query.ToString());

        }

        private void btnMySql_Click(object sender, EventArgs e)
        {
            string table = Microsoft.VisualBasic.Interaction.InputBox("Type the name of table", "Table name");
            StringBuilder query = new StringBuilder();
            DataTable dt = (DataTable)dgResult.DataSource;

            string[] columns = (from dc in dt.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();

            foreach (DataRow item in dt.Rows)
                query.Append(string.Format("INSERT INTO {0} ({1}) values ({2})", table, string.Join(",", columns), string.Join(",", item.ItemArray)) + ";\n");

            Clipboard.SetText(query.ToString());
            MessageBox.Show("Copied to clipboard!");
        }







    }
}
