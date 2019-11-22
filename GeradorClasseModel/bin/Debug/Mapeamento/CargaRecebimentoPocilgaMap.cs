namespace aa
{
	public class : MapeadorDeEntidade<CargaRecebimentoPocilgaMap>
	{
		public CargaRecebimentoPocilgaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.ChaveDeFatoDoFrete).HasColumnName("CHAVEDEFATODOFRETE").HasMaxLength(50);
			this.Mapeador.Property(a => a.DataDoMovimento).HasColumnName("DATADOMOVIMENTO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataDeCadastro).HasColumnName("DATADECADASTRO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.SerieDaCarga).HasColumnName("SERIEDACARGA").HasMaxLength(50);
			this.Mapeador.Property(a => a.IdDaFilial).HasColumnName("IDDAFILIAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.NumeroDaCarga).HasColumnName("NUMERODACARGA");
			this.Mapeador.Property(a => a.IdDoMotorista).HasColumnName("IDDOMOTORISTA");
			this.Mapeador.Property(a => a.NomeDoMotorista).HasColumnName("NOMEDOMOTORISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.IDDaPropriedade).HasColumnName("IDDAPROPRIEDADE");
			this.Mapeador.Property(a => a.NomeDaPropriedade).HasColumnName("NOMEDAPROPRIEDADE").HasMaxLength(200);
			this.Mapeador.Property(a => a.Placa).HasColumnName("PLACA").HasMaxLength(20);
			this.Mapeador.Property(a => a.Contrato).HasColumnName("CONTRATO").HasMaxLength(50);
			this.Mapeador.Property(a => a.Romaneio).HasColumnName("ROMANEIO").HasMaxLength(50);
			this.Mapeador.Property(a => a.SelecionadoParaRecebimento).HasColumnName("SELECIONADOPARARECEBIMENTO").IsRequired();
			this.Mapeador.Property(a => a.Finalizado).HasColumnName("FINALIZADO").IsRequired();
			this.Mapeador.Property(a => a.CargaOffLine).HasColumnName("CARGAOFFLINE").IsRequired();
			this.Mapeador.Property(a => a.Sync).HasColumnName("SYNC");
			this.Mapeador.Property(a => a.TentativasDeEnvio).HasColumnName("TENTATIVASDEENVIO");
			this.Mapeador.Property(a => a.ExcecaoDeRetornoDoServico).HasColumnName("EXCECAODERETORNODOSERVICO").HasMaxLength(2000);
			this.Mapeador.Property(a => a.IdSincronismo).HasColumnName("IDSINCRONISMO");
			this.Mapeador.Property(a => a.PesoBalancao).HasColumnName("PESOBALANCAO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.IdPecuarista).HasColumnName("IDPECUARISTA");
			this.Mapeador.Property(a => a.Pecuarista).HasColumnName("PECUARISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.DocumentoFrete).HasColumnName("DOCUMENTOFRETE").HasMaxLength(50);
			this.Mapeador.Property(a => a.DocumentoContrato).HasColumnName("DOCUMENTOCONTRATO").HasMaxLength(50);
			this.Mapeador.Property(a => a.DocumentoRomaneio).HasColumnName("DOCUMENTOROMANEIO").HasMaxLength(50);
			this.Mapeador.Property(a => a.DataAbate).HasColumnName("DATAABATE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataEntrada).HasColumnName("DATAENTRADA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.QuantidadeCabecasPeloGTA).HasColumnName("QUANTIDADECABECASPELOGTA");
			this.Mapeador.Property(a => a.QuantidadeCabecaPelaEscala).HasColumnName("QUANTIDADECABECAPELAESCALA");
			this.Mapeador.Property(a => a.ComandoParaAPI).HasColumnName("COMANDOPARAAPI");
			this.Mapeador.Property(a => a.Lote).HasColumnName("LOTE").HasMaxLength(10);
			this.Mapeador.Property(a => a.IdDoProdutoSelecioando).HasColumnName("IDDOPRODUTOSELECIOANDO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IdDaReferenciaSelecionada).HasColumnName("IDDAREFERENCIASELECIONADA").HasMaxLength(20);
			this.Mapeador.Property(a => a.ApelidoPecuarista).HasColumnName("APELIDOPECUARISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.ApelidoPropriedade).HasColumnName("APELIDOPROPRIEDADE").HasMaxLength(200);
			this.Mapeador.Property(a => a.DataDescarregamento).HasColumnName("DATADESCARREGAMENTO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.ExistePesagemDeEntrada).HasColumnName("EXISTEPESAGEMDEENTRADA");
			this.Mapeador.ToTable("CARGARECEBIMENTOPOCILGA"); 
		}
	}
}