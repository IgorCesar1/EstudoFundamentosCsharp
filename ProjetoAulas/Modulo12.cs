namespace Modulo12;

public class TrabalhandoComExcecoes
{

    public void AulaGerandoException()
    {
        while(true)
        {
            Console.WriteLine("Informe um número:");
            var numero = Console.ReadLine();
            var resultado = 500/ int.Parse(numero);
            Console.WriteLine("Resultado:" + resultado);

        }
       
    }

    public void AulatratandoException()
    {
        while(true)
        {
            try
            {
                Console.WriteLine("Informe um número:");
                var numero = Console.ReadLine();
                var resultado = 500/ int.Parse(numero);
                Console.WriteLine("Resultado:" + resultado);
            }

            catch(DivideByZeroException exeception)
            {
                
                 Console.WriteLine("Ocorreu um erro de divisão!" + exeception.Message);
                 Console.WriteLine("Stack" + exeception.StackTrace);
            }
            catch(Exception exeception)
            {

                 Console.WriteLine("Ocorreu um erro!" + exeception.Message);
                 Console.WriteLine("Stack" + exeception.StackTrace);
            }
            

        }
       
    }


}