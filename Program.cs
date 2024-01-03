using System;
using projectimage;

public class Program
{
    public static void Main(string[] args)
    {
        InputFileReader inputFileReader = new InputFileReader();
        ImageInput imageInput = new ImageInput();
        ImageDownloader imageDownloader = new ImageDownloader();
        ImageSave imageSave = new ImageSave();

        string[] words = inputFileReader.Read("input.txt");
        foreach (string input in words)
        {
            try
            {
                string ConvertedText = imageInput.Convert(input);
                byte[] imageData = imageDownloader.DownloadImage(ConvertedText);
                imageSave.SaveImageToFile(imageData, $"{input}.PNG");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi xu ly: {ex.Message}");
            }
        }
    }
}