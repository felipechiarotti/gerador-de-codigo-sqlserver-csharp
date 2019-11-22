namespace aa 
{ 
	public class PesoBalancaRodoviaria  
	{ 
		public int ID { get; set; } 
		public int IdCargaBalancaRodoviaria { get; set; } 
		public DateTime DataDeCadastro { get; set; } 
		public decimal PesoBruto { get; set; } 
		public decimal PesoLiquido { get; set; } 
		public decimal Tara { get; set; } 
		public string TipoPeso { get; set; } 
		public int QuantidadeDeCabecas { get; set; } 
		public string Funcionario { get; set; } 
		public int StatusDeEnvio { get; set; } 
		public int CodFuncionario { get; set; } 
	} 
}