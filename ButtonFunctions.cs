using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TempFileDeleter
{
    internal class ButtonFunctions
    {

        public static bool temp;
        public static bool down;
        public static bool bin;


        public static void DeleteButton()
        {
            if (temp)
            {
                Operations.DeleteTemp();
            }

            if (down)
            {
                Operations.DeleteDownloads();
            }

            if (bin)
            {
                Operations.EmptyRecycleBin();
            }

            if (!down && !temp && !bin)
            {
                MessageBox.Show("Select an option");
            }
        }
    }
}
