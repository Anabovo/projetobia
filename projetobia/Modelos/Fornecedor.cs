namespace Modelos
{
public class Fornecedor
{
    string nomefornecedor;
    string telefone;
    string cnpj;
    string endereco;
    string fornecimento;
    string email;

     public void Setnomefornecedor (string NF)
     {
        nomefornecedor = NF;
     }
     public string Getnomefornecedor ()
     {
        return nomefornecedor;
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

      public void Setforncimento (string FN)
     {
        fornecimento = FN;
     }
     public string Getfornecimento ()
     {
        return fornecimento;
     }

      public void Setemail (string EMAIL)
     {
        email = EMAIL;
     }
     public string Getemail ()
     {
        return email;
     }

 }
}