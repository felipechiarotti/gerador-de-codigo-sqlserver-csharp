using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorClasseModel
{
    public partial class FormGerador : Form
    {
        ConexaoBD banco;
        public FormGerador()
        {
            InitializeComponent();
            this.Height = 150;
        }

        private void btProcurarBase_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "sdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoBase.Text = openFileDialog1.FileName;
            }
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {

            if (File.Exists(txtCaminhoBase.Text) && txtCaminhoBase.Text.EndsWith(".sdf"))
            {

                pnGerador.Location = pnCaminhoBase.Location;

                banco = new ConexaoBD(txtCaminhoBase.Text);
                comboBox1.DataSource = banco.Tables;


                pnCaminhoBase.Visible = false;
                this.Height = 250;
                pnGerador.Visible = true;
            }
            else
            {
                MessageBox.Show("Arquivo inválido");
            }

        }

        private void btGerarClasse_Click(object sender, EventArgs e)
        {
            GerarClasse(comboBox1.SelectedItem.ToString());

        }



        private void btGerarTodas_Click(object sender, EventArgs e)
        {
            foreach (string classeNome in banco.Tables)
            {
                GerarClasse(classeNome);
            }

            MessageBox.Show("Todas as classes foram geradas");
        }

        public void GerarClasse(string name)
        {
            Classe classe = new Classe(name, txtNamespace.Text, banco.GetTableProperties(name));
            if (checkBox1.Checked) GerarMapeamento(classe);
            SalvarArquivo("Modelo", classe.GerarClasse(), classe.Name);
        }

        public void GerarMapeamento(Classe cl)
        {
            Map map = new Map(cl.Name, cl.NameSpace, cl.Properties);
            SalvarArquivo("Mapeamento", map.GerarClasse(), map.Name);
        }

        public void SalvarArquivo(string dir, string texto, string filename)
        {
            string diretorio = $".\\{dir}";
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }
            System.IO.File.WriteAllText(diretorio + @"\" + filename + ".cs", texto);

        }
    }
}
