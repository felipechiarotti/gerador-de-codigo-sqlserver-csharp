namespace aa
{
	public class : MapeadorDeEntidade<CamaraFriaMap>
	{
		public CamaraFriaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.CodigoDaCamara).HasColumnName("CODIGODACAMARA").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.CodigoDaFilial).HasColumnName("CODIGODAFILIAL").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Descricao).HasColumnName("DESCRICAO").HasMaxLength(100);
			this.Mapeador.Property(a => a.QuantidadeDeCapacidade).HasColumnName("QUANTIDADEDECAPACIDADE");
			this.Mapeador.Property(a => a.NovoId).HasColumnName("NOVOID");
			this.Mapeador.ToTable("CAMARAFRIA"); 
		}
	}
}