namespace aa
{
	public class : MapeadorDeEntidade<ClassificacaoAnimalMap>
	{
		public ClassificacaoAnimalMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IdLocal).HasColumnName("IDLOCAL").IsRequired();
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.PercentualReducao).HasColumnName("PERCENTUALREDUCAO").HasMaxLength(20);
			this.Mapeador.ToTable("CLASSIFICACAOANIMAL"); 
		}
	}
}