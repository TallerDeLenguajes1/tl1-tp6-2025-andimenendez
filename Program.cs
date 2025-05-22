Console.WriteLine("Ingrese el primer numero");
string PrimerNumero = Console.ReadLine();
Console.WriteLine("Ingrese el primer numero");
string segundoNumero = Console.ReadLine();
  int a;
  int b;
  int aux;
bool ConvertirAIntPrimerNumero = int.TryParse(PrimerNumero, out a)
;
bool ConvertirAIntSegundoNumero = int.TryParse(segundoNumero, out b)
;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: " + b);

if (a > 0 && b > 0)
{
   aux = a;
   a = b;
   b = aux;
Console.WriteLine("valor invertido de A: " +a); 
Console.WriteLine("valor de invertido de B: " +b); 
}
else
{
   Console.WriteLine("para poder invertir los numeros deben ser mayor a 0");
}
