using System;
using System.Collections.Generic;

namespace estacion_de_trenes
{
    class Queue
    {
        private List<string> elements = new List<string>();

        //Enqueue
        public void Enqueue(string elementToEnqueue)
        {
            elements.Add(elementToEnqueue);
            System.Console.WriteLine($"Enqueue({elementToEnqueue})");
        }

        //Dequeue
        public string Dequeue()
        {
            string firstElement = elements[0];

            elements.RemoveAt(0);

            return firstElement;
        }

        //Front
        public string? Front()
        {
            if (elements.Count == 0)
            {
                return null;
            }

            string firstElement = elements[0];

            return firstElement;
        }

        //Rear
        public string? Rear()
        {
            if (elements.Count == 0)
            {
                return null;
            }

            int lastPosition = elements.Count - 1;

            return elements[lastPosition];
        }

        //print queue
        public void Print()
        {
            foreach (string truk in elements)
            {
                System.Console.WriteLine(truk);
            }
        }
        public void DequeueAll()
        {
            foreach (string truk in elements)
            {
                Dequeue();
            }
        }
        

        public override string ToString()
        {
            string queueAsString = "";
            queueAsString += "---------------------\n";
            foreach (var item in elements)
            {
                queueAsString += $"{item} | ";

            }
            queueAsString += "\n---------------------\n";

            return queueAsString;
        }
    }
}
