namespace aa
{
	public class : MapeadorDeEntidade<SequenciasMap>
	{
		public SequenciasMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.CodPosto).HasColumnName("COD_POSTO").IsRequired().HasMaxLength(5);
			this.Mapeador.Property(a => a.CodFilial).HasColumnName("COD_FILIAL").IsRequired().HasMaxLength(3);
			this.Mapeador.Property(a => a.SerieSeq).HasColumnName("SERIE_SEQ").IsRequired().HasMaxLength(3);
			this.Mapeador.Property(a => a.NumeroSeq).HasColumnName("NUMERO_SEQ").IsRequired();
			this.Mapeador.Property(a => a.SeqNumeroMax).HasColumnName("SEQ_NUMERO_MAX").IsRequired();
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS").IsRequired();
			this.Mapeador.ToTable("SEQUENCIAS"); 
		}
	}
}