namespace aa
{
	public class : MapeadorDeEntidade<VolumeMap>
	{
		public VolumeMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.CodPosto).HasColumnName("COD_POSTO").IsRequired().HasMaxLength(5);
			this.Mapeador.Property(a => a.CodFilial).HasColumnName("COD_FILIAL").IsRequired().HasMaxLength(3);
			this.Mapeador.Property(a => a.SerieSeq).HasColumnName("SERIE_SEQ").IsRequired().HasMaxLength(3);
			this.Mapeador.Property(a => a.Produto).HasColumnName("PRODUTO").IsRequired().HasMaxLength(12);
			this.Mapeador.Property(a => a.Referencia).HasColumnName("REFERENCIA").IsRequired().HasMaxLength(4);
			this.Mapeador.Property(a => a.DataProducao).HasColumnName("DATAPRODUCAO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataValidade).HasColumnName("DATAVALIDADE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.PesoLiquido).HasColumnName("PESOLIQUIDO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.TaraInterna).HasColumnName("TARAINTERNA").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.TaraExterna).HasColumnName("TARAEXTERNA").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoBruto).HasColumnName("PESOBRUTO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.Usuario).HasColumnName("USUARIO").IsRequired();
			this.Mapeador.Property(a => a.Quantidade).HasColumnName("QUANTIDADE");
			this.Mapeador.Property(a => a.Romaneio).HasColumnName("ROMANEIO").HasMaxLength(9);
			this.Mapeador.Property(a => a.PostoDeTrabalho).HasColumnName("POSTODETRABALHO").HasMaxLength(5);
			this.Mapeador.Property(a => a.Erro).HasColumnName("ERRO").HasMaxLength(150);
			this.Mapeador.Property(a => a.DataApontamento).HasColumnName("DATAAPONTAMENTO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Sync).HasColumnName("SYNC").IsRequired();
			this.Mapeador.Property(a => a.DescricaoErro).HasColumnName("DESCRICAOERRO").HasMaxLength(150);
			this.Mapeador.Property(a => a.SeqPreEtiqueta).HasColumnName("SEQPREETIQUETA").HasMaxLength(6);
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS").HasMaxLength(1);
			this.Mapeador.Property(a => a.NumeroDoItem).HasColumnName("NUMERODOITEM");
			this.Mapeador.Property(a => a.NumeroDoSubItem).HasColumnName("NUMERODOSUBITEM");
			this.Mapeador.Property(a => a.QuantidadeSacos).HasColumnName("QUANTIDADE_SACOS");
			this.Mapeador.Property(a => a.QuantidadePecasSacos).HasColumnName("QUANTIDADE_PECAS_SACOS");
			this.Mapeador.ToTable("VOLUME"); 
		}
	}
}