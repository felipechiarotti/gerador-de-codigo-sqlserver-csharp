namespace aa 
{ 
	public class OrdemProducaoEsteiraItem  
	{ 
		public int ID { get; set; } 
		public int IDOrdem { get; set; } 
		public string ChaveFato { get; set; } 
		public string IDItem { get; set; } 
		public string IDReferencia { get; set; } 
		public int NumeroItem { get; set; } 
		public int NumeroSubItem { get; set; } 
		public decimal SaldoProduzir { get; set; } 
		public string NumeroLote { get; set; } 
		public string ProdutoDescricao { get; set; } 
		public string IdUnidade { get; set; } 
		public decimal QuantidadeProduzir { get; set; } 
		public string CodigoLinha { get; set; } 
		public DateTime DataMovimentacao { get; set; } 
		public string CodigoFilial { get; set; } 
	} 
}