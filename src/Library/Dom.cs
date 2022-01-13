using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Dom
    {
        public void mortgageProperty(Player player) 
        { 
            PlayerInput input = new PlayerInput();
            Monopoly game = new Monopoly();

            if (player.getPropertiesOwnedFromBoard().Count == 0)
            {

                Console.WriteLine("Nie masz żadnych domków.", input.playerPrompt(player));

                return;
            }
            else if (player.getPropertiesOwnedFromBoard().Count > 4)
            {
                Console.WriteLine("Czy chcesz zamienić 4 domki na hotel?");
            }

        }
    }


}

