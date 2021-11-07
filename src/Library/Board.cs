using Library.Spaces;
using Library.Republics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    public class Board : PropertyChangedBase
    {
        public const int Size = 40;
        public ObservableCollection<Space> Spaces { get; set; }
        public Board()
        {
            MakeBoard();
        }
        private int[] generateRandomRepublicValues(int siberiaIndex) {
            Random _rnd = new Random();
            int[] rndTotal = Enumerable.Range(0, siberiaIndex).OrderBy(c => _rnd.Next()).ToArray();
            int[] rndSelected = new int[8];
            Array.Copy(rndTotal, 0, rndSelected, 0, 8);
            int rnd = _rnd.Next(0, 8);
            rndSelected[rnd] = siberiaIndex;
            return rndSelected;
        }
        private Republic MakeRepublic(int pos, int[] randomRepublicValues) {
            int republicIndex = randomRepublicValues[(int)((pos - 1) / 5)];
            string className = ((Republics)republicIndex).ToString();
            var container = Activator.CreateInstance(null, "Library.Republics." + className);
            Republic republic = (Republic)container.Unwrap();
            return republic;
        }
        private void MakeBoard()
        {
            int siberiaIndex = (int)Republics.Siberia;
            int[] randomRepublicValues = generateRandomRepublicValues(siberiaIndex);

            Spaces = new ObservableCollection<Space>();

            for (int pos = 0; pos < Size; pos++)
            {
                Space space = null;
                
                switch (pos)
                {
                    default:
                        space = MakeRepublic(pos, randomRepublicValues);
                        break;
                    case 5:
                    case 15:
                    case 25:
                    case 35:
                        space = new Station();
                        break;
                    case 7:
                    case 13:
                        space = new Chance();
                        break;
                    case 0:
                        space = new Start();
                        break;
                    case 10:
                        space = new Reeducation();
                        break;
                    case 20:
                        space = new Katorga();
                        break;
                    case 30:
                        space = new Redistribution();
                        break;
                }
                space.Position = pos;
                space.SetIndices(pos);
                Spaces.Add(space);
            }
        }
        public enum Republics
        {
            Armenian,
            Azerbaijan,
            Byelorussian,
            Estonian,
            Georgian,
            Kazakh,
            Kirghiz,
            Latvian,
            Lithuanian,
            Moldavian,
            Russian,
            Tajik,
            Turkmen,
            Ukrainian,
            Uzbek,
            // Syberia powinna być zawsze ostatnia
            Siberia
        }
    }

}