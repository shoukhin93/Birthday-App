using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_App
{
    class FormCharacteristics
    {
        public string[,] movemenCharactaristics = { { "x", "y++" }, { "x++", "y--" }, { "x", "y++" }, { "x++", "y--" }, 
                                                  { "x--", "y++" }, { "x", "y--" }, {"x--", "y--"}, {"x--", "y++"}, {"x++", "y++"},
                                                  {"x++", "y--"}, {"x", "y++"}, {"x++", "y++"}};

        public string[] imageName = { "a", "p","p", "y", "b","i","r","t","h","d","a","y" };
    }
}
