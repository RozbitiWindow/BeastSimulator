using System;
using System.Collections.Generic;
using System.Text;

namespace BeastSimulator.Core
{
    internal class Beast
    {
        private string _name;
        private int _age;
        private int _food;
        private int _energy;
        private int _luck;
        private int _energyGrow = 0;
        private int _hungerGrow = 0;
        private bool _hungerRestore = false;
        private bool _isAllive = true;
        public Beast()
        {
            _name = "Green Monster";
            _age = 250;
            _food = 50;
            _energy = 30;
            _luck = 50;
        }

        public void ZobrazitStav()
        {
            Console.WriteLine("Your Beast: " + _name);
            Console.WriteLine("\nAge: " + _age);
            if (_food >= 100)
            {
                _food = 100;
                Console.WriteLine("Hunger: " + _food + " (full)");
            }
            else if (_food == 50) { Console.WriteLine("Hunger: " + _food + " (50%)"); }
            else { Console.WriteLine("Hunger: " + _food); }
            Console.WriteLine("Energy: " + _energy);
            Console.WriteLine("Luck: " + _luck);

        }

        public void Starni()
        {
            // hunger vice než dost
            if (_food < 5)
            {
                Console.WriteLine("You cant grow right now, no hunger left!");
                _hungerGrow = 0;
            }
            else
            {
                _hungerGrow = 1;
            }

            if (_energy < 3) //energy
            {
                Console.WriteLine("You cant grow right now, no energy left!");
                _energyGrow = 0;
            }
            else
            {
                _energyGrow = 1;
            }

            // Pokud jsou obě podmínky splněny, teprve pak se mění hodnoty a přičítá věk
            if (_hungerGrow == 1 && _energyGrow == 1)
            {
                Console.WriteLine("You are growing!");
                Console.WriteLine("Losing hunger, luck and energy");

                _food -= 5;
                _energy -= 3;
                _age++;
                _luck = Math.Max(0, _luck - 2);
            }
            else
            {
                Console.WriteLine("You cant grow. Missing stats!");
            }
        }

        public void Nakrm()
        {
            if (_food > 99)
            {
                Console.WriteLine("Cant restore 0 hunger!");
            }
            else
            {
                _hungerRestore = true;
            }

            if (_hungerRestore == true)
            {
                _food = _food + 5;
                _energy = _energy + 3;

                if (_food > 100) { _food = 100; }
                if (_food < 0) { _food = 0; }
                if (_energy > 100) { _energy = 100; }
                if (_energy < 0) { _energy = 0; }
                Console.WriteLine("Grr.. super betrayed!");

            }

            _hungerRestore = false;


        }

        public bool IsAlive()
        {
            if (_food > 0 && _luck > 0 && _energy > 0)
            {
                _isAllive = true;
            }
            else
            {
                _isAllive = false;
                Console.WriteLine("Your bestie died!");
            }
            return _isAllive;
        }

        public void HrajSi()
        {
            if (_energy >= 20 && _food >= 10)
            {
                _food -= 10;
                _energy -= 20;
                _luck += 20;
                Console.WriteLine("Hurrraaa..that was great fun!");
                if (_food < 0)
                {
                    _food = 0;
                }
                if (_energy > 0)
                {
                    { _energy = 0; }
                }
                if (_luck > 100)
                {
                    _luck = 100;
                }

                else
                {
                    Console.WriteLine("You cant play, not enought energy or hunger!");

                }
            }

        }
    }
}