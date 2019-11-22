namespace aa
{
	public class : MapeadorDeEntidade<TbVolumeMap>
	{
		public TbVolumeMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.GUID).HasColumnName("GUID").HasMaxLength(50);
			this.Mapeador.Property(a => a.CodFilial).HasColumnName("COD_FILIAL").HasMaxLength(10);
			this.Mapeador.Property(a => a.SerieVolume).HasColumnName("SERIE_VOLUME").HasMaxLength(10);
			this.Mapeador.Property(a => a.NumVolume).HasColumnName("NUM_VOLUME");
			this.Mapeador.Property(a => a.TipoAnimal).HasColumnName("TIPO_ANIMAL").HasMaxLength(10);
			this.Mapeador.Property(a => a.LayoutEtiqueta).HasColumnName("LAYOUT_ETIQUETA");
			this.Mapeador.Property(a => a.CodigoPrecoce).HasColumnName("CODIGO_PRECOCE").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodigoItem).HasColumnName("CODIGO_ITEM").HasMaxLength(20);
			this.Mapeador.Property(a => a.CodigoReferencia).HasColumnName("CODIGO_REFERENCIA").HasMaxLength(5);
			this.Mapeador.Property(a => a.NomeProduto).HasColumnName("NOME_PRODUTO").HasMaxLength(100);
			this.Mapeador.Property(a => a.DataProducao).HasColumnName("DATA_PRODUCAO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataValidade).HasColumnName("DATA_VALIDADE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataCongelamento).HasColumnName("DATA_CONGELAMENTO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataMaturacao).HasColumnName("DATA_MATURACAO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.PesoLiquido).HasColumnName("PESO_LIQUIDO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoBruto).HasColumnName("PESO_BRUTO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.TaraInterna).HasColumnName("TARA_INTERNA").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.TaraExterna).HasColumnName("TARA_EXTERNA").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS").HasMaxLength(5);
			this.Mapeador.Property(a => a.SeriePallet).HasColumnName("SERIE_PALLET").HasMaxLength(5);
			this.Mapeador.Property(a => a.NumeroPallet).HasColumnName("NUMERO_PALLET");
			this.Mapeador.Property(a => a.Localizacao).HasColumnName("LOCALIZACAO").HasMaxLength(20);
			this.Mapeador.Property(a => a.NumeroLote).HasColumnName("NUMERO_LOTE").HasMaxLength(10);
			this.Mapeador.Property(a => a.QuantidadePrimariaX).HasColumnName("QUANTIDADE_PRIMARIAX").HasPrecision(15, 3);
			this.Mapeador.ToTable("TBVOLUME"); 
		}
	}
}