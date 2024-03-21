using System.Text.RegularExpressions;
using Система;
using Система.ВВ;

var папкаІзДією = args[0];
var усіЗмінні = new Dictionary<string, ЗміннаОточення>();
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

    var назваМодуля = Path.GetFileName(папкаМодуля);
    //НадрукуватиЗмінні(назваМодуля, змінні);
    ОбєднатиЗмінні(назваМодуля, змінні);
}

НадрукуватиУсіЗмінні(усіЗмінні);

void ОбєднатиЗмінні(string назваМодуля, Dictionary<string, ЗміннаОточення> змінні)
{
    foreach (var назва in змінні.Keys)
    {
        var змінна = змінні[назва];

        if (усіЗмінні.TryGetValue(назва, out var глобальнаЗмінна))
        {
            глобальнаЗмінна.ЄЗмінноюСервісаОточення = змінна.ЄЗмінноюСервісаОточення || глобальнаЗмінна.ЄЗмінноюСервісаОточення;
            глобальнаЗмінна.ЄЗмінноюОточення = змінна.ЄЗмінноюОточення || глобальнаЗмінна.ЄЗмінноюОточення;
            глобальнаЗмінна.Модулі.Add(назваМодуля);
        }
        else
        {
            усіЗмінні.Add(назва, змінна);
            змінна.Модулі.Add(назваМодуля);
        }
    }
}

static void НадрукуватиЗмінні(string назваМодуля, Dictionary<string, ЗміннаОточення> змінні)
{
    Console.WriteLine($"# Модуль {назваМодуля}");
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

void НадрукуватиУсіЗмінні(Dictionary<string, ЗміннаОточення> змінні)
{
    Console.WriteLine($"# Усі змінні");
    if (змінні.Count == 0)
    {
        Console.WriteLine();
        Console.WriteLine($"Змінні оточення не використовуються");
    }
    else
    {
        Console.WriteLine("| Змінна | Оточення | Сервіс | Модулі |");
        Console.WriteLine("| ------ | -------- | ------ | ---- |");
        foreach (var назва in змінні.Keys.OrderBy(_ => _))
        {
            var змінна = змінні[назва];
            var модулі = string.Join(", <br>", змінна.Модулі.OrderBy(_ => _));
            Console.WriteLine($"| {назва,-40} | {(змінна.ЄЗмінноюОточення ? ":white_check_mark:" : ""),-20} | {(змінна.ЄЗмінноюСервісаОточення ? ":white_check_mark:" : ""),-20} | {модулі} |");
        }
    }

    Console.WriteLine();
}

class ЗміннаОточення
{
    public bool ЄЗмінноюОточення { get; set; }
    public bool ЄЗмінноюСервісаОточення { get; set; }

    public HashSet<string> Модулі { get; set; } = new();
}