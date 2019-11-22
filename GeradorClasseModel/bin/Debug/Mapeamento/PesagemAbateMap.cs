namespace aa
{
	public class : MapeadorDeEntidade<PesagemAbateMap>
	{
		public PesagemAbateMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Id).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.Sequencia).HasColumnName("SEQUENCIA").IsRequired();
			this.Mapeador.Property(a => a.IDDoProduto).HasColumnName("IDDOPRODUTO").IsRequired().HasMaxLength(20);
			this.Mapeador.Property(a => a.IDDaReferencia).HasColumnName("IDDAREFERENCIA").IsRequired().HasMaxLength(20);
			this.Mapeador.Property(a => a.Peso1).HasColumnName("PESO1").IsRequired();
			this.Mapeador.Property(a => a.Peso2).HasColumnName("PESO2").IsRequired();
			this.Mapeador.Property(a => a.SequenciaContrato).HasColumnName("SEQUENCIACONTRATO").IsRequired();
			this.Mapeador.Property(a => a.Lote).HasColumnName("LOTE").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Sexo).HasColumnName("SEXO").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS").IsRequired();
			this.Mapeador.Property(a => a.DataAbate).HasColumnName("DATAABATE").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataHora).HasColumnName("DATAHORA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.ChaveFatoContrato).HasColumnName("CHAVEFATOCONTRATO").IsRequired().HasMaxLength(20);
			this.Mapeador.Property(a => a.IDDaFilial).HasColumnName("IDDAFILIAL").IsRequired().HasMaxLength(20);
			this.Mapeador.Property(a => a.IdDaClassificaoAnimal).HasColumnName("IDDACLASSIFICAOANIMAL");
			this.Mapeador.Property(a => a.IDDaCamaraFria).HasColumnName("IDDACAMARAFRIA").HasMaxLength(20);
			this.Mapeador.Property(a => a.PesoPorMedia).HasColumnName("PESOPORMEDIA").IsRequired();
			this.Mapeador.Property(a => a.Excecao).HasColumnName("EXCECAO").HasMaxLength(1000);
			this.Mapeador.Property(a => a.CodigoDaExcecao).HasColumnName("CODIGODAEXCECAO").IsRequired();
			this.Mapeador.Property(a => a.IdDaFaixaDePeso).HasColumnName("IDDAFAIXADEPESO");
			this.Mapeador.Property(a => a.DescricaoDaFaixaDaPeso).HasColumnName("DESCRICAODAFAIXADAPESO").HasMaxLength(100);
			this.Mapeador.Property(a => a.DescricaoDaClassificacao).HasColumnName("DESCRICAODACLASSIFICACAO").HasMaxLength(100);
			this.Mapeador.Property(a => a.Produto).HasColumnName("PRODUTO").HasMaxLength(100);
			this.Mapeador.Property(a => a.GuidParaEnvio).HasColumnName("GUIDPARAENVIO").HasMaxLength(40);
			this.Mapeador.Property(a => a.GuidParaEnvioStatus).HasColumnName("GUIDPARAENVIOSTATUS");
			this.Mapeador.Property(a => a.ChaveFatoRomAnimalMorto).HasColumnName("CHAVEFATOROMANIMALMORTO").HasMaxLength(20);
			this.Mapeador.Property(a => a.FinalizouPesagem).HasColumnName("FINALIZOUPESAGEM").IsRequired();
			this.Mapeador.Property(a => a.DocumentoAnimalMorto).HasColumnName("DOCUMENTOANIMALMORTO").HasMaxLength(50);
			this.Mapeador.Property(a => a.ComandoParaAPI).HasColumnName("COMANDOPARAAPI");
			this.Mapeador.Property(a => a.OperacaoSisbov).HasColumnName("OPERACAOSISBOV");
			this.Mapeador.Property(a => a.CodManejo).HasColumnName("CODMANEJO").HasMaxLength(10);
			this.Mapeador.Property(a => a.TentativasDeEnvio).HasColumnName("TENTATIVASDEENVIO");
			this.Mapeador.Property(a => a.TipoDeTemperatura).HasColumnName("TIPODETEMPERATURA").HasMaxLength(3);
			this.Mapeador.Property(a => a.RomaneioStatusContabil).HasColumnName("ROMANEIO_STATUS_CONTABIL").HasMaxLength(5);
			this.Mapeador.Property(a => a.NumeroItem).HasColumnName("NUMERO_ITEM");
			this.Mapeador.Property(a => a.CodigoPostoTrabalho).HasColumnName("CODIGO_POSTO_TRABALHO").HasMaxLength(10);
			this.Mapeador.Property(a => a.Tara).HasColumnName("TARA").HasPrecision(19, 5);
			this.Mapeador.ToTable("PESAGEMABATE"); 
		}
	}
}