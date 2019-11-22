namespace aa
{
	public class : MapeadorDeEntidade<ProdutosMap>
	{
		public ProdutosMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Id).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.CodProduto).HasColumnName("COD_PRODUTO").IsRequired().HasMaxLength(6);
			this.Mapeador.Property(a => a.CodRef).HasColumnName("COD_REF").IsRequired().HasMaxLength(3);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").IsRequired().HasMaxLength(200);
			this.Mapeador.ToTable("PRODUTOS"); 
		}
	}
}