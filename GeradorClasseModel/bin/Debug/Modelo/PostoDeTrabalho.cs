namespace aa 
{ 
	public class PostoDeTrabalho  
	{ 
		public string ID { get; set; } 
		public string Nome { get; set; } 
		public string TipoBalanca { get; set; } 
		public string RecursoImpressoraTermica { get; set; } 
		public string PortaImpressoraTermica { get; set; } 
		public string SerieDoVolume { get; set; } 
		public string ProximaSerieDoVolume { get; set; } 
		public string SerieAtivaDoVolume { get; set; } 
		public string TemBalanca { get; set; } 
		public decimal DesvioPadraoEstabilizacaoPesagem { get; set; } 
		public int FatorDivisaoBalanca { get; set; } 
		public string IPBalancaVirtual { get; set; } 
		public int NumeroPesagensPesoEstavel { get; set; } 
		public decimal PesoMinimoExigivelBalanca { get; set; } 
		public string PortaComunicacaoBalanca { get; set; } 
		public string VelocidadeComunicacaoBalanca { get; set; } 
		public int StopBits { get; set; } 
		public int ByteSize { get; set; } 
		public int Paridade { get; set; } 
		public string TemLampadaSinalizacao { get; set; } 
		public string PortaComunicacaoSinalizador { get; set; } 
		public decimal PortaBalancaVirtual { get; set; } 
		public string AcaoEnter { get; set; } 
		public string DesvioPadraoUnidade { get; set; } 
	} 
}