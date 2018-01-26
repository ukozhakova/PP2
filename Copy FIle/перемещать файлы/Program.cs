using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перемещать_файлы
{
	public class SimpleFileMove
	{
		static void Main()
		{
			string sourceFile = @"C:\Users\Asus\Desktop\family\test.txt";
			string destinationFile = @"C:\Users\Asus\Desktop\Mamam\test.txt";

			// To move a file or folder to a new location:
			System.IO.File.Move(sourceFile, destinationFile);

			// To move an entire directory. To programmatically modify or combine
			// path strings, use the System.IO.Path class.
			System.IO.Directory.Move(@"C:\Users\Asus\Desktop\family\prog Tomp\hh", @"C:\Users\Asus\Desktop\family\ConsoleApp1");
		}
	}
}
