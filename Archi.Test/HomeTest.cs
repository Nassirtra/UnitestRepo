using System;
using System.Collections.Generic;
using System.Text;

namespace Archi.Test
{
    internal class HomeTest
    {

        public HomeTest()
        {
        }

        internal string GetUserName(int userId)
        {
            string name = null;
            if (userId == 1)
            {
                name = "first";
            }
            else if (userId == 2)
            {
                name = "second";
            }
            else
            {
                name = "nothing";
            }
            return name;
        }
    }
}
