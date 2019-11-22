namespace aa
{
	public class : MapeadorDeEntidade<EstruturaProdCabMap>
	{
		public EstruturaProdCabMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IDDoProduto).HasColumnName("IDDOPRODUTO").HasMaxLength(20);
			this.Mapeador.Property(a => a.IDDaReferencia).HasColumnName("IDDAREFERENCIA").HasMaxLength(20);
			this.Mapeador.Property(a => a.NomeDoItem).HasColumnName("NOMEDOITEM").HasMaxLength(100);
			this.Mapeador.Property(a => a.Opcao).HasColumnName("OPCAO").HasMaxLength(5);
			this.Mapeador.Property(a => a.NomeDaEstrutura).HasColumnName("NOMEDAESTRUTURA").HasMaxLength(100);
			this.Mapeador.Property(a => a.CodigoDaEstrutura).HasColumnName("CODIGODAESTRUTURA").HasMaxLength(50);
			this.Mapeador.Property(a => a.QuantidadeFabricadaPadrao).HasColumnName("QUANTIDADEFABRICADAPADRAO").HasPrecision(15, 4);
			this.Mapeador.Property(a => a.ValorUnitario).HasColumnName("VALORUNITARIO").HasPrecision(15, 4);
			this.Mapeador.Property(a => a.IDDoPostoDeTrabalho).HasColumnName("IDDOPOSTODETRABALHO").HasMaxLength(10);
			this.Mapeador.Property(a => a.NomeDoPostoDeTrabalho).HasColumnName("NOMEDOPOSTODETRABALHO").HasMaxLength(100);
			this.Mapeador.Property(a => a.DataDeCriacao).HasColumnName("DATADECRIACAO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataDeAlteracao).HasColumnName("DATADEALTERACAO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.DataDeAtivacao).HasColumnName("DATADEATIVACAO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.Status).HasColumnName("STATUS").HasMaxLength(10);
			this.Mapeador.Property(a => a.PesagemDupla).HasColumnName("PESAGEMDUPLA").HasMaxLength(5);
			this.Mapeador.ToTable("ESTRUTURAPRODCAB"); 
		}
	}
}