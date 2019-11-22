namespace aa 
{ 
	public class RecebimentoControleEscalaItem  
	{ 
		public int Id { get; set; } 
		public string RomaneioAnimalChaveFato { get; set; } 
		public string RomaneioAnimalDocumento { get; set; } 
		public int RomaneioAnimalNumItem { get; set; } 
		public string RomaneioAnimalCodigoProduto { get; set; } 
		public string RomaneioAnimalCodigoReferencia { get; set; } 
		public string RomaneioAnimalProdutoNome { get; set; } 
		public string RomaneioAnimalLote { get; set; } 
		public string RomaneioAnimalCurral { get; set; } 
		public decimal RomaneioAnimalQuantidade { get; set; } 
		public decimal RomaneioAnimalPeso { get; set; } 
		public decimal RomaneioAnimalPrevisto { get; set; } 
		public decimal RomaneioAnimalRestante { get; set; } 
		public string EscalaChaveFato { get; set; } 
		public int EscalaIdLocal { get; set; } 
		public DateTime EscalaDataAbate { get; set; } 
		public int Sequencia { get; set; } 
		public boolean Selecionado { get; set; } 
		public int IdOrigem { get; set; } 
	} 
}