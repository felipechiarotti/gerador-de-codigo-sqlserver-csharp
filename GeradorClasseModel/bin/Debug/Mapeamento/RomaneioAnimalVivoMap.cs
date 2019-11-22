namespace aa
{
	public class : MapeadorDeEntidade<RomaneioAnimalVivoMap>
	{
		public RomaneioAnimalVivoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.Placa).HasColumnName("PLACA").HasMaxLength(20);
			this.Mapeador.Property(a => a.ChaveDeFatoDoRomaneio).HasColumnName("CHAVEDEFATODOROMANEIO").HasMaxLength(50);
			this.Mapeador.Property(a => a.DocumentoRomaneio).HasColumnName("DOCUMENTOROMANEIO").HasMaxLength(50);
			this.Mapeador.Property(a => a.IdDoPecuarista).HasColumnName("IDDOPECUARISTA");
			this.Mapeador.Property(a => a.NomePecuarista).HasColumnName("NOMEPECUARISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.ApelidoPecuarista).HasColumnName("APELIDOPECUARISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.IdDaPropriedadeRural).HasColumnName("IDDAPROPRIEDADERURAL");
			this.Mapeador.Property(a => a.NomePropriedadeRural).HasColumnName("NOMEPROPRIEDADERURAL").HasMaxLength(200);
			this.Mapeador.Property(a => a.ApelidoPropriedadeRural).HasColumnName("APELIDOPROPRIEDADERURAL").HasMaxLength(200);
			this.Mapeador.Property(a => a.ChaveDeFatoDoFrete).HasColumnName("CHAVEDEFATODOFRETE").HasMaxLength(50);
			this.Mapeador.Property(a => a.DocumentoFrete).HasColumnName("DOCUMENTOFRETE").HasMaxLength(200);
			this.Mapeador.Property(a => a.DataDoMovimento).HasColumnName("DATADOMOVIMENTO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataDeAbate).HasColumnName("DATADEABATE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataHora).HasColumnName("DATAHORA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Finalizado).HasColumnName("FINALIZADO").IsRequired();
			this.Mapeador.Property(a => a.CargaOffLine).HasColumnName("CARGAOFFLINE").IsRequired();
			this.Mapeador.Property(a => a.Sync).HasColumnName("SYNC").IsRequired();
			this.Mapeador.Property(a => a.TentativasDeEnvio).HasColumnName("TENTATIVASDEENVIO");
			this.Mapeador.Property(a => a.ExcecaoDeRetornoDoServico).HasColumnName("EXCECAODERETORNODOSERVICO").HasMaxLength(2000);
			this.Mapeador.Property(a => a.PesoBalancao).HasColumnName("PESOBALANCAO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.ChaveFatoEscala).HasColumnName("CHAVEFATOESCALA").HasMaxLength(50);
			this.Mapeador.Property(a => a.DocumentoEscala).HasColumnName("DOCUMENTOESCALA").HasMaxLength(50);
			this.Mapeador.Property(a => a.Lote).HasColumnName("LOTE").HasMaxLength(10);
			this.Mapeador.Property(a => a.ComandoParaAPI).HasColumnName("COMANDOPARAAPI");
			this.Mapeador.Property(a => a.IdDoProdutoSelecionado).HasColumnName("IDDOPRODUTOSELECIONADO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IdDaReferenciaSelecionada).HasColumnName("IDDAREFERENCIASELECIONADA").HasMaxLength(20);
			this.Mapeador.Property(a => a.SelecionadoParaRecebimento).HasColumnName("SELECIONADOPARARECEBIMENTO").IsRequired();
			this.Mapeador.Property(a => a.GTA).HasColumnName("GTA").HasMaxLength(50);
			this.Mapeador.Property(a => a.QuantCabecas).HasColumnName("QUANTCABECAS");
			this.Mapeador.Property(a => a.NF).HasColumnName("NF").HasMaxLength(50);
			this.Mapeador.Property(a => a.NomeDoMotorista).HasColumnName("NOMEDOMOTORISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.IdDaFilial).HasColumnName("IDDAFILIAL").HasMaxLength(10);
			this.Mapeador.Property(a => a.IdDoTransporador).HasColumnName("IDDOTRANSPORADOR");
			this.Mapeador.Property(a => a.NomeTransportador).HasColumnName("NOMETRANSPORTADOR").HasMaxLength(100);
			this.Mapeador.Property(a => a.ApelidoTransportador).HasColumnName("APELIDOTRANSPORTADOR").HasMaxLength(100);
			this.Mapeador.Property(a => a.GUID).HasColumnName("GUID").HasMaxLength(60);
			this.Mapeador.Property(a => a.GUIDStatus).HasColumnName("GUIDSTATUS");
			this.Mapeador.Property(a => a.Iniciado).HasColumnName("INICIADO");
			this.Mapeador.Property(a => a.GUIDEntrada).HasColumnName("GUIDENTRADA").HasMaxLength(60);
			this.Mapeador.Property(a => a.GUIDModoDeEnvio).HasColumnName("GUIDMODODEENVIO");
			this.Mapeador.Property(a => a.LoteDigitado).HasColumnName("LOTEDIGITADO");
			this.Mapeador.Property(a => a.CodMotorista).HasColumnName("CODMOTORISTA");
			this.Mapeador.Property(a => a.GerouEscalaEhFrete).HasColumnName("GEROUESCALAEHFRETE");
			this.Mapeador.Property(a => a.GrupoRendimentoSelecionado).HasColumnName("GRUPORENDIMENTOSELECIONADO").HasMaxLength(10);
			this.Mapeador.Property(a => a.DataFim).HasColumnName("DATAFIM").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.ServicoOcupado).HasColumnName("SERVICOOCUPADO");
			this.Mapeador.Property(a => a.Turno).HasColumnName("TURNO");
			this.Mapeador.ToTable("ROMANEIOANIMALVIVO"); 
		}
	}
}