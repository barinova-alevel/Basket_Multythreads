﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace Busket
{
    class UberCheater : UsualPlayer
    {
        public UberCheater(string name, CounterKeeper counterKeeper, Busket1 busket) : base(name, counterKeeper, busket)
        {
        }

        private static int startNumber;
        private static int count;

        static UberCheater()
        {
            startNumber = 40;
            count = 0;
        }

        public override int GuessNumber()
        {
            Console.WriteLine($"{Name} is thinking about number.... ");
            Thread.Sleep(100);
            int temp = startNumber + count;
            if (list.Contains(temp))
            {
                startNumber++;
                temp = startNumber + count;
            }
            list.Add(temp);
            count++;
            Console.WriteLine($"{Name} number is {temp}");
            return temp;
        }
    }
}
