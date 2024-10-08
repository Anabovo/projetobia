using Modelos;

namespace Controles;

public class ControlePedido : BaseControle
{
  //----------------------------------------------------------------------------

  public ControlePedido() : base()
  {
    NomeDaTabela = "Pedidos";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idPedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return collection.FindOne(d => d.id == idPedido);
  }

  //----------------------------------------------------------------------------

  public virtual List<Pedido>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return new List<Pedido>(tabela.FindAll().OrderBy(d => d.id));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idPedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Delete(idPedido);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Pedido Pedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Upsert(Pedido);
  }

  //----------------------------------------------------------------------------
}