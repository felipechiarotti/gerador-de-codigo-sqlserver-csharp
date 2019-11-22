namespace aa
{
	public class : MapeadorDeEntidade<ApontamentoProducaoContingenciaMap>
	{
		public ApontamentoProducaoContingenciaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Filial).HasColumnName("FILIAL").IsRequired().HasMaxLength(3);
			this.Mapeador.Property(a => a.DataDeApontamento).HasColumnName("DATADEAPONTAMENTO").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Sync).HasColumnName("SYNC").IsRequired();
			this.Mapeador.Property(a => a.CodigoSistemaAnterior).HasColumnName("CODIGOSISTEMAANTERIOR").IsRequired().HasMaxLength(20);
			this.Mapeador.Property(a => a.DataDeMovimentacao).HasColumnName("DATADEMOVIMENTACAO").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Item).HasColumnName("ITEM").IsRequired().HasMaxLength(10);
			this.Mapeador.ToTable("APONTAMENTOPRODUCAOCONTINGENCIA"); 
		}
	}
}