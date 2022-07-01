# 							                                                                                                             **Introdução  C#**💻



![img](https://i.ytimg.com/vi/dVzJ3bx68FA/hqdefault.jpg?sqp=-oaymwEXCNACELwBSFryq4qpAwkIARUAAIhCGAE=&rs=AOn4CLCGmGaqXINg2nnIlemsgwmWtOKQKg)

"FESSOR BRUNO" C# https://youtube.com/playlist?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi

> **Índice:**
>
> ✔ 1- [Usando VS Community para criar programas console - Curso Programação Completo C# - Aula 1.1](https://www.youtube.com/watch?v=xCU9X7SFxPg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=2&t=321s)
>
> - Criando o primeiro programa olá mundo.
>
> ✔ 2- [Primeiro programa no padrão c# .net - Curso Programação Completo C# - Aula 02](https://www.youtube.com/watch?v=2cGjyyw5ifQ&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=4&t=207s)
>
> - Apresentação do código
>
> ✔ 3- [Variáveis - Curso Programação Completo C# - Aula 03](https://www.youtube.com/watch?v=25gWhVRRYDI&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=5)
>
> - primeiro temos especificar o ***tipo*** de dados no qual se vai trabalhar, em seguida o ***nome*** e ***valor***;
>
>   | Tipo de dados | Intervalo                                                    |
>   | ------------- | ------------------------------------------------------------ |
>   | byte          | 0 ..255                                                      |
>   | sbyte         | -128 ..127                                                   |
>   | short         | -32,768 ..32,767                                             |
>   | ushort        | 0 ..65,535                                                   |
>   | int           | -2,147,483,648 ..2,147,483,647                               |
>   | uint          | 0 ..4,294,967,295                                            |
>   | long          | -9,223,372,036,854,775,808..9,223,372,036,854,775,807        |
>   | ulong         | 0 ..18,446,744,073,709,551,615                               |
>   | float         | -3.402823e38 ..3.402823e38                                   |
>   | double        | -1.79769313486232e308 ..1.79769313486232e308                 |
>   | decimal       | -79228162514264337593543950335..79228162514264337593543950335 |
>   | char          | U+0000 .. U+ffff                                             |
>
> 4- [Escopo de variáveis - Curso Programação Completo C# - Aula 04](https://www.youtube.com/watch?v=1tsK4u4Hmck&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=6)
>
> - Onde as variáveis são visíveis podendo ser local ou global.
>
>   > Exemplo: local
>   >
>   > ```c#
>   > internal class Program
>   > {
>   >     int num = 10;//global
>   >  static void Main(string[] args)
>   >  {
>   >      int num = 0;//local
>   >  }
>   > 
>   >  void test()
>   >  {
>   > 
>   >      Console.WriteLine(num);
>   >  }
>   > }
>   > ```
>
> 5- [Operadores e Operações - Curso Programação Completo C# - Aula 05](https://www.youtube.com/watch?v=f8rDk6nJ9DE&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=7)
>
> ### Operadores Aritméticos
>
> | **Operador Aritmético** | **Descrição**             |
> | ----------------------- | ------------------------- |
> | **+**                   | Adição                    |
> | **-**                   | Subtração                 |
> | *****                   | Multiplicação             |
> | **/**                   | Divisão                   |
> | **%**                   | Módulo (resto da divisão) |
>
> ### Operadores Aritméticos de Atribuição Reduzida
>
> | **Operador Aritmético** | ** Descrição** |
> | ----------------------- | -------------- |
> | **+ =**                 | mais igual     |
> | **- =**                 | menos igual    |
> | *** =**                 | vezes igual    |
> | **/ =**                 | dividido igual |
> | **% =**                 | módulo igual   |
>
> ### Operadores Relacionais
>
> | **Operador Relacional** | **Descrição**           |
> | ----------------------- | ----------------------- |
> | **==**                  | Igual a                 |
> | **!=**                  | Diferente de            |
> | **>**                   | Maior que               |
> | **<**                   | Menor que               |
> | **>=**                  | Maior do que ou igual a |
> | **<=**                  | Menor do que ou igual a |
>
> ### Operadores Lógicos
>
> | **Operador Lógico** | **Descrição** |
> | ------------------- | ------------- |
> | **&&**              | AND = E       |
> | *\|*                | OR = Ou       |
> | **!**               | NOT = Não     |
>
> 
>
> 6- [Formatando a saída no console - Curso Programação Completo C# - Aula 06](https://www.youtube.com/watch?v=BVNhK3lQyww&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=8&t=316s)
>
> | Sequência Escape | Representação                             |
> | ---------------- | ----------------------------------------- |
> | \a               | Sinal sonoro (alerta)                     |
> | \b               | Backspace                                 |
> | \f               | Alimentação de formulário                 |
> | \n               | Nova linha                                |
> | \r               | Carriage return                           |
> | \t               | Tabulação horizontal                      |
> | \v               | Tabulação vertical                        |
> | \'               | Aspas simples                             |
> | \"               | Aspas duplas                              |
> | \\               | Barra invertida                           |
> | \?               | Interrogação                              |
> | \ ooo            | Caractere ASCII na notação octal          |
> | \x hh            | Caractere ASCII na notação hexadecimal    |
> | \x hhhh          | Caractere Unicode na notação hexadecimal. |
>
> 
>
> ## Especificadores de formato padrão
>
> | Especificador de formato       | Nome                       | Descrição                                                    | Exemplos                                                     |
> | :----------------------------- | :------------------------- | :----------------------------------------------------------- | :----------------------------------------------------------- |
> | "C" ou "c"                     | Moeda                      | Resultado: um valor de moeda.  Compatível com: todos os tipos numéricos.  Especificador de precisão: número de casas decimais.  Especificador de precisão padrão: definido por [NumberFormatInfo.CurrencyDecimalDigits](https://docs.microsoft.com/pt-br/dotnet/api/system.globalization.numberformatinfo.currencydecimaldigits).  Para saber mais: [especificador de formato de moeda ("C")](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings#CFormatString). | 123.456 ("C", en-US) -> $123.46  123.456 ("C", fr-FR) -> 123,46 €  123.456 ("C", ja-JP) -> 123  -123.456 ("C3", en-US) -> ($123.456)  -123.456 ("C3", fr-FR) -> -123.456 €  -123.456 ("C3", ja-JP) -> ->123.456 |
> | "D" ou "d"                     | Decimal                    | Resultado: dígitos inteiros com sinal negativo opcional.  Compatível com: somente tipos integrais.  Especificador de precisão: número mínimo de dígitos.  Especificador de precisão padrão: número mínimo de dígitos necessários.  Para saber mais: [especificador de formato decimal ("D")](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings#DFormatString). | 1234 ("D") -> 1234  -1234 ("D6") -> -001234                  |
> | "E" ou "e"                     | Exponencial (científica)   | Resultado: notação Exponencial.  Compatível com: todos os tipos numéricos.  Especificador de precisão: número de casas decimais.  Especificador de precisão padrão: 6.  Para saber mais: [especificador de formato exponencial ("E")](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings#EFormatString). | 1052.0329112756 ("E", en-US) -> 1,052033E+003  1052.0329112756 ("e", fr-FR) -> 1,052033e+003  -1052.0329112756 ("e2", en-US) -> -1,05e+003  -1052.0329112756 ("E2", fr-FR) -> -1,05E+003 |
> | "F" ou "f"                     | Ponto fixo                 | Resultado: dígitos integrais e decimais com sinal negativo opcional.  Compatível com: todos os tipos numéricos.  Especificador de precisão: número de casas decimais.  Especificador de precisão padrão: definido por [NumberFormatInfo.NumberDecimalDigits](https://docs.microsoft.com/pt-br/dotnet/api/system.globalization.numberformatinfo.numberdecimaldigits).  Para saber mais: [especificador de formato de ponto fixo ("F")](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings#FFormatString). | 1234.567 ("F", en-US) -> 1234.57  1234.567 ("F", de-DE) -> 1234,57  1234 ("F1", en-US) -> 1234.0  1234 ("F1", de-DE) -> 1234,0  -1234.56 ("F4", en-US) -> -1234.5600  -1234.56 ("F4", de-DE) -> -1234.5600 |
> | "G" ou "g"                     | Geral                      | Resultado: a mais compacta entre notação de ponto fixo ou científica.  Compatível com: todos os tipos numéricos.  Especificador de precisão: número de dígitos significativos.  Especificador de precisão padrão: depende do tipo numérico.  Para saber mais: [especificador de formato geral ("G")](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings#GFormatString). | -123.456 ("G", en-US) -> -123.456  -123.456 ("G", sv-ES) -> -123.456  123.4546 ("G4", en-US) -> 123,5  123.4546 ("G4", sv-ES) -> 123,5  -1.234567890e-25 ("G", en-US) -> -1.23456789E-25  -1.234567890e-25 ("G", sv-ES) -> -1,23456789E-25 |
> | "N" ou "n"                     | Número                     | Resultado: dígitos integrais e decimais, separadores de grupo e um separador decimal com sinal negativo opcional.  Compatível com: todos os tipos numéricos.  Especificador de precisão: número de casas decimais desejadas.  Especificador de precisão padrão: definido por [NumberFormatInfo.NumberDecimalDigits](https://docs.microsoft.com/pt-br/dotnet/api/system.globalization.numberformatinfo.numberdecimaldigits).  Para saber mais: [especificador de formato numérico ("N")](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings#NFormatString). | 1234.567 ("N", en-US) -> 1.234,57  1234.567 ("N", ru-RU) -> 1 234,57  1234 ("N1", en-US) -> 1.234.0  1234 ("N1", ru-RU) -> 1 234,0  -1234.56 ("N3", en-US) -> -1.234.560  -1234.56 ("N3", ru-RU) -> -1 234.560 |
> | "P" ou "p"                     | Porcentagem                | Resultado: número multiplicado por 100 e exibido com um sinal de porcentagem.  Compatível com: todos os tipos numéricos.  Especificador de precisão: número de casas decimais desejadas.  Especificador de precisão padrão: definido por [NumberFormatInfo.PercentDecimalDigits](https://docs.microsoft.com/pt-br/dotnet/api/system.globalization.numberformatinfo.percentdecimaldigits).  Para saber mais: [especificador de formato de porcentagem ("P")](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings#PFormatString). | 1 ("P", en-US) -> 100,00%  1 ("P", fr-FR) -> 100,00%  -0,39678 ("P1", en-US) -> -39,7 %  -0,39678 ("P1", fr-FR) -> -39,7 % |
> | "R" ou "r"                     | Ida e volta                | Resultado: uma cadeia de caracteres que pode ir e voltar para um número idêntico.  Compatível com: [Single](https://docs.microsoft.com/pt-br/dotnet/api/system.single), [Double](https://docs.microsoft.com/pt-br/dotnet/api/system.double) e [BigInteger](https://docs.microsoft.com/pt-br/dotnet/api/system.numerics.biginteger).  Observação: recomendado apenas para o tipo [BigInteger](https://docs.microsoft.com/pt-br/dotnet/api/system.numerics.biginteger). Para os tipos [Double](https://docs.microsoft.com/pt-br/dotnet/api/system.double), use "G17"; para os tipos [Single](https://docs.microsoft.com/pt-br/dotnet/api/system.single), use "G9". Especificador de precisão: ignorado.  Para saber mais: [especificador de formato de ida e volta ("R")](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings#RFormatString). | 123456789.12345678 ("R") -> 123456789.12345678  -1234567890.12345678 ("R") -> -1234567890.1234567 |
> | "X" ou "x"                     | Hexadecimal                | Resultado: uma cadeia de caracteres hexadecimal.  Compatível com: somente tipos integrais.  Especificador de precisão: número de dígitos na cadeia de caracteres de resultado.  Para saber mais: [especificador de formato hexadecimal ("X")](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings#XFormatString). | 255 ("X") -> FF  -1 ("x") -> ff  255 ("x4") -> 00ff  -1 ("X4") -> 00FF |
> | Qualquer outro caractere único | Especificador desconhecido | Resultado: gera uma [FormatException](https://docs.microsoft.com/pt-br/dotnet/api/system.formatexception) em tempo de execução. |                                                              |
>
> 
>
> 7- [Constantes em C# - Curso Programação Completo C# - Aula 07](https://www.youtube.com/watch?v=y5M_9AfhLs4&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=9)
>
> - O valor de uma constante não pode ser alterado ao longo do programa.
>
>   > Exemplo:
>   >
>   > ```c#
>   >     static void Main(string[] args)
>   >     {
>   >         //ENTRADA
>   >         const string programador = "Eduardo Quirino";
>   >         const double pi = 3.1415;
>   > 
>   > ```
>   >
>   >
>   > ```c#
>   >         //SAIDA
>   >         Console.WriteLine("programador: {0}\n pi: {1}",programador,pi);
>   >         Console.ReadKey();
>   >     }
>   > ```
>
>   
>
>   8-[Lendo valores do teclado - Curso Programação Completo C# - Aula 08](https://www.youtube.com/watch?v=jKM9NjtihmU&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=10)
>
>   



---

---



[Curso de Programação com C#](https://www.youtube.com/watch?v=r2kEkCGrxZs&list=PLucm8g_ezqNoMPIGWbRJXemJKyoUpTjA1) Boson =>Treinamentos

SUMÁRIO :

> <AULA  01 > Configuração IDE
>
> <AULA  02 > Estrutura de um programa básico e classe Console
>
> <AULA  03 > Declaração e Atribuição de Variáveis

Material : http://www.bosontreinamentos.com.br/category/csharp/

---

---





> **Extra**
>
> *Lista de exercícios:* https://satellasoft.com/artigo/csharp/lista-de-exercicios-em-csharp
>
> *W3schol Tutorial C#:* https://www.w3schools.com/cs/index.php

