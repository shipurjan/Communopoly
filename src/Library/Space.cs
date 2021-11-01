using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Space
    {
        protected int position;
        public void SetPosition(int p)
        {
            position = p;
        }
        public int GetPosition()
        {
            return position;
        }

    }
}
