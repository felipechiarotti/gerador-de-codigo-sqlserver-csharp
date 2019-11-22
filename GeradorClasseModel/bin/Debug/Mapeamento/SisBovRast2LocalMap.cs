namespace aa
{
	public class : MapeadorDeEntidade<SisBovRast2LocalMap>
	{
		public SisBovRast2LocalMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IdLocal).HasColumnName("IDLOCAL").IsRequired();
			this.Mapeador.Property(a => a.ID).HasColumnName("ID");
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVEFATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.SeqCabeca).HasColumnName("SEQCABECA");
			this.Mapeador.Property(a => a.StatusSif).HasColumnName("STATUSSIF").HasMaxLength(20);
			this.Mapeador.Property(a => a.Excecao).HasColumnName("EXCECAO").HasMaxLength(1000);
			this.Mapeador.Property(a => a.CodigoDaExcecao).HasColumnName("CODIGODAEXCECAO").IsRequired();
			this.Mapeador.Property(a => a.Sync).HasColumnName("SYNC").IsRequired();
			this.Mapeador.ToTable("SISBOVRAST2LOCAL"); 
		}
	}
}