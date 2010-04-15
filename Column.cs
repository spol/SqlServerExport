using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlServerExport
{
    class Column
    {
        public string Type;
        public int Ordinal;
        public int Length;
        public string Name;
        public bool IsNullable;

        public string FormatData(object Data)
        {
            if (Data == DBNull.Value)
            {
                return "NULL";
            }

            switch (Type)
            {
                case "int":
                    return Data.ToString();
                case "nvarchar":
                    return "'" + Data.ToString().Replace("'", "''") + "'";
                case "ntext":
                    return "'" + Data.ToString().Replace("'", "''") + "'";
                case "datetime":
                    return "'" + Convert.ToDateTime(Data).ToString("MMM dd yyyy hh:mm:sstt") + "'";
                default:
                    return Data.ToString();
            }
        }

        public string GetDefintion()
        {
            StringBuilder Definition = new StringBuilder();

            Definition.Append("[" + Name + "] ");
            switch (Type)
            {
                case "int":
                    Definition.Append(Type + " ");
                    break;
                case "nvarchar":
                    Definition.Append(Type + "(" + Length.ToString() + ") ");
                    break;
                case "ntext":
                    Definition.Append(Type + " ");
                    break;
                case "datetime":
                    Definition.Append(Type + " ");
                    break;
                default:
                    Definition.Append(Type + " ");
                    break;
            }

            if (IsNullable)
            {
                Definition.Append("NULL");
            }
            else
            {
                Definition.Append("NOT NULL");
            }

            return Definition.ToString();
        }
    }
}
