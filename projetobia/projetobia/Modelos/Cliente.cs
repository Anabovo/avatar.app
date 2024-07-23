namespace Modelos
{
public class Cliente
{
    string nome;
    string datadenascimento;
    string cpf;
    string endereco;
    int id;

     public void Setnome (string N)
     {
        nome = N;
     }
     public string Getnome ()
     {
        return nome;
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
       public void Setid (string I)
     {
       id = I;
     }
     public string Getid ()
     {
        return id;
     }
}
}