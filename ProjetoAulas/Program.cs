// Console.WriteLine("Primeiro programa");


using Cadastro;

namespace Aplication
{
    public class Program
    {
        static void Main(string[] args)
        {
                //AulaClasses();
                //AulapropiedadeSomenteLeitura();
               // AulaHeranca();
               //Aulaclasseselada();
              // AulaClasseAbstrata();
               TrabalhandoComStrings();
        } 

             private static void TrabalhandoComStrings()
             {
                var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
               // trabalhandoComStrings.ConverterParaLetrasMinusculas();
                //trabalhandoComStrings.ConverterParaLetrasMaiusculas();
                 //trabalhandoComStrings.Aulasubstrings();
               // trabalhandoComStrings.AulaRange();
                 //trabalhandoComStrings.AulaContains();
                 //trabalhandoComStrings.AulaTrim();
                 // trabalhandoComStrings.AulaStartWithEndsWith();
                 //trabalhandoComStrings.AulaReplace();
                 trabalhandoComStrings.AulaLength();



             }
             private static void Conversores()
             {
                var conversores = new Conversores.Conversor();
                //conversores.ConvertAndParse();
                conversores.AulaTryParse();
             }


             private static void AulaClasseAbstrata()
             {
                var cachorro = new Cachorro();                
                cachorro.Nome = "RALF";
                Console.WriteLine(cachorro.Raca = "Pastor Alemão");
                Console.WriteLine(cachorro.Situacao(9));
                cachorro.ImprimirDados();

                Console.WriteLine("-------------------------------------------");

                var cachorroGrande = new Cachorro();                
                cachorroGrande.Nome = "RALF";
                Console.WriteLine(cachorroGrande.Raca = "Vira Lata");
                Console.WriteLine(cachorroGrande.Situacao(11));
                
                cachorroGrande.ImprimirDados();
             }

            private static void Aulaclasseselada()
            {
                //var configuracao = new Cadastro.Configuracao();
               // configuracao.Host = "localhost";
                var configuracao = new Cadastro.Configuracao
                {
                    Host = "localhost"
                };
                   Console.WriteLine(configuracao.Host);
            }

            private static void AulaHeranca()
            {
               /* var PessoaFisica = new Cadastro.PessoaFisica();
                PessoaFisica.Id = 1;
                PessoaFisica.Endereco = "Endereco Teste";
                PessoaFisica.Cidade = "Cidade Teste";
                PessoaFisica.Cep = "1,2,3,4,5,6,1,2";
                PessoaFisica.CPF = "1,2,3,4,5,6,0,2";
                PessoaFisica.ImprimirDados();
                PessoaFisica.ImprimirCpf();

                */
                 var funcionario = new Cadastro.Funcionario();
                funcionario.Id = 10;
                funcionario.Endereco = "Endereco Teste";
                funcionario.Cidade = "Cidade Teste";
                funcionario.Cep = "1,2,3,4,5,6,1,2";
                funcionario.CPF = "1,2,3,4,5,6,0,2";
                funcionario.ImprimirDados();
                funcionario.ImprimirCpf();

            }

            private static void AulaClasses()
            {
                var resultado = Cadastro.Calculos.SomarNumeros(2,3);
                Console.WriteLine(resultado);

                /*
                 var produto = new Cadastro.Produto();
                produto.SetId(1);

                produto.Descricao= "Teclado";

                produto.ImprimirDescricao();
                Console.WriteLine(produto.GetId());
                */
            }

            private static void AulapropiedadeSomenteLeitura()
            {
                                
                 var produto = new Cadastro.Produto();
                produto.Descricao = "Mouse";
                //produto.Estoque = 1;
                Console.WriteLine(produto.Estoque);
            }
  
  
        }
}






