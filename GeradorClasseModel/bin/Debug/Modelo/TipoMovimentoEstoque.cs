namespace aa 
{ 
	public class TipoMovimentoEstoque  
	{ 
		public string ID { get; set; } 
		public string Descricao { get; set; } 
		public string PerfilMovimento { get; set; } 
		public string TestaDocumentoOrigem { get; set; } 
		public string ImportaItemDocumentoOrigem { get; set; } 
		public string ForcaSequenciaAutomatica { get; set; } 
		public string UsaDocumentoRelacionado { get; set; } 
		public string ExigeDocumentoRelacionado { get; set; } 
	} 
}