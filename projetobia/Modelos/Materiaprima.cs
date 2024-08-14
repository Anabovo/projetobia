namespace Modelos
{
public class MateriaPrima
{
    string materiaprima;
    string telefone;
    string cnpj;
    string endereco;
    string tipofornecimento;
    string email;

     public void Setmateriaprima (string MP)
     {
        materiaprima = MP;
     }
     public string Getmateriaprima ()
     {
        return materiaprima;
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

     public void Setemail (string EMAIL)
     {
        email = EMAIL;
     }
     public string Getemail ()
     {
        return email;
     }

      public void Settipoforncimento (string TF)
     {
        tipofornecimento = TF;
     }
     public string Gettipofornecimento ()
     {
        return tipofornecimento;
     }
}
}