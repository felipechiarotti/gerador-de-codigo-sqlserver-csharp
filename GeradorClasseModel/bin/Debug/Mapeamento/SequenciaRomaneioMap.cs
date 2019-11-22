namespace aa
{
	public class : MapeadorDeEntidade<SequenciaRomaneioMap>
	{
		public SequenciaRomaneioMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Id).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVE_FATO").HasMaxLength(30);
			this.Mapeador.Property(a => a.Data).HasColumnName("DATA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.UltimaSequencia).HasColumnName("ULTIMA_SEQUENCIA");
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS");
			this.Mapeador.ToTable("SEQUENCIAROMANEIO"); 
		}
	}
}