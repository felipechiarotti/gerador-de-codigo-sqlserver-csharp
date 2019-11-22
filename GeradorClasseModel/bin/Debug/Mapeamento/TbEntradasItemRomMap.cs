namespace aa
{
	public class : MapeadorDeEntidade<TbEntradasItemRomMap>
	{
		public TbEntradasItemRomMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IDEntradasitem).HasColumnName("ID_ENTRADASITEM").IsRequired();
			this.Mapeador.Property(a => a.NumItem).HasColumnName("NUM_ITEM");
			this.Mapeador.Property(a => a.NumSubItem).HasColumnName("NUM_SUBITEM");
			this.Mapeador.Property(a => a.Seq).HasColumnName("SEQ");
			this.Mapeador.Property(a => a.QtdePri).HasColumnName("QTDE_PRI").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.QtdeAux).HasColumnName("QTDE_AUX").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.NumLote).HasColumnName("NUM_LOTE").HasMaxLength(12);
			this.Mapeador.Property(a => a.PesoLiquidoReal).HasColumnName("PESO_LIQUIDO_REAL").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoBruto).HasColumnName("PESO_BRUTO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.Ean128).HasColumnName("EAN128").HasMaxLength(130);
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVE_FATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.Datahora).HasColumnName("DATAHORA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.IdVolume).HasColumnName("ID_VOLUME");
			this.Mapeador.Property(a => a.GerarVolume).HasColumnName("GERAR_VOLUME");
			this.Mapeador.Property(a => a.Documento).HasColumnName("DOCUMENTO").HasMaxLength(30);
			this.Mapeador.Property(a => a.NumSerieEan).HasColumnName("NUM_SERIE_EAN").HasMaxLength(15);
			this.Mapeador.Property(a => a.CodFilialVolume).HasColumnName("COD_FILIAL_VOLUME").HasMaxLength(5);
			this.Mapeador.Property(a => a.SerieVolume).HasColumnName("SERIE_VOLUME").HasMaxLength(15);
			this.Mapeador.Property(a => a.NumVolume).HasColumnName("NUM_VOLUME");
			this.Mapeador.Property(a => a.OperacaoSincronismo).HasColumnName("OPERACAO_SINCRONISMO");
			this.Mapeador.Property(a => a.GerarPacoteCaixa).HasColumnName("GERAR_PACOTE_CAIXA");
			this.Mapeador.Property(a => a.CodigoSistemaAnterior).HasColumnName("CODIGO_SISTEMA_ANTERIOR").HasMaxLength(50);
			this.Mapeador.Property(a => a.NumSerieEanValor).HasColumnName("NUM_SERIE_EAN_VALOR");
			this.Mapeador.ToTable("TBENTRADASITEMROM"); 
		}
	}
}