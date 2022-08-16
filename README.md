# Estudos_DotNetC#
Representa as Instruções de códigos relacionados ao Fundamentos DotNet C#


Converções 

    Cases - Os mais utilizados no c# são camelCase e o PascalCase.
    
        camelCase     
        PascalCase    
        snake_case    
        spinal-case


    Escrita

        Nunca abrevie sempre escreva por extensil 
        sempre renomear o arquivo fisico com o mesmo nome da classe


Operadores Condicionais 
switch - case,
if - else,
bool - true or false,
while - do,
for ().

    static void Main(string[] args)
    {
      System.Console.WriteLine("Digite uma letra");
      string letra = Console.ReadLine();

      if(letra == "a" ||
      letra == "e" ||
      letra == "i" ||
      letra == "o" ||
      letra == "u") 
      {
        System.Console.WriteLine("Vogal");
      }

      switch (letra)
      {
      case "a":
      case "e":
      case "i":
      case "o":
      case "u":
      
      System.Console.WriteLine("vogal");
      break;
                
      default:
      System.Console.WriteLine("Não é um vogal");
      break;
     }

Operadores lógicos 
      
   Operador OR (Pipe, ||) 
    
    System.Console.WriteLine("Digite uma letra");
            string letra = Console.ReadLine();

            if(letra == "a" ||
            letra == "e" ||
            letra == "i" ||
            letra == "o" ||
            letra == "u") 
            {
                System.Console.WriteLine("Vogal");
            }
Boolean
  
    bool ehMaiorDeIdade = true;
    bool possuiAutorizacaoDoResponsavel = false;

    if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
    {
        System.Console.WriteLine("Entrada liberada");
    }
    else
    {
        System.Console.WriteLine("Entrada não permitida");
    }

Operador AND (&&)
  
    bool possuiPresencaMinima = true;
        double media = 7;

        if (possuiPresencaMinima && media >= 7)
        {
            System.Console.WriteLine("Aprovado");
        }
        else
        {
            System.Console.WriteLine("Reprovado");
        }

Operador NOT (!)
  
    bool choveu = false;
    bool estahTarde = false;
    if (!choveu && !estahTarde)
    {
        System.Console.WriteLine("Vou pedalar");
    }
    else
    {
        System.Console.WriteLine("Não vou pedalar, deixa pra outro dia");
    }

Operadores Aritméticos e a classe Math
   
    public class Calculadora
    {
        
        public void Somar(int x, int y)
        {
            System.Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtracao(int x, int y)
        {
            System.Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            System.Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            System.Console.WriteLine($"{x} / {y} = {x / y}");
        }

Potencia
     
     public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y)
            System.Console.WriteLine($"{x} ^ {y} = {pot}");
        }

Trigonometria

    public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);

            System.Console.WriteLine($" O Seno de {angulo}º =  {Math.Round(seno, 4) } ");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);

            System.Console.WriteLine($" O Coseno de {angulo}º =  {Math.Round(coseno, 4)} ");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);

            System.Console.WriteLine($" O Tangente de {angulo}º =  {Math.Round(tangente, 4)} ");
        }

Estrutura de Repetição 
- FOR

      int numero = 5;
      for (int contador = 0; contador <= 10; contador++)
      {
        System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
      }

- WHILE
    
      while (contador <= 10)
      {
        System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;

        // Interrompendo o fluxo de repetição
        if (contador == 5)
        {
            break;    
        }

      }

- DO WHILE 
    
      int numero, soma = 0;

      do
      {
        System.Console.WriteLine("Digite um número (0 para)");
        numero = Convert.ToInt32(Console.ReadLine());

        soma += numero;

      } while (numero != 0);

      System.Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");

Construindo um menu interativo
     
     string opcao;

     while (true)
      {
        System.Console.WriteLine("Digite a sua opção");
        System.Console.WriteLine("1 - Cadastrar cliente");
        System.Console.WriteLine("2 - Buscar cliente");
        System.Console.WriteLine("3 - Apagar cliente");
        System.Console.WriteLine("4 - Encerrar");

        opcao = Console.ReadLine();

        switch(opcao)
        {
            case "1":
            System.Console.WriteLine("Cadastro do cliente");
            break;

            case "2":
            System.Console.WriteLine("Busca do cliente");
            break;

            case "3":
            System.Console.WriteLine("Apagar cliente");
            break;

            case "4":
            System.Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;

            default:
                System.Console.WriteLine("Opção Inválida");
                break;
        }   
    }


    
