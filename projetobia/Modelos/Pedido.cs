namespace Modelos
{
public class Pedido
{
    int codigodocliente;
    string telefone;
    int codigodoproduto;
    string endereco;
    string cor;
    int quantidade;
    string frete;
    string valortotal;
    int id;

     public void Setcodigodocliente (int CDC)
     {
        codigodocliente = CDC;
     }
     public int Getcodigodocliente ()
     {
        return codigodocliente;
     }
      public void Setcodigodoproduto (int CDP)
     {
        codigodoproduto = CDP;
     }
     public int Getcodigodoproduto ()
     {
        return codigodoproduto;
     }

      public void Settelefone (string TEL)
     {
        telefone = TEL;
     }
     public string Gettelefone ()
     {
        return telefone;
     }
      public void Setendereco (string END)
     {
        endereco = END;
     }
     public string Getendereco ()
     {
        return endereco;
     }
      public void Setid (int ID)
     {
        id = ID;
     }
     public int Getid ()
     {
        return id;
     }
       public void Setcor (string COR)
     {
       cor = COR;
     }
     public string Getcor ()
     {
        return cor;
     }
     public void Setquantidade (int QNT)
     {
        quantidade = QNT;
     }
     public int Getquantidade ()
     {
        return codigodocliente;
     }
     public void Setfrete (string FRT)
     {
        frete = FRT;
     }
     public string Getfrete ()
     {
        return frete;
     }
     public void Setvalortotal (string VLT)
     {
        valortotal = VLT;
     }
     public string Getvalortotal ()
     {
        return valortotal;
     }
     
}
}