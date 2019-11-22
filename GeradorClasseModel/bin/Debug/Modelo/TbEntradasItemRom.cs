namespace aa 
{ 
	public class TbEntradasItemRom  
	{ 
		public long ID { get; set; } 
		public int IDEntradasitem { get; set; } 
		public int NumItem { get; set; } 
		public int NumSubItem { get; set; } 
		public int Seq { get; set; } 
		public decimal QtdePri { get; set; } 
		public decimal QtdeAux { get; set; } 
		public string NumLote { get; set; } 
		public decimal PesoLiquidoReal { get; set; } 
		public decimal PesoBruto { get; set; } 
		public string Ean128 { get; set; } 
		public string ChaveFato { get; set; } 
		public DateTime Datahora { get; set; } 
		public long IdVolume { get; set; } 
		public boolean GerarVolume { get; set; } 
		public string Documento { get; set; } 
		public string NumSerieEan { get; set; } 
		public string CodFilialVolume { get; set; } 
		public string SerieVolume { get; set; } 
		public int NumVolume { get; set; } 
		public int OperacaoSincronismo { get; set; } 
		public boolean GerarPacoteCaixa { get; set; } 
		public string CodigoSistemaAnterior { get; set; } 
		public long NumSerieEanValor { get; set; } 
	} 
}