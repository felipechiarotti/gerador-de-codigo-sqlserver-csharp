namespace aa
{
	public class : MapeadorDeEntidade<PesoBalancaRodoviariaMap>
	{
		public PesoBalancaRodoviariaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IdCargaBalancaRodoviaria).HasColumnName("IDCARGABALANCARODOVIARIA").IsRequired();
			this.Mapeador.Property(a => a.DataDeCadastro).HasColumnName("DATADECADASTRO").HasPrecision(23, 3);
			this.Mapeador.Property(a => a.PesoBruto).HasColumnName("PESOBRUTO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.PesoLiquido).HasColumnName("PESOLIQUIDO").HasPrecision(16, 3);
			this.Mapeador.Property(a => a.Tara).HasColumnName("TARA").IsRequired().HasPrecision(16, 3);
			this.Mapeador.Property(a => a.TipoPeso).HasColumnName("TIPOPESO").IsRequired().HasMaxLength(5);
			this.Mapeador.Property(a => a.QuantidadeDeCabecas).HasColumnName("QUANTIDADEDECABECAS").IsRequired();
			this.Mapeador.Property(a => a.Funcionario).HasColumnName("FUNCIONARIO").HasMaxLength(50);
			this.Mapeador.Property(a => a.StatusDeEnvio).HasColumnName("STATUSDEENVIO");
			this.Mapeador.Property(a => a.CodFuncionario).HasColumnName("CODFUNCIONARIO");
			this.Mapeador.ToTable("PESOBALANCARODOVIARIA"); 
		}
	}
}