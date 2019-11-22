namespace aa 
{ 
	public class CargaRecebimentoPocilga  
	{ 
		public int ID { get; set; } 
		public string ChaveDeFatoDoFrete { get; set; } 
		public DateTime DataDoMovimento { get; set; } 
		public DateTime DataDeCadastro { get; set; } 
		public string SerieDaCarga { get; set; } 
		public string IdDaFilial { get; set; } 
		public int NumeroDaCarga { get; set; } 
		public int IdDoMotorista { get; set; } 
		public string NomeDoMotorista { get; set; } 
		public int IDDaPropriedade { get; set; } 
		public string NomeDaPropriedade { get; set; } 
		public string Placa { get; set; } 
		public string Contrato { get; set; } 
		public string Romaneio { get; set; } 
		public boolean SelecionadoParaRecebimento { get; set; } 
		public boolean Finalizado { get; set; } 
		public boolean CargaOffLine { get; set; } 
		public int Sync { get; set; } 
		public int TentativasDeEnvio { get; set; } 
		public string ExcecaoDeRetornoDoServico { get; set; } 
		public int IdSincronismo { get; set; } 
		public decimal PesoBalancao { get; set; } 
		public int IdPecuarista { get; set; } 
		public string Pecuarista { get; set; } 
		public string DocumentoFrete { get; set; } 
		public string DocumentoContrato { get; set; } 
		public string DocumentoRomaneio { get; set; } 
		public DateTime DataAbate { get; set; } 
		public DateTime DataEntrada { get; set; } 
		public int QuantidadeCabecasPeloGTA { get; set; } 
		public int QuantidadeCabecaPelaEscala { get; set; } 
		public int ComandoParaAPI { get; set; } 
		public string Lote { get; set; } 
		public string IdDoProdutoSelecioando { get; set; } 
		public string IdDaReferenciaSelecionada { get; set; } 
		public string ApelidoPecuarista { get; set; } 
		public string ApelidoPropriedade { get; set; } 
		public DateTime DataDescarregamento { get; set; } 
		public boolean ExistePesagemDeEntrada { get; set; } 
	} 
}