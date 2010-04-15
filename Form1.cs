using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlServerExport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = "";
                SqlConnection ServerConnection = new SqlConnection("user id=" + ServerUsername.Text + ";" +
                                           "password=" + ServerPassword.Text + ";server=" + ServerHost.Text + ";" +
                                           "Trusted_Connection=yes;" +
                                           "database=" + ServerDatabase.Text + ";" +
                                           "connection timeout=10");
                ServerConnection.Open();

                SqlCommand Command = new SqlCommand("SELECT * FROM sys.Tables", ServerConnection);
                SqlDataReader Tables = Command.ExecuteReader();

                List<string> TableNames = new List<string>();

                while (Tables.Read())
                {
                    TableNames.Add(Tables["name"].ToString());
                }
                Tables.Close();

                foreach (string Table in TableNames)
                {
                    Table T = new Table(Table, ServerConnection);

                    Output.Text += T.getCreateStatement() + Environment.NewLine + Environment.NewLine;

                    List<string> Inserts = T.GetInsertStatements();

                    foreach (string Insert in Inserts)
                    {
                        Output.Text += Insert + Environment.NewLine;
                    }
                    Output.Text += Environment.NewLine + Environment.NewLine;
                }
               
                MessageBox.Show("Done.");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occured when trying to connect. Please check the connection details.\n\n" + ex.Message);
            }
        }
    }
}
