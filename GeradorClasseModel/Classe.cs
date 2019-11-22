using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorClasseModel
{
    public class Classe
    {
        public string Name { get; set; }
        public string TableName { get; set; }
        public string NameSpace { get; set; }
        public IList<ClassProperty> Properties { get; set; }

        public Classe(string name, string nameSpace, IList<ClassProperty> properties)
        {
            Name = FilterString(name);
            TableName = name;
            NameSpace = nameSpace;
            Properties = FilterProperties(properties);
        }

        public virtual string GerarClasse()
        {
            return  GerarHeader() + GerarPropriedades() + GerarFinal();
        }

        public virtual string GerarHeader()
        {
            string nl = "\r\n";
            string tab = "\t";
            string header =
             $"namespace {NameSpace} {nl}" +
              "{ \r\n" +
                $"{tab}public class {Name}  {nl}" +
                 "\t{ \r\n";

            return header;
        }

        public string GerarPropriedades()
        {
            string nl = "\r\n";
            string tab = "\t";
            string properties = "";
            foreach (ClassProperty prop in Properties)
            {
                properties += tab + tab;
                properties += $"public {prop.type} {prop.name} {{ get; set; }} {nl}";
            }

            return properties;
        }

        public string GerarFinal()
        {
            return "\t} \r\n}";
        }

        private string FilterString(string name)
        {
            string novoNome = ""+ char.ToUpper(name[0]);
            if (name.Contains("_"))
            {

                //string novoNome = name.Replace("_", "");

                for (int i = 1; i < name.Length; i++)
                {

                     if (name[i] == '_')
                    {
                        novoNome += char.ToUpper(name[i + 1]);
                        i++;
                    }
                    else
                    {
                        novoNome += name[i];
                    }
                }
            }
            else
            {
                novoNome += name.Substring(1);
            }
            return novoNome;
        }

        private IList<ClassProperty> FilterProperties(IList<ClassProperty> properties)
        {
            foreach (ClassProperty prop in properties)
            {
                prop.name = FilterString(prop.name);
            }
            return properties;
        }
    }
}
