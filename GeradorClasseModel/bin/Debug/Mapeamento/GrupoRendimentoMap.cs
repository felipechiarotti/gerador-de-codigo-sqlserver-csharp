namespace aa
{
	public class : MapeadorDeEntidade<GrupoRendimentoMap>
	{
		public GrupoRendimentoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired().HasMaxLength(5);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(30);
			this.Mapeador.ToTable("GRUPORENDIMENTO"); 
		}
	}
}