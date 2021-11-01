using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Space : PropertyChangedBase
    {
        protected int position;
        private SpaceColor spaceColor;
        public SpaceColor SpaceColor { get; set; }
        public void SetSpaceColor(SpaceColor c)
        {
            spaceColor = c;
        }
        public void SetPosition(int p)
        {
            position = p;
        }
        public int GetPosition()
        {
            return position;
        }

    }
    public enum SpaceColor
    {
        republic,
        chance,
        katorga,
        redistribution,
        reeducation,
        start,
        station
    }
}
