Мій аналіз трішки перейшов межі банального [гіст](https://gist.github.com/kant2002/3cccadf516996ac28062bf1003cfa174), тому треба вже писати багато тексту, щоб ті хто не слідкували за процесом аналізу, мали змогу подивитися на те що є у більш прийнятному форматі. Через те що я так само як і ви зовнішня людина, якась інформація на цьому це мої спекуляції, тому вживайте на свій розсуд.

## Що зараз є

- [Графік залежностей між пакетами](./deps)
- [Графік залежностей між сервісами](./service-deps)
- [Діаграма флоу подій між Дією та зовнішнімі системами](./events-flow)
- [Список змінних оточення](./env-vars-list)
- [Список операція молекулера](./moleculer-actions)
- [Бази даних Mongo](./dbs)

## Сервіси
- [Сервіс Адресів](./address-service)

## OpenAPI

- [Сервіс Адресів](./swaggeriu/address.html)
- [Сервіс авторізації](./swaggeriu/auth.html)
- [Сервіс судимості](./swaggeriu/criminal-cert.html)
- [Сервіс документів користувача](./swaggeriu/documents.html)
- [Сервіс ленти](./swaggeriu/feed.html)
- [Шлюз](./swaggeriu/gateway.html)
- [Каталог публічних сервісів](./swaggeriu/public-service-catalog.html)
- [Сервіс користувача](./swaggeriu/user.html)

## GRPC

- [Сервіс Адресів](https://github.com/kant2002/be-address-service-client/blob/main/proto/address-service.proto)
- [Сервіс авторізації](https://github.com/diia-open-source/be-auth-service/blob/main/proto/auth.proto)
- [Сервіс судимості](https://github.com/diia-open-source/be-criminal-cert-service/blob/main/proto/criminal-cert-service.proto)
- [Сервіс документів користувача](https://github.com/diia-open-source/be-documents-service/blob/main/proto/documents-service.proto)
- [Каталог публічних сервісів](https://github.com/diia-open-source/be-public-service-catalog/blob/main/proto/public-service-catalog.proto)
- [Сервіс користувача](https://github.com/diia-open-source/be-user-service/blob/main/proto/user-service.proto)
- [Сервіс крипто примітивів](https://github.com/kant2002/be-diia-crypto-client/blob/main/proto/crypto-service.proto)
- [Сервіс повідомлень](https://github.com/kant2002/be-notification-service-client/blob/main/proto/notification-service.proto)
- [Сервіс аналітики](https://github.com/kant2002/be-analytics-service-client/blob/main/proto/analytics-service.proto)

## Опис архітектури

дуже поверхнево, і я ще викладені сервіси не аналізував детально, тому велика імовірність що я десь провтикаю глобально.

те що виклано це лише шлюз для доступу до самих реестрів + система авторизації + зберігання інформаціі для праці.
усі команди від фронта у вигляді мобільних апок кладуться на шину поверх Кроліка. далі переважно Дія нічого глобального не робить, а лише передає запити у правильному форматі на шину які достаавляють до реестрів.

Монга для зберігання локальних даних (ще не знаю що саме там зберігається, треба час щоб щось прийнятне витягти)
Аутентіфікація там якесь незрозуміле кубло, я буду тягти до останнього поки норм, бо я не спеціалізуюся на безпеці, і мені буде складно аналізувати що там таке.

процеси і події із шини задокументовані, і що цікаво є якісь великі коди процесні, що вказує на те що є якийсь над великий  документ де усі держ процеси можливо задокументовані.

## Спостереження

1. Клієнти, для яких немає ісходного коду, згенеровані якоюсь іншою версію genproto ніж та що у опенсурсі або із іншою версією пакету types. Є дрібні відмінності, які мабуть світчами не зробиш. можливо це залежить від версії ts-proto або protoc, не знаю.
2. Не зовсім безпека, але потенційні операційні проблеми колись
   - https://github.com/diia-open-source/be-auth-service/blob/4c7e8500780694b9778656def29a82273fc55ffb/src/config.ts#L217
   - https://github.com/diia-open-source/be-auth-service/blob/4c7e8500780694b9778656def29a82273fc55ffb/src/config.ts#L330-L333