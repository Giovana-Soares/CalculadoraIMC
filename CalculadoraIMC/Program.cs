using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Qual seu nome?");
    string nome = Console.ReadLine();
  
    Console.WriteLine("Qual sua altura?");
    float altura = Convert.ToSingle(Console.ReadLine());
          
    Console.WriteLine("Qual seu peso?");
    float peso = Convert.ToSingle(Console.ReadLine());
          
    double imc = Math.Round(peso / (altura * altura), 2);
    Console.WriteLine("{0} sua altura é {1} e seu peso é {2}", nome, altura, peso);
    Console.WriteLine("Seu IMC: " +imc);
          
          
    if (imc<17)
    {
      Console.WriteLine("Muito abaixo do peso");
    }
    else if (imc>=17.00 && imc < 18.50)
    {
      Console.WriteLine("Abaixo do peso");
    }
    else if (imc>=18.50 && imc < 25.00)
    {
      Console.WriteLine("Peso Normal");
    }
    else if (imc>=25.00 && imc < 30.00)
    {
      Console.WriteLine("Acima do Peso");
    } 
    else if (imc>=30.00 && imc < 35.00)
    {
      Console.WriteLine("Obesidade I");
    }
    else if (imc>=35.00 && imc < 40.00)
    {
      Console.WriteLine("Obesidade II (severa)");
    }
    else if (imc>=40.00)
    {
      Console.WriteLine("Obesidade III (mórbida)");
    }
      
    if(imc<18.50){
      double pesoIdeal = 18.50;
      double pesoAganhar = Math.Round((pesoIdeal - imc), 2);
      
      Console.WriteLine("Você precisa ganhar {0} KG para atingir o peso ideal", pesoAganhar); 
    }
          
    if(imc>=25.0){
      double pesoIdeal = 25.0;
      double pesoAganhar = Math.Round(( imc - pesoIdeal ), 2);
                  
      Console.WriteLine("Você precisa perder {0} KG para atingir o peso ideal", pesoAganhar); 
    }
  }
}