namespace aa
{
	public class : MapeadorDeEntidade<TipoDeVeiculoMap>
	{
		public TipoDeVeiculoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(500);
			this.Mapeador.ToTable("TIPODEVEICULO"); 
		}
	}
}