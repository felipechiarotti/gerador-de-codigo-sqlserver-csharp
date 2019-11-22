namespace aa
{
	public class : MapeadorDeEntidade<FilialMap>
	{
		public FilialMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Apelido).HasColumnName("APELIDO").HasMaxLength(100);
			this.Mapeador.Property(a => a.AbatePerfil).HasColumnName("ABATEPERFIL");
			this.Mapeador.Property(a => a.UF).HasColumnName("UF").HasMaxLength(5);
			this.Mapeador.Property(a => a.Cidade).HasColumnName("CIDADE").HasMaxLength(50);
			this.Mapeador.Property(a => a.CodigoServicoInspecao).HasColumnName("CODIGOSERVICOINSPECAO").HasMaxLength(20);
			this.Mapeador.Property(a => a.NomeFilial).HasColumnName("NOMEFILIAL").HasMaxLength(100);
			this.Mapeador.Property(a => a.Endereco).HasColumnName("ENDERECO").HasMaxLength(100);
			this.Mapeador.Property(a => a.Bairro).HasColumnName("BAIRRO").HasMaxLength(50);
			this.Mapeador.Property(a => a.Cep).HasColumnName("CEP").HasMaxLength(10);
			this.Mapeador.Property(a => a.Fone).HasColumnName("FONE").HasMaxLength(20);
			this.Mapeador.Property(a => a.Fax).HasColumnName("FAX").HasMaxLength(20);
			this.Mapeador.Property(a => a.Email).HasColumnName("EMAIL").HasMaxLength(100);
			this.Mapeador.ToTable("FILIAL"); 
		}
	}
}