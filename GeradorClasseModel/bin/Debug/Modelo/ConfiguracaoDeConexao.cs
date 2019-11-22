namespace aa 
{ 
	public class ConfiguracaoDeConexao  
	{ 
		public int ID { get; set; } 
		public string CodigoPostoDeTrabalho { get; set; } 
		public string Host { get; set; } 
		public string Porta { get; set; } 
		public int TipoConexao { get; set; } 
		public int TipoEquipamento { get; set; } 
		public int TipoAplicacao { get; set; } 
		public string NomeAplicacao { get; set; } 
		public int Ordinal { get; set; } 
		public int StopBit { get; set; } 
		public int ByteSize { get; set; } 
		public int Paridade { get; set; } 
		public int BaudRate { get; set; } 
		public string Descricao { get; set; } 
		public string CodigoEquipamento { get; set; } 
		public string NomeEquipamento { get; set; } 
		public int TipoPorta { get; set; } 
	} 
}