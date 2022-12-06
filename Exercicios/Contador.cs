using System;
class Programa {
  static void Main(string[] args)
  {
    int inicial, final, incremento;
    
    Console.WriteLine("Informe o valor inicial: ");
    inicial = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Informe o valor final: ");
    final = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Informe o incremento: ");
    incremento = Convert.ToInt32(Console.ReadLine());
    
    Console.Clear();
    
    if (final >= inicial)
    {
        for (inicial = inicial; inicial <= final; inicial+=incremento)
        {
            Console.WriteLine(inicial);
        }
    }
    else if (inicial > final)
    {
        for (inicial = inicial; inicial > final; inicial-=incremento)
        {
            Console.WriteLine(inicial);
        }
    }
  }
}