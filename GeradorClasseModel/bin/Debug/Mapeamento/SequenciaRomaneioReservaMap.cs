namespace aa
{
	public class : MapeadorDeEntidade<SequenciaRomaneioReservaMap>
	{
		public SequenciaRomaneioReservaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Id).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVE_FATO").HasMaxLength(30);
			this.Mapeador.Property(a => a.Data).HasColumnName("DATA").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.SequenciaReservada).HasColumnName("SEQUENCIA_RESERVADA");
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS");
			this.Mapeador.Property(a => a.SequenciaReservadaTamanho).HasColumnName("SEQUENCIA_RESERVADA_TAMANHO");
			this.Mapeador.Property(a => a.Serie).HasColumnName("SERIE").HasMaxLength(5);
			this.Mapeador.Property(a => a.TipoDocumento).HasColumnName("TIPO_DOCUMENTO").HasMaxLength(5);
			this.Mapeador.Property(a => a.Modo).HasColumnName("MODO");
			this.Mapeador.ToTable("SEQUENCIAROMANEIORESERVA"); 
		}
	}
}