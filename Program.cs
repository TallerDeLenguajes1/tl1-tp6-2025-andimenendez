int opcion;
int resultado;
int otroCalculo = 1;
int a, b;


while (otroCalculo == 1)
{
   Console.WriteLine("Ingrese la opcion segun la operacion que desea realizar \n1 -SUMA\n2-RESTA\n3-DIVISION\n4-MULTIPLICACION");
   string menu = Console.ReadLine();
   bool ConvertirAIntopcion = int.TryParse(menu, out opcion);

   Console.WriteLine("ingrese el primer numero");
   string primerNumero = Console.ReadLine();
   bool ConvertirAIntPrimerNumero = int.TryParse(primerNumero, out a);

   Console.WriteLine("ingrese el segundo numero");
   string segundoNumero = Console.ReadLine();
   bool ConvertirAIntSegundoNumero = int.TryParse(segundoNumero, out b);

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


   Console.WriteLine("\n¿Desea realizar otra operación? \n1 - Sí\n2 - No");
   string respuesta = Console.ReadLine();
   bool ConvertirAInt = int.TryParse(respuesta, out otroCalculo);
}


