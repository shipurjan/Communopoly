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
namespace RefactoringGuru.DesignPatterns.Adapter.Conceptual
{
    
    public interface ITarget
    {
        string GetRequest();
    }

   
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }

