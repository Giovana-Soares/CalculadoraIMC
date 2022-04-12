public class Pessoa{

    public string Nome{get;set;}
    public double Altura{get;set;}
    public double Peso { get; set; }


    public double IMC { get => Peso / (Altura * Altura); }

    
    public string FaixaIMC(){
        if (IMC<17)
            {
                return "Muito abaixo do peso";
            }
            else if (IMC>=17.00 && IMC < 18.50)
            {
               return "Abaixo do peso";
            }
            else if (IMC>=18.50 && IMC < 25.00)
            {
                return "Peso Normal";
            }
            else if (IMC>=25.00 && IMC < 30.00)
            {
                return "Acima do Peso";
            }
            else if (IMC>=30.00 && IMC < 35.00)
            {
                return "Obesidade I";
            }
            else if (IMC>=35.00 && IMC < 40.00)
            {
                return "Obesidade II (severa)"; 
            }
            else if(IMC>40.00)
            {
                return "Obesidade III (mórbida)";
            }
        return "ERRO";
    }

    public double Calculo(){ 
                if(IMC<18.50){
                    double pesoIdeal = 18.50;
                    double pesoAganhar = pesoIdeal - IMC;
                    return pesoAganhar; 
                }
          
                if(IMC>=25.0){
                    double pesoIdeal = 25.0;
                    double pesoAperder =  IMC - pesoIdeal;  
                    return pesoAperder; 
                }
                return -1;
            }

            public Pessoa(string nome, double altura, double peso)
            {
                Nome= nome;
                Altura=altura;
                Peso=peso;
            }
    
}