namespace aa 
{ 
	public class TbEntradasItem  
	{ 
		public int ID { get; set; } 
		public int IDEntradas { get; set; } 
		public string CodFilial { get; set; } 
		public string CodLocal { get; set; } 
		public int NumItem { get; set; } 
		public int NumSubItem { get; set; } 
		public int NumItemOrig { get; set; } 
		public int NumSubitemOrig { get; set; } 
		public string NumLote { get; set; } 
		public string CodProduto { get; set; } 
		public string CodRef { get; set; } 
		public decimal QtdePri { get; set; } 
		public decimal QtdeAux { get; set; } 
		public decimal QtdePriFilhos { get; set; } 
		public decimal QtdeAuxFilhos { get; set; } 
		public decimal PesoMinimo { get; set; } 
		public decimal PesoMaximo { get; set; } 
		public decimal PesoBruto { get; set; } 
		public decimal PesoLiquido { get; set; } 
		public int OrigemDeProducao { get; set; } 
		public decimal SaldoProduzir { get; set; } 
		public string ChaveFato { get; set; } 
		public string ProdutoDescricao { get; set; } 
		public string ProdutoGTIN { get; set; } 
		public string CodUnidade { get; set; } 
		public boolean Atendido { get; set; } 
	} 
}