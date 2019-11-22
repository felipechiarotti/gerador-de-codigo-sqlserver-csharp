namespace aa
{
	public class : MapeadorDeEntidade<CargaBalancaRodoviariaMap>
	{
		public CargaBalancaRodoviariaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IDOrigemLocal).HasColumnName("IDORIGEMLOCAL").IsRequired();
			this.Mapeador.Property(a => a.IdDaFilial).HasColumnName("IDDAFILIAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.Placa).HasColumnName("PLACA").HasMaxLength(50);
			this.Mapeador.Property(a => a.IdTipoDoFrete).HasColumnName("IDTIPODOFRETE").HasMaxLength(50);
			this.Mapeador.Property(a => a.Sequencia).HasColumnName("SEQUENCIA");
			this.Mapeador.Property(a => a.DataDeCadastro).HasColumnName("DATADECADASTRO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataDeMovimento).HasColumnName("DATADEMOVIMENTO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Lote).HasColumnName("LOTE").HasMaxLength(50);
			this.Mapeador.Property(a => a.Sexo).HasColumnName("SEXO").HasMaxLength(50);
			this.Mapeador.Property(a => a.IDDoProduto).HasColumnName("IDDOPRODUTO").HasMaxLength(50);
			this.Mapeador.Property(a => a.IDDaReferencia).HasColumnName("IDDAREFERENCIA").HasMaxLength(50);
			this.Mapeador.Property(a => a.NomeDoProduto).HasColumnName("NOMEDOPRODUTO").HasMaxLength(100);
			this.Mapeador.Property(a => a.Observacao).HasColumnName("OBSERVACAO").HasMaxLength(1000);
			this.Mapeador.Property(a => a.Tara).HasColumnName("TARA").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.ChaveDeFatoDoFrete).HasColumnName("CHAVEDEFATODOFRETE").HasMaxLength(50);
			this.Mapeador.Property(a => a.ChaveFatoContrato).HasColumnName("CHAVEFATOCONTRATO").HasMaxLength(50);
			this.Mapeador.Property(a => a.ContratoDocumento).HasColumnName("CONTRATODOCUMENTO").HasMaxLength(50);
			this.Mapeador.Property(a => a.FreteDocumento).HasColumnName("FRETEDOCUMENTO").HasMaxLength(50);
			this.Mapeador.Property(a => a.TipoPeso).HasColumnName("TIPOPESO").HasMaxLength(5);
			this.Mapeador.Property(a => a.GTA).HasColumnName("GTA").HasMaxLength(50);
			this.Mapeador.Property(a => a.NFProdutor).HasColumnName("NFPRODUTOR").HasMaxLength(50);
			this.Mapeador.Property(a => a.CodigoTransportador).HasColumnName("CODIGOTRANSPORTADOR").HasMaxLength(50);
			this.Mapeador.Property(a => a.Modo).HasColumnName("MODO");
			this.Mapeador.Property(a => a.IdDaEntradaDeOrigem).HasColumnName("IDDAENTRADADEORIGEM");
			this.Mapeador.Property(a => a.QuantidadeDeCabecas).HasColumnName("QUANTIDADEDECABECAS").IsRequired();
			this.Mapeador.Property(a => a.NomeDoMotorista).HasColumnName("NOMEDOMOTORISTA").HasMaxLength(300);
			this.Mapeador.Property(a => a.IdSincronismo).HasColumnName("IDSINCRONISMO").IsRequired();
			this.Mapeador.Property(a => a.Enviar).HasColumnName("ENVIAR").IsRequired();
			this.Mapeador.Property(a => a.PesoBalancao).HasColumnName("PESOBALANCAO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.CodMotorista).HasColumnName("CODMOTORISTA");
			this.Mapeador.Property(a => a.TipoVeiculo).HasColumnName("TIPOVEICULO").HasMaxLength(10);
			this.Mapeador.Property(a => a.Pecuarista).HasColumnName("PECUARISTA").HasMaxLength(100);
			this.Mapeador.Property(a => a.PropriedadeRural).HasColumnName("PROPRIEDADERURAL").HasMaxLength(100);
			this.Mapeador.Property(a => a.DataEntrada).HasColumnName("DATAENTRADA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataAbate).HasColumnName("DATAABATE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataHoraFim).HasColumnName("DATAHORAFIM").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.CodItemCarga).HasColumnName("CODITEMCARGA");
			this.Mapeador.Property(a => a.NomeItemCarga).HasColumnName("NOMEITEMCARGA").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeTransportador).HasColumnName("NOMETRANSPORTADOR").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomePecuarista).HasColumnName("NOMEPECUARISTA").HasMaxLength(255);
			this.Mapeador.ToTable("CARGABALANCARODOVIARIA"); 
		}
	}
}