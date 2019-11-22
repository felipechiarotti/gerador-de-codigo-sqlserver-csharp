namespace aa
{
	public class : MapeadorDeEntidade<TbEntradasItemMap>
	{
		public TbEntradasItemMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IDEntradas).HasColumnName("ID_ENTRADAS").IsRequired();
			this.Mapeador.Property(a => a.CodFilial).HasColumnName("COD_FILIAL").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodLocal).HasColumnName("COD_LOCAL").HasMaxLength(5);
			this.Mapeador.Property(a => a.NumItem).HasColumnName("NUM_ITEM");
			this.Mapeador.Property(a => a.NumSubItem).HasColumnName("NUM_SUBITEM");
			this.Mapeador.Property(a => a.NumItemOrig).HasColumnName("NUM_ITEM_ORIG");
			this.Mapeador.Property(a => a.NumSubitemOrig).HasColumnName("NUM_SUBITEM_ORIG");
			this.Mapeador.Property(a => a.NumLote).HasColumnName("NUM_LOTE").HasMaxLength(12);
			this.Mapeador.Property(a => a.CodProduto).HasColumnName("COD_PRODUTO").HasMaxLength(15);
			this.Mapeador.Property(a => a.CodRef).HasColumnName("COD_REF").HasMaxLength(5);
			this.Mapeador.Property(a => a.QtdePri).HasColumnName("QTDE_PRI").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.QtdeAux).HasColumnName("QTDE_AUX").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.QtdePriFilhos).HasColumnName("QTDE_PRI_FILHOS").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.QtdeAuxFilhos).HasColumnName("QTDE_AUX_FILHOS").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoMinimo).HasColumnName("PESO_MINIMO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoMaximo).HasColumnName("PESO_MAXIMO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoBruto).HasColumnName("PESO_BRUTO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoLiquido).HasColumnName("PESO_LIQUIDO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.OrigemDeProducao).HasColumnName("ORIGEM_DE_PRODUCAO");
			this.Mapeador.Property(a => a.SaldoProduzir).HasColumnName("SALDO_PRODUZIR").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVE_FATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.ProdutoDescricao).HasColumnName("PRODUTO_DESCRICAO").HasMaxLength(200);
			this.Mapeador.Property(a => a.ProdutoGTIN).HasColumnName("PRODUTO_GTIN").HasMaxLength(30);
			this.Mapeador.Property(a => a.CodUnidade).HasColumnName("COD_UNIDADE").HasMaxLength(10);
			this.Mapeador.Property(a => a.Atendido).HasColumnName("ATENDIDO");
			this.Mapeador.ToTable("TBENTRADASITEM"); 
		}
	}
}