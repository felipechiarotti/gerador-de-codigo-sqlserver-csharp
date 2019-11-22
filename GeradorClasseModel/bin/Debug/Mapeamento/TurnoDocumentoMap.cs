namespace aa
{
	public class : MapeadorDeEntidade<TurnoDocumentoMap>
	{
		public TurnoDocumentoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Id).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.Descricao).HasColumnName("DESCRICAO").HasMaxLength(400);
			this.Mapeador.ToTable("TURNODOCUMENTO"); 
		}
	}
}