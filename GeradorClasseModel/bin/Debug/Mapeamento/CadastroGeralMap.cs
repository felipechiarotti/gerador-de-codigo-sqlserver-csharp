namespace aa
{
	public class : MapeadorDeEntidade<CadastroGeralMap>
	{
		public CadastroGeralMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IDLocal).HasColumnName("IDLOCAL").IsRequired();
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.TipoCadastro).HasColumnName("TIPOCADASTRO").IsRequired().HasMaxLength(1);
			this.Mapeador.Property(a => a.TipoLocal).HasColumnName("TIPOLOCAL").IsRequired().HasMaxLength(1);
			this.Mapeador.Property(a => a.CnpjCpf).HasColumnName("CNPJCPF").IsRequired().HasMaxLength(20);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").IsRequired().HasMaxLength(100);
			this.Mapeador.Property(a => a.Apelido).HasColumnName("APELIDO").IsRequired().HasMaxLength(100);
			this.Mapeador.ToTable("CADASTROGERAL"); 
		}
	}
}