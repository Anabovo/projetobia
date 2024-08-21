using Modelos;

namespace projetobia.Controles;

public class MateriaprimaControle : ControleBase
{
  //----------------------------------------------------------------------------

  public MateriaprimaControle() : base()
  {
    NomeDaTabela = "Materiasprimas";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idMateriaprima)
  {
    var collection = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    return collection.FindOne(d => d.IdMateriaPrima == idMateriaprima);
  }

  //----------------------------------------------------------------------------

  public virtual List<Materiaprima>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    return new List<Materiaprima>(tabela.FindAll().OrderBy(d => d.IdMateriaPrima));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idMateriaprima)
  {
    var collection = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    collection.Delete(idMateriaprima);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Materiaprima Materiaprima)
  {
    var collection = liteDB.GetCollection<Materiaprima>(NomeDaTabela);
    collection.Upsert(Materiaprima);
  }

  //----------------------------------------------------------------------------
}