using System;
using BeastSimulator.Core;

namespace BeastSimulator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Beast beast = new Beast();

            Pause("Beast created");
            beast.ZobrazitStav();

            Pause("Testing Starni()");
            beast.Starni();
            beast.ZobrazitStav();

            Pause("Testing Nakrm()");
            beast.Nakrm();
            beast.ZobrazitStav();

            for (int day = 1; day <= 10; day++)
            {
                Pause($"-- Day {day} --");
                beast.Starni();
                beast.ZobrazitStav();

                bool alive = beast.IsAllive();
                Console.WriteLine("Alive: " + alive);

                if (!alive)
                {
                    Console.WriteLine("Beast died.");
                    break;
                }
            }

            Pause("Test finished");
        }

        static void Pause(string message)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine(message);
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();


        }
    }
}