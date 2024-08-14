namespace Modelos
{
public class Cliente
{
    string nome;
    string datadenascimento;
    string cpf;
    string endereco;
    string telefone;
    int id;

     public void Setnome (string N)
     {
        nome = N;
     }
     public string Getnome ()
     {
        return nome;
     }
      public void Setdatadenascimento (string DN)
     {
        datadenascimento = DN;
     }
     public string Getdatadenascimento ()
     {
        return datadenascimento;
     }

      public void Settelefone (string T)
     {
        telefone = T;
     }
     public string Gettelefone ()
     {
        return telefone;
     }
      public void Setcpf(string CPF)
     {
        cpf = CPF;
     }
     public string Getcnpj ()
     {
        return cpf;
     }
      public void Setendereco (string E)
     {
        endereco = E;
     }
     public string Getendereco ()
     {
        return endereco;
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