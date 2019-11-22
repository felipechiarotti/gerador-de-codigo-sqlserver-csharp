namespace aa
{
	public class : MapeadorDeEntidade<ReferenciaDeItemApontamentoMap>
	{
		public ReferenciaDeItemApontamentoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.CodProduto).HasColumnName("CODPRODUTO").IsRequired().HasMaxLength(20);
			this.Mapeador.Property(a => a.CodReferencia).HasColumnName("CODREFERENCIA").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.CodigoEAN).HasColumnName("CODIGOEAN").HasMaxLength(20);
			this.Mapeador.Property(a => a.TipoDeTemperatura).HasColumnName("TIPODETEMPERATURA").HasMaxLength(10);
			this.Mapeador.Property(a => a.SifDiPoa).HasColumnName("SIFDIPOA").HasMaxLength(20);
			this.Mapeador.Property(a => a.PrazoDeValidade).HasColumnName("PRAZODEVALIDADE");
			this.Mapeador.Property(a => a.OrigemTaraInterna).HasColumnName("ORIGEMTARAINTERNA").HasMaxLength(10);
			this.Mapeador.Property(a => a.TaraInterna).HasColumnName("TARAINTERNA").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.OrigemTaraExterna).HasColumnName("ORIGEMTARAEXTERNA").HasMaxLength(10);
			this.Mapeador.Property(a => a.TaraExterna).HasColumnName("TARAEXTERNA").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.Exportavel).HasColumnName("EXPORTAVEL").HasMaxLength(10);
			this.Mapeador.Property(a => a.NomeExportacao).HasColumnName("NOMEEXPORTACAO").HasMaxLength(100);
			this.Mapeador.Property(a => a.LayoutDaEtiqueta).HasColumnName("LAYOUTDAETIQUETA");
			this.Mapeador.Property(a => a.IDDaLinhaDeProducao).HasColumnName("IDDALINHADEPRODUCAO").HasMaxLength(20);
			this.Mapeador.Property(a => a.QuantidadeDeSacos).HasColumnName("QUANTIDADEDESACOS");
			this.Mapeador.Property(a => a.EhPesoPadrao).HasColumnName("EHPESOPADRAO");
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.NumeroDoItem).HasColumnName("NUMERODOITEM");
			this.Mapeador.Property(a => a.NumeroDoSubItem).HasColumnName("NUMERODOSUBITEM");
			this.Mapeador.Property(a => a.NomeLingua1).HasColumnName("NOMELINGUA1").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeLingua2).HasColumnName("NOMELINGUA2").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeLingua3).HasColumnName("NOMELINGUA3").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeLingua4).HasColumnName("NOMELINGUA4").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeLingua5).HasColumnName("NOMELINGUA5").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeLingua6).HasColumnName("NOMELINGUA6").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeLingua7).HasColumnName("NOMELINGUA7").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeLingua8).HasColumnName("NOMELINGUA8").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeLingua9).HasColumnName("NOMELINGUA9").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeRotulo).HasColumnName("NOMEROTULO").HasMaxLength(100);
			this.Mapeador.Property(a => a.Observacao).HasColumnName("OBSERVACAO").HasMaxLength(100);
			this.Mapeador.Property(a => a.Minimo).HasColumnName("MINIMO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.Maximo).HasColumnName("MAXIMO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.LiquidoPadrao).HasColumnName("LIQUIDOPADRAO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.BrutoPadrao).HasColumnName("BRUTOPADRAO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.TipoItemSped).HasColumnName("TIPO_ITEM_SPED").HasMaxLength(5);
			this.Mapeador.Property(a => a.TipoItem).HasColumnName("TIPO_ITEM").HasMaxLength(5);
			this.Mapeador.ToTable("REFERENCIADEITEMAPONTAMENTO"); 
		}
	}
}