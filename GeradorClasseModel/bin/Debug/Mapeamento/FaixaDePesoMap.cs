namespace aa
{
	public class : MapeadorDeEntidade<FaixaDePesoMap>
	{
		public FaixaDePesoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IdLocal).HasColumnName("IDLOCAL").IsRequired();
			this.Mapeador.Property(a => a.IdProdutoLocal).HasColumnName("IDPRODUTOLOCAL").IsRequired();
			this.Mapeador.Property(a => a.CodProduto).HasColumnName("CODPRODUTO").IsRequired().HasMaxLength(50);
			this.Mapeador.Property(a => a.CodReferencia).HasColumnName("CODREFERENCIA").IsRequired().HasMaxLength(50);
			this.Mapeador.Property(a => a.NumeroDaFaixa).HasColumnName("NUMERODAFAIXA").IsRequired();
			this.Mapeador.Property(a => a.DescricaoDaFaixa).HasColumnName("DESCRICAODAFAIXA").HasMaxLength(100);
			this.Mapeador.Property(a => a.PesoInicial).HasColumnName("PESOINICIAL").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.PesoFinal).HasColumnName("PESOFINAL").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.IDDaClassificao).HasColumnName("IDDACLASSIFICAO");
			this.Mapeador.ToTable("FAIXADEPESO"); 
		}
	}
}