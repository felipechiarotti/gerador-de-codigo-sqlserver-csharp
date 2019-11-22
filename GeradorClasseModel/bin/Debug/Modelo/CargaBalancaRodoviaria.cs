namespace aa 
{ 
	public class CargaBalancaRodoviaria  
	{ 
		public int ID { get; set; } 
		public int IDOrigemLocal { get; set; } 
		public string IdDaFilial { get; set; } 
		public string Placa { get; set; } 
		public string IdTipoDoFrete { get; set; } 
		public int Sequencia { get; set; } 
		public DateTime DataDeCadastro { get; set; } 
		public DateTime DataDeMovimento { get; set; } 
		public string Lote { get; set; } 
		public string Sexo { get; set; } 
		public string IDDoProduto { get; set; } 
		public string IDDaReferencia { get; set; } 
		public string NomeDoProduto { get; set; } 
		public string Observacao { get; set; } 
		public decimal Tara { get; set; } 
		public string ChaveDeFatoDoFrete { get; set; } 
		public string ChaveFatoContrato { get; set; } 
		public string ContratoDocumento { get; set; } 
		public string FreteDocumento { get; set; } 
		public string TipoPeso { get; set; } 
		public string GTA { get; set; } 
		public string NFProdutor { get; set; } 
		public string CodigoTransportador { get; set; } 
		public int Modo { get; set; } 
		public int IdDaEntradaDeOrigem { get; set; } 
		public int QuantidadeDeCabecas { get; set; } 
		public string NomeDoMotorista { get; set; } 
		public int IdSincronismo { get; set; } 
		public boolean Enviar { get; set; } 
		public decimal PesoBalancao { get; set; } 
		public int CodMotorista { get; set; } 
		public string TipoVeiculo { get; set; } 
		public string Pecuarista { get; set; } 
		public string PropriedadeRural { get; set; } 
		public DateTime DataEntrada { get; set; } 
		public DateTime DataAbate { get; set; } 
		public DateTime DataHoraFim { get; set; } 
		public int CodItemCarga { get; set; } 
		public string NomeItemCarga { get; set; } 
		public string NomeTransportador { get; set; } 
		public string NomePecuarista { get; set; } 
	} 
}