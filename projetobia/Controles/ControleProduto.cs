using Modelos;


namespace Controles;

public class ControleProduto : BaseControle
{
  //----------------------------------------------------------------------------

  public ControleProduto() : base()
  {
    NomeDaTabela = "Produtos";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idProduto)
  {
    var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
    return collection.FindOne(d => d.id == idProduto);
  }

  //----------------------------------------------------------------------------

  public virtual List<Produto>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Produto>(NomeDaTabela);
    return new List<Produto>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idProduto)
  {
    var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
    collection.Delete(idProduto);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Produto Produto)
  {
    var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
    collection.Upsert(Produto);
  }

  //----------------------------------------------------------------------------
}