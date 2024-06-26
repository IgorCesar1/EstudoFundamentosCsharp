
// TRABALHANDO COM VARIÁVEIS
/*

Console.WriteLine("Primeiro programa");

int idade = 33;
Console.WriteLine(idade);
string nomePessoa = "Rafael Almeida";
Console.WriteLine(nomePessoa);
decimal valor = 200.99m;
Console.WriteLine(valor);
double valorDouble = 200.99;
Console.WriteLine(valorDouble);
float valorFloat = 200.99f;
Console.WriteLine(valorFloat);
var idadeNova = 34;
Console.WriteLine(idadeNova);
char flag = 'Y';
Console.WriteLine(flag);
bool ativo = true;
Console.WriteLine(ativo);


// CONSTANTE

const string descricao = "Curso CSHARP";
descricao = "Curso";

Console.WriteLine(descricao);





// OPERADORES ARITMÉTRICOS 


int numero01 = 1; 
var numero02 = 2;

int soma = numero01 + numero02;
Console.WriteLine(soma);

int subtracao = numero01 - numero02;
Console.WriteLine(subtracao);

int multiplicacao = (numero01 * numero02) * 20;
Console.WriteLine(multiplicacao);

int divisao = numero01 / numero02;
Console.WriteLine(divisao);




// OPERADORES RELACIONAIS 


bool igual = numero01 == numero02;
Console.WriteLine(igual);

bool maior = numero02 > numero01;
Console.WriteLine(maior);

bool menor = numero02 < numero01;
Console.WriteLine(menor);


bool maiorouigual = numero02 >= numero01;
Console.WriteLine(maiorouigual);

bool menorouigual = numero02 <= numero01;
Console.WriteLine(menorouigual);

bool diferente = numero02 != numero01;
Console.WriteLine(diferente);



// OPERADORES LÓGICOS 


int numero01 = 1; 
var numero02 = 2;


bool valido = numero02 > numero01 && 6 > 7;
Console.WriteLine(valido);

bool valido2 = !(numero02 > 3);
Console.WriteLine(valido2);




// OPERADOR TERNÁRIO 



int numero01 = 1; 
var numero02 = 2;

bool ativo = true;
string status = !ativo ? "Cadastro ativo" : "Cadastro inativo";
Console.WriteLine(status);





// PRÁTICA 


/* CADASTRO SIMPLES*/


/*


var Nome = Insiraoseunome();
Console.WriteLine(Nome);
string Insiraoseunome()
{
    return "Insira o seu nome:";
}

var Idade = Insirasuaidade();
Console.WriteLine(Idade);
string Insirasuaidade()
{
    return "Insira a sua idade:";
}

var Cidade = Insirasuacidade();
Console.WriteLine(Cidade);
string Insirasuacidade()
{
    return "Insira a sua cidade:";
}

*/




// ARRAY LIST 

 /*

//using System.Collections;

var arrayList = new ArrayList();

arrayList.Add(1);
arrayList.Add("Igor");
arrayList.Add(true);

Console.WriteLine(arrayList[1]); // acesso por indice

//arrayList.Remove(1); // Para remover um item da lista

//arrayList.Clear(); // Para limpar toda a lista

foreach(var item in arrayList) // para percorrer e buscar todos os itens da lista


{
Console.WriteLine(item);
}

*/




// ARRAY TIPADO COM NÚMERO E STRING

 /*

 var arrayTipadoNumero = new int [3] {1,2,3}; // Para criar um arraytipado onde aceita apenas número

var arrayTipadoNumero = new int [3];  // Para desfazer o array anterior e criar uma nova lista

arrayTipadoNumero[0] = 5; // Para mudar um item o arraytipado OBS: O número dois representa o segundo item ou seja a contagem sempre começa por ZERO, 1, 2 e etc.
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10;

 Array.Resize(ref arrayTipadoNumero, 100); // Para aumentar a minha lista de array, incluindo novos números
/arrayTipadoNumero[2] = 100; // Neste caso não podemos pedir um indice maior do que o tamanho da coleção que predefinimos


foreach(var item in arrayTipadoNumero)

{
    Console.WriteLine(item);
}

var arraytipadostring = new string[2] {"Rafael", "Almeida"}; // Para um arraytipado com string, seguindo a mesma lógica

foreach(var item in arraytipadostring)

{

Console.WriteLine(item);

}

*/








// LISTA GENÉRICA

/*

var lista = new List<string>(10)  // Criando uma lista genérica

{
    "Rafael",
    "Almeida",
};


lista.Add("Rafael");
lista.Add("Almeida");
lista.Add("Curso");


var nome = lista[0]; 

lista.RemoveAt(1); // Para remover um item da lista

foreach(var item in lista)

{

Console.WriteLine(item);

}
*/


 /*

/// CRIANDO DICIONÁRIO

var dicionario = new Dictionary<string, string>()
{
    {"CASA", "Igor02"},
    {"CARRO", "Cesar"},
};

dicionario.Add("NOME", "Curso");

dicionario["Curso"] = "Curso";

var nome = dicionario["Curso"];
Console.WriteLine(nome);

foreach(var item in dicionario)
{

Console.WriteLine(item.Value);

}
*/



/// queue
 /*
var queue = new Queue<string>();
queue.Enqueue("Curso");
queue.Enqueue("Curso02");

 var nome = queue.Peek();
 var nome1 = queue.Peek();


var nome = queue.Dequeue();
var nome1 = queue.Dequeue();

Console.WriteLine(nome);
Console.WriteLine(nome1);


/
foreach(var item in queue)
{

Console.WriteLine(item);

}
*/






// STACK

 /*

var stack = new Stack<string>();
stack.Push("Rafael");
stack.Push("Almeida");

var nome = stack.Pop();
var nome1 = stack.Pop();
Console.WriteLine(nome);
Console.WriteLine(nome1);

foreach(var item in stack)
{
Console.WriteLine(item);

}
*/



// IF/ELSE IF/ELSE

/*

var diaDaSemana = 0;
var diaDetrabalho = false;

if(diaDaSemana == 0 && diaDetrabalho == true)
{
Console.WriteLine("Hoje é domingo!");
}

else if(diaDaSemana == 0 && diaDetrabalho == false)

{
    Console.WriteLine("Hoje é domingo mas não é dia de trabalho!");

}

else
{
    Console.WriteLine("Hoje não é domingo!");

}

if (diaDaSemana == 6)
{
    Console.WriteLine("Hoje é domingo!");

}
else if (diaDaSemana == 1)
{
    Console.WriteLine("Hoje é segunda!");

}

else if (diaDaSemana == 2)
{
    Console.WriteLine("Hoje é terça!");

}

else if (diaDaSemana == 3)
{
    Console.WriteLine("Hoje é quarta!");

}

else if (diaDaSemana == 4)
{
    Console.WriteLine("Hoje é quinta!");

}

else if (diaDaSemana == 5)
{
    Console.WriteLine("Hoje é sexta!");

}

else if (diaDaSemana == 6)
{
    Console.WriteLine("Hoje é sábado!");

}

else 
{
    Console.WriteLine("Dia da semana inválido!");

}

switch (diaDaSemana)
{
    case 0:
         Console.WriteLine("Hoje é Domingo!");
         break;
    case 1:
         Console.WriteLine("Hoje é Segunda!");
         break;
    case 2:
         Console.WriteLine("Hoje é Terça!");
         break;
    case 3:
         Console.WriteLine("Hoje é Quarta!");
         break;
    case 4:
         Console.WriteLine("Hoje é Quinta!");
         break;
    case 5:
         Console.WriteLine("Hoje é Sexta!");
         break;
    case 6:
         Console.WriteLine("Hoje é Sábado!");
         break;

}

  
switch(diaDaSemana < 1)
{
    case true:
         Console.WriteLine("Hoje é Domingo!");
         break;

    case false:
         Console.WriteLine("Dia da semana inválido!");
         break;


}

   */