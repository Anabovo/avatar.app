namespace Modelos
{
public class Produto
{
    string nometransportadora;
    string telefone;
    string cnpj;
    string endereco;
    string fornecimento;
    string email;

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
}
}