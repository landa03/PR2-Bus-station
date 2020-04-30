using System;
using System.Collections.Generic;

namespace estacion_de_trenes
{
    class Program
    {
        static void Main(string[] args)
        {
            //utilizar queue de "data structures 2"
            //utilizar program de "count shars"
            //utilizar "console menu"
            Menu menu = new Menu();
            menu.Display();

            Queue queue = new Queue();

            System.Console.WriteLine(queue);

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");
            //queue.Enqueue(Convert.ToString(Console.ReadLine()));
            
        }
    }
}
