using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorClasseModel
{
    class Map : Classe
    {
        public Map(string name, string nameSpace, IList<ClassProperty> properties) : base (name, nameSpace, properties)
        {
            this.Name += "Map";
        }
        public override string GerarClasse()
        {
            return GerarHeader() + "\t"+ GerarMapearNomesDeTabelaEColunas() + "\r\n\t}\r\n}" ;
        }
        public override string GerarHeader()
        {
            string header = @"namespace " + NameSpace + "\r\n" +
                            "{\r\n" +
                                    $"\tpublic class : MapeadorDeEntidade<{base.Name}>\r\n" +
                                    "\t{\r\n" +
                                        $"\t\tpublic {this.Name}() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)\r\n" +
                                         "\t\t{\r\n" +
                                          "\t\t}\r\n\r\n";
            return header;
        }

        public string GerarMapearNomesDeTabelaEColunas()
        {
            string header = $"\tprotected override void MapearNomesDeTabelaEColunas() \r\n" +
                              "\t\t{\r\n";

            string mapeamentos = "";
            foreach(ClassProperty prop in Properties)
            {
                mapeamentos += (GerarMapeamento(prop));
            }
            
            string toTable = $"\t\t\tthis.Mapeador.ToTable(\"{TableName.ToUpper()}\"); \r\n\t\t}}";

            return header + mapeamentos + toTable;
        }

        public string GerarMapeamento(ClassProperty property)
        {
            string mapeamento = $"\t\t\tthis.Mapeador.Property(a => a.{property.name}).HasColumnName(\"{property.columnName.ToUpper()}\")";
            string nullable = (property.nullable == "NO") ? ".IsRequired()" : "";
            string hasmaxlength = (property.maxLength> 0) ? $".HasMaxLength({property.maxLength})" : "";
            string hasprecision = (property.numericPrecision > 0 && property.numericScale > 0) ? $".HasPrecision({property.numericPrecision}, {property.numericScale})" : "";

            return mapeamento + nullable + hasmaxlength + hasprecision + ";\r\n";
        }
    }
}
