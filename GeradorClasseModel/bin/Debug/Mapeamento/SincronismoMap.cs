namespace aa
{
	public class : MapeadorDeEntidade<SincronismoMap>
	{
		public SincronismoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.Sync).HasColumnName("SYNC");
			this.Mapeador.Property(a => a.Modo).HasColumnName("MODO");
			this.Mapeador.Property(a => a.TentativasDeEnvio).HasColumnName("TENTATIVASDEENVIO");
			this.Mapeador.Property(a => a.HorarioDaUltimaTentativa).HasColumnName("HORARIODAULTIMATENTATIVA").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Data).HasColumnName("DATA").IsRequired().HasPrecision(23, 3);
			this.Mapeador.Property(a => a.TabelaDeOrigem).HasColumnName("TABELADEORIGEM").IsRequired().HasMaxLength(100);
			this.Mapeador.Property(a => a.Excecao).HasColumnName("EXCECAO").HasMaxLength(2000);
			this.Mapeador.Property(a => a.OrdemDeEnvio).HasColumnName("ORDEMDEENVIO");
			this.Mapeador.ToTable("SINCRONISMO"); 
		}
	}
}