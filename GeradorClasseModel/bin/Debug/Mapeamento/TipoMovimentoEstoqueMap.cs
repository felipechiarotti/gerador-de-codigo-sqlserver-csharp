namespace aa
{
	public class : MapeadorDeEntidade<TipoMovimentoEstoqueMap>
	{
		public TipoMovimentoEstoqueMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Descricao).HasColumnName("DESCRICAO").HasMaxLength(200);
			this.Mapeador.Property(a => a.PerfilMovimento).HasColumnName("PERFILMOVIMENTO").HasMaxLength(20);
			this.Mapeador.Property(a => a.TestaDocumentoOrigem).HasColumnName("TESTADOCUMENTOORIGEM").HasMaxLength(10);
			this.Mapeador.Property(a => a.ImportaItemDocumentoOrigem).HasColumnName("IMPORTAITEMDOCUMENTOORIGEM").HasMaxLength(10);
			this.Mapeador.Property(a => a.ForcaSequenciaAutomatica).HasColumnName("FORCASEQUENCIAAUTOMATICA").HasMaxLength(10);
			this.Mapeador.Property(a => a.UsaDocumentoRelacionado).HasColumnName("USADOCUMENTORELACIONADO").HasMaxLength(10);
			this.Mapeador.Property(a => a.ExigeDocumentoRelacionado).HasColumnName("EXIGEDOCUMENTORELACIONADO").HasMaxLength(10);
			this.Mapeador.ToTable("TIPOMOVIMENTOESTOQUE"); 
		}
	}
}