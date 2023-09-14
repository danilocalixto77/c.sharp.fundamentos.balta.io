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
        MeuApp.csproj (arquivo formato XML)
        Program.cs  (arquivo codigo fonte)

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
        - int idade; //OK iniciar variável com 0.
        - int idade = 25; //OK iniciar variável com 25.
        - var idade = 25; //OK iniciar variável com 25.
        - var idade; // ERRADO tipo não informado.
    - Nome de variável uma boa prática é criá-la com nomes que tenham haver com a informação que a variável irá armazenar.
    - Por convenção variáveis iniciam com letra minúscuas.


  - Constantes
  - Palavras reservadas
  - Comentários
  - Tipos primitivos
  - System
  - Byte
  - Números inteiros
  - Números reais
  - Boolean
  - Char
  - String
  - Var
  - Object
  - Nullabel Types
  - Alias
  - Valores padrões
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

