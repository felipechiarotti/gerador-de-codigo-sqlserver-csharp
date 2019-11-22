namespace aa
{
	public class : MapeadorDeEntidade<RecebimentoControleEscalaMap>
	{
		public RecebimentoControleEscalaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Id).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.ChaveFatoContrato).HasColumnName("CHAVE_FATO_CONTRATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.ChaveFatoEscala).HasColumnName("CHAVE_FATO_ESCALA").HasMaxLength(20);
			this.Mapeador.Property(a => a.DocumentoEscala).HasColumnName("DOCUMENTO_ESCALA").HasMaxLength(30);
			this.Mapeador.Property(a => a.DocumentoContrato).HasColumnName("DOCUMENTO_CONTRATO").HasMaxLength(30);
			this.Mapeador.Property(a => a.DataAbate).HasColumnName("DATA_ABATE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Modo).HasColumnName("MODO");
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS");
			this.Mapeador.Property(a => a.Sequencia).HasColumnName("SEQUENCIA");
			this.Mapeador.Property(a => a.Quantidade).HasColumnName("QUANTIDADE").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.NumItem).HasColumnName("NUM_ITEM");
			this.Mapeador.Property(a => a.LoteSif).HasColumnName("LOTE_SIF").HasMaxLength(20);
			this.Mapeador.Property(a => a.LoteAbate).HasColumnName("LOTE_ABATE").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodigoFilial).HasColumnName("CODIGO_FILIAL").HasMaxLength(5);
			this.Mapeador.ToTable("RECEBIMENTOCONTROLEESCALA"); 
		}
	}
}