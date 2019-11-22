namespace aa
{
	public class : MapeadorDeEntidade<SisBovDIFMap>
	{
		public SisBovDIFMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
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
			this.Mapeador.Property(a => a.PesoAntes).HasColumnName("PESOANTES").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.PesoDepois).HasColumnName("PESODEPOIS").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.StatusLocal).HasColumnName("STATUSLOCAL").IsRequired();
			this.Mapeador.Property(a => a.StatusSif).HasColumnName("STATUSSIF").HasMaxLength(20);
			this.Mapeador.Property(a => a.CodigoDaExcecao).HasColumnName("CODIGODAEXCECAO").IsRequired();
			this.Mapeador.Property(a => a.FilialSelecionada).HasColumnName("FILIALSELECIONADA").HasMaxLength(20);
			this.Mapeador.Property(a => a.NumeroDoLote).HasColumnName("NUMERODOLOTE");
			this.Mapeador.Property(a => a.DataHora).HasColumnName("DATAHORA").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataAbate).HasColumnName("DATAABATE").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DocumentoDeOrigem).HasColumnName("DOCUMENTODEORIGEM").HasMaxLength(50);
			this.Mapeador.Property(a => a.MercadosHabilitados).HasColumnName("MERCADOSHABILITADOS").HasMaxLength(100);
			this.Mapeador.Property(a => a.GerarRomaneioAbateCarcaraSequestrada).HasColumnName("GERARROMANEIOABATECARCARASEQUESTRADA");
			this.Mapeador.Property(a => a.SeqCabecaRomaneioAbate).HasColumnName("SEQCABECAROMANEIOABATE");
			this.Mapeador.Property(a => a.SeqVolumeRomaneioAbate).HasColumnName("SEQVOLUMEROMANEIOABATE");
			this.Mapeador.ToTable("SISBOVDIF"); 
		}
	}
}