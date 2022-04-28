﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject
{
    //game manager
    public class DungeonGame
    {
        GameGUI gameGUI;
        GameLogic gameLogic;

        public DungeonGame()
        {
            gameGUI = new GameGUI();
            gameLogic = new GameLogic();
            Application.Run(gameGUI);
        }
    }
}
