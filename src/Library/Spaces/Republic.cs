using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Spaces
{
    public abstract class Republic : Space
    {
        private RepublicColor republicColor;
        public RepublicColor RepublicColor { get; set; }

    }
    public enum RepublicColor
    {
        armenian,
        azerbaijan,
        byelorussian,
        estonian,
        georgian,
        kazakh,
        kirghiz,
        latvian,
        lithuanian,
        moldavian,
        russian,
        siberia,
        tajik,
        turkmen,
        ukrainian,
        uzbek
    }
}
