namespace aa
{
	public class : MapeadorDeEntidade<PesagemAbateTransferenciaMap>
	{
		public PesagemAbateTransferenciaMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.Transferido).HasColumnName("TRANSFERIDO");
			this.Mapeador.ToTable("PESAGEMABATETRANSFERENCIA"); 
		}
	}
}