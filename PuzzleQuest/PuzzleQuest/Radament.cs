﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleQuest
{
    class Radament
    {
        public string nazwa;
        public int hp;
        public float obrazenia;
        public float krytyczne;
        public Radament(string n, int zycie, float dmg, float cryt)
        {
            this.nazwa = n;
            this.hp = zycie;
            this.obrazenia = dmg;
            this.krytyczne = cryt;

        }

        public Radament() { }
    }
}
