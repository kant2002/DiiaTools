Запуск
======

Я запускав Дію двома способами, перший спосіб це [локально](#вариант-1-локальна-побудова-сервісів) будувати сервіси і запускати, другий спосіб це підіймати усе [через Докер](#вариант-2-запуск-у-докері).

# Вариант 1. Локальна побудова сервісів

Запуск інфраструктури

```
git clone -b outhouse https://github.com/kant2002/diia-setup-howto
cd diia-setup-howto/backend
mkdir scripts/
cd scripts
openssl genrsa -out key.pem 2048
openssl req -new -sha256 -key key.pem -subj "/C=UA/ST=Kiiv/O=Diia in Action/CN=localhost" -addext "subjectAltName=DNS:localhost,DNS:bankid" -out csr.csr
openssl req -x509 -sha256 -days 365 -key key.pem -in csr.csr -out certificate.pem -copy_extensions copy

openssl pkcs12 -export -inkey key.pem -in certificate.pem -out aspnetapp.pfx -password pass:12345678
cd ..
cp .env.example .env
docker compose up --file docker-compose.infra.yml
```

Запуск сервісу шлюзу

```
git clone -b outhouse https://github.com/kant2002/be-gateway-service
cd be-gateway-service
npm ci
npm start
cp .env.example .env
```

Запуск сервіса авторізації
```
git clone -b outhouse https://github.com/kant2002/be-auth-service
cd be-gateway-service
npm ci
npm start
cp .env.example .env
```

Змінити у файлі .env ці значення
```
NODE_TLS_REJECT_UNAUTHORIZED=0
BANK_ID_API_HOST=localhost
BANK_ID_API_PORT=55032
GRPC_BANK_ID_CRYPTO_SERVICE_ADDRESS=localhost:5192
```

Запуск сервісу документів

```
git clone https://github.com/kant2002/be-documents-service
cd be-documents-service
npm ci
npm start
cp .env.example .env
```

Запуск сервісу каталогу держ послуг

```
git clone https://github.com/kant2002/be-public-service-catalog
cd be-public-service-catalog
npm ci
npm start
cp .env.example .env
```

Запуск сервісу даних користувача

```
git clone https://github.com/kant2002/be-user-service
cd be-user-service
npm ci
npm start
cp .env.example .env
```

# Вариант 2. Запуск у Докері

Запуск інфраструктури

```
git clone -b outhouse https://github.com/kant2002/diia-setup-howto
cd diia-setup-howto/backend
mkdir scripts/
cd scripts
openssl genrsa -out key.pem 2048
openssl req -new -sha256 -key key.pem -subj "/C=UA/ST=Kiiv/O=Diia in Action/CN=localhost" -addext "subjectAltName=DNS:localhost,DNS:bankid" -out csr.csr
openssl req -x509 -sha256 -days 365 -key key.pem -in csr.csr -out certificate.pem -copy_extensions copy

openssl pkcs12 -export -inkey key.pem -in certificate.pem -out aspnetapp.pfx -password pass:12345678
cd ..

cp .env.example .env
cp .env.auth.example .env.auth
cp .env.gateway.example .env.gateway
cp .env.documents.example .env.documents
docker compose up --file docker-compose.yml
```
