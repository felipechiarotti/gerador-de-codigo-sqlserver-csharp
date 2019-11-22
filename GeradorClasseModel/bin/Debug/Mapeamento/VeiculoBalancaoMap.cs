namespace aa
{
	public class : MapeadorDeEntidade<VeiculoBalancaoMap>
	{
		public VeiculoBalancaoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.IdLocal).HasColumnName("IDLOCAL").IsRequired();
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(200);
			this.Mapeador.Property(a => a.Motorista).HasColumnName("MOTORISTA");
			this.Mapeador.Property(a => a.NomeMotorista).HasColumnName("NOMEMOTORISTA").HasMaxLength(300);
			this.Mapeador.Property(a => a.TipoDoVeiculo).HasColumnName("TIPODOVEICULO").HasMaxLength(50);
			this.Mapeador.Property(a => a.CodProprietario).HasColumnName("CODPROPRIETARIO");
			this.Mapeador.ToTable("VEICULOBALANCAO"); 
		}
	}
}