﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Player2 : Player
    {
        // Player 2 Constructor
        public Player2(string playerName, int playerAge, string heroName) : base(playerName, playerAge, heroName) { }
        // Overring Status from Player
        public override void Status()
        {
            Console.WriteLine("Status: " + offlineStatus);
        }
        // Overring Do from Player 
        public override void Do()
        {
            Console.WriteLine("Player 1 is " + inQueue);
        }
    }
}
