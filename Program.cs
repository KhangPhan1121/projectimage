using System;
using projectimage;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap: ");
        string input = Console.ReadLine();

        if(string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Nhap sai");
            return;
        }

        string[] words = input.Split(",");

        ImageInput imageInput = new ImageInput();
        ImageDownloader imageDownloader = new ImageDownloader();
        ImageSave imageSave = new ImageSave();

        foreach(string word in words)
        {
            string ConvertedText = imageInput.Convert(word.Trim());
            byte[] imageData = imageDownloader.DownloadImage(ConvertedText);

            if(imageData != null)
            {
                imageSave.SaveImageToFile(imageData, $"{word.Trim()}");
            }
        }
    }
}