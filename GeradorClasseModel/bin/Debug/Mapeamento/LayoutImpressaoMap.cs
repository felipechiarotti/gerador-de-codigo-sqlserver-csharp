namespace aa
{
	public class : MapeadorDeEntidade<LayoutImpressaoMap>
	{
		public LayoutImpressaoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.Data).HasColumnName("DATA").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.PostoDeTrabalho).HasColumnName("POSTODETRABALHO").HasMaxLength(20);
			this.Mapeador.Property(a => a.LocalDoLayout).HasColumnName("LOCALDOLAYOUT").HasMaxLength(300);
			this.Mapeador.Property(a => a.NomeArquivoDoLayout).HasColumnName("NOMEARQUIVODOLAYOUT").HasMaxLength(100);
			this.Mapeador.Property(a => a.Habilitado).HasColumnName("HABILITADO").IsRequired();
			this.Mapeador.ToTable("LAYOUTIMPRESSAO"); 
		}
	}
}