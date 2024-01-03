using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectimage
{
    public class ImageSave
    {
        public void SaveImageToFile(byte[] imageData, string fileName)
        {
            try
            {
                File.WriteAllBytes(fileName, imageData);
                Console.WriteLine($"Image saved to file:  {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving image: {ex.Message}");
            }
        }
    }
}