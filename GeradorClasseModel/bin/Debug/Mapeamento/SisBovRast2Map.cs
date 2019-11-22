namespace aa
{
	public class : MapeadorDeEntidade<SisBovRast2Map>
	{
		public SisBovRast2Map() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IdLocal).HasColumnName("IDLOCAL").IsRequired();
			this.Mapeador.Property(a => a.ID).HasColumnName("ID");
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVEFATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.SeqCabeca).HasColumnName("SEQCABECA");
			this.Mapeador.Property(a => a.IDOcorrencia).HasColumnName("IDOCORRENCIA").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrenciaSif).HasColumnName("IDOCORRENCIASIF").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia1).HasColumnName("IDOCORRENCIA1").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia2).HasColumnName("IDOCORRENCIA2").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia3).HasColumnName("IDOCORRENCIA3").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia4).HasColumnName("IDOCORRENCIA4").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia5).HasColumnName("IDOCORRENCIA5").HasMaxLength(20);
			this.Mapeador.Property(a => a.StatusSif).HasColumnName("STATUSSIF").HasMaxLength(20);
			this.Mapeador.Property(a => a.IdDaFilial).HasColumnName("IDDAFILIAL").HasMaxLength(10);
			this.Mapeador.ToTable("SISBOVRAST2"); 
		}
	}
}