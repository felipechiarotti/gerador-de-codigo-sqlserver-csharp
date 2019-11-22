namespace aa
{
	public class : MapeadorDeEntidade<ItemPesagemAbateMap>
	{
		public ItemPesagemAbateMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IdItemPesagemAbate).HasColumnName("IDITEMPESAGEMABATE").IsRequired();
			this.Mapeador.Property(a => a.IDDoItem).HasColumnName("IDDOITEM").HasMaxLength(50);
			this.Mapeador.Property(a => a.IDDaReferencia).HasColumnName("IDDAREFERENCIA").HasMaxLength(50);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(500);
			this.Mapeador.Property(a => a.DescricaoGrade).HasColumnName("DESCRICAOGRADE").HasMaxLength(500);
			this.Mapeador.Property(a => a.PesagemDupla).HasColumnName("PESAGEMDUPLA").IsRequired();
			this.Mapeador.Property(a => a.OrigemTaraExterna).HasColumnName("ORIGEMTARAEXTERNA").HasMaxLength(50);
			this.Mapeador.Property(a => a.OrigemTaraInterna).HasColumnName("ORIGEMTARAINTERNA").HasMaxLength(50);
			this.Mapeador.Property(a => a.TaraExterna).HasColumnName("TARAEXTERNA").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.TaraInterna).HasColumnName("TARAINTERNA").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.PesoMinimo).HasColumnName("PESOMINIMO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.IdsFaixasDePeso).HasColumnName("IDSFAIXASDEPESO").HasMaxLength(200);
			this.Mapeador.Property(a => a.Sexo).HasColumnName("SEXO").HasMaxLength(10);
			this.Mapeador.Property(a => a.CodigoGrupoRendimento).HasColumnName("CODIGOGRUPORENDIMENTO").HasMaxLength(5);
			this.Mapeador.Property(a => a.PrazoDeValidade).HasColumnName("PRAZODEVALIDADE");
			this.Mapeador.Property(a => a.TipoDeTemperatura).HasColumnName("TIPODETEMPERATURA").HasMaxLength(3);
			this.Mapeador.Property(a => a.DescricaoProdutoNF).HasColumnName("DESCRICAOPRODUTONF").HasMaxLength(60);
			this.Mapeador.Property(a => a.DescricaoProdutoRot).HasColumnName("DESCRICAOPRODUTOROT").HasMaxLength(60);
			this.Mapeador.Property(a => a.SifDipoa).HasColumnName("SIFDIPOA").HasMaxLength(255);
			this.Mapeador.ToTable("ITEMPESAGEMABATE"); 
		}
	}
}