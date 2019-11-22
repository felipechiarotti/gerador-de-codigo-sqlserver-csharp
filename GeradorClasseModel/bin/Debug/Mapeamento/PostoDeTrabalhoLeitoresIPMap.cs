namespace aa
{
	public class : MapeadorDeEntidade<PostoDeTrabalhoLeitoresIPMap>
	{
		public PostoDeTrabalhoLeitoresIPMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IDLocal).HasColumnName("IDLOCAL").IsRequired();
			this.Mapeador.Property(a => a.IDPosto).HasColumnName("IDPOSTO").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.EnderecoIP).HasColumnName("ENDERECOIP").HasMaxLength(50);
			this.Mapeador.Property(a => a.PortaComando).HasColumnName("PORTACOMANDO");
			this.Mapeador.Property(a => a.PortaDados).HasColumnName("PORTADADOS");
			this.Mapeador.ToTable("POSTODETRABALHOLEITORESIP"); 
		}
	}
}