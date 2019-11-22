namespace aa 
{ 
	public class Sincronismo  
	{ 
		public int ID { get; set; } 
		public int Sync { get; set; } 
		public int Modo { get; set; } 
		public int TentativasDeEnvio { get; set; } 
		public DateTime HorarioDaUltimaTentativa { get; set; } 
		public DateTime Data { get; set; } 
		public string TabelaDeOrigem { get; set; } 
		public string Excecao { get; set; } 
		public int OrdemDeEnvio { get; set; } 
	} 
}