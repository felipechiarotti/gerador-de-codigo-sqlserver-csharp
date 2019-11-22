namespace aa
{
	public class : MapeadorDeEntidade<EscalaAbateApiMap>
	{
		public EscalaAbateApiMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Id).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IdFilial).HasColumnName("ID_FILIAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.IdDocumento).HasColumnName("ID_DOCUMENTO").HasMaxLength(50);
			this.Mapeador.Property(a => a.Serie).HasColumnName("SERIE").HasMaxLength(50);
			this.Mapeador.Property(a => a.Numero).HasColumnName("NUMERO");
			this.Mapeador.Property(a => a.NumeroLote).HasColumnName("NUMERO_LOTE");
			this.Mapeador.Property(a => a.NumeroLoteAbate).HasColumnName("NUMERO_LOTE_ABATE").HasMaxLength(50);
			this.Mapeador.Property(a => a.NumeroManejo).HasColumnName("NUMERO_MANEJO").HasMaxLength(50);
			this.Mapeador.Property(a => a.ChaveFatoSisbov).HasColumnName("CHAVE_FATO_SISBOV").HasMaxLength(50);
			this.Mapeador.Property(a => a.Raca).HasColumnName("RACA").HasMaxLength(50);
			this.Mapeador.Property(a => a.Maturidade).HasColumnName("MATURIDADE").HasMaxLength(50);
			this.Mapeador.Property(a => a.Quantidade).HasColumnName("QUANTIDADE").IsRequired();
			this.Mapeador.Property(a => a.Peso).HasColumnName("PESO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.SequenciaCabeca).HasColumnName("SEQUENCIA_CABECA").IsRequired();
			this.Mapeador.Property(a => a.DataAbate).HasColumnName("DATA_ABATE").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataMovimentacao).HasColumnName("DATA_MOVIMENTACAO").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.CodigoUnidadePrimaria).HasColumnName("CODIGO_UNIDADE_PRIMARIA").HasMaxLength(50);
			this.Mapeador.Property(a => a.CodigoUnidadeAuxiliar).HasColumnName("CODIGO_UNIDADE_AUXILIAR").HasMaxLength(50);
			this.Mapeador.Property(a => a.IdProduto).HasColumnName("ID_PRODUTO").HasMaxLength(50);
			this.Mapeador.Property(a => a.IdReferencia).HasColumnName("ID_REFERENCIA").HasMaxLength(50);
			this.Mapeador.Property(a => a.DescricaoProduto).HasColumnName("DESCRICAO_PRODUTO").HasMaxLength(500);
			this.Mapeador.Property(a => a.MercadosHabilitados).HasColumnName("MERCADOS_HABILITADOS").HasMaxLength(50);
			this.Mapeador.Property(a => a.MercadoPrincipal).HasColumnName("MERCADO_PRINCIPAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.DescricaoMercado).HasColumnName("DESCRICAO_MERCADO").HasMaxLength(500);
			this.Mapeador.Property(a => a.ImprimeResumo).HasColumnName("IMPRIME_RESUMO").HasMaxLength(500);
			this.Mapeador.Property(a => a.NumeroCurral).HasColumnName("NUMERO_CURRAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.HoraInicial).HasColumnName("HORA_INICIAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.HoraFinal).HasColumnName("HORA_FINAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.TipoAnimal).HasColumnName("TIPO_ANIMAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.IdPropriedadeRural).HasColumnName("ID_PROPRIEDADE_RURAL");
			this.Mapeador.Property(a => a.NomePropriedadeRural).HasColumnName("NOME_PROPRIEDADE_RURAL").HasMaxLength(200);
			this.Mapeador.Property(a => a.IdMunicipio).HasColumnName("ID_MUNICIPIO").HasMaxLength(50);
			this.Mapeador.Property(a => a.NomeMunicipio).HasColumnName("NOME_MUNICIPIO").HasMaxLength(200);
			this.Mapeador.Property(a => a.Uf).HasColumnName("UF").HasMaxLength(50);
			this.Mapeador.Property(a => a.MeioTransporte).HasColumnName("MEIO_TRANSPORTE").HasMaxLength(200);
			this.Mapeador.Property(a => a.AtestadoSanitario).HasColumnName("ATESTADO_SANITARIO").HasMaxLength(200);
			this.Mapeador.Property(a => a.Sexo).HasColumnName("SEXO").HasMaxLength(50);
			this.Mapeador.Property(a => a.IdPecuarista).HasColumnName("ID_PECUARISTA").HasMaxLength(50);
			this.Mapeador.Property(a => a.NomePecuarista).HasColumnName("NOME_PECUARISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.SequenciaContrato).HasColumnName("SEQUENCIA_CONTRATO");
			this.Mapeador.Property(a => a.ApelidoPecuarista).HasColumnName("APELIDO_PECUARISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.ApelidoPropriedadeRural).HasColumnName("APELIDO_PROPRIEDADE_RURAL").HasMaxLength(200);
			this.Mapeador.Property(a => a.DataEntrada).HasColumnName("DATA_ENTRADA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.AbatePerfilLinhaProducao).HasColumnName("ABATE_PERFIL_LINHA_PRODUCAO");
			this.Mapeador.Property(a => a.DocumentoRomaneioAbateAnimal).HasColumnName("DOCUMENTO_ROMANEIO_ABATE_ANIMAL").HasMaxLength(30);
			this.Mapeador.Property(a => a.ChaveFatoRomaneioAbateAnimal).HasColumnName("CHAVE_FATO_ROMANEIO_ABATE_ANIMAL").HasMaxLength(30);
			this.Mapeador.Property(a => a.ChaveFatoAnimalMorto).HasColumnName("CHAVE_FATO_ANIMAL_MORTO").HasMaxLength(30);
			this.Mapeador.Property(a => a.LoteItem).HasColumnName("LOTE_ITEM").HasMaxLength(10);
			this.Mapeador.Property(a => a.ChaveFatoRaa).HasColumnName("CHAVE_FATO_RAA").HasMaxLength(30);
			this.Mapeador.Property(a => a.DocumentoRaa).HasColumnName("DOCUMENTO_RAA").HasMaxLength(50);
			this.Mapeador.Property(a => a.QuantidadeMacho).HasColumnName("QUANTIDADE_MACHO");
			this.Mapeador.Property(a => a.QuantidadeFemea).HasColumnName("QUANTIDADE_FEMEA");
			this.Mapeador.Property(a => a.QuantidadeMachoRomaneada).HasColumnName("QUANTIDADE_MACHO_ROMANEADA");
			this.Mapeador.Property(a => a.QuantidadeFemeaRomaneada).HasColumnName("QUANTIDADE_FEMEA_ROMANEADA");
			this.Mapeador.Property(a => a.UltimaSequenciaRomaneada).HasColumnName("ULTIMA_SEQUENCIA_ROMANEADA");
			this.Mapeador.Property(a => a.QuantidadeRomaneada).HasColumnName("QUANTIDADE_ROMANEADA");
			this.Mapeador.Property(a => a.RomaneioStatusContabil).HasColumnName("ROMANEIO_STATUS_CONTABIL").HasMaxLength(5);
			this.Mapeador.Property(a => a.NumeroItem).HasColumnName("NUMERO_ITEM");
			this.Mapeador.ToTable("ESCALAABATEAPI"); 
		}
	}
}