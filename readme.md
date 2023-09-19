# Curso: Fundamentos do C# - André Baltieri (Balta.io)

### Linguagens e Compiladores
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

### C#
 - Por que utilizar C#?
   - Linguagem com alto nível de maturidade.
   - Possui uma enorme comunidade.
   - Microsoft por trás dos bastidores com o suporte.
 - C# como primeira linguagem
   - Possui muito material e é altamente desafiadora.
 - Código gerenciado
   - Gerenciado pelo Runtime CLR (Common Language Runtime). 
   - Gerencia memória, segurança e outro recursos.
 - Compilação e gerenciamento
   - Cada linguagem possue seu compilador.
   - Compilação inicial não gera código binário.
   - Criada a IL (Intermediate language)
   - E depois o binário será gerado.
 - IL
   - Todas as linguagens Microsoft inicialmente são compilada para IL.
   - C#, VB.NET, F#, Cobol, .Net
   - Isso permite ter código de linguagens diferentes no mesmo projeto.
   - C# e VB.NET 
   - Nunca no mesmo arquivo, somente em arquivos diferentes.
   - Entretanto prática não é muito comum.
   - Ao final é gerado o binário que é igual para todas linguagens.
   - O processo de conversão do IL para o Binário é conhecida como JIT.
   - JIT (Just in Time).
 - Revisão

### Frameworks

  - Frameworks
    - São estruturas prontas, que diminuem os riscos dos projetos e agilizam o desenvolvimento.
  - .NET Framework
    - É o legado.
  - .NET Core
    - É o atual
  - .NET Standard
    - Responsável pela padronização entre as linguagens.
  - .NET 5
    - É o futuro, com a unificação do .NET Framework com o .NET Core 
  - LTS
    - Long Term Support, principal opção.
  - Versionamento
  - Runtime e SDK
    - Runtime executa.
    - Software Developmant Kit (SDK) cria as aplicações .NET
    - Em produção utiliza-se o runtime
  - Revisão

### .NET

  - Instalação
    - Baixando dotnet do site Microsoft.
    - Baixando versão mais atual do SDK.
    - Instalação Windows simples somente next até o final.
    - Checando versão via Power Shell : dotnet --info

  - dotnet cli
    - Command Line Interface
    - Comando via CLI dotnet.
      dotnet --list-sdks
      dotnet --list-runtimes
      dotnet -h | --help
      dotnet --info

  - VS Code
    - Baixar Visual Studio Code
    - Instalar extensões
      - Necessárias:
        C# id : ms-dotnettools.csharp
      - Sugeridas:
        One Dark Pro
        vscode-icons id: vscode-icons-team.vscode-icons
    - Comandos de atalhos do VSCode:
    - "Ctrl + ," = Abre setting, que pode ser editado por json também.

  - Tipos de projeto
    - Web, API, ML, DLL...
    - Pra cada projeto deve ser previamente definido para obter o resultado desejado.
    - Tipo : Class Library - Gera uma DLL.
    - Tipo : Console Application
    - Tipo : Web
    - Tipo : Tests
    - Comando para criação de projetos:
      - dotnet new console 	=> Novo Console Application
      - dotnet new classlib 	=> Novo Class Library
      - dotnet new web 		=> Novo projeto ASP.NET Core
      - dotnet new mvc 		=> Novo projeto ASP.NET Core
      - dotnet new webapi 	=> Novo Projeto ASP.NET Core
      - dotnet new mstest 	=> Novo projeto Microsoft Teste
    - Paramentros
      - -o para definir o local do projeto

  - Fluxo de execução
    - Para checar se você está em um projeto C# verifice que na pasta há um arquivo com extenção ".csproj"
    - Ao iniciar um projeto executar dentro da pasta do projeto o comando : "dotnet restore" , para que o dotnet faça uma atualização dos arquivos, baixando todas as dependências e pacotes adicionais ao dotnet que esta aplicação precisa.
    - Compilação via linha de comando "dotnet build".
    - Comando para limpesa dos arquivos de cash. "dotnet clean".
    - Para execuar a aplicação. "dotnet run"
      -  Comandos da aula:
        - dotnet restore
        - dotnet clean
        - dotnet build
        - dotnet run

  - Variáveis de ambiente
    - Utilizadas para definir o local em que a aplicação estará sendo executada, existem casos de projetos que possuem ambientes de desenvolvimento, testes, homologação e produto. 
    - Exemplos de execução passando parâmetros para definição de ambiente:
      - dotnet run --environment=$SEU_AMBIENTE
      - dotnet run --environment=$development

  - Estrutura do App
    - Executando dentro da pasta da aplicação "code ." Irá abrir o vscode com os arquivos do projeto.
    - Arquivo base da estrutura
      - MeuApp.csproj (arquivo formato XML)
      - Program.cs  (arquivo codigo fonte)

  - Debug
    - Executado modo debug pelo VSCode, Ctrl+Shift+D.
    - Pasta .vscode deve existir nas pastas do seu projeto.
    - Caso não exista, ao entrar na opção de debug o vscode irá perguntar se deseja criar o "launch.jason" file, neste momento será criada a pasta ".vscode" que habilita para executar o debug da aplicação. Selecionar um projeto ".Net Core".

  - Revisão

### Linguagem de Programação

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
      - bool ==> fase
      - char ==> '\0'
      - string ==> ""

  - Conversão implícita
  - Conversão explícita
  - Parse
  - Convert
  - Convertendo tipos
  - Operadores aritméticos
  - Operadores de atribuição
  - Operadores de comparação
  - Utilizando operadores
  - Operadores lógicos
  - Operador condicional: IF
  - Utilizando IF
  - Estrutura condicional: Switch
  - Laços de repetição: For
  - Laços de repetição: While
  - Laços de repetição: Do/While
  - Métodos e funções
  - Métodos e funções: Prática
  - Value Types e Reference Types
  - Value Types e Reference Types: Prática
  - Structs
  - Structs: Prática
  - Enums
  - Revisão

