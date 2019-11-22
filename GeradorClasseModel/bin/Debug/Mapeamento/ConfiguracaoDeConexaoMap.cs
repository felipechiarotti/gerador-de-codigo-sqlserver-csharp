namespace aa
{
	public class : MapeadorDeEntidade<ConfiguracaoDeConexaoMap>
	{
		public ConfiguracaoDeConexaoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.ID).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.CodigoPostoDeTrabalho).HasColumnName("CODIGOPOSTODETRABALHO").IsRequired().HasMaxLength(10);
			this.Mapeador.Property(a => a.Host).HasColumnName("HOST").HasMaxLength(200);
			this.Mapeador.Property(a => a.Porta).HasColumnName("PORTA").HasMaxLength(50);
			this.Mapeador.Property(a => a.TipoConexao).HasColumnName("TIPOCONEXAO");
			this.Mapeador.Property(a => a.TipoEquipamento).HasColumnName("TIPOEQUIPAMENTO");
			this.Mapeador.Property(a => a.TipoAplicacao).HasColumnName("TIPOAPLICACAO");
			this.Mapeador.Property(a => a.NomeAplicacao).HasColumnName("NOMEAPLICACAO").HasMaxLength(30);
			this.Mapeador.Property(a => a.Ordinal).HasColumnName("ORDINAL");
			this.Mapeador.Property(a => a.StopBit).HasColumnName("STOPBIT");
			this.Mapeador.Property(a => a.ByteSize).HasColumnName("BYTESIZE");
			this.Mapeador.Property(a => a.Paridade).HasColumnName("PARIDADE");
			this.Mapeador.Property(a => a.BaudRate).HasColumnName("BAUDRATE");
			this.Mapeador.Property(a => a.Descricao).HasColumnName("DESCRICAO").HasMaxLength(200);
			this.Mapeador.Property(a => a.CodigoEquipamento).HasColumnName("CODIGOEQUIPAMENTO").HasMaxLength(20);
			this.Mapeador.Property(a => a.NomeEquipamento).HasColumnName("NOMEEQUIPAMENTO").HasMaxLength(100);
			this.Mapeador.Property(a => a.TipoPorta).HasColumnName("TIPOPORTA");
			this.Mapeador.ToTable("CONFIGURACAODECONEXAO"); 
		}
	}
}