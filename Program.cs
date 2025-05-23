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
