namespace aa
{
	public class : MapeadorDeEntidade<TbProdutoRefCustomValuesMap>
	{
		public TbProdutoRefCustomValuesMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IdCustom).HasColumnName("IDCUSTOM");
			this.Mapeador.Property(a => a.IdProduto).HasColumnName("IDPRODUTO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IdReferencia).HasColumnName("IDREFERENCIA").HasMaxLength(10);
			this.Mapeador.Property(a => a.Valor).HasColumnName("VALOR").HasMaxLength(255);
			this.Mapeador.ToTable("TBPRODUTOREFCUSTOMVALUES"); 
		}
	}
}