using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGProject
{
    public class Bandit : Enemy
    {
        public Bandit()
        {
            name = "Bandit";
            strength = 5;
            intelligence = 1;
            defense = 5;
            speed = 10;
            isDefending = false;
            hitPoints = 100;
            mySprite = Properties.Resources.Bandit;
        }
    }
}