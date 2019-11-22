namespace aa
{
	public class : MapeadorDeEntidade<PostoDeTrabalhoMap>
	{
		public PostoDeTrabalhoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.TipoBalanca).HasColumnName("TIPOBALANCA").HasMaxLength(50);
			this.Mapeador.Property(a => a.RecursoImpressoraTermica).HasColumnName("RECURSOIMPRESSORATERMICA").HasMaxLength(100);
			this.Mapeador.Property(a => a.PortaImpressoraTermica).HasColumnName("PORTAIMPRESSORATERMICA").HasMaxLength(10);
			this.Mapeador.Property(a => a.SerieDoVolume).HasColumnName("SERIEDOVOLUME").HasMaxLength(10);
			this.Mapeador.Property(a => a.ProximaSerieDoVolume).HasColumnName("PROXIMASERIEDOVOLUME").HasMaxLength(10);
			this.Mapeador.Property(a => a.SerieAtivaDoVolume).HasColumnName("SERIEATIVADOVOLUME").HasMaxLength(10);
			this.Mapeador.Property(a => a.TemBalanca).HasColumnName("TEMBALANCA").HasMaxLength(10);
			this.Mapeador.Property(a => a.DesvioPadraoEstabilizacaoPesagem).HasColumnName("DESVIOPADRAOESTABILIZACAOPESAGEM").HasPrecision(15, 7);
			this.Mapeador.Property(a => a.FatorDivisaoBalanca).HasColumnName("FATORDIVISAOBALANCA");
			this.Mapeador.Property(a => a.IPBalancaVirtual).HasColumnName("IPBALANCAVIRTUAL").HasMaxLength(50);
			this.Mapeador.Property(a => a.NumeroPesagensPesoEstavel).HasColumnName("NUMEROPESAGENSPESOESTAVEL");
			this.Mapeador.Property(a => a.PesoMinimoExigivelBalanca).HasColumnName("PESOMINIMOEXIGIVELBALANCA").HasPrecision(15, 7);
			this.Mapeador.Property(a => a.PortaComunicacaoBalanca).HasColumnName("PORTACOMUNICACAOBALANCA").HasMaxLength(10);
			this.Mapeador.Property(a => a.VelocidadeComunicacaoBalanca).HasColumnName("VELOCIDADECOMUNICACAOBALANCA").HasMaxLength(20);
			this.Mapeador.Property(a => a.StopBits).HasColumnName("STOPBITS");
			this.Mapeador.Property(a => a.ByteSize).HasColumnName("BYTESIZE");
			this.Mapeador.Property(a => a.Paridade).HasColumnName("PARIDADE");
			this.Mapeador.Property(a => a.TemLampadaSinalizacao).HasColumnName("TEMLAMPADASINALIZACAO").HasMaxLength(10);
			this.Mapeador.Property(a => a.PortaComunicacaoSinalizador).HasColumnName("PORTACOMUNICACAOSINALIZADOR").HasMaxLength(10);
			this.Mapeador.Property(a => a.PortaBalancaVirtual).HasColumnName("PORTABALANCAVIRTUAL");
			this.Mapeador.Property(a => a.AcaoEnter).HasColumnName("ACAO_ENTER").HasMaxLength(5);
			this.Mapeador.Property(a => a.DesvioPadraoUnidade).HasColumnName("DESVIO_PADRAO_UNIDADE").HasMaxLength(5);
			this.Mapeador.ToTable("POSTODETRABALHO"); 
		}
	}
}