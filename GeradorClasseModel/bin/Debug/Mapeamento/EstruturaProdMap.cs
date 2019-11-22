namespace aa
{
	public class : MapeadorDeEntidade<EstruturaProdMap>
	{
		public EstruturaProdMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IDCab).HasColumnName("IDCAB").IsRequired();
			this.Mapeador.Property(a => a.IDDoProduto).HasColumnName("IDDOPRODUTO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDDaReferencia).HasColumnName("IDDAREFERENCIA").HasMaxLength(20);
			this.Mapeador.Property(a => a.NomeDoItem).HasColumnName("NOMEDOITEM").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeDaGrade).HasColumnName("NOMEDAGRADE").HasMaxLength(100);
			this.Mapeador.Property(a => a.IDDoProdutoComponente).HasColumnName("IDDOPRODUTOCOMPONENTE").HasMaxLength(60);
			this.Mapeador.Property(a => a.IDDaReferenciaComponente).HasColumnName("IDDAREFERENCIACOMPONENTE").HasMaxLength(20);
			this.Mapeador.Property(a => a.NomeDoItemComponente).HasColumnName("NOMEDOITEMCOMPONENTE").HasMaxLength(100);
			this.Mapeador.Property(a => a.NomeDaGradeComponente).HasColumnName("NOMEDAGRADECOMPONENTE").HasMaxLength(100);
			this.Mapeador.Property(a => a.Opcao).HasColumnName("OPCAO").HasMaxLength(5);
			this.Mapeador.Property(a => a.Operacao).HasColumnName("OPERACAO").HasMaxLength(10);
			this.Mapeador.Property(a => a.PercentualDoComponente).HasColumnName("PERCENTUALDOCOMPONENTE").HasPrecision(10, 4);
			this.Mapeador.Property(a => a.QuantidadeDoComponente).HasColumnName("QUANTIDADEDOCOMPONENTE").HasPrecision(15, 4);
			this.Mapeador.Property(a => a.ValorDoCusto).HasColumnName("VALORDOCUSTO").HasPrecision(20, 4);
			this.Mapeador.Property(a => a.Sequencia).HasColumnName("SEQUENCIA");
			this.Mapeador.Property(a => a.Observacao).HasColumnName("OBSERVACAO").HasMaxLength(200);
			this.Mapeador.Property(a => a.Dummy).HasColumnName("DUMMY").HasMaxLength(5);
			this.Mapeador.Property(a => a.ValorUnitario).HasColumnName("VALORUNITARIO").HasPrecision(20, 4);
			this.Mapeador.Property(a => a.PercentualDeTolerancia).HasColumnName("PERCENTUALDETOLERANCIA").HasPrecision(10, 4);
			this.Mapeador.Property(a => a.Unidade).HasColumnName("UNIDADE").HasMaxLength(10);
			this.Mapeador.Property(a => a.QuantidadeFabricadaPadrao).HasColumnName("QUANTIDADEFABRICADAPADRAO").HasPrecision(15, 4);
			this.Mapeador.Property(a => a.PesagemDupla).HasColumnName("PESAGEMDUPLA").HasMaxLength(5);
			this.Mapeador.Property(a => a.CodGrupoRendimento).HasColumnName("CODGRUPORENDIMENTO").HasMaxLength(10);
			this.Mapeador.Property(a => a.PrazoDeValidade).HasColumnName("PRAZODEVALIDADE");
			this.Mapeador.Property(a => a.DescProdNF).HasColumnName("DESCPRODNF").HasMaxLength(100);
			this.Mapeador.Property(a => a.DescProdRot).HasColumnName("DESCPRODROT").HasMaxLength(100);
			this.Mapeador.ToTable("ESTRUTURAPROD"); 
		}
	}
}