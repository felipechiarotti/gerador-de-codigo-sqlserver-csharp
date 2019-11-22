namespace aa
{
	public class : MapeadorDeEntidade<VolumeAbateMap>
	{
		public VolumeAbateMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IDLocal).HasColumnName("IDLOCAL").IsRequired();
			this.Mapeador.Property(a => a.IdDaPesagemAbate).HasColumnName("IDDAPESAGEMABATE");
			this.Mapeador.Property(a => a.CodFilial).HasColumnName("CODFILIAL").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.SerieVolume).HasColumnName("SERIEVOLUME").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.NumeroDoVolume).HasColumnName("NUMERODOVOLUME").IsRequired();
			this.Mapeador.Property(a => a.TipoAnimal).HasColumnName("TIPOANIMAL").HasMaxLength(10);
			this.Mapeador.Property(a => a.AprovacaoContaminacao).HasColumnName("APROVACAOCONTAMINACAO").HasMaxLength(5);
			this.Mapeador.Property(a => a.AprovacaoReligiosa).HasColumnName("APROVACAORELIGIOSA").HasMaxLength(5);
			this.Mapeador.Property(a => a.Banda).HasColumnName("BANDA").HasMaxLength(5);
			this.Mapeador.Property(a => a.ChaveDeFatoDoAbate).HasColumnName("CHAVEDEFATODOABATE").HasMaxLength(20);
			this.Mapeador.Property(a => a.CodigoDaReferenciaDoItem).HasColumnName("CODIGODAREFERENCIADOITEM").HasMaxLength(20);
			this.Mapeador.Property(a => a.CodigoDoItem).HasColumnName("CODIGODOITEM").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodigoPrecoce).HasColumnName("CODIGOPRECOCE").HasMaxLength(10);
			this.Mapeador.Property(a => a.DataProducao).HasColumnName("DATAPRODUCAO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataValidade).HasColumnName("DATAVALIDADE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Hora).HasColumnName("HORA").HasMaxLength(10);
			this.Mapeador.Property(a => a.CheckSum).HasColumnName("CHECKSUM").HasMaxLength(5);
			this.Mapeador.Property(a => a.IdDoFuncionario).HasColumnName("IDDOFUNCIONARIO").HasMaxLength(10);
			this.Mapeador.Property(a => a.IdSisbov).HasColumnName("IDSISBOV");
			this.Mapeador.Property(a => a.LayoutEtiqueta).HasColumnName("LAYOUTETIQUETA");
			this.Mapeador.Property(a => a.Mercadosabate).HasColumnName("MERCADOSABATE").HasMaxLength(200);
			this.Mapeador.Property(a => a.MercadosHabilitados).HasColumnName("MERCADOSHABILITADOS").HasMaxLength(200);
			this.Mapeador.Property(a => a.NomeItem).HasColumnName("NOMEITEM").HasMaxLength(100);
			this.Mapeador.Property(a => a.NumeroDoItem).HasColumnName("NUMERODOITEM");
			this.Mapeador.Property(a => a.NumeroDoSubItem).HasColumnName("NUMERODOSUBITEM");
			this.Mapeador.Property(a => a.PesoBruto).HasColumnName("PESOBRUTO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoBrutoReal).HasColumnName("PESOBRUTOREAL").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoLiquido).HasColumnName("PESOLIQUIDO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoLiquidoReal).HasColumnName("PESOLIQUIDOREAL").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.QuantidadeDeSacos).HasColumnName("QUANTIDADEDESACOS");
			this.Mapeador.Property(a => a.SequenciaCabeca).HasColumnName("SEQUENCIACABECA");
			this.Mapeador.Property(a => a.TaraExterna).HasColumnName("TARAEXTERNA").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.TaraInterna).HasColumnName("TARAINTERNA").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.SequenciaDaEstrutura).HasColumnName("SEQUENCIADAESTRUTURA");
			this.Mapeador.Property(a => a.NumeroLote).HasColumnName("NUMEROLOTE").HasMaxLength(20);
			this.Mapeador.Property(a => a.Localizacao).HasColumnName("LOCALIZACAO").HasMaxLength(20);
			this.Mapeador.Property(a => a.Ph).HasColumnName("PH").HasPrecision(10, 4);
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodGrupoRendimento).HasColumnName("CODGRUPORENDIMENTO").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodManejo).HasColumnName("COD_MANEJO").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodCamara).HasColumnName("COD_CAMARA").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodRaca).HasColumnName("COD_RACA").HasMaxLength(10);
			this.Mapeador.Property(a => a.Sexo).HasColumnName("SEXO").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodMaturidade).HasColumnName("COD_MATURIDADE").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodConformacao).HasColumnName("COD_CONFORMACAO").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodCobertura).HasColumnName("COD_COBERTURA").HasMaxLength(10);
			this.Mapeador.Property(a => a.DocumentoRomAbateAnimal).HasColumnName("DOCUMENTOROMABATEANIMAL").HasMaxLength(30);
			this.Mapeador.Property(a => a.Rastreabilidade).HasColumnName("RASTREABILIDADE").HasMaxLength(40);
			this.Mapeador.Property(a => a.CodClassificacao).HasColumnName("COD_CLASSIFICACAO");
			this.Mapeador.Property(a => a.NumDoctoContrato).HasColumnName("NUM_DOCTO_CONTRATO");
			this.Mapeador.Property(a => a.NumDoctoRomaneio).HasColumnName("NUM_DOCTO_ROMANEIO");
			this.Mapeador.Property(a => a.TipoDeTemperatura).HasColumnName("TIPODETEMPERATURA").HasMaxLength(3);
			this.Mapeador.Property(a => a.DescricaoDaClassificacao).HasColumnName("DESCRICAODACLASSIFICACAO").HasMaxLength(25);
			this.Mapeador.Property(a => a.IdMeiaCarcaca).HasColumnName("IDMEIACARCACA").HasMaxLength(20);
			this.Mapeador.Property(a => a.DescricaoProdutoNF).HasColumnName("DESCRICAOPRODUTONF").HasMaxLength(60);
			this.Mapeador.Property(a => a.DescricaoProdutoRot).HasColumnName("DESCRICAOPRODUTOROT").HasMaxLength(60);
			this.Mapeador.Property(a => a.SequenciaSisbov).HasColumnName("SEQUENCIA_SISBOV");
			this.Mapeador.Property(a => a.MeiaCarcacaPesoLiquido).HasColumnName("MEIA_CARCACA_PESO_LIQUIDO").HasPrecision(19, 5);
			this.Mapeador.Property(a => a.MeiaCarcacaPesoBruto).HasColumnName("MEIA_CARCACA_PESO_BRUTO").HasPrecision(19, 5);
			this.Mapeador.Property(a => a.SifDipoa).HasColumnName("SIFDIPOA").HasMaxLength(255);
			this.Mapeador.Property(a => a.Sif).HasColumnName("SIF").HasMaxLength(255);
			this.Mapeador.ToTable("VOLUMEABATE"); 
		}
	}
}