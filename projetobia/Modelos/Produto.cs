namespace Modelos
{
public class Produto:Registro
{
    string nometransportadora;
    string telefone;
    string cnpj;
    string endereco;
    string fornecedor;
    string email;
    string cor;
    int quantidade;
    int codigodoproduto;
    int id;

     public void Setnometransportadora (string NT)
     {
        nometransportadora = NT;
     }
     public string Getnometransportadora ()
     {
        return nometransportadora;
     }

      public void Settelefone (string T)
     {
        telefone = T;
     }
     public string Gettelefone ()
     {
        return telefone;
     }
      public void Setcnpj (string C)
     {
        cnpj = C;
     }
     public string Getcnpj ()
     {
        return cnpj;
     }
      public void Setendereco (string E)
     {
        endereco = E;
     }
     public string Getendereco ()
     {
        return endereco;
     }
      public void Setcor (string COR)
     {
        cor = COR;
     }
     public string Getcor ()
     {
        return cor;
     }
      public void Setquantidade (int Q)
     {
        quantidade = Q;
     }
     public int Getquantidade ()
     {
        return quantidade;
     }
        public void Setid (int I)
     {
       id = I;
     }
     public int Getid ()
     {
        return id;
     }
       public void Setemail (string EMAIL)
     {
        email = EMAIL;
     }
     public string Getemail ()
     {
        return email;
     }
       public void Setfornecedor (string F)
     {
        fornecedor = F;
     }
     public string Getfornecedor ()
     {
        return fornecedor;
     }

     public void Setcodigodoproduto (int CP)
     {
        codigodoproduto = CP;
     }
     public int Getcodigodoproduto ()
     {
        return codigodoproduto;
     }

}
}