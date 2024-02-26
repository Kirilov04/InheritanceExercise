using System;
using System.Collections.Generic;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Wizard> wizardList = new();
            var kiko = new Wizard("Kiko", 1);
            var maria = new DarkWizard("Maria", 11);
            var pesho = new SoulMaster("Pesho", 111);

            wizardList.Add(kiko);
            wizardList.Add(maria);
            wizardList.Add(pesho);

            foreach (var wizard in wizardList) 
            {
                wizard.CastSpell();
            }
        }
    }
}