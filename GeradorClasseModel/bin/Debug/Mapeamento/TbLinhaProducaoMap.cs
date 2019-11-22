namespace aa
{
	public class : MapeadorDeEntidade<TbLinhaProducaoMap>
	{
		public TbLinhaProducaoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.CodLinha).HasColumnName("COD_LINHA").HasMaxLength(5);
			this.Mapeador.Property(a => a.NomeLinha).HasColumnName("NOME_LINHA").HasMaxLength(60);
			this.Mapeador.Property(a => a.OrigemMP).HasColumnName("ORIGEM_MP").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodTipoMvOpMp).HasColumnName("COD_TIPO_MV_OP_MP").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodTipoMvOpPa).HasColumnName("COD_TIPO_MV_OP_PA").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodTipoMvRpMp).HasColumnName("COD_TIPO_MV_RP_MP").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodTipoMvRpPa).HasColumnName("COD_TIPO_MV_RP_PA").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodTipoMvOPPq).HasColumnName("COD_TIPO_MV_OP_PQ").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodTipoMvRpPq).HasColumnName("COD_TIPO_MV_RP_PQ").HasMaxLength(5);
			this.Mapeador.Property(a => a.PercRendimentoMin).HasColumnName("PERC_RENDIMENTO_MIN").HasPrecision(15, 2);
			this.Mapeador.Property(a => a.PercRendimentoMax).HasColumnName("PERC_RENDIMENTO_MAX").HasPrecision(15, 2);
			this.Mapeador.Property(a => a.PermitePesoMPMaiorPA).HasColumnName("PERMITE_PESO_MP_MAIOR_PA");
			this.Mapeador.ToTable("TBLINHAPRODUCAO"); 
		}
	}
}