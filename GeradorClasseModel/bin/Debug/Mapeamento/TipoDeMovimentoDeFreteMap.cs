namespace aa
{
	public class : MapeadorDeEntidade<TipoDeMovimentoDeFreteMap>
	{
		public TipoDeMovimentoDeFreteMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IDTipoDeMovimentoDeFrete).HasColumnName("IDTIPODEMOVIMENTODEFRETE").IsRequired();
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(200);
			this.Mapeador.Property(a => a.TipoReceitaOuDespesa).HasColumnName("TIPORECEITAOUDESPESA").HasMaxLength(50);
			this.Mapeador.Property(a => a.TipoReceitaOuDespesaCompleto).HasColumnName("TIPORECEITAOUDESPESACOMPLETO").HasMaxLength(50);
			this.Mapeador.Property(a => a.NomeDoPesoV1).HasColumnName("NOMEDOPESOV1").HasMaxLength(200);
			this.Mapeador.Property(a => a.NomeDoPesoV2).HasColumnName("NOMEDOPESOV2").HasMaxLength(200);
			this.Mapeador.Property(a => a.NomeDaQuantidadeV1).HasColumnName("NOMEDAQUANTIDADEV1").HasMaxLength(200);
			this.Mapeador.Property(a => a.NomeDaQuantidadeV2).HasColumnName("NOMEDAQUANTIDADEV2").HasMaxLength(200);
			this.Mapeador.Property(a => a.AtuaizaKMDoVeiculo).HasColumnName("ATUAIZAKMDOVEICULO").HasMaxLength(50);
			this.Mapeador.Property(a => a.AtuaizaKMDoVeiculoCompleto).HasColumnName("ATUAIZAKMDOVEICULOCOMPLETO").HasMaxLength(50);
			this.Mapeador.Property(a => a.RestringePlaca).HasColumnName("RESTRINGEPLACA").HasMaxLength(50);
			this.Mapeador.Property(a => a.RestringePlacaCompleto).HasColumnName("RESTRINGEPLACACOMPLETO").HasMaxLength(50);
			this.Mapeador.Property(a => a.AtualizaItemMan).HasColumnName("ATUALIZAITEMMAN").HasMaxLength(50);
			this.Mapeador.Property(a => a.AtualizaItemManCompleto).HasColumnName("ATUALIZAITEMMANCOMPLETO").HasMaxLength(50);
			this.Mapeador.Property(a => a.UsaDocumentoRelacionado).HasColumnName("USADOCUMENTORELACIONADO").HasMaxLength(50);
			this.Mapeador.Property(a => a.UsaDocumentoRelacionadoCompleto).HasColumnName("USADOCUMENTORELACIONADOCOMPLETO").HasMaxLength(50);
			this.Mapeador.Property(a => a.NomeDaDataV1).HasColumnName("NOMEDADATAV1").HasMaxLength(200);
			this.Mapeador.Property(a => a.NomeDaDataV2).HasColumnName("NOMEDADATAV2").HasMaxLength(200);
			this.Mapeador.Property(a => a.IDNome).HasColumnName("IDNOME").HasMaxLength(50);
			this.Mapeador.ToTable("TIPODEMOVIMENTODEFRETE"); 
		}
	}
}