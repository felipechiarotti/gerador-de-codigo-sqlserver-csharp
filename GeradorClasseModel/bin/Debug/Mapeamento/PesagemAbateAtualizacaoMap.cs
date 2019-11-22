namespace aa
{
	public class : MapeadorDeEntidade<PesagemAbateAtualizacaoMap>
	{
		public PesagemAbateAtualizacaoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.Sequencia).HasColumnName("SEQUENCIA");
			this.Mapeador.Property(a => a.SequenciaContrato).HasColumnName("SEQUENCIACONTRATO");
			this.Mapeador.Property(a => a.IDDoProduto).HasColumnName("IDDOPRODUTO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDDaReferencia).HasColumnName("IDDAREFERENCIA").HasMaxLength(20);
			this.Mapeador.Property(a => a.Peso1).HasColumnName("PESO1");
			this.Mapeador.Property(a => a.Peso2).HasColumnName("PESO2");
			this.Mapeador.Property(a => a.Lote).HasColumnName("LOTE").HasMaxLength(10);
			this.Mapeador.Property(a => a.Sexo).HasColumnName("SEXO").HasMaxLength(10);
			this.Mapeador.Property(a => a.ChaveFatoContrato).HasColumnName("CHAVEFATOCONTRATO").HasMaxLength(30);
			this.Mapeador.Property(a => a.ChaveFatoRomAnimalMorto).HasColumnName("CHAVEFATOROMANIMALMORTO").HasMaxLength(30);
			this.Mapeador.Property(a => a.IDDaFilial).HasColumnName("IDDAFILIAL").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDDaClassificaoAnimal).HasColumnName("IDDACLASSIFICAOANIMAL");
			this.Mapeador.Property(a => a.IDDaCamaraFria).HasColumnName("IDDACAMARAFRIA").HasMaxLength(20);
			this.Mapeador.Property(a => a.CodManejo).HasColumnName("CODMANEJO").HasMaxLength(10);
			this.Mapeador.Property(a => a.IDTransferencia).HasColumnName("IDTRANSFERENCIA");
			this.Mapeador.ToTable("PESAGEMABATEATUALIZACAO"); 
		}
	}
}