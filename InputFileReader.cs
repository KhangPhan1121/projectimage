using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectimage
{
    public class InputFileReader
    {
        public string[] Read(string filePath)
        {
            try
            {
                if(File.Exists(filePath))
                {
                    return File.ReadAllLines(filePath);
                }
                else
                {
                    Console.WriteLine($"File {filePath} khong ton tai");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"loi doc file{ex.Message}");
            }
            return new string[0];
        }
    }
}