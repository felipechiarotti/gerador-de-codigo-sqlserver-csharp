namespace aa
{
	public class : MapeadorDeEntidade<TbEntradasMap>
	{
		public TbEntradasMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.ChaveFato).HasColumnName("CHAVE_FATO").HasMaxLength(10);
			this.Mapeador.Property(a => a.ChaveFatoOrigUn).HasColumnName("CHAVE_FATO_ORIG_UN").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodTipoMv).HasColumnName("COD_TIPO_MV").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodLinha).HasColumnName("COD_LINHA").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodFilial).HasColumnName("COD_FILIAL").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodDocto).HasColumnName("COD_DOCTO").HasMaxLength(5);
			this.Mapeador.Property(a => a.SerieSeq).HasColumnName("SERIE_SEQ").HasMaxLength(5);
			this.Mapeador.Property(a => a.NumDocto).HasColumnName("NUM_DOCTO");
			this.Mapeador.Property(a => a.CodCliFor).HasColumnName("COD_CLI_FOR");
			this.Mapeador.Property(a => a.DataEstoque).HasColumnName("DATA_ESTOQUE").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.PesoBruto).HasColumnName("PESO_BRUTO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.PesoLiquido).HasColumnName("PESO_LIQUIDO").HasPrecision(15, 3);
			this.Mapeador.Property(a => a.QtdeItens).HasColumnName("QTDE_ITENS");
			this.Mapeador.Property(a => a.CodFuncionario).HasColumnName("COD_FUNCIONARIO");
			this.Mapeador.Property(a => a.Atendido).HasColumnName("ATENDIDO");
			this.Mapeador.Property(a => a.StatusCtb).HasColumnName("STATUS_CTB").HasMaxLength(2);
			this.Mapeador.ToTable("TBENTRADAS"); 
		}
	}
}