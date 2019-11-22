namespace aa 
{ 
	public class PesoRecebimentoPocilga  
	{ 
		public int ID { get; set; } 
		public string ChaveDeFatoDoFrete { get; set; } 
		public string IdDoProduto { get; set; } 
		public string IdDaReferencia { get; set; } 
		public string NomeDoProduto { get; set; } 
		public string Rastreamento { get; set; } 
		public DateTime DataDeCadastro { get; set; } 
		public decimal Peso { get; set; } 
		public decimal Tara { get; set; } 
		public int Quantidade { get; set; } 
		public int Seq { get; set; } 
		public boolean Ignorar { get; set; } 
		public string LoteTatuagem { get; set; } 
		public int StatusDeEnvio { get; set; } 
		public int IdDoRomaneioAnimalVivo { get; set; } 
		public DateTime DataFim { get; set; } 
		public string NumeroCurralAtual { get; set; } 
		public int NumeroItem { get; set; } 
		public string ChaveFatoContrato { get; set; } 
		public string ChaveFatoRomaneio { get; set; } 
		public string DocumentoRomaneio { get; set; } 
	} 
}