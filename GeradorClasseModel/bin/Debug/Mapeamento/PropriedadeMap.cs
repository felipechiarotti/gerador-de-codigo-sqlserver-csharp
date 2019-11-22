namespace aa
{
	public class : MapeadorDeEntidade<PropriedadeMap>
	{
		public PropriedadeMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.CPFCNPJ).HasColumnName("CPFCNPJ").HasMaxLength(50);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.CodigoPecuarista).HasColumnName("CODIGOPECUARISTA");
			this.Mapeador.Property(a => a.NomePecuarista).HasColumnName("NOMEPECUARISTA").HasMaxLength(200);
			this.Mapeador.Property(a => a.Cidade).HasColumnName("CIDADE").HasMaxLength(100);
			this.Mapeador.Property(a => a.UFDoMunicipio).HasColumnName("UFDOMUNICIPIO").HasMaxLength(100);
			this.Mapeador.ToTable("PROPRIEDADE"); 
		}
	}
}