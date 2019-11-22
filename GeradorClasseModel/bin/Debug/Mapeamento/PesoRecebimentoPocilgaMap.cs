namespace aa
{
	public class : MapeadorDeEntidade<PesoRecebimentoPocilgaMap>
	{
		public PesoRecebimentoPocilgaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.ChaveDeFatoDoFrete).HasColumnName("CHAVEDEFATODOFRETE").IsRequired().HasMaxLength(50);
			this.Mapeador.Property(a => a.IdDoProduto).HasColumnName("IDDOPRODUTO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IdDaReferencia).HasColumnName("IDDAREFERENCIA").HasMaxLength(20);
			this.Mapeador.Property(a => a.NomeDoProduto).HasColumnName("NOMEDOPRODUTO").HasMaxLength(500);
			this.Mapeador.Property(a => a.Rastreamento).HasColumnName("RASTREAMENTO").HasMaxLength(50);
			this.Mapeador.Property(a => a.DataDeCadastro).HasColumnName("DATADECADASTRO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Peso).HasColumnName("PESO").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.Tara).HasColumnName("TARA").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.Quantidade).HasColumnName("QUANTIDADE").IsRequired();
			this.Mapeador.Property(a => a.Seq).HasColumnName("SEQ");
			this.Mapeador.Property(a => a.Ignorar).HasColumnName("IGNORAR");
			this.Mapeador.Property(a => a.LoteTatuagem).HasColumnName("LOTETATUAGEM").HasMaxLength(50);
			this.Mapeador.Property(a => a.StatusDeEnvio).HasColumnName("STATUSDEENVIO");
			this.Mapeador.Property(a => a.IdDoRomaneioAnimalVivo).HasColumnName("IDDOROMANEIOANIMALVIVO");
			this.Mapeador.Property(a => a.DataFim).HasColumnName("DATAFIM").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.NumeroCurralAtual).HasColumnName("NUMEROCURRALATUAL").HasMaxLength(30);
			this.Mapeador.Property(a => a.NumeroItem).HasColumnName("NUMERO_ITEM");
			this.Mapeador.Property(a => a.ChaveFatoContrato).HasColumnName("CHAVE_FATO_CONTRATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.ChaveFatoRomaneio).HasColumnName("CHAVE_FATO_ROMANEIO").HasMaxLength(20);
			this.Mapeador.Property(a => a.DocumentoRomaneio).HasColumnName("DOCUMENTO_ROMANEIO").HasMaxLength(40);
			this.Mapeador.ToTable("PESORECEBIMENTOPOCILGA"); 
		}
	}
}