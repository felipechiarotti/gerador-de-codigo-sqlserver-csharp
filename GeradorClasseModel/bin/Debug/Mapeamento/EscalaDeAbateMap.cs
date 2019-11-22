namespace aa
{
	public class : MapeadorDeEntidade<EscalaDeAbateMap>
	{
		public EscalaDeAbateMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IDDaFilial).HasColumnName("IDDAFILIAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.IDDoDocumento).HasColumnName("IDDODOCUMENTO").HasMaxLength(50);
			this.Mapeador.Property(a => a.Serie).HasColumnName("SERIE").HasMaxLength(50);
			this.Mapeador.Property(a => a.Numero).HasColumnName("NUMERO");
			this.Mapeador.Property(a => a.NumeroDoLote).HasColumnName("NUMERODOLOTE");
			this.Mapeador.Property(a => a.NumeroLoteAbate).HasColumnName("NUMEROLOTEABATE").HasMaxLength(50);
			this.Mapeador.Property(a => a.NumeroDoManejo).HasColumnName("NUMERODOMANEJO").HasMaxLength(50);
			this.Mapeador.Property(a => a.ChaveDeFatoSisbov).HasColumnName("CHAVEDEFATOSISBOV").HasMaxLength(50);
			this.Mapeador.Property(a => a.Raca).HasColumnName("RACA").HasMaxLength(50);
			this.Mapeador.Property(a => a.Maturidade).HasColumnName("MATURIDADE").HasMaxLength(50);
			this.Mapeador.Property(a => a.Quantidade).HasColumnName("QUANTIDADE").IsRequired();
			this.Mapeador.Property(a => a.Peso).HasColumnName("PESO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.SequenciaCabeca).HasColumnName("SEQUENCIACABECA").IsRequired();
			this.Mapeador.Property(a => a.DataAbate).HasColumnName("DATAABATE").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataMovimentacao).HasColumnName("DATAMOVIMENTACAO").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.CodigoDaUnidadePrimaria).HasColumnName("CODIGODAUNIDADEPRIMARIA").HasMaxLength(50);
			this.Mapeador.Property(a => a.CodigoDaUnidadeAuxiliar).HasColumnName("CODIGODAUNIDADEAUXILIAR").HasMaxLength(50);
			this.Mapeador.Property(a => a.IDDoProduto).HasColumnName("IDDOPRODUTO").HasMaxLength(50);
			this.Mapeador.Property(a => a.IDDaReferencia).HasColumnName("IDDAREFERENCIA").HasMaxLength(50);
			this.Mapeador.Property(a => a.DescricaoDoProduto).HasColumnName("DESCRICAODOPRODUTO").HasMaxLength(500);
			this.Mapeador.Property(a => a.MercadosHabilitados).HasColumnName("MERCADOSHABILITADOS").HasMaxLength(50);
			this.Mapeador.Property(a => a.MercadoPrincipal).HasColumnName("MERCADOPRINCIPAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.DescricaoMercado).HasColumnName("DESCRICAOMERCADO").HasMaxLength(500);
			this.Mapeador.Property(a => a.ImprimeResumo).HasColumnName("IMPRIMERESUMO").HasMaxLength(500);
			this.Mapeador.Property(a => a.NumeroDoCurral).HasColumnName("NUMERODOCURRAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.HoraInicial).HasColumnName("HORAINICIAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.HoraFinal).HasColumnName("HORAFINAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.TipoAnimal).HasColumnName("TIPOANIMAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.IDDaPropriedadeRural).HasColumnName("IDDAPROPRIEDADERURAL");
			this.Mapeador.Property(a => a.NomeDaPropriedadeRural).HasColumnName("NOMEDAPROPRIEDADERURAL").HasMaxLength(200);
			this.Mapeador.Property(a => a.IDDoMunicipio).HasColumnName("IDDOMUNICIPIO").HasMaxLength(50);
			this.Mapeador.Property(a => a.NomeDoMunicipio).HasColumnName("NOMEDOMUNICIPIO").HasMaxLength(200);
			this.Mapeador.Property(a => a.UF).HasColumnName("UF").HasMaxLength(50);
			this.Mapeador.Property(a => a.QuantidadeDeBois).HasColumnName("QUANTIDADEDEBOIS").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.QuantidadeDeBufalos).HasColumnName("QUANTIDADEDEBUFALOS").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.QuantidadeDeTouros).HasColumnName("QUANTIDADEDETOUROS").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.QuantidadeDeCarneiros).HasColumnName("QUANTIDADEDECARNEIROS").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.QuantidadeDeVacas).HasColumnName("QUANTIDADEDEVACAS").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.QuantidadeDeBubalinas).HasColumnName("QUANTIDADEDEBUBALINAS").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.QuantidadeDeVitelos).HasColumnName("QUANTIDADEDEVITELOS").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.MeioDeTransporte).HasColumnName("MEIODETRANSPORTE").HasMaxLength(200);
			this.Mapeador.Property(a => a.AtestadoSanitario).HasColumnName("ATESTADOSANITARIO").HasMaxLength(200);
			this.Mapeador.Property(a => a.Sexo).HasColumnName("SEXO").HasMaxLength(50);
			this.Mapeador.Property(a => a.IDDoPecuarista).HasColumnName("IDDOPECUARISTA").HasMaxLength(50);
			this.Mapeador.Property(a => a.NomeDoPecuarista).HasColumnName("NOMEDOPECUARISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.SequenciaContrato).HasColumnName("SEQUENCIACONTRATO");
			this.Mapeador.Property(a => a.ApelidoDoPecuarista).HasColumnName("APELIDODOPECUARISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.ApelidoDaPropriedadeRural).HasColumnName("APELIDODAPROPRIEDADERURAL").HasMaxLength(200);
			this.Mapeador.Property(a => a.DataDeEntrada).HasColumnName("DATADEENTRADA").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.QuantidadeRomaneada).HasColumnName("QUANTIDADEROMANEADA");
			this.Mapeador.Property(a => a.UltimaSequenciaRomaneada).HasColumnName("ULTIMASEQUENCIAROMANEADA");
			this.Mapeador.Property(a => a.QuantidadeMacho).HasColumnName("QUANTIDADEMACHO");
			this.Mapeador.Property(a => a.QuantidadeFemea).HasColumnName("QUANTIDADEFEMEA");
			this.Mapeador.Property(a => a.QuantidadeMachoRomaneada).HasColumnName("QUANTIDADEMACHOROMANEADA");
			this.Mapeador.Property(a => a.QuantidadeFemeaRomaneada).HasColumnName("QUANTIDADEFEMEAROMANEADA");
			this.Mapeador.Property(a => a.ChaveFatoRAA).HasColumnName("CHAVEFATORAA").HasMaxLength(30);
			this.Mapeador.Property(a => a.DocumentoRAA).HasColumnName("DOCUMENTORAA").HasMaxLength(50);
			this.Mapeador.Property(a => a.LoteDoItem).HasColumnName("LOTEDOITEM").HasMaxLength(10);
			this.Mapeador.Property(a => a.ChaveFatoAnimalMorto).HasColumnName("CHAVEFATOANIMALMORTO").HasMaxLength(30);
			this.Mapeador.Property(a => a.ChaveRomaneioAbateAnimal).HasColumnName("CHAVEROMANEIOABATEANIMAL").HasMaxLength(30);
			this.Mapeador.Property(a => a.DocumentoRomaneioAbateAnimal).HasColumnName("DOCUMENTOROMANEIOABATEANIMAL").HasMaxLength(30);
			this.Mapeador.Property(a => a.AbatePerfilLinhaDeProducao).HasColumnName("ABATEPERFILLINHADEPRODUCAO");
			this.Mapeador.Property(a => a.RomaneioStatusContabil).HasColumnName("ROMANEIO_STATUS_CONTABIL").HasMaxLength(5);
			this.Mapeador.Property(a => a.NumeroItem).HasColumnName("NUMERO_ITEM");
			this.Mapeador.ToTable("ESCALADEABATE"); 
		}
	}
}