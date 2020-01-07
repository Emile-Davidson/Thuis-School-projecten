using System;

namespace arrays_loops
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string[] lijstje = {"sword", "shield", "potion", "head", "undead army"};
            bool running = true;
            Random randomnumber = new Random();
            Console.Clear();
            while(running == true){
                Console.WriteLine("leuk joch!");
                if(randomnumber.Next(0, 10) == 5){
                running = false;
                }
            }
            for(int bla = 0; bla < lijstje.Length; bla++){
                Console.WriteLine("item" + bla + "is" + lijstje[bla]);
            }
            foreach(string item in lijstje){
                Console.WriteLine(item);
            }
        }
    }
}
