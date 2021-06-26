using System;

namespace Exercicio_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double quantidade;
            string combustivel;

            Console.Write($@"Gasolina(g), Álcool(a) Digite combustível você deseja: ");
            combustivel = Console.ReadLine().ToLower();

            Console.Write("\nQuantos litros você quer desse combustivel: ");
            quantidade = double.Parse(Console.ReadLine());

            switch (CombustivelValidado(combustivel))
            {
                case "a":
                precoAlcool(quantidade);
                    break;
                case "g":
                precoGasolina(quantidade);
                    break;
            }
        }
        static string CombustivelValidado(string combustivel){
            bool combustivelVerificado;
            combustivelVerificado = false;

            while(combustivelVerificado == false){
                if(combustivel == "a"){
                    combustivelVerificado = true;
                }
                else if(combustivel == "g"){
                    combustivelVerificado = true;
                }
                else{
                    Console.Write($@"Combustível inválido!!
Gasolina(g), Álcool(a)
Digite combustível você deseja: ");
                    combustivel = Console.ReadLine().ToLower();
                }
            }
                return(combustivel);
        }
        static void precoAlcool(double quantidade){
            double precoAlcool, valor, descontoInicial, desconto, valorDescontado;

            if(quantidade <= 20){
            precoAlcool = 4.90; 
            descontoInicial = precoAlcool * 0.03;
            valorDescontado = precoAlcool - descontoInicial;

            desconto = descontoInicial * quantidade;
            valor = valorDescontado * quantidade;

            Console.WriteLine($"\nO desconto que você receberá é de {desconto.ToString("N2")}");
            Console.WriteLine($"O valor a pagar é de {valor.ToString("N2")}");
            } else {
            precoAlcool = 4.90; 
            descontoInicial = precoAlcool * 0.05;
            valorDescontado = precoAlcool - descontoInicial;

            desconto = descontoInicial * quantidade;
            valor = valorDescontado * quantidade;

            Console.WriteLine($"\nO desconto que você receberá é de {desconto.ToString("N2")}");
            Console.WriteLine($"O valor a pagar é de {valor.ToString("N2")}");
            }
        }
        static void precoGasolina(double quantidade){
            double precoGasolina, valor, descontoInicial, desconto, valorDescontado;

            if(quantidade <= 20){
            precoGasolina = 4.90; 
            descontoInicial = precoGasolina * 0.04;
            valorDescontado = precoGasolina - descontoInicial;

            desconto = descontoInicial * quantidade;
            valor = valorDescontado * quantidade;

            Console.WriteLine($"\nO desconto que você receberá é de {desconto.ToString("N2")}");
            Console.WriteLine($"O valor a pagar é de {valor.ToString("N2")}");
            } else {
            precoGasolina = 4.90; 
            descontoInicial = precoGasolina * 0.06;
            valorDescontado = precoGasolina - descontoInicial;

            desconto = descontoInicial * quantidade;
            valor = valorDescontado * quantidade;

            Console.WriteLine($"\nO desconto que você receberá é de {desconto.ToString("N2")}");
            Console.WriteLine($"O valor a pagar é de {valor.ToString("N2")}");
            }
        }
    }
            
               
                
        
            }
            
           


            // 1- Fazer o cara escolher entre alcool ou gasolina = feito
            // 2 - Fazer o cara escolher quantos litros ele vai querer 

            // 3 - Se ele escolher alcool e for menos que ou igual a 20 litros,
            // desconto de 3%
            // 4- Se ele escolher alcool e for maior que 20 litros, desconto de
            // 5%

            // 5 - Se ele escolher gasolina e for menos que ou igual a 20 litros,
            // desconto de 4%
            // 6- Se ele escolher alcool e for maior que 20 litros, desconto de
            // 6%

            // Preço alcool = 4,90
            // Preço gasolina = 5,30
            

        


    

