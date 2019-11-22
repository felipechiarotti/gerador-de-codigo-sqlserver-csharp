namespace aa
{
	public class : MapeadorDeEntidade<VersionInfoMap>
	{
		public VersionInfoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Version).HasColumnName("VERSION").IsRequired();
			this.Mapeador.Property(a => a.AppliedOn).HasColumnName("APPLIEDON").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Description).HasColumnName("DESCRIPTION").HasMaxLength(1024);
			this.Mapeador.ToTable("VERSIONINFO"); 
		}
	}
}