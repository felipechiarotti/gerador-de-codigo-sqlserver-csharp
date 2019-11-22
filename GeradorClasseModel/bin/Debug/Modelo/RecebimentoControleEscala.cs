namespace aa 
{ 
	public class RecebimentoControleEscala  
	{ 
		public int Id { get; set; } 
		public string ChaveFatoContrato { get; set; } 
		public string ChaveFatoEscala { get; set; } 
		public string DocumentoEscala { get; set; } 
		public string DocumentoContrato { get; set; } 
		public DateTime DataAbate { get; set; } 
		public int Modo { get; set; } 
		public int Status { get; set; } 
		public int Sequencia { get; set; } 
		public decimal Quantidade { get; set; } 
		public int NumItem { get; set; } 
		public string LoteSif { get; set; } 
		public string LoteAbate { get; set; } 
		public string CodigoFilial { get; set; } 
	} 
}