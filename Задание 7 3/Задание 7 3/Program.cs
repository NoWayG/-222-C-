using System;
using System.Text;
class Program
{
    static void Main()
    {
        string text = " мой крутой коледж.я говорю это честно.люблю ТЭТК.";
        Console.WriteLine(" исходный текст:" + text);

        string formattedText = FormatText(text);
        Console.WriteLine(" фоматированный текст:" + formattedText);
        Console.ReadKey();
    }
    static string FormatText(string text)
    {
        string[] sentences = text.Split('.');
        StringBuilder formattedText = new StringBuilder();
        foreach (string sentence in sentences)
        {
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                string trimmedSentence = sentence.Trim();
                if (trimmedSentence.Length > 0)
                {
                    char firstChar = char.ToUpper(trimmedSentence[0]);
                    formattedText.Append(firstChar + trimmedSentence.Substring(1).Trim() + ". ");
                }
            }
        }
        return formattedText.ToString().Trim();
    }
}