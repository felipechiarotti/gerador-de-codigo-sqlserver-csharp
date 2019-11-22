namespace aa
{
	public class : MapeadorDeEntidade<SisBovMap>
	{
		public SisBovMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IdLocal).HasColumnName("IDLOCAL").IsRequired();
			this.Mapeador.Property(a => a.ID).HasColumnName("ID");
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVEFATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.CodigoManejo).HasColumnName("CODIGOMANEJO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDCertificadora).HasColumnName("IDCERTIFICADORA");
			this.Mapeador.Property(a => a.CodigoSisBov).HasColumnName("CODIGOSISBOV").HasMaxLength(20);
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS").HasMaxLength(20);
			this.Mapeador.Property(a => a.DataDeNascimento).HasColumnName("DATADENASCIMENTO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Sexo).HasColumnName("SEXO").HasMaxLength(20);
			this.Mapeador.Property(a => a.SequenciaCabeca).HasColumnName("SEQUENCIACABECA");
			this.Mapeador.Property(a => a.IDOcorrencia).HasColumnName("IDOCORRENCIA").HasMaxLength(20);
			this.Mapeador.Property(a => a.NumeroDoLote).HasColumnName("NUMERODOLOTE");
			this.Mapeador.Property(a => a.NumeroDoCurral).HasColumnName("NUMERODOCURRAL").HasMaxLength(20);
			this.Mapeador.Property(a => a.DataDeAbate).HasColumnName("DATADEABATE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.StatusSif).HasColumnName("STATUSSIF").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrenciaSif).HasColumnName("IDOCORRENCIASIF").HasMaxLength(20);
			this.Mapeador.Property(a => a.DataHora).HasColumnName("DATAHORA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.IDMaturidade).HasColumnName("IDMATURIDADE").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia1).HasColumnName("IDOCORRENCIA1").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia2).HasColumnName("IDOCORRENCIA2").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia3).HasColumnName("IDOCORRENCIA3").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia4).HasColumnName("IDOCORRENCIA4").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDOcorrencia5).HasColumnName("IDOCORRENCIA5").HasMaxLength(20);
			this.Mapeador.Property(a => a.PesoVivo).HasColumnName("PESOVIVO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.RastreadoNaOrigem).HasColumnName("RASTREADONAORIGEM");
			this.Mapeador.Property(a => a.IDProdutorBezerro).HasColumnName("IDPRODUTORBEZERRO");
			this.Mapeador.Property(a => a.DataV2).HasColumnName("DATAV2").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.PesoSifAntesInspecao).HasColumnName("PESOSIFANTESINSPECAO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.PesoSifDepoisInspecao).HasColumnName("PESOSIFDEPOISINSPECAO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.DocumentoDeOrigem).HasColumnName("DOCUMENTODEORIGEM").HasMaxLength(50);
			this.Mapeador.Property(a => a.MercadosHabilitados).HasColumnName("MERCADOSHABILITADOS").HasMaxLength(100);
			this.Mapeador.ToTable("SISBOV"); 
		}
	}
}