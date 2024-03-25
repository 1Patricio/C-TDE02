//1. Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
string nome = "Paulo";
sbyte idade = 17;
double nota = 7.5;


Console.WriteLine (nome + " tem " + idade + " anos e nota: " + nota); //concatenação
Console.WriteLine ($"{nome} tem {idade} anos e nota: {nota}"); //interpolação




//2. Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
Console.WriteLine ($"{nome}\n tem {idade} anos\n e nota: {nota}");


//3. Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// ( ) double
// ( ) long
// ( ) decimal


// R= ( xxx ) double --> O double tem uma capacidade de armazenamento maior, então não há nenhum risco de perder dados durante a conversão






// 4. Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// ( ) double para long
// ( ) double para float
// ( ) decimal para float
// ( ) long para int
// ( ) double para decimal


//R = ( xxx ) double para long




//5. Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
// Console.WriteLine("Informe 3 letras");


// Console.WriteLine("Informe 1º letra");
// string letra1 = Console.ReadLine();
// Console.WriteLine("Informe 2º letra");
// string letra2 = Console.ReadLine();
// Console.WriteLine("Informe 3º letra");
// string letra3 = Console.ReadLine();

// Console.WriteLine($"Ordem Reversa: {letra3}{letra2}{letra1}"); //interpolação
// Console.WriteLine("Ordem Reversa: " + letra3 + letra2 + letra1); //concatenação




// 6. Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// ( F ) long resultado = 1.32;
// ( V ) var nome = “Maria”;
// ( V ) string resultado = 100.ToString();
// ( v ) A sequência de escape \n inclui uma nova linha
// ( F ) float f = 5.45; --> POIS O CERTO SERIA float f = 5.45f;
// ( V ) decimal valor = (decimal) 10.99f;
// ( F ) var status = null;
// ( V ) object o = 12.45m;
// ( V ) string titulo = true.ToString();
// ( F ) A sequencia \t inclui uma tabulação vertical




//7. Escreva um programa para receber dois valores via teclado do tipo double e a seguir realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo exibindo o resultado:
Console.WriteLine("Informe o valor de x");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Soma de x + y ={x+y}");
Console.WriteLine($"Subtração de x - y ={x-y}");
Console.WriteLine($"Multiplicação de x * y ={x*y}");
Console.WriteLine($"Potencia de x elevado a y = {Math.Pow(x, y)}");
double divisao = (double) x/y;
Console.WriteLine($"divisão de x / y ={divisao}");
Console.WriteLine($"Modulo de x % y ={x%y}");



// 8.Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login inválido’: (use o operador condicional ternário)


Console.WriteLine("Informe nome");
string nome2 = Console.ReadLine();

Console.WriteLine("informe senha");
int senha = Convert.ToInt32(Console.ReadLine());

string mensagem = (nome2 == "admin" || nome2 == "maria") && senha == 123 ? "Login feito com sucesso" : "Login Inválido";
Console.WriteLine(mensagem);



// 9. Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
Console.WriteLine("Informe x");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe y");
int y1 = Convert.ToInt32(Console.ReadLine());

string mensagem1 = (x1%2==0) ? "X é par" : "X não é par";
Console.WriteLine(mensagem1);

string mensagem2 = (y1%2==0) ? "Y é par" : "Y não é par";
Console.WriteLine(mensagem2);