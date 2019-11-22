namespace aa
{
	public class : MapeadorDeEntidade<RecebimentoControleEscalaItemMap>
	{
		public RecebimentoControleEscalaItemMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Id).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.RomaneioAnimalChaveFato).HasColumnName("ROMANEIO_ANIMAL_CHAVE_FATO").HasMaxLength(30);
			this.Mapeador.Property(a => a.RomaneioAnimalDocumento).HasColumnName("ROMANEIO_ANIMAL_DOCUMENTO").HasMaxLength(30);
			this.Mapeador.Property(a => a.RomaneioAnimalNumItem).HasColumnName("ROMANEIO_ANIMAL_NUM_ITEM");
			this.Mapeador.Property(a => a.RomaneioAnimalCodigoProduto).HasColumnName("ROMANEIO_ANIMAL_CODIGO_PRODUTO").HasMaxLength(10);
			this.Mapeador.Property(a => a.RomaneioAnimalCodigoReferencia).HasColumnName("ROMANEIO_ANIMAL_CODIGO_REFERENCIA").HasMaxLength(10);
			this.Mapeador.Property(a => a.RomaneioAnimalProdutoNome).HasColumnName("ROMANEIO_ANIMAL_PRODUTO_NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.RomaneioAnimalLote).HasColumnName("ROMANEIO_ANIMAL_LOTE").HasMaxLength(20);
			this.Mapeador.Property(a => a.RomaneioAnimalCurral).HasColumnName("ROMANEIO_ANIMAL_CURRAL").HasMaxLength(30);
			this.Mapeador.Property(a => a.RomaneioAnimalQuantidade).HasColumnName("ROMANEIO_ANIMAL_QUANTIDADE").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.RomaneioAnimalPeso).HasColumnName("ROMANEIO_ANIMAL_PESO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.RomaneioAnimalPrevisto).HasColumnName("ROMANEIO_ANIMAL_PREVISTO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.RomaneioAnimalRestante).HasColumnName("ROMANEIO_ANIMAL_RESTANTE").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.EscalaChaveFato).HasColumnName("ESCALA_CHAVE_FATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.EscalaIdLocal).HasColumnName("ESCALA_ID_LOCAL");
			this.Mapeador.Property(a => a.EscalaDataAbate).HasColumnName("ESCALA_DATA_ABATE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Sequencia).HasColumnName("SEQUENCIA");
			this.Mapeador.Property(a => a.Selecionado).HasColumnName("SELECIONADO");
			this.Mapeador.Property(a => a.IdOrigem).HasColumnName("ID_ORIGEM");
			this.Mapeador.ToTable("RECEBIMENTOCONTROLEESCALAITEM"); 
		}
	}
}