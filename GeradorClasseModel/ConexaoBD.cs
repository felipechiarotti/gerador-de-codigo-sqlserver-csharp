using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace GeradorClasseModel
{
    class ConexaoBD
    {
        public string FileName { get; set; }
        public IList<string> Tables { get; set; }
        public SqlCeConnection conn { get; set; }

        public ConexaoBD(string FileName)
        {
            this.FileName = FileName;
            conn = new SqlCeConnection(@"Data Source=" + FileName + @";Password=;Persist Security Info=True");
            GetTables();
        }

        public void Unconnect()
        {
            conn.Close();
        }
        
        public void GetTables()
        {
            Tables = new List<string>();
            string query = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS";
            using (var cmd = new SqlCeCommand(query, conn))
            {
                conn.Open();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string _tableName = reader.GetString(2);
                    if (!Tables.Contains(_tableName)) Tables.Add(_tableName);
                }

                conn.Close();
            }
        }

        public IList<ClassProperty> GetTableProperties(string tableName)
        {
            IList<ClassProperty> _propertyList = new List<ClassProperty>();

            string query = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, IS_NULLABLE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, NUMERIC_SCALE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TableName";
            using (var cmd = new SqlCeCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TableName", tableName);

                conn.Open();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ClassProperty _property = new ClassProperty(reader.GetString(1), reader.GetString(2));
                    _property.nullable = reader.IsDBNull(3) ? "" : reader.GetString(3) ;
                    _property.maxLength = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                    _property.numericPrecision = reader.IsDBNull(5) ? 0 : reader.GetInt16(5);
                    _property.numericScale = reader.IsDBNull(6) ? 0 : reader.GetInt16(6);
                    _propertyList.Add(_property);
                }

                conn.Close();
            }

            return _propertyList;
        }
    }
}
