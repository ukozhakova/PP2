﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_FIle
{
	// Simple synchronous file copy operations with no user interface.
	// To run this sample, first create the following directories and files:
	// C:\Users\Public\TestFolder
	// C:\Users\Public\TestFolder\test.txt
	// C:\Users\Public\TestFolder\SubDir\test.txt
	public class SimpleFileCopy
	{
		static void Main()
		{
			string fileName = "test.txt";
			string sourcePath = @"C:\Users\Asus\Desktop\family";
			string targetPath = @"C:\Users\Asus\Desktop\family\for text";

			// Use Path class to manipulate file and directory paths.
			string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
			string destFile = System.IO.Path.Combine(targetPath, fileName);

			// To copy a folder's contents to a new location:
			// Create a new target folder, if necessary.
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}

			// To copy a file to another location and 
			// overwrite the destination file if it already exists.
			System.IO.File.Copy(sourceFile, destFile, true);

			// To copy all the files in one directory to another directory.
			// Get the files in the source folder. (To recursively iterate through
			// all subfolders under the current directory, see
			// "How to: Iterate Through a Directory Tree.")
			// Note: Check for target path was performed previously
			//       in this code example.
			if (System.IO.Directory.Exists(sourcePath))
			{
				string[] files = System.IO.Directory.GetFiles(sourcePath);

				// Copy the files and overwrite destination files if they already exist.
				foreach (string s in files)
				{
					// Use static Path methods to extract only the file name from the path.
					fileName = System.IO.Path.GetFileName(s);
					destFile = System.IO.Path.Combine(targetPath, fileName);
					System.IO.File.Copy(s, destFile, true);
				}
			}
			else
			{
				Console.WriteLine("Source path does not exist!");
			}
			Console.ReadKey();
		}
	}
}
