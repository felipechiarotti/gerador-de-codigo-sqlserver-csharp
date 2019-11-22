namespace aa
{
	public class : MapeadorDeEntidade<OrdemProducaoEsteiraMap>
	{
		public OrdemProducaoEsteiraMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVE_FATO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IdFilial).HasColumnName("IDFILIAL").HasMaxLength(10);
			this.Mapeador.Property(a => a.TipoDeDocumento).HasColumnName("TIPODEDOCUMENTO").HasMaxLength(10);
			this.Mapeador.Property(a => a.IdSerie).HasColumnName("IDSERIE").HasMaxLength(10);
			this.Mapeador.Property(a => a.Numero).HasColumnName("NUMERO");
			this.Mapeador.Property(a => a.IdLinha).HasColumnName("IDLINHA").HasMaxLength(10);
			this.Mapeador.Property(a => a.NomeLinha).HasColumnName("NOMELINHA").HasMaxLength(100);
			this.Mapeador.Property(a => a.IdDoTurno).HasColumnName("IDDOTURNO");
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS").HasMaxLength(10);
			this.Mapeador.Property(a => a.DataMov).HasColumnName("DATAMOV").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.StatusCtb).HasColumnName("STATUS_CTB").HasMaxLength(2);
			this.Mapeador.ToTable("ORDEMPRODUCAOESTEIRA"); 
		}
	}
}