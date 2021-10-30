using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Space
    {
        private int position;
        private string type;
        public Space(int position)
        {
            this.position = position;
        }
        public string Type
        {
            get { return type; }
            set
            {
                switch (position)
                {
                    default:
                        type = "Republic";
                        break;
                    case 31:
                    case 32:
                    case 33:
                    case 34:
                        type = "Siberia";
                        break;
                    case 5:
                    case 15:
                    case 25:
                    case 35:
                        type = "Station";
                        break;
                    case 7:
                    case 13:
                        type = "Chance";
                        break;
                    case 0:
                        type = "Start";
                        break;
                    case 10:
                        type = "Reeducation";
                        break;
                    case 20:
                        type = "Katorga";
                        break;
                    case 30:
                        type = "Redistribution";
                        break;
                }
            }
        }
    }
}
