using System.Text.RegularExpressions;
using Система;
using Система.ВВ;

var папкаІзДією = args[0];
var усіЗмінні = new Dictionary<string, ЗміннаОточення>();
var описиЗмінних = new ОписЗмінноїОточення[]
{
    new () { Назва = "AUTH_MONOBANK_API_TOKEN",         ЗовнішнійКомпонент = "MONOBANK", Опис = "" },
    new () { Назва = "AUTH_MONOBANK_BASE_URL",          ЗовнішнійКомпонент = "MONOBANK", Опис = "" },
    new () { Назва = "AUTH_MONOBANK_IS_ENABLED",        ЗовнішнійКомпонент = "MONOBANK", Опис = "" },
    new () { Назва = "AUTH_MONOBANK_PRIVATE_KEY_PATH",  ЗовнішнійКомпонент = "MONOBANK", Опис = "" },

    new () { Назва = "AUTH_PRIVATBANK_ACCOUNT",         ЗовнішнійКомпонент = "PRIVATBANK", Опис = "" },
    new () { Назва = "AUTH_PRIVATBANK_ACCOUNT_SECRET",  ЗовнішнійКомпонент = "PRIVATBANK", Опис = "" },
    new () { Назва = "AUTH_PRIVATBANK_BASE_URL",        ЗовнішнійКомпонент = "PRIVATBANK", Опис = "" },

    new () { Назва = "BANK_ID_ACCESS_CLIENT_ID",        ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_ACCESS_CLIENT_SECRET",    ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_API_HOST",                ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_API_URL_AUTH_PATH",       ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_API_URL_TOKEN_PATH",      ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_API_URL_USER_PATH",       ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_DATASET",                 ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_IS_ENABLED",              ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_VERIFY_HTTPS",            ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_VERIFY_MEMBER_ID",        ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "BANK_ID_VERSION",                 ЗовнішнійКомпонент = "BANK_ID", Опис = "" },
    new () { Назва = "GRPC_BANK_ID_CRYPTO_SERVICE_ADDRESS", ЗовнішнійКомпонент = "BANK_ID", Опис = "" },

    new () { Назва = "EIS_ADDRESS_IN_STRUCTURE", ЗовнішнійКомпонент = "EIS", Опис = "" },
    new () { Назва = "EIS_AGREE_URL", ЗовнішнійКомпонент = "EIS", Опис = "" },
    new () { Назва = "EIS_API_HOST", ЗовнішнійКомпонент = "EIS", Опис = "" },
    new () { Назва = "EIS_API_PORT", ЗовнішнійКомпонент = "EIS", Опис = "" },
    new () { Назва = "EIS_AUTH_PASSWORD", ЗовнішнійКомпонент = "EIS", Опис = "" },
    new () { Назва = "EIS_AUTH_USERNAME", ЗовнішнійКомпонент = "EIS", Опис = "" },
    new () { Назва = "EIS_IS_ENABLED", ЗовнішнійКомпонент = "EIS", Опис = "" },
    new () { Назва = "EIS_RETURN_EXPIRED", ЗовнішнійКомпонент = "EIS", Опис = "" },

    new () { Назва = "ENEMY_TRACK_TELEGRAM_BOT_AUTH_ID", ЗовнішнійКомпонент = "ENEMY_TRACK", Опис = "" },
    new () { Назва = "ENEMY_TRACK_TELEGRAM_BOT_HOST",   ЗовнішнійКомпонент = "ENEMY_TRACK", Опис = "" },

    new () { Назва = "ERESIDENT_APPLICANT_EMAIL_OTP_TTL_IN_SEC", ЗовнішнійКомпонент = "ERESIDENT", Опис = "" },
    new () { Назва = "ERESIDENT_APPLICANT_OTP_LENGTH",  ЗовнішнійКомпонент = "ERESIDENT", Опис = "" },
    new () { Назва = "ERESIDENT_APPLICANT_TEST_EMAIL_REGEXP", ЗовнішнійКомпонент = "ERESIDENT", Опис = "" },
    new () { Назва = "ERESIDENT_APPLICANT_TEST_OTP",    ЗовнішнійКомпонент = "ERESIDENT", Опис = "" },
    new () { Назва = "ERESIDENT_REGISTRY_IS_ENABLED",   ЗовнішнійКомпонент = "ERESIDENT", Опис = "" },

    new () { Назва = "EXTERNAL_RABBIT_ASSERT_EXCHANGES",    ЗовнішнійКомпонент = "EXTERNAL_RABBIT", Опис = "" },
    new () { Назва = "EXTERNAL_RABBIT_CUSTOM_RESPONSE_ROUTING_KEY_PREFIX",  ЗовнішнійКомпонент = "EXTERNAL_RABBIT", Опис = "" },
    new () { Назва = "EXTERNAL_RABBIT_HEARTBEAT",       ЗовнішнійКомпонент = "EXTERNAL_RABBIT", Опис = "" },
    new () { Назва = "EXTERNAL_RABBIT_HOST",            ЗовнішнійКомпонент = "EXTERNAL_RABBIT", Опис = "" },
    new () { Назва = "EXTERNAL_RABBIT_PASSWORD",        ЗовнішнійКомпонент = "EXTERNAL_RABBIT", Опис = "" },
    new () { Назва = "EXTERNAL_RABBIT_PORT",            ЗовнішнійКомпонент = "EXTERNAL_RABBIT", Опис = "" },
    new () { Назва = "EXTERNAL_RABBIT_QUEUE_PREFETCH_COUNT", ЗовнішнійКомпонент = "EXTERNAL_RABBIT", Опис = "" },
    new () { Назва = "EXTERNAL_RABBIT_RESPONSE_ROUTING_KEY_PREFIX", ЗовнішнійКомпонент = "EXTERNAL_RABBIT", Опис = "" },
    new () { Назва = "EXTERNAL_RABBIT_USERNAME",        ЗовнішнійКомпонент = "EXTERNAL_RABBIT", Опис = "" },

    new () { Назва = "MINIO_ACCESS_KEY",                ЗовнішнійКомпонент = "MINIO", Опис = "" },
    new () { Назва = "MINIO_HOST",                      ЗовнішнійКомпонент = "MINIO", Опис = "" },
    new () { Назва = "MINIO_IS_ENABLED",                ЗовнішнійКомпонент = "MINIO", Опис = "" },
    new () { Назва = "MINIO_PORT",                      ЗовнішнійКомпонент = "MINIO", Опис = "" },
    new () { Назва = "MINIO_SECRET_KEY",                ЗовнішнійКомпонент = "MINIO", Опис = "" },

    new () { Назва = "MONGO_AUTH_SOURCE",               ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_CACHE_AUTH_SOURCE",         ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_CACHE_DATABASE",            ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_CACHE_HOSTS",               ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_CACHE_IS_ENABLED",          ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_CACHE_PASSWORD",            ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_CACHE_PORT",                ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_CACHE_READ_PREFERENCE",     ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_CACHE_REPLICA_SET",         ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_CACHE_USER",                ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_DATABASE",                  ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_HOST",                      ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_HOSTS",                     ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_INDEXES_EXIT_AFTER_SYNC",   ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_INDEXES_SYNC",              ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_PASSWORD",                  ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_PORT",                      ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_READ_PREFERENCE",           ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_REPLICA_SET",               ЗовнішнійКомпонент = "MONGO", Опис = "" },
    new () { Назва = "MONGO_USER",                      ЗовнішнійКомпонент = "MONGO", Опис = "" },

    new () { Назва = "RABBIT_HEARTBEAT",                ЗовнішнійКомпонент = "RABBIT", Опис = "" },
    new () { Назва = "RABBIT_HOST",                     ЗовнішнійКомпонент = "RABBIT", Опис = "" },
    new () { Назва = "RABBIT_PASSWORD",                 ЗовнішнійКомпонент = "RABBIT", Опис = "" },
    new () { Назва = "RABBIT_PORT",                     ЗовнішнійКомпонент = "RABBIT", Опис = "" },
    new () { Назва = "RABBIT_QUEUE_PREFETCH_COUNT",     ЗовнішнійКомпонент = "RABBIT", Опис = "" },
    new () { Назва = "RABBIT_USERNAME",                 ЗовнішнійКомпонент = "RABBIT", Опис = "" },

    new () { Назва = "SEVDEIR_IS_ENABLED",              ЗовнішнійКомпонент = "SEVDEIR", Опис = "" },

    new () { Назва = "STRAPI_API_HOST",                 ЗовнішнійКомпонент = "STRAPI", Опис = "" },
    new () { Назва = "STRAPI_API_PORT",                 ЗовнішнійКомпонент = "STRAPI", Опис = "" },
    new () { Назва = "STRAPI_API_TOKEN",                ЗовнішнійКомпонент = "STRAPI", Опис = "" },
    new () { Назва = "STRAPI_IS_ENABLED",               ЗовнішнійКомпонент = "STRAPI", Опис = "" },

    new () { Назва = "UBCH_AUTH_PATH",                  ЗовнішнійКомпонент = "UBCH", Опис = "" },
    new () { Назва = "UBCH_HOST",                       ЗовнішнійКомпонент = "UBCH", Опис = "" },
    new () { Назва = "UBCH_IS_ENABLED",                 ЗовнішнійКомпонент = "UBCH", Опис = "" },
    new () { Назва = "UBCH_LOGIN",                      ЗовнішнійКомпонент = "UBCH", Опис = "" },
    new () { Назва = "UBCH_PASSWORD",                   ЗовнішнійКомпонент = "UBCH", Опис = "" },
    new () { Назва = "UBCH_STATIC_SESS_ID",             ЗовнішнійКомпонент = "UBCH", Опис = "" },
    new () { Назва = "UBCH_SUBSCRIBE_PATH",             ЗовнішнійКомпонент = "UBCH", Опис = "" },
    new () { Назва = "UBCH_UNSUBSCRIBE_PATH",           ЗовнішнійКомпонент = "UBCH", Опис = "" },

    new () { Назва = "ZIPKIN_IS_ENABLED",               ЗовнішнійКомпонент = "ZIPKIN", Опис = "" },
    new () { Назва = "ZIPKIN_SEND_INTERVAL_SEC",        ЗовнішнійКомпонент = "ZIPKIN", Опис = "" },
    new () { Назва = "ZIPKIN_URL",                      ЗовнішнійКомпонент = "ZIPKIN", Опис = "" },
};
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
                    змінні.Add(змінна, new ЗміннаОточення { ЄЗмінноюОточення = true, ЗовнішнійКомпонент = ВзятиЗовнішнійКомпонент(змінна) });
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
                    змінні.Add(змінна, new ЗміннаОточення { ЄЗмінноюСервісаОточення = true, ЗовнішнійКомпонент = ВзятиЗовнішнійКомпонент(змінна) });
                }
            }
        }
    }

    var назваМодуля = Path.GetFileName(папкаМодуля);
    //НадрукуватиЗмінні(назваМодуля, змінні);
    ОбєднатиЗмінні(назваМодуля, змінні);
}

//НадрукуватиУсіЗмінні(усіЗмінні);
НадрукуватиУсіЗмінніПоЗовнішнімКомпонентам(усіЗмінні);

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

string ВзятиЗовнішнійКомпонент(string змінна)
{
    return описиЗмінних.FirstOrDefault(_ => _.Назва == змінна)?.ЗовнішнійКомпонент ?? "";
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

void НадрукуватиУсіЗмінніПоЗовнішнімКомпонентам(Dictionary<string, ЗміннаОточення> змінні)
{
    var группиКомпонентів = змінні.GroupBy(_ => _.Value.ЗовнішнійКомпонент).OrderBy(_ => _.Key);
    foreach (var гр in группиКомпонентів)
    {
        Console.WriteLine($"# Усі змінні сервісу {гр.Key}");
        if (гр.Count() == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Змінні оточення не використовуються");
        }
        else
        {
            Console.WriteLine("| Змінна | Оточення | Сервіс | Модулі |");
            Console.WriteLine("| ------ | -------- | ------ | ---- |");
            foreach (var пара in гр.OrderBy(_ => _.Key))
            {
                var назва = пара.Key;
                var змінна = пара.Value;
                var модулі = string.Join(", <br>", змінна.Модулі.OrderBy(_ => _));
                Console.WriteLine($"| {назва,-40} | {(змінна.ЄЗмінноюОточення ? ":white_check_mark:" : ""),-20} | {(змінна.ЄЗмінноюСервісаОточення ? ":white_check_mark:" : ""),-20} | {модулі} |");
            }
        }

        Console.WriteLine();
    }    
}

class ОписЗмінноїОточення
{
    public required string Назва { get; set; }
    public required string ЗовнішнійКомпонент { get; set; }
    public required string Опис { get; set; }
}

class ЗміннаОточення
{
    public bool ЄЗмінноюОточення { get; set; }
    public bool ЄЗмінноюСервісаОточення { get; set; }
    public required string ЗовнішнійКомпонент { get; set; }

    public HashSet<string> Модулі { get; set; } = new();
}