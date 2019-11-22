namespace GeradorClasseModel
{
    partial class FormGerador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGerarClasse = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btGerarTodas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnGerador = new System.Windows.Forms.Panel();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txNameSpace = new System.Windows.Forms.Label();
            this.pnCaminhoBase = new System.Windows.Forms.Panel();
            this.btContinuar = new System.Windows.Forms.Button();
            this.txtCaminhoBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btProcurarBase = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnGerador.SuspendLayout();
            this.pnCaminhoBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGerarClasse
            // 
            this.btGerarClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarClasse.Location = new System.Drawing.Point(34, 111);
            this.btGerarClasse.Name = "btGerarClasse";
            this.btGerarClasse.Size = new System.Drawing.Size(276, 30);
            this.btGerarClasse.TabIndex = 0;
            this.btGerarClasse.Text = "Gerar Classe";
            this.btGerarClasse.UseVisualStyleBackColor = true;
            this.btGerarClasse.Click += new System.EventHandler(this.btGerarClasse_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btGerarTodas
            // 
            this.btGerarTodas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarTodas.Location = new System.Drawing.Point(34, 147);
            this.btGerarTodas.Name = "btGerarTodas";
            this.btGerarTodas.Size = new System.Drawing.Size(276, 37);
            this.btGerarTodas.TabIndex = 2;
            this.btGerarTodas.Text = "Gerar Todas";
            this.btGerarTodas.UseVisualStyleBackColor = true;
            this.btGerarTodas.Click += new System.EventHandler(this.btGerarTodas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione a Tabela";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnGerador
            // 
            this.pnGerador.Controls.Add(this.checkBox1);
            this.pnGerador.Controls.Add(this.txtNamespace);
            this.pnGerador.Controls.Add(this.txNameSpace);
            this.pnGerador.Controls.Add(this.label1);
            this.pnGerador.Controls.Add(this.btGerarClasse);
            this.pnGerador.Controls.Add(this.btGerarTodas);
            this.pnGerador.Controls.Add(this.comboBox1);
            this.pnGerador.Location = new System.Drawing.Point(0, 121);
            this.pnGerador.Name = "pnGerador";
            this.pnGerador.Size = new System.Drawing.Size(335, 187);
            this.pnGerador.TabIndex = 6;
            this.pnGerador.Visible = false;
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(34, 63);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(276, 20);
            this.txtNamespace.TabIndex = 5;
            // 
            // txNameSpace
            // 
            this.txNameSpace.AutoSize = true;
            this.txNameSpace.Location = new System.Drawing.Point(34, 47);
            this.txNameSpace.Name = "txNameSpace";
            this.txNameSpace.Size = new System.Drawing.Size(115, 13);
            this.txNameSpace.TabIndex = 4;
            this.txNameSpace.Text = "NameSpace da Classe";
            // 
            // pnCaminhoBase
            // 
            this.pnCaminhoBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCaminhoBase.Controls.Add(this.btContinuar);
            this.pnCaminhoBase.Controls.Add(this.txtCaminhoBase);
            this.pnCaminhoBase.Controls.Add(this.label2);
            this.pnCaminhoBase.Controls.Add(this.btProcurarBase);
            this.pnCaminhoBase.Location = new System.Drawing.Point(0, 8);
            this.pnCaminhoBase.Name = "pnCaminhoBase";
            this.pnCaminhoBase.Size = new System.Drawing.Size(335, 89);
            this.pnCaminhoBase.TabIndex = 5;
            // 
            // btContinuar
            // 
            this.btContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btContinuar.Location = new System.Drawing.Point(34, 46);
            this.btContinuar.Name = "btContinuar";
            this.btContinuar.Size = new System.Drawing.Size(276, 36);
            this.btContinuar.TabIndex = 3;
            this.btContinuar.Text = "Continuar";
            this.btContinuar.UseVisualStyleBackColor = true;
            this.btContinuar.Click += new System.EventHandler(this.btContinuar_Click);
            // 
            // txtCaminhoBase
            // 
            this.txtCaminhoBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoBase.Location = new System.Drawing.Point(34, 19);
            this.txtCaminhoBase.Name = "txtCaminhoBase";
            this.txtCaminhoBase.Size = new System.Drawing.Size(195, 20);
            this.txtCaminhoBase.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione a Base de Dados";
            // 
            // btProcurarBase
            // 
            this.btProcurarBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btProcurarBase.Location = new System.Drawing.Point(235, 19);
            this.btProcurarBase.Name = "btProcurarBase";
            this.btProcurarBase.Size = new System.Drawing.Size(75, 23);
            this.btProcurarBase.TabIndex = 0;
            this.btProcurarBase.Text = "Procurar";
            this.btProcurarBase.UseVisualStyleBackColor = true;
            this.btProcurarBase.Click += new System.EventHandler(this.btProcurarBase_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Gerar Mapeamento";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 318);
            this.Controls.Add(this.pnCaminhoBase);
            this.Controls.Add(this.pnGerador);
            this.Name = "FormGerador";
            this.Text = "Gerador de Classe";
            this.pnGerador.ResumeLayout(false);
            this.pnGerador.PerformLayout();
            this.pnCaminhoBase.ResumeLayout(false);
            this.pnCaminhoBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGerarClasse;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btGerarTodas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnGerador;
        private System.Windows.Forms.Panel pnCaminhoBase;
        private System.Windows.Forms.TextBox txtCaminhoBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btProcurarBase;
        private System.Windows.Forms.Button btContinuar;
        private System.Windows.Forms.Label txNameSpace;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

