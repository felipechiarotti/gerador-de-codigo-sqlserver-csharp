namespace aa
{
	public class : MapeadorDeEntidade<OrdemProducaoEsteiraItemMap>
	{
		public OrdemProducaoEsteiraItemMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IDOrdem).HasColumnName("IDORDEM").IsRequired();
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVE_FATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDItem).HasColumnName("IDITEM").HasMaxLength(10);
			this.Mapeador.Property(a => a.IDReferencia).HasColumnName("IDREFERENCIA").HasMaxLength(10);
			this.Mapeador.Property(a => a.NumeroItem).HasColumnName("NUMEROITEM");
			this.Mapeador.Property(a => a.NumeroSubItem).HasColumnName("NUMEROSUBITEM");
			this.Mapeador.Property(a => a.SaldoProduzir).HasColumnName("SALDOPRODUZIR").HasPrecision(20, 4);
			this.Mapeador.Property(a => a.NumeroLote).HasColumnName("NUMEROLOTE").HasMaxLength(10);
			this.Mapeador.Property(a => a.ProdutoDescricao).HasColumnName("PRODUTO_DESCRICAO").HasMaxLength(200);
			this.Mapeador.Property(a => a.IdUnidade).HasColumnName("ID_UNIDADE").HasMaxLength(10);
			this.Mapeador.Property(a => a.QuantidadeProduzir).HasColumnName("QUANTIDADE_PRODUZIR").HasPrecision(20, 4);
			this.Mapeador.Property(a => a.CodigoLinha).HasColumnName("CODIGO_LINHA").HasMaxLength(5);
			this.Mapeador.Property(a => a.DataMovimentacao).HasColumnName("DATA_MOVIMENTACAO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.CodigoFilial).HasColumnName("CODIGO_FILIAL").HasMaxLength(5);
			this.Mapeador.ToTable("ORDEMPRODUCAOESTEIRAITEM"); 
		}
	}
}