using System;
using System.Threading;

namespace Stopwatch
{

    class Program
    {
        static void Main(string[] args)
        {
            int T = Menu();
            Prestart();
            Start(T);
        }

        static int Menu()

        {

            Console.Clear();
        
            Console.WriteLine("S = Segundos");
            Console.WriteLine("");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("");  
            Console.WriteLine("0 = Sair");
            Console.WriteLine("");
            Console.WriteLine("Deseja contar o tempo em Minutos ou Segundo ? ");
            char op = char.Parse(Console.ReadLine().ToLower());
            
            if(op == 's'){
                Console.WriteLine("Quanto tempo deseja contar ??");
                int Time = Int32.Parse(Console.ReadLine());
                return (Time);
            }
            else if(op == 'm'){
                Console.WriteLine("Quanto tempo deseja contar ??");
                int Time = Int32.Parse(Console.ReadLine());
                return (Time * 60);
            }
            else if(op  == 0){
                System.Environment.Exit(0);
                return 0;
            }
            
            else{
               Console.WriteLine("Opção errada, vocé voltara ao menu...");
               Menu();
               return 0;
            }
        }
        static void Prestart(){
            Console.Clear();
            Console.WriteLine("Ready...");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);
        }

        static void Start(int time)
        {
            int currentTime = 0;
           
            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Timer finalizado... Voltanto para o menu");
             Thread.Sleep(2000);
            Menu();

        }
    }

}
