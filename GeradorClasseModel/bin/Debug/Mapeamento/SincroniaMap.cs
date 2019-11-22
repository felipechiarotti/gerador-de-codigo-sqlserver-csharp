namespace aa
{
	public class : MapeadorDeEntidade<SincroniaMap>
	{
		public SincroniaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IDOrigem).HasColumnName("IDORIGEM");
			this.Mapeador.Property(a => a.StatusLocal).HasColumnName("STATUSLOCAL");
			this.Mapeador.Property(a => a.StatusComando).HasColumnName("STATUSCOMANDO");
			this.Mapeador.Property(a => a.IDDoComando).HasColumnName("IDDOCOMANDO").HasMaxLength(100);
			this.Mapeador.Property(a => a.IDDoComandoDeEntrada).HasColumnName("IDDOCOMANDODEENTRADA").HasMaxLength(100);
			this.Mapeador.Property(a => a.Erro).HasColumnName("ERRO").HasMaxLength(2000);
			this.Mapeador.Property(a => a.CodigoErro).HasColumnName("CODIGOERRO");
			this.Mapeador.Property(a => a.Data).HasColumnName("DATA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataFim).HasColumnName("DATAFIM").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.NomeTabelaOrigem).HasColumnName("NOMETABELAORIGEM").HasMaxLength(200);
			this.Mapeador.Property(a => a.Iniciou).HasColumnName("INICIOU");
			this.Mapeador.Property(a => a.Finalizou).HasColumnName("FINALIZOU");
			this.Mapeador.Property(a => a.TentativasDeEnvio).HasColumnName("TENTATIVASDEENVIO");
			this.Mapeador.Property(a => a.CodigoHTTP).HasColumnName("CODIGOHTTP");
			this.Mapeador.Property(a => a.OperacaoComando).HasColumnName("OPERACAOCOMANDO");
			this.Mapeador.Property(a => a.DataUltimaTentativa).HasColumnName("DATAULTIMATENTATIVA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.RetentativasDeEnvio).HasColumnName("RETENTATIVASDEENVIO");
			this.Mapeador.Property(a => a.DadoOriginal).HasColumnName("DADOORIGINAL").HasMaxLength(536870911);
			this.Mapeador.Property(a => a.Ordem).HasColumnName("ORDEM");
			this.Mapeador.Property(a => a.CodigoErroApi).HasColumnName("CODIGO_ERRO_API");
			this.Mapeador.Property(a => a.CodigoFuncao).HasColumnName("CODIGO_FUNCAO");
			this.Mapeador.Property(a => a.DadosParaEnvio).HasColumnName("DADOS_PARA_ENVIO").HasMaxLength(536870911);
			this.Mapeador.Property(a => a.DadosParaEnvioTipo).HasColumnName("DADOS_PARA_ENVIO_TIPO").HasMaxLength(100);
			this.Mapeador.Property(a => a.UrlHttp).HasColumnName("URL_HTTP").HasMaxLength(100);
			this.Mapeador.Property(a => a.ModoEnvio).HasColumnName("MODO_ENVIO");
			this.Mapeador.Property(a => a.OrigemAcaoTipo).HasColumnName("ORIGEM_ACAO_TIPO").HasMaxLength(100);
			this.Mapeador.Property(a => a.OrigemAcaoMetodo).HasColumnName("ORIGEM_ACAO_METODO").HasMaxLength(100);
			this.Mapeador.Property(a => a.DadosRetornoTipo).HasColumnName("DADOS_RETORNO_TIPO").HasMaxLength(100);
			this.Mapeador.ToTable("SINCRONIA"); 
		}
	}
}