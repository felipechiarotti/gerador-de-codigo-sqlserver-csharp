namespace aa
{
	public class : MapeadorDeEntidade<LayoutImpressaoProdutoMap>
	{
		public LayoutImpressaoProdutoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.CodProduto).HasColumnName("COD_PRODUTO").IsRequired().HasMaxLength(6);
			this.Mapeador.Property(a => a.CodRef).HasColumnName("COD_REF").IsRequired().HasMaxLength(3);
			this.Mapeador.Property(a => a.Layout).HasColumnName("LAYOUT").IsRequired().HasMaxLength(8);
			this.Mapeador.ToTable("LAYOUTIMPRESSAOPRODUTO"); 
		}
	}
}