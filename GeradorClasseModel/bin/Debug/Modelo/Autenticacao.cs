namespace aa 
{ 
	public class Autenticacao  
	{ 
		public string Usuario { get; set; } 
		public string Senha { get; set; } 
		public string Token { get; set; } 
		public DateTime DataHoraLogin { get; set; } 
		public DateTime DataHoraLogout { get; set; } 
		public long ContagemAcessos { get; set; } 
		public DateTime DataAplicacao { get; set; } 
		public string CodFilial { get; set; } 
		public string CodPosto { get; set; } 
		public boolean Logado { get; set; } 
		public int CodTurnoDocumento { get; set; } 
		public int CadastroID { get; set; } 
		public string CadastroNome { get; set; } 
		public string CadastroApelido { get; set; } 
		public boolean EhAdministrador { get; set; } 
		public boolean EhSupervisorIndustria { get; set; } 
	} 
}