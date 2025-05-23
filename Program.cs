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
   {
   if (numero1 > numero2)
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
