namespace aa
{
	public class : MapeadorDeEntidade<OcorrenciaAbateMap>
	{
		public OcorrenciaAbateMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Descricao).HasColumnName("DESCRICAO").HasMaxLength(200);
			this.Mapeador.Property(a => a.Destino).HasColumnName("DESTINO").HasMaxLength(200);
			this.Mapeador.Property(a => a.Tipo).HasColumnName("TIPO");
			this.Mapeador.ToTable("OCORRENCIAABATE"); 
		}
	}
}