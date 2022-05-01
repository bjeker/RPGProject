using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject
{
    public class GameLogic
    {
        public event EventHandler<HeroesUpdateEventArgs> HeroesUpdate;
        List<Hero> heroList = new List<Hero>();

        public GameLogic()
        {
            
        }

        public void InitializeGame()
        {
            HeroesAssemble();
        }

        //add heroes to list
        private void HeroesAssemble()
        {
            heroList.Add(new Warrior());
            heroList.Add(new Mage());
            heroList.Add(new Cleric());
            HeroesUpdated();
        }

        private void HeroesUpdated()
        {
            HeroesUpdateEventArgs e = new HeroesUpdateEventArgs(heroList);
            OnHeroesUpdate(this, e);
        }

        protected virtual void OnHeroesUpdate(object? sender, HeroesUpdateEventArgs e)
        {
            HeroesUpdate?.Invoke(sender, e);
        }
    }
}
