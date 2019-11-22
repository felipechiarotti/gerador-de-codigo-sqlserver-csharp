namespace aa 
{ 
	public class FaixaDePeso  
	{ 
		public int IdLocal { get; set; } 
		public int IdProdutoLocal { get; set; } 
		public string CodProduto { get; set; } 
		public string CodReferencia { get; set; } 
		public int NumeroDaFaixa { get; set; } 
		public string DescricaoDaFaixa { get; set; } 
		public decimal PesoInicial { get; set; } 
		public decimal PesoFinal { get; set; } 
		public int IDDaClassificao { get; set; } 
	} 
}