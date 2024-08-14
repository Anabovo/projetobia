namespace Modelos
{
public class Transpotadora
{
    string nometransportadora;
    string telefone;
    string cnpj;
    string endereco;
    string fornecimento;
    string email;
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

        public void Setfornecimento (string F)
     {
        fornecimento = F;
     }
     public string Getfornecimento ()
     {
        return fornecimento;
     }

        public void Setemail (string EM)
     {
        email = EM;
     }
     public string Getemail ()
     {
        return email;
     }

        public void Setid (int I)
     {
       id = I;
     }
     public int Getid ()
     {
        return id;
     }
 }
}