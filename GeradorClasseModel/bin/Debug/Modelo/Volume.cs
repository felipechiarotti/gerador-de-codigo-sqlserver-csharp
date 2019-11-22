namespace aa 
{ 
	public class Volume  
	{ 
		public nchar CodPosto { get; set; } 
		public nchar CodFilial { get; set; } 
		public nchar SerieSeq { get; set; } 
		public nchar Produto { get; set; } 
		public nchar Referencia { get; set; } 
		public DateTime DataProducao { get; set; } 
		public DateTime DataValidade { get; set; } 
		public decimal PesoLiquido { get; set; } 
		public decimal TaraInterna { get; set; } 
		public decimal TaraExterna { get; set; } 
		public decimal PesoBruto { get; set; } 
		public int Usuario { get; set; } 
		public int Quantidade { get; set; } 
		public nchar Romaneio { get; set; } 
		public nchar PostoDeTrabalho { get; set; } 
		public string Erro { get; set; } 
		public DateTime DataApontamento { get; set; } 
		public int Sync { get; set; } 
		public string DescricaoErro { get; set; } 
		public string SeqPreEtiqueta { get; set; } 
		public string Status { get; set; } 
		public int NumeroDoItem { get; set; } 
		public int NumeroDoSubItem { get; set; } 
		public int QuantidadeSacos { get; set; } 
		public int QuantidadePecasSacos { get; set; } 
	} 
}