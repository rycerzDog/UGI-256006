using System;

class Program
{
    static string Translit(string text)
    {
        string result = "";

        text = text.ToUpper();

        foreach (char c in text)
        {
            switch (c)
            {
                case 'А': result += "A"; break;
                case 'Б': result += "B"; break;
                case 'В': result += "V"; break;
                case 'Г': result += "G"; break;
                case 'Д': result += "D"; break;
                case 'Е':
                case 'Ё': result += "E"; break;
                case 'Ж': result += "ZH"; break;
                case 'З': result += "Z"; break;
                case 'И':
                case 'Й': result += "I"; break;
                case 'К': result += "K"; break;
                case 'Л': result += "L"; break;
                case 'М': result += "M"; break;
                case 'Н': result += "N"; break;
                case 'О': result += "O"; break;
                case 'П': result += "P"; break;
                case 'Р': result += "R"; break;
                case 'С': result += "S"; break;
                case 'Т': result += "T"; break;
                case 'У': result += "U"; break;
                case 'Ф': result += "F"; break;
                case 'Х': result += "KH"; break;
                case 'Ц': result += "TS"; break;
                case 'Ч': result += "CH"; break;
                case 'Ш': result += "SH"; break;
                case 'Щ': result += "SHCH"; break;
                case 'Ъ': result += "IE"; break;
                case 'Ы': result += "Y"; break;
                case 'Ь': break;
                case 'Э': result += "E"; break;
                case 'Ю': result += "IU"; break;
                case 'Я': result += "IA"; break;
                default: result += c; break;
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Введите текст на русском: ");
        string text = Console.ReadLine();

        Console.WriteLine(Translit(text));
    }
}