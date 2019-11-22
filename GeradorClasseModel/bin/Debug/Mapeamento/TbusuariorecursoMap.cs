namespace aa
{
	public class : MapeadorDeEntidade<TbusuariorecursoMap>
	{
		public TbusuariorecursoMap() : base(GMF.Framework.Configuracao.GMFConfiguracoes.Configuracoes.SchemaDoBanco)
		{
		}

		protected override void MapearNomesDeTabelaEColunas() 
		{
			this.Mapeador.Property(a => a.Id).HasColumnName("ID").IsRequired();
			this.Mapeador.Property(a => a.IdRecurso).HasColumnName("ID_RECURSO");
			this.Mapeador.Property(a => a.Nome).HasColumnName("NOME").HasMaxLength(100);
			this.Mapeador.Property(a => a.Permissao).HasColumnName("PERMISSAO").HasMaxLength(20);
			this.Mapeador.Property(a => a.ParentNode).HasColumnName("PARENT_NODE");
			this.Mapeador.Property(a => a.Ordem).HasColumnName("ORDEM");
			this.Mapeador.Property(a => a.CodUsuario).HasColumnName("COD_USUARIO").HasMaxLength(20);
			this.Mapeador.ToTable("TBUSUARIORECURSO"); 
		}
	}
}