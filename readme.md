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
    
    > Comandos via CLI dotnet.
    ```
    dotnet --list-sdks
    dotnet --list-runtimes
    dotnet -h | --help
    dotnet --info
    ```` 

  - VS Code
    > Baixar Visual Studio Code
    
    > Instalar extensões

    > Necessárias:
      - C# id : ms-dotnettools.csharp
    > Sugeridas:
      - One Dark Pro -> vscode-icons id: vscode-icons-team.vscode-icons

    > Comandos de atalhos do VSCode: 
   
  - Tipos de projeto
    > Web, API, ML, DLL...
    
    > Pra cada projeto deve ser previamente definido para obter o resultado desejado.
      - Tipo : Class Library - Gera uma DLL.
      - Tipo : Console Application
      - Tipo : Web
      - Tipo : Tests

    > Comando para criação de projetos:
    ```    
    dotnet new console 	=> Novo Console Application
    dotnet new classlib => Novo Class Library
    dotnet new web 		=> Novo projeto ASP.NET Core
    dotnet new mvc 		=> Novo projeto ASP.NET Core
    dotnet new webapi 	=> Novo Projeto ASP.NET Core
    dotnet new mstest 	=> Novo projeto Microsoft Teste
    ```
    > Paramentros
      - -o para definir o local do projeto

# FORMATADO ATÉ AQUI (15/10/2023)
# FORMATADO ATÉ AQUI (15/10/2023)
# FORMATADO ATÉ AQUI (15/10/2023)
# FORMATADO ATÉ AQUI (15/10/2023)

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
    > Executado modo debug pelo VSCode, Ctrl+Shift+D.
    Pasta .vscode deve existir nas pastas do seu projeto.
    Caso não exista, ao entrar na opção de debug o vscode irá perguntar se deseja criar o "launch.jason" file, neste momento será criada a pasta ".vscode" que habilita para executar o debug da aplicação. Selecionar um projeto ".Net Core".
 
    > Ou Ctrl+Shit+P : .NET: Generate Assest for bBuild and Debug

    > Ou em último cado desistale as extenções, fecha o vscode. Abra o projeto com o vscode novamente sem as extensões instaladas e em seguida instale. Após a insatlação irá aparecer a pergunta se deseja criar a pasta .vscode.


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
    >Em inglês significa o **SE**.
    O IF também é composto pelo **ELSE IF** e o **ELSE**.

  - Utilizando IF
    > Exemplos:
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
    - Em inglês significa "chavear".
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

## Mão na massa: Criando uma calculadora
  - Iniciando o projeto
    - Criando o projeto Calculadora
    ```
      dotnet new console -o Calculator
    ```  
  - Soma
  - Utilizando funções
  - Subtração
  - Divisão
  - Multiplicação
  - Menu da aplicação
  - Chamando as funções
  - Saindo da aplicação
  - Revisão

## Mão na massa: Cronômetro

  - Iniciando o projeto
    ```
      dotnet new console -o Stopwatch
    ```  
  - Estrutura do cronômetro
  - Thread e Sleep
    ```
    using System.Threading;
    ...
    Thread.Sleep(1000); //Equivale a 1s

    ```
   - Criando o menu
  - Opções do menu
  - Substring
    ```
    string teste =  'Danilo';
    string resultado = '';
    ... 
    resultado = Substring(teste.Length-1, 1));
    resultado = 'o'
    ...
    resultado = Substring(0,teste.Length-1));
    resultado = 'D'
    ```
  - Obtendo a opção
  - Calculando o tempo
  - Finalizando a aplicação
  - Revisão

## Mão na massa: Editor de Textos

  - Iniciando o projeto
    ```
    dotnet new console -o TextEditor
    ```
  - Iteração e caractere de escape
  - Do/While na prática
  - StreamWriter
    ```
    using System.IO; //Biblioteca que contém o StremWriter
    ...
    //using () para chamada de um arquivo faz a abertura/fechamento.

    ```
  - Salvando o arquivo
  - Abrindo arquivos
  - Revisão

## Strings

  - Guids
    > GUID : Global Unique Identifier. É um Id/Hash gerado pelo C#. Normalmente

    > Pertence ao: System
    
    >Declaração de um GUID.
    ```
    //Gera novo id
    var id = Guid.NewGuid();
    id.ToString();
    //Ao converter para um tipo String pode-se trabalhar com o Guid de várias formas
    Console.WriteLine(id);

    //Gera id zerado - ERRO COMUM
    id = new Guid();
    Console.WriteLine(id);

    //Informando Guid vazio. Irá ocorrer uma Exception.
    //id = new Guid(""); 
    //Informando Guid válido
    id = new Guid("432a5b7c-60ba-49af-98bb-75326592f854");

    //Retorna o Guid atribuido a id
    Console.WriteLine(id);
    ```

  - Interpolação de strings
    ```
    //1º Forma simples, concatenando variáveis
    var preco = 10.2;
    var texto = "O Preço do Produto é " + preco + " Reais.";
    Console.WriteLine(texto);
    //2º Forma com Format que formata uma cadeia de caracteres.
    texto = string.Format("O preço do produto é {0} Reais. {1}", preco, true);
    Console.WriteLine(texto);
    //3º Forma com cifrão $
    texto = $"O preço do produto é {preco} reais";
    Console.WriteLine(texto);
    //Dica: Uso do @. I irá quebrar a linha ou o C# ignora comandos como \n.
    texto = $@"O preço do produto é {preco} reais,
               somente para compras em promoção, 
               com uso do Arroba.";
    Console.WriteLine(texto);
    ```

  - Comparação de strings
    ```
    var texto = "Testando";
    //Metodo CompareTo retorna 0 ou 1.
    Console.WriteLine($"Variável= {texto}" + " Digitado= Testando " +     texto.CompareTo("Testando")); //0 Achou
    Console.WriteLine($"Variável= {texto}" + " Digitado= testando " +     texto.CompareTo("testando")); //1 Não Achou

    //Metodo Contains retorna True ou False
    texto = "Este texto é um teste do método Contains.";
    Console.WriteLine(texto.Contains("teste")); //True Case sensitive
    Console.WriteLine(texto.Contains("TESTE",     StringComparison.OrdinalIgnoreCase)); //True Para ignorar Case sensitive
    ```
  - StartsWith/EndsWith
    ```
    var texto = "Este texto é um teste";
    Console.WriteLine(texto.StartsWith("Este"));
    Console.WriteLine(texto.StartsWith("este"));
    Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine(texto.StartsWith("texto"));

    Console.WriteLine(texto.EndsWith("teste"));
    Console.WriteLine(texto.EndsWith("Teste"));
    Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine(texto.EndsWith("TESTE"));
    ```

  - Equals
    ```
    Console.WriteLine("Módulo09: Strings | Aula05: Equal");
    var texto = "Este texto é um teste";
    var idade = 46;
    var nome = "Danilo";
    //Comparando valores da variável
    Console.WriteLine(texto.Equals("Este texto é um teste"));
    Console.WriteLine(texto.Equals("este texto é um teste"));
    Console.WriteLine(texto.Equals("ESTE TEXTO É UM TESTE"));
    Console.WriteLine(texto.ToUpper().Equals("ESTE TEXTO É UM TESTE"));
    Console.WriteLine(texto.Equals("este texto é um teste",     StringComparison.OrdinalIgnoreCase));
    //Comparando tipos de objetos/variáveis
    Console.WriteLine"-------------------------------------------");
    Console.WriteLine(texto.Equals(idade));
    Console.WriteLine(texto.Equals(nome));
    ```

  - Índices/Index
    > Indica uma pocisão de um caracter dentro de uma lista ou array.

    > No C# inicia com 0.
    ```
    var texto = "Este texto é um teste";
    //Retorna o indice do primeiro encontrado
    Console.WriteLine(texto.IndexOf("u"));
    //Retorna o indice do último encontrado
    Console.WriteLine(texto.LastIndexOf("e"));
    ```

  - Métodos adicionais
    ```
    var texto = "Este texto é um teste";
    Console.WriteLine(texto.ToUpper());
    Console.WriteLine(texto.ToLower());
    Console.WriteLine(texto.Insert(5, "AQUI "));
    Console.WriteLine(texto.Remove(5, 6));
    Console.WriteLine(texto.Length);

    ```
  - Manipulando strings
    ```
    var texto = "  Este texto é um teste   ";
    Console.WriteLine(texto.Replace("e", "X"));
    Console.WriteLine(texto.Replace("xxxxxx", "X"));

    var textoFatiado = texto.Split(" ");
    Console.WriteLine(textoFatiado[0]);
    Console.WriteLine(textoFatiado[1]);
    Console.WriteLine(textoFatiado[2]);
    Console.WriteLine(textoFatiado[3]);
    Console.WriteLine(textoFatiado[4]);

    var resultado = texto.Substring(5, 5);
    resultado = texto.Substring(5, texto.LastIndexOf("o"));
    Console.WriteLine(resultado);

    Console.WriteLine(texto.Trim());
    ```
  - StringBuilder
    > Biblioteca: using System.Text;
    ```
    //var texto = "Este texto é um teste";
    var texto = new StringBuilder();
    texto.Append("Este texto é um teste");
    texto.Append("é um teste");
    texto.Append("Este texto teste");
    texto.Append("Este um teste");

    Console.WriteLine(texto.ToString()); //Há situações em que é necessário a conversão.
    Console.WriteLine(texto);
    ```

  - Revisão

## Mão na massa: Editor HTML

  - Iniciando o projeto
    ```
    dotnet new console -o EditorHtml
    ```

  - Desenhando a tela
  - Exibindo o menu
  - Menu da aplicação
  - Editor
  - Visualizador

  - Substituindo caracteres
  - Revisão

## Datas

  - Iniciando com datas
    > DateTime() é um tipo struct.

    > Não é inicializado por padrão vazio, virá um valor por default.
      ```
      Console.Clear();
      var data = new DateTime();
      Console.WriteLine($"Data padrão instanciada: {data}");
      var dataHoje = DateTime.Now;
      Console.WriteLine($"Data dia de hoje: {dataHoje}");
      ```

  - Obtendo valores da data
    ```
    var data = new DateTime(2020, 10, 12, 8, 23, 14);
    Console.WriteLine(data);
    Console.WriteLine(data.Year);
    Console.WriteLine(data.Month);
    Console.WriteLine(data.Day);
    Console.WriteLine(data.Hour);
    Console.WriteLine(data.Minute);
    Console.WriteLine(data.Second);
    Console.WriteLine(data.DayOfWeek);
    Console.WriteLine((int)data.DayOfWeek);
    Console.WriteLine(data.DayOfYear);
    ```

  - Formatando datas
    ```
    Console.Clear();
    var data = DateTime.Now;
    //var formatada = String.Format("{0:yyyy}", data);
    //var formatada = String.Format("{0:M}", data);
    //var formatada = String.Format("{0:MM}", data);
    //var formatada = String.Format("{0:yyyy/MM/dd hh:mm:ss}", data);
    var formatada = String.Format("{0:yyyy/MM/dd hh:mm:ss f z}", data);
    Console.WriteLine(formatada);
    ```

  - Padrões de formatação
    ```
    Console.Clear();
    var data = DateTime.Now;
    //var formatada = String.Format("{0:t}", data); //Hora curta
    //var formatada = String.Format("{0:d}", data); //Data
    //var formatada = String.Format("{0:T}", data); //Hora longa
    //var formatada = String.Format("{0:f}", data); //Data e Hora longa por extenso
    //var formatada = String.Format("{0:g}", data); //Data e Hora curta
    //var formatada = String.Format("{0:r}", data); //R ou r.Padrão Ingles utilizado por sistemas
    //var formatada = String.Format("{0:s}", data); //Normalmente em base NoSql
    var formatada = String.Format("{0:u}", data); //Muito utilizada em JSON
    Console.WriteLine(formatada);
    ```

  - Adicionando valores
    ```
    Console.Clear();
    var data = DateTime.Now;
    Console.WriteLine(data);
    Console.WriteLine(data.AddDays(5));
    Console.WriteLine(data.AddMonths(2));
    Console.WriteLine(data.AddYears(10));
    Console.WriteLine(data.AddHours(5));
    Console.WriteLine(data.AddMinutes(15));
    ```

  - Comparando datas
    ```
    Console.Clear();
    var data = DateTime.Now;

    if (data.Date == DateTime.Now.Date)
    {
        Console.WriteLine("É igual");
    }
    Console.WriteLine(data);

    ```
  - CultureInfo
    ```
    Console.Clear();

    var pt = new CultureInfo("pt-PT");
    var br = new CultureInfo("pt-BR");
    var en = new CultureInfo("en-US");
    var de = new CultureInfo("de-DE");

    Console.WriteLine(DateTime.Now.ToString("D")); //Funciona da mesma forma
    Console.WriteLine(string.Format("{0:D}", DateTime.Now)); //Funciona da mesma forma

    //Inserindo a cultura
    Console.WriteLine(DateTime.Now.ToString("D", pt));
    Console.WriteLine(DateTime.Now.ToString("D", en));
    Console.WriteLine(DateTime.Now.ToString("D", de));

    var culturaAtual = CultureInfo.CurrentCulture;

    Console.WriteLine(DateTime.Now.ToString("D", culturaAtual));
    ```

  - Timezone
    ```
    Console.Clear();

    var utcData = DateTime.UtcNow;

    Console.WriteLine(DateTime.Now);
    Console.WriteLine(utcData);
    Console.WriteLine(utcData.ToLocalTime()); //Para pegar a data local

    var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
    Console.WriteLine(timezoneAustralia);

    var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcData, timezoneAustralia);

    Console.WriteLine(horaAustralia);

    //Listando timezones
    var timaZones = TimeZoneInfo.GetSystemTimeZones();
    foreach (var tmzs in timaZones)
    {
        Console.WriteLine(tmzs.Id);
        Console.WriteLine(tmzs);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcData, tmzs));
        Console.WriteLine("---------------------------");
    }
    ```

  - Timespan
    ```
    Console.Clear();

    var timeSpan = new TimeSpan();
    Console.WriteLine(timeSpan);

    var timeSpanNanoSegundo = new TimeSpan(1);
    Console.WriteLine(timeSpanNanoSegundo);

    var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
    Console.WriteLine(timeSpanHoraMinutoSegundo);

    var timeSpanDiaHoraMinutoSegundo = new TimeSpan(1, 5, 12, 10);
    Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

    var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(1, 5, 12, 8, 100);
    Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);
    ```

  - Revisão
    ```
    Console.Clear();
    //Quanto dias tem em um mês?
    Console.WriteLine(DateTime.DaysInMonth(2023, 2));
    //Como ver o horario de verão
    Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
    Console.WriteLine(FinaldeSemana(DateTime.Now.DayOfWeek));

    static bool FinaldeSemana(DayOfWeek hoje)
    {
        return hoje == DayOfWeek.Saturday || hoje == DayOfWeek.Sunday;
    }
    ```

## Moedas

  - Tipo para moedas
    > Os numero com casa decimais temos o float, double e decimal.

    > Caso seja declarado uma variável e não seja implicitamente declarada o tipo de variável que tenha ponto flutuante, o C# automaticamente irá criar como **double**.

    > Há várias discussões acerca de qual desses três tipo de variáveis acima mencionado seria a melhor alternativa para se trabalhar. Desses três tipos o **Decimal** possue maior precisão, entretanto utiliza mais recursos que os outros dois tipos **double e float**, portanto essa questão de qual é melhor ou pior, é um debate que deve ser analisado a luz da necessidade do projeto. Mas em caso de dúvidas a utilização do **decimal** seria uma opção mais indicada.

  - Formatando moedas
    ```
      var valor = 10.25;
      Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("en-US")));
      Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("de-DE")));
      Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));
      Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
      Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));
      Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));

    ```

  - Math
    ```
      decimal valor = 10536.25m;
      Console.WriteLine(Math.Round(valor));
      Console.WriteLine(Math.Ceiling(valor));
      Console.WriteLine(Math.Floor(valor));
    ```

  - Revisão

## Arrays

  - Arrays
    > Os arrays podem ser inicializado da seguinte forma:

    > Para os Arrays inicializados com seus respectivos valores, deve se observar que todos os valores do array de vem ser preenchidos. Ex: Um array de 5 posições as 5 posições devem ser declaradas entre chaves com o seu respectivo valor.
      ```
        static void Main(string[] args)
        {
            Console.Clear();

            //Formas de inicialização de array:
            int[] meuArray = new int[3];
            var meuArray1 = new int[4];
            //Inicializando com valores. 
            var meuArrayInicializado = new int[5] { 1, 10, 100, 200, 300 };


            Console.WriteLine(meuArray[0]);

            meuArray[0] = 10;
            meuArray[1] = 12;
            meuArray[1] = 15;
            meuArray[1] = 200;
            meuArray[1] = 1200;

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);

            var meuArrayStructEx = new Teste[2] {new Teste(), new Teste()};

            Console.WriteLine(meuArrayStructEx[0].Id);

        }

        struct Teste
        {
            public int Id { get; set; }
        }

      ```
    > Obsevando que o tipo Array é um tipo um pouco mais simples para trabalharmos, portando não é o mais comum de utilizar no dia a dia. A seguir teremos exemplo do tipo Lista que apresenta melhores possibilidades de se trabalhar com esse tipo.
 
    > Arrays são **Reference Type**, portanto eles alocam o espaço da memória e sempre ele irá substituir os valores dentor do mesmo array. Para criar um novo array deve-se utilizar o método **Clone**.


  - Percorrendo um array
    ```
      meuArray[0] = 10;
      meuArray[1] = 12;
      meuArray[2] = 15;
      meuArray[3] = 200;
      meuArray[4] = 1200;

      for (int i = 0; i < meuArray.Length; i++)
      {
            Console.WriteLine($"Posição: {i} Valor: {meuArray[i]}");
      }

    ```

  - ForEach
    ```
      int[] meuArray = new int[5];
      meuArray[0] = 10;
      meuArray[1] = 12;
      meuArray[2] = 15;
      meuArray[3] = 200;
      meuArray[4] = 1200;

      Console.WriteLine("ForEach de um array de inteiros");
      Console.WriteLine("----------------------------------");
      foreach (var item in meuArray)
      {
            Console.WriteLine(item);
      }

      Console.WriteLine("ForEach de um array de inteiros");
      Console.WriteLine("----------------------------------");
      var funcionarios = new Funcinario[5];
      funcionarios[0] = new Funcinario() { Id = 1010, Nome = "Danilo" };
      funcionarios[1] = new Funcinario() { Id = 2020, Nome = "Lu" };
      foreach (var funcionario in funcionarios)
      {
            Console.WriteLine($"ID: {funcionario.Id} - NOME: {funcionario.Nome}");
      }

    ```

  - Alterando os valores
    > Como mencionado anteriormente o array ele é um objeto do tipo Reference Type. Portanto atribuições de um array1 para um array2, eles irão ocupar o mesmo espaço de memória.

    > Para podermos ter atribuições para um novo array, requer que o array2 seja instanciado com o comando **new**.
    ```
      //Exemplo de atribuição por referência:
      var arr1 = new int[4];
      var arr2 = arr1;
      arr1[0] = 23;
      Console.WriteLine($"{arr1[0]} {arr2[0]}");

      //Exemplo de atribuição para um novo array.
      var arr3 = new int[4];

      arr1[0] = arr3[0];

      arr3[0] = 15;

      Console.WriteLine($"{arr1[0]} {arr3[0]}");

    ```

  - Revisão

## Exceptions

  - Exceptions
  - Try/Catch
  - Tratando erros
    > Sempre que for inserir uma Exception observar para fazer da exceção específica para a mais genérica.

    ```
      var arr = new int[3];

      try
      {
            for (var i = 0; i <= 5; i++)
            {
                  Console.WriteLine($"{arr[i]}");
            }
      }
      catch (IndexOutOfRangeException ex)
      {
            Console.WriteLine($"Índice fora do range do array.");
            Console.WriteLine($"InnerException : {ex.InnerException}");
            Console.WriteLine($"Mensagem : {ex.Message}");
      }
      catch (Exception ex)
      {
            Console.WriteLine($"Ops... Algo errado!");
            Console.WriteLine($"InnerException : {ex.InnerException}");
            Console.WriteLine($"Mensagem : {ex.Message}");
      }

    ```

  - Disparando exceções
    ```
      static void ModuloAula1404(string textoTeste)
      {
            Salvar(textoTeste);
      }

      static void Salvar(string texto)
      {
            if (string.IsNullOrEmpty(texto))
                  throw new ArgumentException("O texto não pode ser nulo ou vazio (throw)!");
      }

    ```

  - Custom Exceptions
    ```
      public class MinhaException : Exception
      {
            public MinhaException(DateTime data)
            {
                QuandoAconteceu = data;
            }

            public DateTime QuandoAconteceu { get; set; }
      }

      //Modulo: 14 - Exceptions | Aula 05: Custm Exceptions
      static void ModuloAula1405(string textoTeste)
      {
            SalvarNewException(textoTeste);
      }

    ```
  - Finally
  - Revisão

## Conclusão








