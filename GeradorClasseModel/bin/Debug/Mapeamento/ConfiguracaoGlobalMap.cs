namespace aa
{
	public class : MapeadorDeEntidade<ConfiguracaoGlobalMap>
	{
		public ConfiguracaoGlobalMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").IsRequired().HasMaxLength(200);
			this.Mapeador.Property(a => a.Conteudo).HasColumnName("CONTEUDO").HasMaxLength(500);
			this.Mapeador.ToTable("CONFIGURACAOGLOBAL"); 
		}
	}
}