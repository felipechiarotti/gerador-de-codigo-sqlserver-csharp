namespace aa 
{ 
	public class TbVolume  
	{ 
		public long ID { get; set; } 
		public string GUID { get; set; } 
		public string CodFilial { get; set; } 
		public string SerieVolume { get; set; } 
		public int NumVolume { get; set; } 
		public string TipoAnimal { get; set; } 
		public int LayoutEtiqueta { get; set; } 
		public string CodigoPrecoce { get; set; } 
		public string CodigoItem { get; set; } 
		public string CodigoReferencia { get; set; } 
		public string NomeProduto { get; set; } 
		public DateTime DataProducao { get; set; } 
		public DateTime DataValidade { get; set; } 
		public DateTime DataCongelamento { get; set; } 
		public DateTime DataMaturacao { get; set; } 
		public decimal PesoLiquido { get; set; } 
		public decimal PesoBruto { get; set; } 
		public decimal TaraInterna { get; set; } 
		public decimal TaraExterna { get; set; } 
		public string Status { get; set; } 
		public string SeriePallet { get; set; } 
		public int NumeroPallet { get; set; } 
		public string Localizacao { get; set; } 
		public string NumeroLote { get; set; } 
		public decimal QuantidadePrimariaX { get; set; } 
	} 
}