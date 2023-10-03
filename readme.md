# Curso: Fundamentos do C# - André Baltieri 
Curso: [Balta.io](https://balta.io/)

## Linguagens e Compiladores
  - Apresentação
  - Linguagens de programação
  - Alto e baixo nível
  - De alto nível.
  - Linguagem compilada e interpretada
  - Compilada e interpretada
  - C# é uma linguagem compilada.
  - Tipagem de dados
  - Fortemente tipada.
  - Revisão
## C#
  - Por que utilizar C#?
    >Linguagem com alto nível de maturidade.
    >Possui uma enorme comunidade.
    >Microsoft por trás dos bastidores com o suporte.
  - C# como primeira linguagem
    >Possui muito material e é altamente desafiadora.
  - Código gerenciado
    >Gerenciado pelo Runtime CLR (Common Language Runtime). 
    >Gerencia memória, segurança e outro recursos.
  - Compilação e gerenciamento
    >Cada linguagem possue seu compilador.
    >Compilação inicial não gera código binário.
    >Criada a IL (Intermediate language)
    >E depois o binário será gerado.
  - IL
    >Todas as linguagens Microsoft inicialmente são compilada para IL.
    >C#, VB.NET, F#, Cobol, .Net
    >Isso permite ter código de linguagens diferentes no mesmo projeto. Como: C# e VB.NET.
    >Nunca no mesmo arquivo, somente em arquivos diferentes.
    >Entretanto prática não é muito comum.
    >Ao final é gerado o binário que é igual para todas linguagens.
    >O processo de conversão do IL para o Binário é conhecida como JIT.
    >JIT (Just in Time).
  - Revisão
 
## Frameworks

  - Frameworks
    >São estruturas prontas, que diminuem os riscos dos projetos e agilizam o desenvolvimento.
  - .NET Framework
    >É o legado.
  - .NET Core
    >É o atual
  - .NET Standard
    >Responsável pela padronização entre as linguagens.
  - .NET 5
    >É o futuro, com a unificação do .NET Framework com o .NET Core 
  - LTS
    >Long Term Support, principal opção.
  - Versionamento
  - Runtime e SDK
    >Runtime executa.
    >Software Developmant Kit (SDK) cria as aplicações .NET
    >Em produção utiliza-se o runtime
  - Revisão

### .NET

  - Instalação
    > Baixando dotnet do site Microsoft.
      Baixando versão mais atual do SDK.
      Instalação Windows simples somente next até o final.
      Checando versão via Power Shell : dotnet --info

  - dotnet cli
    > CLI Command Line Interface
    Comandos via CLI dotnet.
```
    dotnet --list-sdks
    dotnet --list-runtimes
    dotnet -h | --help
    dotnet --info
```` 

  - VS Code
    > Baixar Visual Studio Code
    Instalar extensões
    Necessárias:
    C# id : ms-dotnettools.csharp
    Sugeridas:
    One Dark Pro -> vscode-icons id: vscode-icons-team.vscode-icons
    Comandos de atalhos do VSCode:
    "Ctrl + ," = Abre setting, que pode ser editado por json também.

  - Tipos de projeto
    > Web, API, ML, DLL...
    Pra cada projeto deve ser previamente definido para obter o resultado desejado.
    Tipo : Class Library - Gera uma DLL.
    Tipo : Console Application
    Tipo : Web
    Tipo : Tests
    Comando para criação de projetos:

      ```    
        dotnet new console 	=> Novo Console Application
        dotnet new classlib => Novo Class Library
        dotnet new web 		=> Novo projeto ASP.NET Core
        dotnet new mvc 		=> Novo projeto ASP.NET Core
        dotnet new webapi 	=> Novo Projeto ASP.NET Core
        dotnet new mstest 	=> Novo projeto Microsoft Teste
      ```

    > Paramentros
      -o para definir o local do projeto

  - Fluxo de execução
    > Para checar se você está em um projeto C# verifice que na pasta há um arquivo com extenção ".csproj"
    Ao iniciar um projeto executar dentro da pasta do projeto o comando : "dotnet restore" , para que o dotnet faça uma atualização dos arquivos, baixando todas as dependências e pacotes adicionais ao dotnet que esta aplicação precisa.
    Compilação via linha de comando "dotnet build".
    Comando para limpesa dos arquivos de cash. "dotnet clean".
    Para execuar a aplicação. "dotnet run"
    Comandos da aula:

      ```
        dotnet restore
        dotnet clean
        dotnet build
        dotnet run
      ```

  - Variáveis de ambiente
    > Utilizadas para definir o local em que a aplicação estará sendo executada, existem casos de projetos que possuem ambientes de desenvolvimento, testes, homologação e produto. 
    Exemplos de execução passando parâmetros para definição de ambiente:

      ```
      dotnet run --environment=$SEU_AMBIENTE
      dotnet run --environment=$development
      ```     

  - Estrutura do App
    > Executando dentro da pasta da aplicação "code ." Irá abrir o vscode com os arquivos do projeto.
    Arquivo base da estrutura
    MeuApp.csproj (arquivo formato XML)
    Program.cs  (arquivo codigo fonte)

  - Debug
    >Executado modo debug pelo VSCode, Ctrl+Shift+D.
    Pasta .vscode deve existir nas pastas do seu projeto.
    Caso não exista, ao entrar na opção de debug o vscode irá perguntar se deseja criar o "launch.jason" file, neste momento será criada a pasta ".vscode" que habilita para executar o debug da aplicação. Selecionar um projeto ".Net Core".

  - Revisão

## Linguagem de Programação

  - Notas importantes
    - Nome de projeto sem utilização de espaços ou caracteres especiais.
      - Ex: "Meu APP", "Meu App", "Meu_App", "Meu@pp".
      - Ex: "MeuApp" boa prática.
    - Evitar também no path de pastas com caracteres especiais ou mesmo muito longos.
    - C# é case sensitive, observar as declarações maiusculas de letras minúculas.
      - Teste é diferente de teste.  

  - Escopo de um programa
    - Importações
      - Ficam no inicio do arquivo.
      - Ex: módulo de acesso banco de dados, módulo de escrita em disco.
      - Definida por "using"
    - Namespace
      - Divisão/Separação lógica.
    - Classe
      - O programa
    - Método principal
        - Método Main

  - Namespaces
    - O C# não aceita um mesmo namespace, mesmo que dentro de pastas diferentes no mesmo projeto. Caso seja criado e necessite de namespace igual no projeto, diferenciar ao final do namespace com ".$nomedapasta"
    - O mesmo namespace é permitido desde que a classe seja diferente.
    - Exemplo: \MeuApp -> MeuApp
               \Teste\MeuApp -> MeuApp.Teste
    - Ideal criar um namespace e uma classe por arquivo.

  - Using
    - Tudo que for necessário usar no .Net deverá ser importado na cláusula using.
    - Serve para organizar organizar e estruturar em pastas e namespaces.
    - Organização física são as pastas.
    - Organização lógica são os namespaces.

  - Variáveis
    - Algo utilizado para armazenar uma informação. 
    - E esta informação pode ser alterada, variar a qualquer momento.
    - C# por ser fortemente tipada ela existem os tipos.
    - Na sintaxe o tipo vem antes do nome da variável.   
      - Exemplo:
        - int idade; //OK inicia variável com 0.
        - int idade = 25; //OK iniciar variável com 25.
        - var idade = 25; //OK iniciar variável com 25.
        - var idade; // ERRADO tipo não informado.
    - Nome de variável uma boa prática é criá-la com nomes que tenham haver com a informação que a variável irá armazenar.
    - Por convenção variáveis iniciam com letra minúsculas.

  - Constantes
    - Semelhante a variável, entretanto não pode ser alterado.
    - Diferente do var utiliza-se const.
    - Por convenção declara-se em maíucula e separadas por "_".
      - Exemplo:
        - const int IDADE_MINIMA; //OK inicia variável com 0, entretanto não é ideal.
        - const int IDADE_MINIMA = 25; //OK inicia com 25.
        - const var IDADE_MINIMA = 25; //ERRADO não utiliza-se var.
        - const var IDADE_MINIMA; //ERRADO não utiliza-se var.

  - Palavras reservadas
    - São Keywords reservadas ao C# que não é permitida a utilização para criação de variáveis.

  - Comentários
    - No C# há três forma de comentário.
      - Primeira: 
        - // -> Manual para uma linha
        - Ctrl + K + C -> Automático via vscode marca bloco selecionado.
        - Ctrl + K + U -> Automático via vscode desmarca bloco selecionado.
      - Segunda:
        - /* */ -> Manual para um bloco
      - Terceira:
        - Notação XML ///<>.

  - Tipos primitivos
    - São os tipos bases que temos no .Net.
    - Também conhecidos como "built-in types".
    - Também chamados de Tipos de Valor (value type).
      - Esses tipos de valor são classificados como:
        - Tipos Simpes (Simple Type)
        - Enumeradores (Enums)
        - Estruturas (Structs)
        - Tipos Nulos (Nullable Types)
    - Cada tipo primitivo possue uma capacidade:
      int -> -2,147,483,648 até 2,147,483,648

  - System
    - É o tipo raiz. Tipo base. Todos deviram do system.

  - Byte
    - Utilizado para representar um byte.
    - O tipo "sbyte" permite valores negativos.
    - São tipos chamados:
      - Ocupação de memória.
      - Signed: Com sinal "-".
      - Unsigned: Sem sinal.
    - Definições:
      - byte (8 bits) -> Vai de 0 até 255.
      - sbyte (8 bits) -> Vai de -128 até 127.
    - Exemplo : byte nomeVariavel = 255

  - Números inteiros
    - São representados pelo:
      - short/ushort
      - int/uint
      - long/ulong
    - São tipos com "u" no inicio da declaração são:
      - Unsigned: Sem sinal.
      - Signed: Com sinal "-".
      - Desta forma em caso da sua variável não trabalhar com valores negativos, é um tipo aconselhável.
   - Definições:
     - Ocupação de memória.
     - short (16 bits)  
       - -32.768 até 32.767
     - ushort (16 bits)  
       - 0 até 65.535
     - int (32 bits)  
       - -2.147.483.648 até 2.147.483.647
     - uint (32 bits)  
       - 0 até 4.294.967.295
     - long (64 bits)  
       - -9.223.372.036.854.775.808 até 9.223.372.036.854.775.807
     - ulong (64 bits) 
       - 0 até 18.446.744.073.709.551.615 
     - Em caso de declaração somente com o var:
       - var idade = 46; 
       - Por padrão o C# irá formatar como tipo int.

  - Números reais
    - Número que exitem maior precisão, ou seja, valores fracionados.
    - Permitem positivos ou negativos, entretanto não possuem a declaração usigned.
    - Definições:
      - Ocupação de memória.
      - float (notação F) (32 bits)
        - -3.402823e38 até 3.402823e38  
      - double (64 bits)
        - -1.79769313486232e308 até 1.79769313486232e308
      - decimal (notação M) (128 bits)
        - (+ ou -) 1.0 x10e-28 até 7.9x10e28   
    - Declaração
      - float salarioMinimo = 1.500f;
      - double salario = 1.600
      - decimal reajusteSalarial = 20.50m;
      - Em caso de declaração somente com o var:
        - var salario = 1.400; 
        - Por padrão o C# irá formatar como tipo Double.

  - Boolean
    - Armazena true ou false(verdadeiro ou falso).
    - Definição:
      - Ocupação de memória:
        - bool (8 bits)
        - true ou false

  - Char
    - Utilizado para armazernar um caracter no formato Unicode.
    - Atribuição do valor é por ASPAS SIMPLES ' '.
    - Definição: 
      - Ocupação de memória.
        - char (16 bits)
        - Qualquer caractere.

  - String
    - Armazena uma lista/conjunto de caracteres (char).
    - Atribuição do valor é por ASPAS DUPLAS " ".
    - É um tipo com imensas possbilidades e temas a se tratar.
    - Definição:
      - Ocupação de memória.  
        - string(?) - É definido pelo tamanho declarado.
    - Declaração:
      - string primeiraLetra = "D";
      - string texto = "Meu texto completo";
      - var documento = "123456789abcde";
        
  - Var
    - O var ele assimila o primeiro tipo declarado. 
    - A partir do momento que você atriui um valor para variável, o C# define esse tipo para variável.

  - Object
    - Tipo genérico que recebe qualquer valor ou objeto.
    - Da mesma maneira do var assume o primeiro valor atribuido.
    - Uma variável declarada como object não exige que seja atribuido o tipo inicialmente.
    
  - Nullabel Types
    - Sgnifica vazio, nada
    - Diferente de zero ou uma string vazia.
    - Todo tipo primitivo pode receber o valor null.
    - Atribuição desse tipo é pelo "null"
    - Sempre que for feito a atribuição de null. Deve ser feita da seguinte forma:
      - int? idade = null; //inserindo-se uma interrogação na frente do tipo.

  - Alias
    - É uma apeido que todo tipo no .NET tem.
    - Exemplo:
      - System.String tem o alias string.
      - Int32 tem o alias int.

  - Valores padrões
    - Todos os tipos built-in possuem um valor padrão.
    - Se nenhum valor for informado, segue logo abaixo:
      - int ==> 0
      - float ==> 0
      - decimal ==> 0
      - bool ==> false
      - char ==> '\0'
      - string ==> ""

  - Conversão implícita
    - O a transformação de um dado de um tipo X para um tipo Y.
    - Exitem dois tipos: implícitas e explícitas.
    - Conversão implícita. 
      - Pode ser executada apendas com passagem de dados.
      - São tipos diferentes, mas com valores compatíveis.
      - Ou também se o tamanho do dado for compatível.
      - Definições:
        - sbyte
          - short, int, long, float, double, decimal
        - byte
          - short, ushort, int, uint, long ulong, float, double, decimal
        - short
          - int, long, float, double ou decimal.
        - ushort
          - int uint, long, ulong, float, double ou decimal
        - int
          - long, float, double or decimal.
    - Também conhecido com cast implícito.

  - Conversão explícita
    - É a conversão da qual temos obrigatóriamente informar o tipo que está sendo convertido.

  - Parse
    - Método presente em todo tipo primitivo.
    - O parse sempre espera uma cadeia de "string" para um outro tipo qualquer.
    - Caso haja incompatibilidade, ocorrerá um erro.
    - Ex: int numeroInteiro = int.Parse("46");

  - Convert
    - O parse é uma extensão dos tipos primitivos. Entretanto o convert é um a classe, é um objeto. 
    - Convert é semalhante ao Parse, entretanto, funciona para todos outros tipos de valores. Não se restringindo somente a string como no caso do Parse.
    - Contudo o Convert também irá "tentar" converter, caso não seja possível ocorrerá um erro.
    - Ex: int inteiro = Convert.ToInt32("1000");

  - Convertendo tipos
    - Conversão Implícita
    - Conversão Explícita
    - Parse
    - Convert

  - Operadores aritméticos
    - Definições:
      - Soma -> +
      - Subtração -> -
      - Multiplicação -> *
      - Divisão -> /
    - Ordem de precedência multiplicação e divisão calculado primeiro.
    - Para mudar a ordem de precedência, utilizar parâmetros.
    - Tipo aceitos: short, int, fload, double e decimal.

  - Operadores de atribuição
    - O sinal de = é usado para atribuir valor.
    - Podemos utilizar operadores aritméticos para atribuir.
    - x += 5 é o mesmo x = x + 5
    - Muito comum a utilização em loops de repetição.
    - Ex: 
      - int x = 0; // Atribuição 
      - x += 5; // x = x + 5;
      - x -= 1; // x = x - 1;
      - x *= 10; // x = x * 10;
      - x /= 2; // x = x / 2;
 
  - Operadores de comparação
    - Tem a finalidade de comparar qualquer tipo de dados.
    - O retorno de uma comparação é sempre True ou False.
    - Definições:
      - Igual -> ==
      - Diferente -> !=
      - Maior que -> >
      - Menor que -> <
      - Maior ou igual a -> >=
      - Menor ou igual a -> <=
    - Ex:
      - int x = 25; //atribuição
      - x == 0; // False
      - x != 0; // True  
      - x > 0; // True  
      - x < 0; // False  
      - x >= 0; // True
      - x <= 0; // False  

  - Utilizando operadores
    - Exemplos de atribuição  e comparação.

  - Operadores lógicos
    - Usado para comparar uma condição.
    - Sempre retorna verdadeiro ou falso (true or false)
    - Representação dos operadores:

| Operador | Sinal |
| -------- | ----- |
| E / AND | && |
| OU / OR | <code>&#124;&#124;</code> |
| NEGAÇÃO | ! |


  - Exemplos:
```
    int x = 12;
    bool andE = (x > 25) && (x < 40); //false
    	System.Console.WriteLine($"O operador retornou: {andE}");
    bool orOu = (x > 25) && (x < 40); //true
	System.Console.WriteLine($"O operador retornou: {orOu}");
    bool negacao = !(x < 25); //false
    	System.Console.WriteLine($"O operador retornou: {orOu}");
```

  - Operador condicional: IF
    - É o "SE"
    - o IF também é composto pelo "ELSE IF" e o "ELSE".
  - Utilizando IF
    - Exemplos:
```
    int idade = 10;
    int maiorIdade = 21;
    int idadeMaxima = 60;
    if (idade < maiorIdade)
    {
        System.Console.WriteLine("Menor de idade!");
    }
    else if (idade > idadeMaxima)
    {
        System.Console.WriteLine("Idoso!");
    }
    else if (idade <= idadeMaxima)
    {
        System.Console.WriteLine("Jovem!");
    }
    else
    {
        System.Console.WriteLine("Maior de idade!");
    }
    System.Console.WriteLine("Finalizou!");


    if (idade < maiorIdade)
    {
        return;
    }
    else
    {
        System.Console.WriteLine("1");
        System.Console.WriteLine("2");
        System.Console.WriteLine("3");
        System.Console.WriteLine("4");
        System.Console.WriteLine("5");
        System.Console.WriteLine("6");
    }

```
  - Estrutura condicional: Switch
    - Em inglês significa chavear.
    - Execução em cascata.
    - A execução deve ser parada usando o comando "break".
    - E possui uma condição "default".
    - Exemplos: 
```
    string valor = "maria";
    switch (valor)
    {
        case "joao": System.Console.WriteLine("Não é o cara."); break;
        case "danilo": System.Console.WriteLine("Esse é o cara."); break;
        case "maria": System.Console.WriteLine("Ou será que é essa?"); break;
        default: System.Console.WriteLine("Não encontrei essa pessoa!"); break;
    }

    bool? valor2 = true;
    switch (valor2)
    {
        case true: System.Console.WriteLine("É Verdadeiro"); break;
        case false: System.Console.WriteLine("É Falso"); break;
        default: System.Console.WriteLine("Não encontrei"); break;

    }
```
  - Laços de repetição: For
    - Em inglês seria "para".
    - Os laços de repetição são comumente utilizado para iterar algo que necessite executar uma ação N vezes.
    - Definições:
      - possue 3 parâmetros: for (contador; condição; incremento);
    - Exemplos:
```
    for (var i = 0; i <= 5; i++)
        System.Console.WriteLine($"Contando de 0 a 5: {i}");

    for (var j = 5; j >= 0; j--)
        System.Console.WriteLine($"Contagem regressiva de 5 a 0: {j}");

    for (int k = 1; k <= 5; k++)
    {
        System.Console.WriteLine($"Contando de 1 a 5: {k}");
    }
```
  - Laços de repetição: While
    - Em inglês significa "enquanto"
    - Checa uma condição e verifica se ela é verdadeira no inicio do laço.
    - Necessita um incremento.
    - Exemplo:

```
    int valor = 0;

    while (valor <= 5)
    {
        System.Console.WriteLine(valor);
        valor++;
    }

    valor = 0;
    while (valor <= 5)
    {
        valor++;
        System.Console.WriteLine(valor);
    }

    //loop infitino
    while (true)
    {
        System.Console.WriteLine(valor);
        valor++;
    }
```

  - Laços de repetição: Do/While
    - Em inglês "faça" faça enquanto.
    - Definido pela palavra do/while
    - Checa a condição depois de executar pelo menos um loop.
```
    int valor = 0;
    do
    {
        System.Console.WriteLine(valor);
        valor++;
    } while (valor <= 5);

```

  - Métodos e funções
    - Tem por objetivo segmentar os programas.
    - Também conhecido como métodos.
    - O "main" é um exempo de método.
    - Um método pode ou não possuir retorno, deverá ter um nome, e opcionalmente parâmetros.
    - Esta camada de nome, parâmetros e retorno compõem uma assinatura.
    - Por convensão os método iniciam com letra maiúscula.
    - Exemplo:
```
    static void Main(sgring[] args)
    {
	//Invocação do método
	MeuMetodo("C# é legal");
    }	

    //Definição do método
    static void MeuMetodo (string parametro)
    {
    	Console.WriteLine(parametro);
    }


    static string RetornaNome(string nome, string sobrenome)
    {
    	//Retorna o nome e o sobrenome
        return nome + " " + sobrenome; 
    }

    //Invocar método
    var nomeCompleto = RetornaNome("Jose","Silva");
    Console.WriteLine(nomeCompleto);

```
  - Métodos e funções: Prática
    - Não se declara a assinatura do metodo dentro de outro método.
    - Os parâmetros podem ser declarados como opcionais no método desde que na declaração já seja atribuido o seu valor.
    - Parâmetro opcional deve sempre ser declarado ao final dos da lista de parâmetros.


```

    static void Main(string[] args)
    {


        MeuMetodo();

	string nomeCompleto = RetornaNome("Danilo", "Calixto");
	System.Console.WriteLine(nomeCompleto);

    }

    static void MeuMetodo()
    {
        System.Console.WriteLine("C# é Legal!!!");
    }

    static string RetornaNome(
        string nome,
        string sobrenome,
        int idade = 46, //parâmetros opcionais
        double altura = 1.85, //parâmetros opcionais
        bool teste = true //parâmetros opcionais
        )
    {
        return nome + " " + sobrenome + " " + idade.ToString();
    }
```

  - Value Types e Reference Types
    - Definições:
    - A memória é divida em duas partes, Heap e Stack.
    - Stack armazena os dados.
    - Heap armazena as referências para os dados.
    - No .NET qualquer tipo será tratado como:
    - Tipo de valor(Value Type)
      - Quando a atribuição é feita por valor, é alocado um espaço de memória.
      - É criado um dado novo.
      - É feito uma cópia
      - Ambas serão independentes.
      - Built-in, Structs, Enums
      - Garbage Collecto não acessa Stack.  
    - Tipo de referência(Reference Type)
      - Armazena o endereço.
      - É armazenado na memória Heap.
      - Quando é feito a atribuição, é feito uma cópia do endereço.
      - Apontando para o mesmo endereço.
      - E neste caso não são independentes.
      - Classes, Objects, Arrays...
      - Quando não mais utilizadas o Garbage Collector remove.


  - Value Types e Reference Types: Prática
    - Exemplos:

```
    //Value Type
    int x = 25;
    int y = x; //É feito uma cópia 
    System.Console.WriteLine(x); //x = 25
    System.Console.WriteLine(y); //y = 25
    x = 32;
    System.Console.WriteLine(x); //x = 32
    System.Console.WriteLine(y); //y = 25
    //Reference Type
    var arr1 = new string[2];
    arr1[0] = "Item 1";
    var arr2 = arr1;
    System.Console.WriteLine(arr1[0]); // arr1[0] = "Item 1"
    System.Console.WriteLine(arr2[0]); // arr2[0] = "Item 1"
    arr1[0] = "Item 2";
    System.Console.WriteLine(arr1[0]); // arr1[0] = "Item 2"
    System.Console.WriteLine(arr2[0]); // arr2[0] = "Item 2"
```

  - Structs
    - Tipos de dados estruturados.
    - Apenas estrutura, o esqueleto.
    - Armazena outros tipos de dados.
    - Definido pela palavra: "struct"
    - Tipo de Valor (Value Type)
    - Convenção nomenclatura sempre em maíuscula.
    - Criado a partir da palavra "new".
    - Estrutura não podem ser criadas dentro de uma classe nem método.
    ```
    static void Main(string[] args)
    {
      	//Cria uma estrutura
   	var produto = new Produto()  

	produto.Id = 1;
  	produto.Titulo = "Mouse";
  	produto.Proco = 51.99f;

	Console.WriteLine(produto.Id);
	Console.WriteLine(produto.Titulo);
	Console.WriteLine(produto.Preco);
	Console.WriteLine(produto.PrecoEmDolar(5.01f));

    }

    struct Produto
    {
	//Metodo Construtor
	//Metodo Especial não tem retorno
        //Este método tem o mesmo nome da struct
	//Ele possue mesmo nome pois é executado sempre que a struct é criada. 
	//Esse metodo contrutor facilita muito a criação da estrutura.

 	//Metodo Construtor	
	public Produto(int id, string titulo, float preco)
	{
		Id = id;
		Titulo = titulo;
		Preco = preco;
		
	}
	
      	//Propriedades
        public int Id;
  
        //Metodos
        public float PrecoEmDolar(float dolar)
        {
          return Price * dolar;     
        }

    }

    ```
  - Structs: Prática

    ´´´

	static void Main(string[] args)
        {
            Produto prod = new Produto(1, "Mouse", 5.35f);

            prod.Preco = 25.99f;
            System.Console.WriteLine(prod.Id);
            System.Console.WriteLine(prod.Nome);
            System.Console.WriteLine(prod.Preco);
        }


	struct Produto
	{
	    public Produto(int id, string nome, double preco)
	    {
	        Id = id;
	        Nome = nome;
	        Preco = preco;
	    }
	
	    public int Id;
	    public string Nome;
	    public double Preco;
	
	    public double PrecoEmDolar(double dolar)
	    {
	        return Preco * dolar;
	    }
	}


´´´

  - Enums
    - Enumeradores são inteiros que dão uma melhor visualização do código.
    - Substituem o uso de inteiros.
    - Usado em listas curtas.
    - Usados em dados fixos: Hard Coded.
    - Convensão para nomenclatura iniciar com letra E.
    - Definições:

```
  enum EEstadoCivil
  {
    Solteiro = 1,
    Casado = 2,
    Divorciado = 3
  }

  struct Cliente
  {
    public string nome;
    public EEstadoCivil EstadoCivil; //O atributo foi definido com o tipo EEstadoCivil

    //Com enumerador
    var cliente = new Cliente("Jose da Silva", EEstadoCivil.Casado); 

    Console.WriteLine(cliente.Nome);
    Console.WriteLine(cliente.EstadoCivil); //--> Escreverá = Casado
    //Para imprimir o número definido no enumerador, necessita de conversão explícita.
    Console.WriteLine((int)cliente.EstadoCivil); //--> Escreverá = 2

  }

```
  - Revisão

# Mão na massa: Criando uma calculadora
  - Iniciando o projeto




  - Soma
  - Utilizando funções
  - Subtração
  - Divisão
  - Multiplicação
  - Menu da aplicação
  - Chamando as funções
  - Saindo da aplicação
  - Revisão













