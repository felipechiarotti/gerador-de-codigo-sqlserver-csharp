namespace aa 
{ 
	public class TbEntradas  
	{ 
		public int ID { get; set; } 
		public string ChaveFato { get; set; } 
		public string ChaveFatoOrigUn { get; set; } 
		public string CodTipoMv { get; set; } 
		public string CodLinha { get; set; } 
		public string CodFilial { get; set; } 
		public string CodDocto { get; set; } 
		public string SerieSeq { get; set; } 
		public int NumDocto { get; set; } 
		public int CodCliFor { get; set; } 
		public DateTime DataEstoque { get; set; } 
		public decimal PesoBruto { get; set; } 
		public decimal PesoLiquido { get; set; } 
		public int QtdeItens { get; set; } 
		public int CodFuncionario { get; set; } 
		public boolean Atendido { get; set; } 
		public string StatusCtb { get; set; } 
	} 
}