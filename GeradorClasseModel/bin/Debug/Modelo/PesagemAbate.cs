namespace aa 
{ 
	public class PesagemAbate  
	{ 
		public int Id { get; set; } 
		public int Sequencia { get; set; } 
		public string IDDoProduto { get; set; } 
		public string IDDaReferencia { get; set; } 
		public double Peso1 { get; set; } 
		public double Peso2 { get; set; } 
		public int SequenciaContrato { get; set; } 
		public string Lote { get; set; } 
		public string Sexo { get; set; } 
		public int Status { get; set; } 
		public DateTime DataAbate { get; set; } 
		public DateTime DataHora { get; set; } 
		public string ChaveFatoContrato { get; set; } 
		public string IDDaFilial { get; set; } 
		public int IdDaClassificaoAnimal { get; set; } 
		public string IDDaCamaraFria { get; set; } 
		public boolean PesoPorMedia { get; set; } 
		public string Excecao { get; set; } 
		public int CodigoDaExcecao { get; set; } 
		public int IdDaFaixaDePeso { get; set; } 
		public string DescricaoDaFaixaDaPeso { get; set; } 
		public string DescricaoDaClassificacao { get; set; } 
		public string Produto { get; set; } 
		public string GuidParaEnvio { get; set; } 
		public int GuidParaEnvioStatus { get; set; } 
		public string ChaveFatoRomAnimalMorto { get; set; } 
		public boolean FinalizouPesagem { get; set; } 
		public string DocumentoAnimalMorto { get; set; } 
		public int ComandoParaAPI { get; set; } 
		public int OperacaoSisbov { get; set; } 
		public string CodManejo { get; set; } 
		public int TentativasDeEnvio { get; set; } 
		public string TipoDeTemperatura { get; set; } 
		public string RomaneioStatusContabil { get; set; } 
		public int NumeroItem { get; set; } 
		public string CodigoPostoTrabalho { get; set; } 
		public decimal Tara { get; set; } 
	} 
}