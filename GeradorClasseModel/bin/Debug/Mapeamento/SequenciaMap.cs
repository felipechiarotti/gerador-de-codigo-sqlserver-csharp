namespace aa
{
	public class : MapeadorDeEntidade<SequenciaMap>
	{
		public SequenciaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.CodigoFilial).HasColumnName("CODIGOFILIAL").IsRequired().HasMaxLength(5);
			this.Mapeador.Property(a => a.CodigoDocumento).HasColumnName("CODIGODOCUMENTO").IsRequired().HasMaxLength(5);
			this.Mapeador.Property(a => a.SerieSequencia).HasColumnName("SERIESEQUENCIA").IsRequired().HasMaxLength(5);
			this.Mapeador.Property(a => a.ModeloDocumentoFiscal).HasColumnName("MODELODOCUMENTOFISCAL").HasMaxLength(5);
			this.Mapeador.Property(a => a.NumeroDaSequencia).HasColumnName("NUMERODASEQUENCIA");
			this.Mapeador.Property(a => a.StatusSequencia).HasColumnName("STATUSSEQUENCIA").HasMaxLength(5);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.SequenciaMinima).HasColumnName("SEQUENCIAMINIMA");
			this.Mapeador.Property(a => a.SequenciaMaxima).HasColumnName("SEQUENCIAMAXIMA");
			this.Mapeador.Property(a => a.LinhaDeProducao).HasColumnName("LINHADEPRODUCAO").HasMaxLength(5);
			this.Mapeador.ToTable("SEQUENCIA"); 
		}
	}
}