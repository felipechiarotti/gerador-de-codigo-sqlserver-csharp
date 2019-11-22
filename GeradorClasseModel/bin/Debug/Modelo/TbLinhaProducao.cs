namespace aa 
{ 
	public class TbLinhaProducao  
	{ 
		public int ID { get; set; } 
		public string CodLinha { get; set; } 
		public string NomeLinha { get; set; } 
		public string OrigemMP { get; set; } 
		public string CodTipoMvOpMp { get; set; } 
		public string CodTipoMvOpPa { get; set; } 
		public string CodTipoMvRpMp { get; set; } 
		public string CodTipoMvRpPa { get; set; } 
		public string CodTipoMvOPPq { get; set; } 
		public string CodTipoMvRpPq { get; set; } 
		public decimal PercRendimentoMin { get; set; } 
		public decimal PercRendimentoMax { get; set; } 
		public int PermitePesoMPMaiorPA { get; set; } 
	} 
}