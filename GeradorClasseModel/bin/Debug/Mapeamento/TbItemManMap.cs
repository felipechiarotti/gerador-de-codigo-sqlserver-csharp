namespace aa
{
	public class : MapeadorDeEntidade<TbItemManMap>
	{
		public TbItemManMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.CodItem).HasColumnName("COD_ITEM").IsRequired();
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.Durabilidade).HasColumnName("DURABILIDADE");
			this.Mapeador.ToTable("TBITEMMAN"); 
		}
	}
}