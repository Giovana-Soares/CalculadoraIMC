using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Qual sua altura?");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual seu peso?");
            float peso = Convert.ToSingle(Console.ReadLine());

            Pessoa pessoa1 = new Pessoa(nome,altura,peso);
            Console.WriteLine("{0} sua altura é {1} e seu peso é {2}", pessoa1.Nome, pessoa1.altura, pessoa1.peso);
            Console.WriteLine("Seu IMC: {0} " , pessoa1.Imc );


            
            
            if(imc<18.50){
                double pesoIdeal = 18.50;
                double pesoAganhar = Math.Round((pesoIdeal - imc), 2);
      
                 Console.WriteLine("Você precisa ganhar {0} KG para atingir o peso ideal", pesoAganhar); 
            }
          
            if(imc>=25.0){
                double pesoIdeal = 25.0;
                double pesoAperder = Math.Round(( imc - pesoIdeal ), 2);
                  
                Console.WriteLine("Você precisa perder {0} KG para atingir o peso ideal", pesoAperder); 
            }
        }
    }
}
