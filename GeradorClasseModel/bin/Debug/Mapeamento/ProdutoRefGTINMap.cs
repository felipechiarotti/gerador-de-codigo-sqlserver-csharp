namespace aa
{
	public class : MapeadorDeEntidade<ProdutoRefGTINMap>
	{
		public ProdutoRefGTINMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.CodProduto).HasColumnName("CODPRODUTO").IsRequired().HasMaxLength(20);
			this.Mapeador.Property(a => a.CodReferencia).HasColumnName("CODREFERENCIA").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.CodigoGtin).HasColumnName("CODIGOGTIN").HasMaxLength(50);
			this.Mapeador.ToTable("PRODUTOREFGTIN"); 
		}
	}
}