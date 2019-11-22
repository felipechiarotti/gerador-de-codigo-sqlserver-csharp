namespace aa 
{ 
	public class SisBovDIF  
	{ 
		public int IdLocal { get; set; } 
		public int ID { get; set; } 
		public string ChaveFato { get; set; } 
		public int SeqCabeca { get; set; } 
		public string IDOcorrencia { get; set; } 
		public string IDOcorrenciaSif { get; set; } 
		public string IDOcorrencia1 { get; set; } 
		public string IDOcorrencia2 { get; set; } 
		public string IDOcorrencia3 { get; set; } 
		public string IDOcorrencia4 { get; set; } 
		public string IDOcorrencia5 { get; set; } 
		public decimal PesoAntes { get; set; } 
		public decimal PesoDepois { get; set; } 
		public int StatusLocal { get; set; } 
		public string StatusSif { get; set; } 
		public int CodigoDaExcecao { get; set; } 
		public string FilialSelecionada { get; set; } 
		public int NumeroDoLote { get; set; } 
		public DateTime DataHora { get; set; } 
		public DateTime DataAbate { get; set; } 
		public string DocumentoDeOrigem { get; set; } 
		public string MercadosHabilitados { get; set; } 
		public boolean GerarRomaneioAbateCarcaraSequestrada { get; set; } 
		public int SeqCabecaRomaneioAbate { get; set; } 
		public int SeqVolumeRomaneioAbate { get; set; } 
	} 
}