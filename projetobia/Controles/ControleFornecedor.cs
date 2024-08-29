using Modelos;

namespace Controles;

public class ControleFornecedor : BaseControle
{
  //----------------------------------------------------------------------------

  public ControleFornecedor() : base()
  {
    NomeDaTabela = "Fornecedores";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idFornecedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    return collection.FindOne(d => d.id == idFornecedor);
  }

  //----------------------------------------------------------------------------

  public virtual List<Fornecedor>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    return new List<Fornecedor>(tabela.FindAll().OrderBy(d => d.nomefornecedor));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idFornecedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    collection.Delete(idFornecedor);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Fornecedor fornecedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    collection.Upsert(fornecedor);
  }

  //----------------------------------------------------------------------------
}