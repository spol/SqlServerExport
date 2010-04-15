using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlServerExport
{
    class Table
    {
        private string TableName;
        private SqlConnection Connection;

        public Table(string Name, SqlConnection Connection)
        {
            this.TableName = Name;
            this.Connection = Connection;
        }

        public string getCreateStatement()
        {
            List<Column> Columns = GetTableColumns();

            StringBuilder Statement = new StringBuilder();
            Statement.Append("CREATE TABLE [" + TableName + "]" + "(" + Environment.NewLine);

            foreach (Column Col in Columns)
            {
                Statement.Append(Col.GetDefintion());
                if (Col.Ordinal < Columns.Count)
                {
                    Statement.Append("," + Environment.NewLine);
                }
            }
            Statement.Append(");");
            return Statement.ToString();
        }

        public List<string> GetInsertStatements()
        {
            List<string> Inserts = new List<string>();

            List<Column> Columns = GetTableColumns();

            SqlCommand DataQuery = new SqlCommand("SELECT * FROM " + TableName, Connection);

            SqlDataReader DataReader = DataQuery.ExecuteReader();

            while (DataReader.Read())
            {
                List<string> DataFields = new List<string>();

                StringBuilder Statement = new StringBuilder();
                Statement.Append("INSERT INTO " + TableName + " (");
                foreach (Column Col in Columns)
                {
                    Statement.Append(Col.Name);
                    if (Col.Ordinal < Columns.Count)
                    {
                        Statement.Append(", ");
                    }
                }
                Statement.Append(") VALUES (");
                foreach (Column Col in Columns)
                {
                    Statement.Append(Col.FormatData(DataReader[Col.Name]));
                    if (Col.Ordinal < Columns.Count)
                    {
                        Statement.Append(", ");
                    }
                }
                Statement.Append(");");
                Inserts.Add(Statement.ToString());
            }

            DataReader.Close();

            return Inserts;
        }

        private List<Column> GetTableColumns()
        {
            SqlCommand ColumnQuery = new SqlCommand("SELECT	* FROM INFORMATION_SCHEMA.COLUMNS (NOLOCK) WHERE TABLE_NAME = '" + TableName + "' ORDER BY ORDINAL_POSITION", Connection);

            SqlDataReader ColumnReader = ColumnQuery.ExecuteReader();

            List<Column> Columns = new List<Column>();
            while (ColumnReader.Read())
            {
                Column Col = new Column();
                Col.Type    = ColumnReader["DATA_TYPE"].ToString();
                Col.Ordinal = Convert.ToInt32(ColumnReader["ORDINAL_POSITION"]);
                if (ColumnReader["CHARACTER_MAXIMUM_LENGTH"] != DBNull.Value)
                {
                    Col.Length = Convert.ToInt32(ColumnReader["CHARACTER_MAXIMUM_LENGTH"]);
                }
                Col.Name    = ColumnReader["COLUMN_NAME"].ToString();
                Col.IsNullable = ColumnReader["IS_NULLABLE"].ToString() == "YES";

                Columns.Add(Col);
            }

            ColumnReader.Close();

            return Columns;

        }

    }
}
