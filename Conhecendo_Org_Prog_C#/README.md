#Arquivos de projeto

    .csproj: Contém informações referente a um projeto (build, debug, versão)
    .sln: Contém informações que carregam um agrupamento de projetos

Criando uma solution e agrupando projetos

Array 

    1. int[] array = new int[4];
    2. int[] array = new int[] {42, 75, 74, 61};
    3. string[] nomes = {"Jan, "Fev};

Array e Listas coleção do mesmo objeto

    int[] arrayInteiros = new int[3];
    arrayInteiros[0] = 72;
    arrayInteiros[1] = 64;
    arrayInteiros[2] = 50;

    for (int contador = 0; contador < arrayInteiros.Length ; contador++)
    {
        System.Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");   
    }

Lista
  
    List<string> listaString = new List<string>();

    listaString.Add("SP");
    listaString.Add("BA");
    listaString.Add("PA");

    for (int contador = 0; contador < listaString.Count; contador++)
    {
        System.Console.WriteLine($"Posição Nº {contador} - {listaString[co]}");
    }

Redimensionando um array
    
    int[] arrayInteiros = new int[3];
    arrayInteiros[0] = 72;
    arrayInteiros[1] = 64;
    arrayInteiros[2] = 50;

    Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Percorrendo o array com o FOR

    System.Console.WriteLine("Percorrendo o array com o FOR");
    for (int contador = 0; contador < arrayInteiros.Length ; contador++)
    {
        System.Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");   
    } 

Percorrendo o array com o FOREACH
  
    System.Console.WriteLine("Percorrendo o array com o FOREACH");

    int contadorForeach = 0;
    foreach(int valor in arrayInteiros)
    {
        System.Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
        contadorForeach++;
    }

Copiando um array para outro

    int[] arrayInteiros = new int[3];
    arrayInteiros[0] = 72;
    arrayInteiros[1] = 64;
    arrayInteiros[2] = 50;

    // copiando array 
    int[] arrayInteiroDobrado = new int[arrayInteiros.Length * 2];
    Array.Copy(arrayInteiros, arrayInteiroDobrado, arrayInteiros.Length);

    // aumentando o tamanho do array
    //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

    // Percorrendo o array com o FOR
    System.Console.WriteLine("Percorrendo o array com o FOR");
    for (int contador = 0; contador < arrayInteiros.Length ; contador++)
    {
        System.Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");   
    } 

    // Percorrendo o array com o FOREACH
    System.Console.WriteLine("Percorrendo o array com o FOREACH");

    int contadorForeach = 0;
    foreach(int valor in arrayInteiros)
    {
        System.Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
        contadorForeach++;
    }

Comentários e boas práticas
    
    Os comentários servem para documentar o seu código, explicando um determinado método ou execução.
    Auxiliam outros programadores a entender o que está acontecendo.

    "//": É representado um um linha unica
    "/*" e "*\" comenta com quebra de linhas
    "<sumary>" Permite documentar classe, métodos, parâmetros, etc
