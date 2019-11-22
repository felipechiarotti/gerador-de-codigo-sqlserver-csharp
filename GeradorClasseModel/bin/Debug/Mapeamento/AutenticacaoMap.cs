namespace aa
{
	public class : MapeadorDeEntidade<AutenticacaoMap>
	{
		public AutenticacaoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Usuario).HasColumnName("USUARIO").IsRequired().HasMaxLength(50);
			this.Mapeador.Property(a => a.Senha).HasColumnName("SENHA").HasMaxLength(300);
			this.Mapeador.Property(a => a.Token).HasColumnName("TOKEN").HasMaxLength(500);
			this.Mapeador.Property(a => a.DataHoraLogin).HasColumnName("DATAHORALOGIN").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataHoraLogout).HasColumnName("DATAHORALOGOUT").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.ContagemAcessos).HasColumnName("CONTAGEMACESSOS");
			this.Mapeador.Property(a => a.DataAplicacao).HasColumnName("DATAAPLICACAO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.CodFilial).HasColumnName("CODFILIAL").HasMaxLength(20);
			this.Mapeador.Property(a => a.CodPosto).HasColumnName("CODPOSTO").HasMaxLength(20);
			this.Mapeador.Property(a => a.Logado).HasColumnName("LOGADO");
			this.Mapeador.Property(a => a.CodTurnoDocumento).HasColumnName("CODTURNODOCUMENTO");
			this.Mapeador.Property(a => a.CadastroID).HasColumnName("CADASTRO_ID");
			this.Mapeador.Property(a => a.CadastroNome).HasColumnName("CADASTRO_NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.CadastroApelido).HasColumnName("CADASTRO_APELIDO").HasMaxLength(100);
			this.Mapeador.Property(a => a.EhAdministrador).HasColumnName("EH_ADMINISTRADOR");
			this.Mapeador.Property(a => a.EhSupervisorIndustria).HasColumnName("EH_SUPERVISOR_INDUSTRIA");
			this.Mapeador.ToTable("AUTENTICACAO"); 
		}
	}
}