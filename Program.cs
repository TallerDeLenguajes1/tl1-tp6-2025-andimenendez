float numero;
Console.WriteLine("Ingrese un numero");
string numeroIngresado = Console.ReadLine();
bool ConvertirAintNumeroIngresado = float.TryParse(numeroIngresado, out  numero);
if (ConvertirAintNumeroIngresado)
{
      float absoluto = Math.Abs(numero);
      float cuadrado = numero * numero;
      double raiz = Math.Sqrt(numero);
      double seno = Math.Sin(numero);
      double coseno = Math.Cos(numero);
      int parteEntera = (int)Math.Truncate(numero);
    
   // Mostrar resultados
      Console.WriteLine($"Valor absoluto: {absoluto}");
      Console.WriteLine($"Cuadrado: {cuadrado}");
      Console.WriteLine($"Raíz cuadrada (de números negativos se muestra 0): {raiz}");
      Console.WriteLine($"Seno: {seno}");
      Console.WriteLine($"Coseno: {coseno}");
      Console.WriteLine($"Parte entera: {parteEntera}");
}
else
{
   Console.WriteLine("numero no valido");
}

float numero1;
float numero2;
Console.WriteLine("Ingrese el primer numero");
string numero1Ingresado = Console.ReadLine();
bool ConvertirAintNumero1Ingresado = float.TryParse(numero1Ingresado, out  numero1);
Console.WriteLine("Ingrese el segundo numero");
string numero2Ingresado = Console.ReadLine();
bool ConvertirAintNumero2Ingresado = float.TryParse(numero2Ingresado, out numero2);

   if (ConvertirAintNumero1Ingresado && ConvertirAintNumero2Ingresado)
   {   if (numero1 > numero2)
   {
      Console.WriteLine($"\nMáximo:{numero1}");
      Console.WriteLine($"\nMinimo:{numero2}");
   }
   else
   {
      Console.WriteLine($"\nMáximo:{numero2}");
      Console.WriteLine($"\nMinimo:{numero1}");
   }
   }


// calculadora v1
int opcion;
int resultado;
int otroCalculo = 1;
int a, b;


while (otroCalculo == 1)
{
   Console.WriteLine("Ingrese la opcion segun la operacion que desea realizar \n1-SUMA\n2-RESTA\n3-DIVISION\n4-MULTIPLICACION");
   string menu = Console.ReadLine();
   bool ConvertirAIntopcion = int.TryParse(menu, out opcion);
   if (opcion >= 1 && opcion <= 4)
   {
      Console.WriteLine("ingrese el primer numero");
         string primerNumero = Console.ReadLine();
         bool ConvertirAIntPrimerNumero = int.TryParse(primerNumero, out a);

      Console.WriteLine("ingrese el segundo numero");
         string segundoNumero = Console.ReadLine();
         bool ConvertirAIntSegundoNumero = int.TryParse(segundoNumero, out b);

      if(ConvertirAIntPrimerNumero && ConvertirAIntSegundoNumero)
         {
            switch (opcion)
            {
               case 1:
                  resultado = a + b;
                  Console.WriteLine($"{a}+{b} = {resultado}");
                  break;
               case 2:
                  resultado = a - b;
                  Console.WriteLine($"{a}-{b} = {resultado}");
                  break;
               case 3:
                  resultado = a / b;
                  Console.WriteLine($"{a}/{b} = {resultado}");
                  break;
               case 4:
                  resultado = a * b;
                  Console.WriteLine($"{a}*{b} = {resultado}");
                  break;
            }
         }else{
            Console.WriteLine("numeros no validos");
         }
   } else {
      Console.WriteLine("opcion incorrecta");
   }

   do
   {
      Console.WriteLine("\n Ingrese 1: Si desea realizar otra operacion o 0 segun lo que desee realizar");
      string Nuevarespuesta = Console.ReadLine();
      bool ConvertirNuevaRespuestaAInt = int.TryParse(Nuevarespuesta, out otroCalculo);
      if (!ConvertirNuevaRespuestaAInt || (otroCalculo != 0 && otroCalculo != 1))
    {
        Console.WriteLine("Entrada inválida. Ingrese solo 1 o 0.");
        otroCalculo = -1; 
    }
   } while ((otroCalculo != 1) && (otroCalculo != 0));

}


