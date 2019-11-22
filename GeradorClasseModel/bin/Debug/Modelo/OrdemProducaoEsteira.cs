namespace aa 
{ 
	public class OrdemProducaoEsteira  
	{ 
		public int ID { get; set; } 
		public string ChaveFato { get; set; } 
		public string IdFilial { get; set; } 
		public string TipoDeDocumento { get; set; } 
		public string IdSerie { get; set; } 
		public int Numero { get; set; } 
		public string IdLinha { get; set; } 
		public string NomeLinha { get; set; } 
		public int IdDoTurno { get; set; } 
		public string Status { get; set; } 
		public DateTime DataMov { get; set; } 
		public string StatusCtb { get; set; } 
	} 
}