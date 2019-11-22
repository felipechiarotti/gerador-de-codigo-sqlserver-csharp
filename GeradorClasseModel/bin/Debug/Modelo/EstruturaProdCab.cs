namespace aa 
{ 
	public class EstruturaProdCab  
	{ 
		public int ID { get; set; } 
		public string IDDoProduto { get; set; } 
		public string IDDaReferencia { get; set; } 
		public string NomeDoItem { get; set; } 
		public string Opcao { get; set; } 
		public string NomeDaEstrutura { get; set; } 
		public string CodigoDaEstrutura { get; set; } 
		public decimal QuantidadeFabricadaPadrao { get; set; } 
		public decimal ValorUnitario { get; set; } 
		public string IDDoPostoDeTrabalho { get; set; } 
		public string NomeDoPostoDeTrabalho { get; set; } 
		public DateTime DataDeCriacao { get; set; } 
		public DateTime DataDeAlteracao { get; set; } 
		public DateTime DataDeAtivacao { get; set; } 
		public string Status { get; set; } 
		public string PesagemDupla { get; set; } 
	} 
}