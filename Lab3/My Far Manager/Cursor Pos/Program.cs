using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace My_Far_Manager
    {
        using System;

        class Sample
        {
            protected static int origRow;
            protected static int origCol;

            protected static void WriteAt(string s, int x, int y)
            {
                    Console.SetCursorPosition(origCol + x, origRow + y);
                    Console.Write(s);
            }

            public static void Main()
            {
                WriteAt("File", 6, 36);
                Console.WriteLine();
            }
        }
    }

}
