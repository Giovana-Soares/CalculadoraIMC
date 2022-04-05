public class Pessoa{

    public string Nome{get;set;}
    public double Altura{get;set;}
    public double Peso { get; set; }

   
   
   
    public Pessoa(string Nome, double Altura, double Peso)
    {
        Nome= Nome;
        Altura=Altura;
        Peso=Peso;
    }

    public double Imc { get => (Math.Round(peso / (altura * altura), 2); }

    public string FaixaIMC {
        if (imc<17)
            {
                return Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc>=17.00 && imc < 18.50)
            {
               return Console.WriteLine("Abaixo do peso");
            }
            else if (imc>=18.50 && imc < 25.00)
            {
                return Console.WriteLine("Peso Normal");
            }
            else if (imc>=25.00 && imc < 30.00)
            {
                return Console.WriteLine("Acima do Peso");
            }
            else if (imc>=30.00 && imc < 35.00)
            {
                return Console.WriteLine("Obesidade I");
            }
            else if (imc>=35.00 && imc < 40.00)
            {
                return Console.WriteLine("Obesidade II (severa)");
            }
            else if (imc>=40.00)
            {
                return Console.WriteLine("Obesidade III (mórbida)");
            }
            else {
                return Console.WriteLine("Valores invalidos");
                }
            }
    }
}