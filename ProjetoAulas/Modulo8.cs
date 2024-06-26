// namespace Cadastro;

using System.Dynamic;

namespace Cadastro
{
    public  static class Calculos
    {
        public static  int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }
    public class Produto

    {   private int Id;

        public string Descricao { get; set;}

        // public readonly int Estoque;

         public int Estoque {get;}

        public  Produto()

        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
             Console.WriteLine(GetId() +  " - " + Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

         public int GetId()
         {
             return Id;
         }   

    }

    public class Pessoa
    {
        public int Id {get;set;}
        public string Endereco {get;set;}
        public string Cidade {get;set;}
        public string Cep {get;set;}

        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("CEP: " + Cep );
        }

    }
    public class  PessoaFisica : Pessoa
    {
        public string CPF {get;set;}

        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }
    public class Funcionario : PessoaFisica
    {
        public string Matricula {get;set;}
    }

    public sealed class Configuracao
    {
        public string Host {get;set;}
    }

    public abstract class Animal
    {
        public string Nome {get;set;}

        public abstract string Getinformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome animal: " + Nome);
            Console.WriteLine("Informacoes: " + Getinformacoes());
        }


    }
    public class Cachorro : Animal
    {
        public string Raca { get; set; }

        public string Situacao(int idade){
            if(idade > 10)            
                return "Morto";
            
            return "Vivo";
        }

        public override string Getinformacoes()
        {

            return "Cachorro é um bom amigo!";        
        }
    }
}
