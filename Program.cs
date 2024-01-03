using System;
using projectimage;

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; ; i++)
        {
            string a = Console.ReadLine();

            ImageInput imageInput = new ImageInput();
            string b = imageInput.Convert(a);

            ImageDownloader imageDownloader = new ImageDownloader();
            var c = imageDownloader.DownloadImage(b);

            ImageSave imageSave = new ImageSave();
            imageSave.SaveImageToFile(c, a + ".PNG");
        }
    }
}