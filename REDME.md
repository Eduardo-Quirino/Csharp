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
<<<<<<< HEAD
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
<<<<<<< HEAD
> 
>
> > **Exemplo:** 
> >
> > ```c#
> >         static void Main(string[] args)
> >         {
> >             //ENTRADA
> >             int val1, val2, soma;
> > 
> >             //PROCESSAMENTO
> >             Console.Write("Digite o primeiro valor: ");
> >             val1 = int.Parse(Console.ReadLine());
> > 
> >             Console.Write("Digite o segundo valor: ");
> >             val2 = Convert.ToInt32( Console.ReadLine());
> > 
> >             soma = val1 + val2;
> >             Console.WriteLine("A soma de {0} mais {1} é igual a {2}", val1, val2, soma);
> > 
> >             //SAIDA
> >             Console.ReadKey();
> >         }
> > 
> > ```
>
> 
>
> **Métodos :** *https://docs.microsoft.com/pt-br/dotnet/api/system.convert?view=net-6.0*
>
> 
>
> | [ChangeType(Object, Type)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.changetype?view=net-6.0#system-convert-changetype(system-object-system-type)) | Retorna um objeto do tipo especificado e cujo valor é equivalente ao objeto especificado. |
> | ------------------------------------------------------------ | ------------------------------------------------------------ |
> | [ChangeType(Object, Type, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.changetype?view=net-6.0#system-convert-changetype(system-object-system-type-system-iformatprovider)) | Retorna um objeto do tipo especificado, cujo valor é equivalente ao objeto especificado. Um parâmetro fornece informações de formatação específicas da cultura. |
> | [ChangeType(Object, TypeCode)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.changetype?view=net-6.0#system-convert-changetype(system-object-system-typecode)) | Retorna um objeto do tipo especificado, cujo valor é equivalente ao objeto especificado. |
> | [ChangeType(Object, TypeCode, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.changetype?view=net-6.0#system-convert-changetype(system-object-system-typecode-system-iformatprovider)) | Retorna um objeto do tipo especificado, cujo valor é equivalente ao objeto especificado. Um parâmetro fornece informações de formatação específicas da cultura. |
> | [FromBase64CharArray(Char[\], Int32, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.frombase64chararray?view=net-6.0#system-convert-frombase64chararray(system-char()-system-int32-system-int32)) | Converte um subconjunto de uma matriz de caracteres Unicode que codifica dados binários como dígitos de base 64 em uma matriz de inteiros sem sinal de 8 bits equivalente. Os parâmetros especificam o subconjunto na matriz de entrada e o número de elementos a serem convertidos. |
> | [FromBase64String(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.frombase64string?view=net-6.0#system-convert-frombase64string(system-string)) | Converte a cadeia de caracteres especificada, o que codifica dados binários, como dígitos de base 64, em uma matriz equivalente de inteiros sem sinais de 8 bits. |
> | [FromHexString(ReadOnlySpan)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.fromhexstring?view=net-6.0#system-convert-fromhexstring(system-readonlyspan((system-char)))) | Converte o intervalo, que codifica os dados binários como caracteres hexadecimais, em uma matriz equivalente de inteiros sem sinais de 8 bits. |
> | [FromHexString(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.fromhexstring?view=net-6.0#system-convert-fromhexstring(system-string)) | Converte a cadeia de caracteres especificada, que codifica dados binários como caracteres hexadecimais, em uma matriz equivalente de inteiros sem sinais de 8 bits. |
> | [GetTypeCode(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.gettypecode?view=net-6.0#system-convert-gettypecode(system-object)) | Retorna o [TypeCode](https://docs.microsoft.com/pt-br/dotnet/api/system.typecode?view=net-6.0) para o objeto especificado. |
> | [IsDBNull(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.isdbnull?view=net-6.0#system-convert-isdbnull(system-object)) | Retorna uma indicação de que se o objeto especificado é do tipo [DBNull](https://docs.microsoft.com/pt-br/dotnet/api/system.dbnull?view=net-6.0). |
> | [ToBase64CharArray(Byte[\], Int32, Int32, Char[], Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobase64chararray?view=net-6.0#system-convert-tobase64chararray(system-byte()-system-int32-system-int32-system-char()-system-int32)) | Converte um subconjunto de uma matriz de inteiros não assinados de 8 bits em um subconjunto equivalente de uma matriz de caracteres Unicode codificada com dígitos com base em 64. Os parâmetros especificam os subconjuntos como deslocamentos nas matrizes de entrada e saída, e o número de elementos na matriz de entrada a serem convertidos. |
> | [ToBase64CharArray(Byte[\], Int32, Int32, Char[], Int32, Base64FormattingOptions)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobase64chararray?view=net-6.0#system-convert-tobase64chararray(system-byte()-system-int32-system-int32-system-char()-system-int32-system-base64formattingoptions)) | Converte um subconjunto de uma matriz de inteiros não assinados de 8 bits em um subconjunto equivalente de uma matriz de caracteres Unicode codificada com dígitos com base em 64. Parâmetros especificam os subconjuntos como deslocamentos nas matrizes de entrada e saída, o número de elementos na matriz de entrada a serem convertidos e se as quebras de linha são inseridas na matriz de saída. |
> | [ToBase64String(Byte[\])](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobase64string?view=net-6.0#system-convert-tobase64string(system-byte())) | Converte uma matriz de inteiros sem sinal de 8 bits na representação de cadeia de caracteres equivalente codificada com dígitos de base 64. |
> | [ToBase64String(Byte[\], Base64FormattingOptions)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobase64string?view=net-6.0#system-convert-tobase64string(system-byte()-system-base64formattingoptions)) | Converte uma matriz de inteiros sem sinal de 8 bits na representação de cadeia de caracteres equivalente codificada com dígitos de base 64. Você pode especificar se deseja inserir quebras de linha no valor retornado. |
> | [ToBase64String(Byte[\], Int32, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobase64string?view=net-6.0#system-convert-tobase64string(system-byte()-system-int32-system-int32)) | Converte um subconjunto de uma matriz de inteiros sem sinal de 8 bits na representação de cadeia de caracteres equivalente codificada com dígitos de base 64. Parâmetros especificam o subconjunto como um deslocamento na matriz de entrada e o número de elementos na matriz a converter. |
> | [ToBase64String(Byte[\], Int32, Int32, Base64FormattingOptions)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobase64string?view=net-6.0#system-convert-tobase64string(system-byte()-system-int32-system-int32-system-base64formattingoptions)) | Converte um subconjunto de uma matriz de inteiros sem sinal de 8 bits na representação de cadeia de caracteres equivalente codificada com dígitos de base 64. Parâmetros especificam o subconjunto como um deslocamento da matriz de entrada, o número de elementos na matriz para converter e se deve ou não inserir quebras de linha no valor retornado. |
> | [ToBase64String(ReadOnlySpan, Base64FormattingOptions)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobase64string?view=net-6.0#system-convert-tobase64string(system-readonlyspan((system-byte))-system-base64formattingoptions)) | Converte os números inteiros sem sinal de 8 bits dentro do intervalo somente leitura especificado em sua representação de cadeia de caracteres equivalente codificada com dígitos de base 64. Opcionalmente, você pode especificar se deseja inserir quebras de linha no valor retornado. |
> | [ToBoolean(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-boolean)) | Retorna o valor booliano especificado. Nenhuma conversão real é executada. |
> | [ToBoolean(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado em um valor booliano equivalente. |
> | [ToBoolean(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-char)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToBoolean(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToBoolean(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-decimal)) | Converte o valor do número decimal especificado em um valor booliano equivalente. |
> | [ToBoolean(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla em um valor booliano equivalente. |
> | [ToBoolean(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em um valor booliano equivalente. |
> | [ToBoolean(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado para um valor booliano equivalente. |
> | [ToBoolean(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um valor booliano equivalente. |
> | [ToBoolean(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-object)) | Converte o valor de um objeto especificado em um valor booliano equivalente. |
> | [ToBoolean(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um valor booliano equivalente, usando as informações de formatação específicas da cultura especificadas. |
> | [ToBoolean(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado em um valor booliano equivalente. |
> | [ToBoolean(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-single)) | Converte o valor do número de ponto flutuante de precisão simples em um valor booliano equivalente. |
> | [ToBoolean(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-string)) | Converte a representação de cadeia de caracteres especificada de um valor lógico para seu equivalente booliano. |
> | [ToBoolean(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um valor lógico para seu equivalente booliano, usando as informações de formatação específicas da cultura especificada. |
> | [ToBoolean(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado em um valor booliano equivalente. |
> | [ToBoolean(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um valor booliano equivalente. |
> | [ToBoolean(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toboolean?view=net-6.0#system-convert-toboolean(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um valor booliano equivalente. |
> | [ToByte(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-boolean)) | Converte o valor booliano especificado no inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-byte)) | Retorna o inteiro sem sinal de 8 bits especificado; nenhuma conversão real é executada. |
> | [ToByte(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-char)) | Converte o valor do caractere Unicode especificado no inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToByte(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-decimal)) | Converte o valor do número decimal especificado em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-object)) | Converte o valor do objeto especificado para um inteiro sem sinal de 8 bits. |
> | [ToByte(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um inteiro sem sinal de 8 bits, usando as informações de formatação específicas da cultura especificadas. |
> | [ToByte(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-sbyte)) | Converte o valor do número inteiro com sinal de 8 bits especificado em um número inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro sem sinal de 8 bits equivalente, usando as informações de formatação específicas da cultura especificada. |
> | [ToByte(String, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-string-system-int32)) | Converte a representação de cadeia de caracteres de um número em uma base especificada em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um inteiro sem sinal de 8 bits equivalente. |
> | [ToByte(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tobyte?view=net-6.0#system-convert-tobyte(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um inteiro sem sinal de 8 bits equivalente. |
> | [ToChar(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-boolean)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToChar(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado em seu caractere Unicode equivalente. |
> | [ToChar(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-char)) | Retorna o valor do caractere Unicode especificado; nenhuma conversão real é executada. |
> | [ToChar(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToChar(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-decimal)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToChar(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-double)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToChar(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em seu caractere Unicode equivalente. |
> | [ToChar(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em seu caractere Unicode equivalente. |
> | [ToChar(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em seu caractere Unicode equivalente. |
> | [ToChar(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-object)) | Converte o valor do objeto especificado em um caractere Unicode. |
> | [ToChar(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-object-system-iformatprovider)) | Converte o valor do objeto especificado para o caractere Unicode equivalente usando as informações de formatação específicas da cultura especificadas. |
> | [ToChar(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado no caractere Unicode equivalente. |
> | [ToChar(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-single)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToChar(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-string)) | Converte o primeiro caractere de uma cadeia de caracteres especificada em um caractere Unicode. |
> | [ToChar(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-string-system-iformatprovider)) | Converte o primeiro caractere da cadeia de caracteres especificada em um caractere Unicode, usando informações de formatação específicas da cultura especificadas. |
> | [ToChar(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado no caractere Unicode equivalente. |
> | [ToChar(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado no caractere Unicode equivalente. |
> | [ToChar(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tochar?view=net-6.0#system-convert-tochar(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em seu caractere Unicode equivalente. |
> | [ToDateTime(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-boolean)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-byte)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-char)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-datetime)) | Retorna o objeto [DateTime](https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-6.0) especificado; nenhuma conversão real é executada. |
> | [ToDateTime(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-decimal)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-double)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-int16)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-int32)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-int64)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-object)) | Converte o valor do objeto especificado em um objeto [DateTime](https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-6.0). |
> | [ToDateTime(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um objeto [DateTime](https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-6.0), usando as informações de formatação específicas da cultura especificadas. |
> | [ToDateTime(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-sbyte)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-single)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-string)) | Converte a representação de cadeia de caracteres especificada de uma data e hora em um valor de data e hora equivalente. |
> | [ToDateTime(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em uma data e hora equivalentes, usando as informações de formatação específicas da cultura especificadas. |
> | [ToDateTime(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-uint16)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-uint32)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDateTime(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todatetime?view=net-6.0#system-convert-todatetime(system-uint64)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDecimal(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-boolean)) | Converte o valor booliano especificado para o número decimal equivalente. |
> | [ToDecimal(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado no número decimal equivalente. |
> | [ToDecimal(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-char)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDecimal(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDecimal(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-decimal)) | Retorna o número decimal especificado; nenhuma conversão real é executada. |
> | [ToDecimal(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-double)) | Converte o valor do número de ponto flutuante de dupla precisão para um número decimal equivalente. |
> | [ToDecimal(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em um número decimal equivalente. |
> | [ToDecimal(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em um número decimal equivalente. |
> | [ToDecimal(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um número decimal equivalente. |
> | [ToDecimal(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-object)) | Converte o valor do objeto especificado em um número decimal equivalente. |
> | [ToDecimal(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um número decimal equivalente, usando as informações de formatação específicas da cultura especificada. |
> | [ToDecimal(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado no número decimal equivalente. |
> | [ToDecimal(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-single)) | Converte o valor do número de ponto flutuante de precisão simples para um número decimal equivalente. |
> | [ToDecimal(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-string)) | Converte a representação de cadeia de caracteres especificada de um número para um número decimal equivalente. |
> | [ToDecimal(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em um número decimal equivalente, usando as informações de formatação específicas da cultura especificada. |
> | [ToDecimal(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado em um número decimal equivalente. |
> | [ToDecimal(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um número decimal equivalente. |
> | [ToDecimal(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todecimal?view=net-6.0#system-convert-todecimal(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um número decimal equivalente. |
> | [ToDouble(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-boolean)) | Converte o valor booliano especificado no número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado para um número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-char)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDouble(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToDouble(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-decimal)) | Converte o valor do número decimal especificado em um número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-double)) | Retorna o número de ponto flutuante de precisão dupla especificado; nenhuma conversão real é executada. |
> | [ToDouble(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em um número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-int32)) | Converte o valor do inteiro com sinal especificado de 32 bits em um número de ponto flutuante de precisão dupla. |
> | [ToDouble(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-object)) | Converte o valor do objeto especificado em um número de ponto flutuante de precisão dupla. |
> | [ToDouble(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um número de ponto flutuante de precisão dupla, usando as informações de formatação específicas da cultura especificadas. |
> | [ToDouble(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado no número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em um número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-string-system-iformatprovider)) | Converte a representação da cadeia de caracteres especificada de um número em um número de ponto flutuante de precisão dupla equivalente, usando as informações de formatação específicas da cultura. |
> | [ToDouble(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado para um número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um número de ponto flutuante de precisão dupla equivalente. |
> | [ToDouble(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.todouble?view=net-6.0#system-convert-todouble(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um número de ponto flutuante de precisão dupla equivalente. |
> | [ToHexString(Byte[\])](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tohexstring?view=net-6.0#system-convert-tohexstring(system-byte())) | Converte uma matriz de inteiros sem sinal de 8 bits na representação de cadeia de caracteres equivalente codificada com caracteres hexadecimais maiúsculos. |
> | [ToHexString(Byte[\], Int32, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tohexstring?view=net-6.0#system-convert-tohexstring(system-byte()-system-int32-system-int32)) | Converte um subconjunto de uma matriz de inteiros sem sinal de 8 bits na representação de cadeia de caracteres equivalente codificada com caracteres hexadecimais maiúsculos. Os parâmetros especificam o subconjunto como um deslocamento na matriz de entrada e o número de elementos na matriz a converter. |
> | [ToHexString(ReadOnlySpan)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tohexstring?view=net-6.0#system-convert-tohexstring(system-readonlyspan((system-byte)))) | Converte um intervalo de inteiros sem sinal de 8 bits em sua representação de cadeia de caracteres equivalente codificada com caracteres hexadecimais maiúsculos. |
> | [ToInt16(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-boolean)) | Converte o valor booliano especificado no inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado no inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-char)) | Converte o valor do caractere Unicode especificado no inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToInt16(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-decimal)) | Converte o valor do número decimal especificado em um inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em um inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-int16)) | Retorna o inteiro com sinal de 16 bits especificado; nenhuma conversão real é executada. |
> | [ToInt16(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em um inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-object)) | Converte o valor do objeto especificado em um inteiro com sinal de 16 bits. |
> | [ToInt16(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um inteiro com sinal de 16 bits, usando as informações de formatação específicas da cultura especificadas. |
> | [ToInt16(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado em um inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em um inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro com sinal de 16 bits equivalente, usando as informações de formatação específicas à cultura especificadas. |
> | [ToInt16(String, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-string-system-int32)) | Converte a representação de cadeia de caracteres de um número em uma base especificada para um inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado no inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um inteiro com sinal de 16 bits equivalente. |
> | [ToInt16(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint16?view=net-6.0#system-convert-toint16(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um inteiro com sinal de 16 bits equivalente. |
> | [ToInt32(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-boolean)) | Converte o valor booliano especificado para o inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado em um inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-char)) | Converte o valor do caractere Unicode especificado no inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToInt32(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-decimal)) | Converte o valor do número decimal especificado em um inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em um inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em um valor com sinal de 32 bits equivalente. |
> | [ToInt32(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-int32)) | Retorna o inteiro com sinal de 32 bits especificado; nenhuma conversão real é executada. |
> | [ToInt32(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-object)) | Converte o valor do objeto especificado para um inteiro com sinal de 32 bits. |
> | [ToInt32(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um inteiro com sinal de 32 bits, usando as informações de formatação específicas da cultura especificadas. |
> | [ToInt32(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado em um inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em um número inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro com sinal de 32 bits equivalente, usando as informações de formatação específicas da cultura especificada. |
> | [ToInt32(String, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-string-system-int32)) | Converte a representação de cadeia de caracteres de um número em uma base especificada para um inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado no inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um inteiro com sinal de 32 bits equivalente. |
> | [ToInt32(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-6.0#system-convert-toint32(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um inteiro com sinal de 32 bits equivalente. |
> | [ToInt64(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-boolean)) | Converte o valor booliano especificado no inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado no inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-char)) | Converte o valor do caractere Unicode especificado no inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToInt64(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-decimal)) | Converte o valor do número decimal especificado em um inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em um inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em um inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em um inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-int64)) | Retorna o inteiro com sinal de 64 bits especificado; nenhuma conversão real é executada. |
> | [ToInt64(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-object)) | Converte o valor do objeto especificado em um inteiro com sinal de 64 bits. |
> | [ToInt64(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um inteiro com sinal de 64 bits, usando as informações de formatação específicas da cultura especificadas. |
> | [ToInt64(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado em um inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em um número inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro com sinal de 64 bits equivalente, usando as informações de formatação específicas à cultura especificadas. |
> | [ToInt64(String, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-string-system-int32)) | Converte a representação de cadeia de caracteres de um número em uma base especificada para um inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado no inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um inteiro com sinal de 64 bits equivalente. |
> | [ToInt64(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint64?view=net-6.0#system-convert-toint64(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um inteiro com sinal de 64 bits equivalente. |
> | [ToSByte(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-boolean)) | Converte o valor booliano especificado para o inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado no inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-char)) | Converte o valor do caractere Unicode especificado no inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToSByte(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-decimal)) | Converte o valor do número decimal especificado em um inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em um inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em um inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em um inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-object)) | Converte o valor do objeto especificado em um inteiro com sinal de 8 bits. |
> | [ToSByte(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um inteiro com sinal de 8 bits, usando as informações de formatação específicas à cultura especificadas. |
> | [ToSByte(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-sbyte)) | Retorna o inteiro com sinal de 8 bits especificado; nenhuma conversão real é executada. |
> | [ToSByte(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em um inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro com sinal de 8 bits equivalente, usando as informações de formatação específicas à cultura especificadas. |
> | [ToSByte(String, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-string-system-int32)) | Converte a representação de cadeia de caracteres de um número em uma base especificada para um inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado no inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um inteiro com sinal de 8 bits equivalente. |
> | [ToSByte(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosbyte?view=net-6.0#system-convert-tosbyte(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um inteiro com sinal de 8 bits equivalente. |
> | [ToSingle(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-boolean)) | Converte o valor booliano especificado no número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado no número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-char)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToSingle(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToSingle(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-decimal)) | Converte o valor do número decimal especificado para um número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em um número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em um número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em um número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-object)) | Converte o valor do objeto especificado em um número de ponto flutuante de precisão simples. |
> | [ToSingle(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um número de ponto flutuante de precisão simples, usando as informações de formatação específicas à cultura especificadas. |
> | [ToSingle(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado no número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-single)) | Retorna o número de ponto flutuante de precisão simples especificado; nenhuma conversão real é executada. |
> | [ToSingle(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres de um número especificada em um número de ponto flutuante de precisão simples equivalente, usando as informações de formatação específicas da cultura especificadas. |
> | [ToSingle(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado no número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um número de ponto flutuante de precisão simples equivalente. |
> | [ToSingle(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tosingle?view=net-6.0#system-convert-tosingle(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um número de ponto flutuante de precisão simples equivalente. |
> | [ToString(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-boolean)) | Converte o valor booliano especificado na representação de cadeia de caracteres equivalente. |
> | [ToString(Boolean, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-boolean-system-iformatprovider)) | Converte o valor booliano especificado na representação de cadeia de caracteres equivalente. |
> | [ToString(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado na representação de cadeia de caracteres equivalente. |
> | [ToString(Byte, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-byte-system-iformatprovider)) | Converte o valor do inteiro sem sinal de 8 bits especificado em sua representação de cadeia de caracteres equivalente, usando as informações de formatação específicas da cultura especificadas. |
> | [ToString(Byte, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-byte-system-int32)) | Converte o valor de um inteiro sem sinal de 8 bits em sua representação de cadeia de caracteres equivalente de uma base especificada. |
> | [ToString(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-char)) | Converte o valor do caractere Unicode especificado na representação de cadeia de caracteres equivalente. |
> | [ToString(Char, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-char-system-iformatprovider)) | Converte o valor do caractere Unicode especificado em sua representação de cadeia de caracteres equivalente, usando as informações de formatação específicas da cultura especificadas. |
> | [ToString(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-datetime)) | Converte o valor do [DateTime](https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-6.0) especificado na representação de cadeia de caracteres equivalente. |
> | [ToString(DateTime, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-datetime-system-iformatprovider)) | Converte o valor do [DateTime](https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-6.0) especificado na representação de cadeia de caracteres equivalente usando as informações de formatação específicas da cultura determinadas. |
> | [ToString(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-decimal)) | Converte o valor do número decimal especificado na representação de cadeia de caracteres equivalente. |
> | [ToString(Decimal, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-decimal-system-iformatprovider)) | Converte o valor do número decimal especificado na representação de cadeia de caracteres equivalente usando as informações de formatação específicas da cultura especificadas. |
> | [ToString(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em sua representação de cadeia de caracteres equivalente. |
> | [ToString(Double, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-double-system-iformatprovider)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em sua representação de cadeia de caracteres equivalente. |
> | [ToString(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado em sua representação de cadeia de caracteres equivalente. |
> | [ToString(Int16, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-int16-system-iformatprovider)) | Converte o valor do inteiro com sinal de 16 bits especificado em sua representação de cadeia de caracteres equivalente usando as informações de formatação específicas da cultura especificadas. |
> | [ToString(Int16, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-int16-system-int32)) | Converte o valor de um inteiro com sinal de 16 bits em sua representação de cadeia de caracteres equivalente em uma base especificada. |
> | [ToString(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em sua representação de cadeia de caracteres equivalente. |
> | [ToString(Int32, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-int32-system-iformatprovider)) | Converte o valor do inteiro com sinal de 32 bits especificado em sua representação de cadeia de caracteres equivalente usando as informações de formatação específicas da cultura especificadas. |
> | [ToString(Int32, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-int32-system-int32)) | Converte o valor de um inteiro com sinal de 32 bits na representação de cadeia de caracteres equivalente a ele em uma base especificada. |
> | [ToString(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em sua representação de cadeia de caracteres equivalente. |
> | [ToString(Int64, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-int64-system-iformatprovider)) | Converte o valor do inteiro com sinal de 64 bits especificado na representação de cadeia de caracteres equivalente, usando as informações de formatação específicas à cultura especificadas. |
> | [ToString(Int64, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-int64-system-int32)) | Converte o valor de um inteiro com sinal de 64 bits na representação de cadeia de caracteres equivalente a ele em uma base especificada. |
> | [ToString(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-object)) | Converte o valor do objeto especificado na representação de cadeia de caracteres equivalente. |
> | [ToString(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-object-system-iformatprovider)) | Converte o valor do objeto especificado na representação de cadeia de caracteres equivalente usando as informações de formatação específicas da cultura especificadas. |
> | [ToString(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado em sua representação de cadeia de caracteres equivalente. |
> | [ToString(SByte, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-sbyte-system-iformatprovider)) | Converte o valor do inteiro com sinal de 8 bits especificado em sua representação de cadeia de caracteres equivalente, usando as informações de formatação específicas à cultura especificadas. |
> | [ToString(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em sua representação de cadeia de caracteres equivalente. |
> | [ToString(Single, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-single-system-iformatprovider)) | Converte o valor do número de ponto flutuante de precisão simples em sua representação de cadeia de caracteres equivalente, usando as informações de formatação específicas da cultura. |
> | [ToString(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-string)) | Retorna a instância de cadeia de caracteres especificada; nenhuma conversão real é executada. |
> | [ToString(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-string-system-iformatprovider)) | Retorna a instância de cadeia de caracteres especificada; nenhuma conversão real é executada. |
> | [ToString(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado em uma representação de cadeia de caracteres equivalente. |
> | [ToString(UInt16, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-uint16-system-iformatprovider)) | Converte o valor do inteiro sem sinal de 16 bits especificado na representação de cadeia de caracteres equivalente, usando as informações de formatação específicas à cultura especificadas. |
> | [ToString(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado na representação de cadeia de caracteres equivalente. |
> | [ToString(UInt32, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-uint32-system-iformatprovider)) | Converte o valor do inteiro sem sinal de 32 bits especificado na representação de cadeia de caracteres equivalente, usando as informações de formatação específicas à cultura especificadas. |
> | [ToString(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado na representação de cadeia de caracteres equivalente. |
> | [ToString(UInt64, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tostring?view=net-6.0#system-convert-tostring(system-uint64-system-iformatprovider)) | Converte o valor do inteiro sem sinal de 64 bits especificado na representação de cadeia de caracteres equivalente, usando as informações de formatação específicas à cultura especificadas. |
> | [ToUInt16(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-boolean)) | Converte o valor booliano especificado no inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado no inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-char)) | Converte o valor do caractere Unicode especificado no inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToUInt16(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-decimal)) | Converte o valor do número decimal especificado em um inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em um inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado no inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em um inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-object)) | Converte o valor do objeto especificado em um inteiro sem sinal de 16 bits. |
> | [ToUInt16(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um inteiro sem sinal de 16 bits, usando as informações de formatação específicas da cultura especificada. |
> | [ToUInt16(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado no inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em um inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro sem sinal de 16 bits equivalente, usando as informações específicas à cultura especificadas. |
> | [ToUInt16(String, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-string-system-int32)) | Converte a representação de cadeia de caracteres de um número em uma base especificada em um inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-uint16)) | Retorna o inteiro sem sinal de 16 bits especificado; nenhuma conversão real é executada. |
> | [ToUInt16(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt16(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint16?view=net-6.0#system-convert-touint16(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um inteiro sem sinal de 16 bits equivalente. |
> | [ToUInt32(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-boolean)) | Converte o valor booliano especificado no inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado no inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-char)) | Converte o valor do caractere Unicode especificado no inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToUInt32(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-decimal)) | Converte o valor do número decimal especificado em um inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em um inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado no inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em um inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-object)) | Converte o valor do objeto especificado em um inteiro sem sinal de 32 bits. |
> | [ToUInt32(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um inteiro sem sinal de 32 bits, usando as informações de formatação específicas da cultura especificada. |
> | [ToUInt32(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado no inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em um inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro sem sinal de 32 bits equivalente, usando as informações específicas à cultura especificadas. |
> | [ToUInt32(String, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-string-system-int32)) | Converte a representação de cadeia de caracteres de um número em uma base especificada em um inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado no inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt32(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-uint32)) | Retorna o inteiro sem sinal de 32 bits especificado; nenhuma conversão real é executada. |
> | [ToUInt32(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint32?view=net-6.0#system-convert-touint32(system-uint64)) | Converte o valor do inteiro sem sinal de 64 bits especificado em um inteiro sem sinal de 32 bits equivalente. |
> | [ToUInt64(Boolean)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-boolean)) | Converte o valor booliano especificado no inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(Byte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-byte)) | Converte o valor do inteiro sem sinal de 8 bits especificado no inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(Char)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-char)) | Converte o valor do caractere Unicode especificado no inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(DateTime)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-datetime)) | A chamada desse método sempre lança [InvalidCastException](https://docs.microsoft.com/pt-br/dotnet/api/system.invalidcastexception?view=net-6.0). |
> | [ToUInt64(Decimal)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-decimal)) | Converte o valor do número decimal especificado em um inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(Double)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-double)) | Converte o valor do número de ponto flutuante de precisão dupla especificado em um inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(Int16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-int16)) | Converte o valor do inteiro com sinal de 16 bits especificado no inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-int32)) | Converte o valor do inteiro com sinal de 32 bits especificado em um inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(Int64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-int64)) | Converte o valor do inteiro com sinal de 64 bits especificado em um inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(Object)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-object)) | Converte o valor do objeto especificado em um inteiro sem sinal de 64 bits. |
> | [ToUInt64(Object, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-object-system-iformatprovider)) | Converte o valor do objeto especificado em um inteiro sem sinal de 64 bits, usando as informações de formatação específicas à cultura especificadas. |
> | [ToUInt64(SByte)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-sbyte)) | Converte o valor do inteiro com sinal de 8 bits especificado no inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(Single)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-single)) | Converte o valor do número de ponto flutuante de precisão simples especificado em um inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(String)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-string)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(String, IFormatProvider)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-string-system-iformatprovider)) | Converte a representação de cadeia de caracteres especificada de um número em um inteiro sem sinal de 64 bits equivalente, usando as informações específicas à cultura especificadas. |
> | [ToUInt64(String, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-string-system-int32)) | Converte a representação de cadeia de caracteres de um número em uma base especificada em um inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(UInt16)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-uint16)) | Converte o valor do inteiro sem sinal de 16 bits especificado no inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(UInt32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-uint32)) | Converte o valor do inteiro sem sinal de 32 bits especificado em um inteiro sem sinal de 64 bits equivalente. |
> | [ToUInt64(UInt64)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.touint64?view=net-6.0#system-convert-touint64(system-uint64)) | Retorna o inteiro sem sinal de 64 bits especificado; nenhuma conversão real é executada. |
> | [TryFromBase64Chars(ReadOnlySpan, Span, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tryfrombase64chars?view=net-6.0#system-convert-tryfrombase64chars(system-readonlyspan((system-char))-system-span((system-byte))-system-int32@)) | Tenta converter o intervalo especificado contendo uma representação de cadeia de caracteres codificada com dígitos de base 64 em um intervalo de números inteiros sem sinal de 8 bits. |
> | [TryFromBase64String(String, Span, Int32)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.tryfrombase64string?view=net-6.0#system-convert-tryfrombase64string(system-string-system-span((system-byte))-system-int32@)) | Tenta converter a representação de cadeia de caracteres codificada com dígitos de base 64 em um intervalo de números inteiros sem sinal de 8 bits. |
> | [TryToBase64Chars(ReadOnlySpan, Span, Int32, Base64FormattingOptions)](https://docs.microsoft.com/pt-br/dotnet/api/system.convert.trytobase64chars?view=net-6.0#system-convert-trytobase64chars(system-readonlyspan((system-byte))-system-span((system-char))-system-int32@-system-base64formattingoptions)) | Tenta converter os números inteiros sem sinal de 8 bits dentro do intervalo somente leitura especificado na representação deles de cadeia de caracteres equivalente codificada com dígitos de base 64. Opcionalmente, você pode especificar se deseja inserir quebras de linha no valor retornado. |
>
> 
>
> 9- [Operações de Bitwise - Curso Programação Completo C# - Aula 09](https://www.youtube.com/watch?v=Br1M23Qphmw&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=11)
>
> > **Lista de Operadores Bitwise C#
>
> 10-[Enumeradores (enum) - Curso Programação Completo C# - Aula 10](https://www.youtube.com/watch?v=kj_-Brm4DDI&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=12&t=303s)
>
> Um *tipo de enumeração* (ou *tipo* de enumeração) é um [tipo de valor](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/value-types) definido por um conjunto de constantes nomeadas do tipo [numérico integral](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) subjacente. Para definir um tipo de enumeração, use a `enum` palavra-chave e especifique os nomes dos `enum`:
>
> ```c#
> enum Season
> {
>     Spring,
>     Summer,
>     Autumn,
>     Winter
> }
> ```
>
> **Meu Exemplo:**
>
> ```c#
> internal class Program
> {
>     //Entrada
>     enum DiasSemana { Domindo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
>     static void Main(string[] args)
>     {
>         //Processamento
>         DiasSemana ds = (DiasSemana)5;//marcando dia da semana
>         //int ds = (int)DiasSemana.Sexta;//converte e imprime em dia numérico
> 
>         //Saida
>         Console.WriteLine(ds);//imprime dia da semana marcado
>         Console.ReadKey();
>     }
> ```
>
> 
>
> 11-[Conversões de tipos (typecast) - Curso Programação Completo C# - Aula ](https://www.youtube.com/watch?v=ucGefp2i4As&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=13)
>
> - Para converter um tipo em outro.
>
> Exemplo: 
>
> > 
> >
> > ```c#
> >           static void Main(string[] args)
> >         {
> >             //ENTRADA
> >             float n1 = 10.5f;
> >             //PROCESSAMENTO
> >             int n2 = (int)n1;//operação de type cast
> > 
> >             //SAIDA
> >             Console.WriteLine(n2);
> >             Console.ReadKey();
> >     }
> > 
> > ```
>
> 12-[Comando condicional IF - Curso Programação Completo C# ](https://www.youtube.com/watch?v=m_0y_k-sCcI&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=14)
>
> ### Operadores Aritméticos
>
> Os operadores aritméticos descritos na **Tabela 1** são os mesmos usados em cálculos matemáticos.
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
> Esses operadores são usados para compor uma operação aritmética **e** uma atribuição, conforme é descrito na **Tabela 2**.
>
> | **Operador Aritmético** | **Descrição**  |
> | ----------------------- | -------------- |
> | **+ =**                 | mais igual     |
> | **- =**                 | menos igual    |
> | *** =**                 | vezes igual    |
> | **/ =**                 | dividido igual |
> | **% =**                 | módulo igual   |
>
> ### Operadores Relacionais
>
> Os operadores relacionais comparam dois valores e retornam um valor booleano (**true** ou **false**). Veja na **Tabela 3** esses operadores.
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
> Os operadores lógicos trabalham como operandos booleanos e seu resultado também será booleano (true ou false). Eles são usados **somente** em expressões lógicas, e são descritos na **Tabela 4**.
>
> | **Operador Lógico** | **Descrição** |
> | ------------------- | ------------- |
> | **&&**              | AND = E       |
> | **\|\|**            | OR = Ou       |
> | **!**               | NOT = Não     |
>
> 13-[Condicional IF-ELSE - Curso Programação Completo C#](https://www.youtube.com/watch?v=Ojm98Gg1rVw&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=15)
>
> > **Estrutura de Condição:**
> >
> > ```csharp
> > if (condição)
> > {
> >   // Código a ser executados caso a condição seja verdadeira
> > } 
> > else 
> > {
> >   // Código a ser executados caso a condição seja falsa
> > }
> > ```
> >
> > 
>
> 14-[IF aninhado - Curso Programação Completo C# ](https://www.youtube.com/watch?v=BR8_SLFAoaM&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=16)
>
> 15-[SWITCH case - Curso Programação Completo C# ](https://www.youtube.com/watch?v=dgEYyIAq-h4&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=17)
>
> 16-[Comando goto - Curso Programação Completo C# ](https://www.youtube.com/watch?v=uE8csfcJLFk&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=18)
>
> 17-[Array / Vetor - Curso Programação Completo C# ](https://www.youtube.com/watch?v=utkQHvmmJ38&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=19)
>
> 18-[Matrizes / Vetores Bidimensionais - Curso Programação Completo C# ](https://www.youtube.com/watch?v=-w2-rlMcKhw&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=20)
>
> 19-[Loop FOR / Estruturas de iteração - Curso Programação Completo C# ](https://www.youtube.com/watch?v=cG1VokOCoJA&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=21)
>
> 20-[Loop WHILE / Estruturas de iteraão - Curso Programação Completo C# ](https://www.youtube.com/watch?v=8g-G1QT9hCk&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=22)
>
> 
=======
> 
>>>>>>> parent of 4ebf13d (Atualização aulas constantes, operadores,)


=======
>   
>>>>>>> parent of 253afe3 (Atualização aulas 9,10,11,12)



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
> *W3schol:* https://www.w3schools.com/cs/index.php

