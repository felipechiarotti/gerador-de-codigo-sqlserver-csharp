namespace aa 
{ 
	public class RomaneioAnimalVivo  
	{ 
		public int ID { get; set; } 
		public string Placa { get; set; } 
		public string ChaveDeFatoDoRomaneio { get; set; } 
		public string DocumentoRomaneio { get; set; } 
		public int IdDoPecuarista { get; set; } 
		public string NomePecuarista { get; set; } 
		public string ApelidoPecuarista { get; set; } 
		public int IdDaPropriedadeRural { get; set; } 
		public string NomePropriedadeRural { get; set; } 
		public string ApelidoPropriedadeRural { get; set; } 
		public string ChaveDeFatoDoFrete { get; set; } 
		public string DocumentoFrete { get; set; } 
		public DateTime DataDoMovimento { get; set; } 
		public DateTime DataDeAbate { get; set; } 
		public DateTime DataHora { get; set; } 
		public boolean Finalizado { get; set; } 
		public boolean CargaOffLine { get; set; } 
		public int Sync { get; set; } 
		public int TentativasDeEnvio { get; set; } 
		public string ExcecaoDeRetornoDoServico { get; set; } 
		public decimal PesoBalancao { get; set; } 
		public string ChaveFatoEscala { get; set; } 
		public string DocumentoEscala { get; set; } 
		public string Lote { get; set; } 
		public int ComandoParaAPI { get; set; } 
		public string IdDoProdutoSelecionado { get; set; } 
		public string IdDaReferenciaSelecionada { get; set; } 
		public boolean SelecionadoParaRecebimento { get; set; } 
		public string GTA { get; set; } 
		public int QuantCabecas { get; set; } 
		public string NF { get; set; } 
		public string NomeDoMotorista { get; set; } 
		public string IdDaFilial { get; set; } 
		public int IdDoTransporador { get; set; } 
		public string NomeTransportador { get; set; } 
		public string ApelidoTransportador { get; set; } 
		public string GUID { get; set; } 
		public int GUIDStatus { get; set; } 
		public boolean Iniciado { get; set; } 
		public string GUIDEntrada { get; set; } 
		public int GUIDModoDeEnvio { get; set; } 
		public boolean LoteDigitado { get; set; } 
		public int CodMotorista { get; set; } 
		public boolean GerouEscalaEhFrete { get; set; } 
		public string GrupoRendimentoSelecionado { get; set; } 
		public DateTime DataFim { get; set; } 
		public boolean ServicoOcupado { get; set; } 
		public int Turno { get; set; } 
	} 
}