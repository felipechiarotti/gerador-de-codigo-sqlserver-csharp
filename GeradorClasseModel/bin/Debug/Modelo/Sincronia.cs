namespace aa 
{ 
	public class Sincronia  
	{ 
		public long ID { get; set; } 
		public int IDOrigem { get; set; } 
		public int StatusLocal { get; set; } 
		public int StatusComando { get; set; } 
		public string IDDoComando { get; set; } 
		public string IDDoComandoDeEntrada { get; set; } 
		public string Erro { get; set; } 
		public int CodigoErro { get; set; } 
		public DateTime Data { get; set; } 
		public DateTime DataFim { get; set; } 
		public string NomeTabelaOrigem { get; set; } 
		public boolean Iniciou { get; set; } 
		public boolean Finalizou { get; set; } 
		public int TentativasDeEnvio { get; set; } 
		public int CodigoHTTP { get; set; } 
		public int OperacaoComando { get; set; } 
		public DateTime DataUltimaTentativa { get; set; } 
		public int RetentativasDeEnvio { get; set; } 
		public ntext DadoOriginal { get; set; } 
		public int Ordem { get; set; } 
		public int CodigoErroApi { get; set; } 
		public int CodigoFuncao { get; set; } 
		public ntext DadosParaEnvio { get; set; } 
		public string DadosParaEnvioTipo { get; set; } 
		public string UrlHttp { get; set; } 
		public int ModoEnvio { get; set; } 
		public string OrigemAcaoTipo { get; set; } 
		public string OrigemAcaoMetodo { get; set; } 
		public string DadosRetornoTipo { get; set; } 
	} 
}