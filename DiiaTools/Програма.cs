using System.Text.RegularExpressions;
using Система;
using Система.ВВ;

var папкаІзДією = args[0];
foreach (var папкаМодуля in Directory.EnumerateDirectories(папкаІзДією))
{
    var файлОписа = Path.Combine(папкаМодуля, "package.json");
    if (!Файл.Існує(файлОписа))
    {
        continue;
    }

    var змінні = new Dictionary<string, ЗміннаОточення>();
    if (Directory.Exists(Path.Combine(папкаМодуля, "src")))
    {
        foreach (var ісходнийФайл in Directory.EnumerateFiles(папкаМодуля, "src/*.ts", SearchOption.AllDirectories))
        {
            var зміст = Файл.ПрочитатиУсіТекст(ісходнийФайл);
            var співставленняЗміннихОточення = Regex.Matches(зміст, @"process\s*.\s*env\s*.\s*([A-Za-z_]*)", RegexOptions.Singleline);
            foreach (var співставлення in співставленняЗміннихОточення.OfType<Match>())
            {
                var змінна = співставлення.Groups[1].Value;
                if (змінні.TryGetValue(змінна, out var дані))
                {
                    дані.ЄЗмінноюОточення = true;
                }
                else
                {
                    змінні.Add(змінна, new ЗміннаОточення { ЄЗмінноюОточення = true });
                }
            }

            var співставленняЗміннихСервісу = Regex.Matches(зміст, @"envService\s*.\s*getVar\s*\(\s*'([A-Za-z_]*)'", RegexOptions.Singleline);
            foreach (var співставлення in співставленняЗміннихСервісу.OfType<Match>())
            {
                var змінна = співставлення.Groups[1].Value;
                if (змінні.TryGetValue(змінна, out var дані))
                {
                    дані.ЄЗмінноюСервісаОточення = true;
                }
                else
                {
                    змінні.Add(змінна, new ЗміннаОточення { ЄЗмінноюСервісаОточення = true });
                }
            }
        }
    }

    Console.WriteLine($"# Модуль {Path.GetFileName(папкаМодуля)}");
    if (змінні.Count == 0)
    {
        Console.WriteLine();
        Console.WriteLine($"Змінні оточення не використовуються");
    }
    else
    {
        Console.WriteLine("| Змінна | Оточення | Сервіс | Опис |");
        Console.WriteLine("| ------ | -------- | ------ | ---- |");
        foreach (var назва in змінні.Keys.OrderBy(_ => _))
        {
            var змінна = змінні[назва];
            Console.WriteLine($"| {назва,-40} | {(змінна.ЄЗмінноюОточення ? ":white_check_mark:" : ""),-20} | {(змінна.ЄЗмінноюСервісаОточення ? ":white_check_mark:" : ""),-20} |   |");
        }
    }

    Console.WriteLine();
}

class ЗміннаОточення
{
    public bool ЄЗмінноюОточення { get; set; }
    public bool ЄЗмінноюСервісаОточення { get; set; }
}