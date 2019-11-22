using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorClasseModel
{
    public class ClassProperty
    {
        public string name { get; set; }
        public string columnName { get; set; }
        public string type { get; set; }
        public string nullable { get; set; }
        public int maxLength { get; set; }
        public int numericPrecision { get; set; }
        public int numericScale { get; set; }

        public ClassProperty(string name, string type)
        {
            this.name = name;
            this.columnName = name;
            this.type = SetType(type);
        }

        public string SetType(string type)
        {
            string tipoMapeado = type;
            if (type == "varchar" || type == "nvarchar") tipoMapeado = "string";
            else if (type == "bigint") tipoMapeado = "long";
            else if (type == "smallint" || type == "tinyint") tipoMapeado = "int";
            else if (type == "numeric") tipoMapeado = "decimal";
            else if (type == "bit") tipoMapeado = "boolean";
            else if (type == "float") tipoMapeado = "double";
            else if (type == "datetime") tipoMapeado = "DateTime";
            return tipoMapeado;
        }

    }
}
