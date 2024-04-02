# Інструменти Дії

Набір інструментів для аналізу ісходного коду Дії.

Для запуску Дії, треба запустити FakeBankId(емуляція системи BankID), та FakeDiiaCrypto (емуляція сервіса diia-crypto)

Також треба накласти [латку](https://github.com/kant2002/be-auth-service/commit/7c9b7c7445ab224f02516a9e055abe0d45f278a2) до сервіса be-auth-service.

Додадкові зміни у .env файлі

```
NODE_TLS_REJECT_UNAUTHORIZED=0
BANK_ID_API_HOST=localhost
BANK_ID_API_PORT=55032
GRPC_BANK_ID_CRYPTO_SERVICE_ADDRESS=localhost:5192
```