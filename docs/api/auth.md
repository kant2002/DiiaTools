Сервіс авторизації
==================

Процес авторизації на тестовому стенді.

- Отримав список авторизаційних методів і отримання ідентифікатора процеса для типу авторизації authorization
- Отримання адреси авторизації для вибраного банку
- Підтверждення авторизаційного коду від банку
- Отримання токена авторизації Дія

```
# Тестовий стенд Дії
$domain = "https://api2oss.diia.gov.ua"
# Банк НаДія
$bankId = "user1"
$appVersion = "4.3.0.1433"
$methods = $(curl -X GET "$domain/api/v3/auth/authorization/methods" `
 -H "Accept: application/json" `
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" `
 -H "app-version: 1.0.1" `
 -H "platform-type: Android" `
 -H "platform-version: 12") | ConvertFrom-JSON
$processId = $methods.processId
$authUrl = $(curl -X GET "$domain/api/v3/auth/bankid/auth-url?processId=$processId&bankId=$bankId" `
 -H "Accept: application/json" `
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" `
 -H "app-version: 1.0.1" `
 -H "platform-type: Android" `
 -H "platform-version: 12") | ConvertFrom-JSON
$authUrl = $authUrl.authUrl	
$url = $authUrl.Replace("signIn.html", "/bankid/signIn").Replace("bankid:8081", "localhost:55032") + "&token=DF8BC4DB62C3F5426C1549E301600"

$redirectToCode = $(curl -X GET $url `
 -H "Accept: application/json" `
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" `
 -H "app-version: 1.0.1" `
 -H "platform-type: Android" `
 -H "platform-version: 12")
$redirectToCode = $redirectToCode.Replace("Redirecting to ", "").Trim('.')
$redirectToCode = $redirectToCode.Replace("$domain/api/v1/auth/bank-id/code/callback?code=", "");
$verifyProcess = $(curl -X GET "$domain/api/v1/auth/bankid/$redirectToCode/verify?processId=$processId&bankId=user1" `
 -H "Accept: application/json" `
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" `
 -H "app-version: 1.0.1" `
 -H "platform-type: Android" `
 -H "platform-version: 12")
$verifyProcess


$diiaToken = $(curl -X GET "$domain/api/v3/auth/token?processId=$processId" `
  -H "Accept: application/json" `
  -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" `
  -H "app-version: 1.0.1" `
  -H "platform-type: Android" `
  -H "platform-version: 12") | ConvertFrom-JSON
$diiaToken.token
$token = $diiaToken.token
```

Перевірка валідності токена. Цей метод залежить від версії аплікації, мабуть 3.0.0 буде достатньо

```
curl -X GET "$domain/api/v3/public-service/catalog" `
 -H "Authorization: Bearer $token" `
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" `
 -H "app-version: 4.3.0.1433" `
 -H "platform-type: Android" `
 -H "platform-version: 12"
```

## Аналіз серверної частини

Виклик створення тестового авторизаційного токена із невалідним РНОКПП (111)
```shell
curl -X POST "http://localhost:8080/api/v1/auth/test/111/token" \
 -H "Accept: application/json" \
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" \
 -H "app-version: 1.0.1" \
 -H "platform-type: Android" \
 -H "platform-version: 12" \
 -H "Content-Type: application/json" \
 -d '{"fName":"string","lName":"string","mName":"string","email":"string","birthDay":"string","gender":"male","document":"string","addressOfRegistration":"string"}' \
```

Повідомлення у лозі
```
<= Request 'Auth.testGetToken.v1' with requestID '9c4d52f2-6eb8-45b5-8690-496470a2f2e9' received from 'desktop-41bgid2-24356' node.
ACT IN: Auth.testGetToken.v1
Start receiving test token
Mongo: {"coll":"refreshtokens","method":"find","query":{"mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f"},"doc":{}}
Mongo: {"coll":"photoidauthrequests","method":"deleteOne","query":{"mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f"},"doc":{}}
Mongo: {"coll":"refreshtokens","method":"deleteMany","query":{"mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f"},"doc":{}}
Deleted photoIdAuthRequestModel by d85a2569-dbaf-4130-828f-8b5ddfd2512f
Publish event: auth-user-log-out {"event":"auth-user-log-out","payload":{"mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f","userIdentifier":"df2b063d6715b97e96c075bdac58ecd77d85d90843c805b6f09322209efe75dd18691c312e2f6b8fa3a60106214a1d68c7195063e9568e120b3bbb3786502278"},"meta":{"date":"2024-03-31T09:00:01.346Z"}}
Removed refresh tokens by mobile uid: 1
Mongo: {"coll":"customrefreshtokenexpirations","method":"findOne","query":{"platformType":"Android","appVersion":"1.0.1"},"doc":{}}
Mongo: {"coll":"refreshtokens","method":"insertOne","query":{"value":"ff885c6e-b8f5-4a78-9519-fca7d813349e","expirationTime":1717059601368,"sessionType":"User","eisTraceId":"47885137-cfa6-40d6-bd9e-c3129b627b18","mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f","authEntryPoint":{"target":"Test","isBankId":false},"authEntryPointHistory":[{"authEntryPoint":{"target":"Test","isBankId":false},"date":"2024-03-31T09:00:01.369Z"}],"userIdentifier":"df2b063d6715b97e96c075bdac58ecd77d85d90843c805b6f09322209efe75dd18691c312e2f6b8fa3a60106214a1d68c7195063e9568e120b3bbb3786502278","platformType":"Android","platformVersion":"12","appVersion":"1.0.1","isDeleted":false,"lastActivityDate":"2024-03-31T09:00:01.369Z","_id":"66092611754d31d3f37c8270","createdAt":"2024-03-31T09:00:01.375Z","updatedAt":"2024-03-31T09:00:01.375Z","__v":0},"doc":{}}
Refresh token created
User data to encrypt
rnokpp is not valid
Itn is not valid
ACT IN FAILED: Auth.testGetToken.v1
The 'Auth.testGetToken.v1' request is rejected.
```

Виклик створення тестового авторизаційного токена із технічно валідним РНОКПП (8111111111)
```shell
curl -X POST "http://localhost:8080/api/v1/auth/test/8111111111/token" \
 -H "Accept: application/json" \
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" \
 -H "app-version: 1.0.1" \
 -H "platform-type: Android" \
 -H "platform-version: 12" \
 -H "Content-Type: application/json" \
 -d '{"fName":"string","lName":"string","mName":"string","email":"string","birthDay":"string","gender":"male","document":"string","addressOfRegistration":"string"}' \

```

Повідомлення у лозі
```
<= Request 'Auth.testGetToken.v1' with requestID '53e55d10-027e-4ab0-967d-d34bd963f117' received from 'desktop-41bgid2-24356' node.
ACT IN: Auth.testGetToken.v1
Start receiving test token
Mongo: {"coll":"refreshtokens","method":"find","query":{"mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f"},"doc":{}}
Mongo: {"coll":"photoidauthrequests","method":"deleteOne","query":{"mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f"},"doc":{}}
Mongo: {"coll":"refreshtokens","method":"deleteMany","query":{"mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f"},"doc":{}}
Deleted photoIdAuthRequestModel by d85a2569-dbaf-4130-828f-8b5ddfd2512f
Removed refresh tokens by mobile uid: 1
Publish event: auth-user-log-out {"event":"auth-user-log-out","payload":{"mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f","userIdentifier":"76ea449e1e8ec84177dcd6f534d525b8108ca872e732997231b471fdd251a502e4f09dfc494d3822e03f9d060dea9b99fa278810395a577115687d9a284ae185"},"meta":{"date":"2024-03-31T09:31:42.964Z"}}
Mongo: {"coll":"customrefreshtokenexpirations","method":"findOne","query":{"platformType":"Android","appVersion":"1.0.1"},"doc":{}}
Mongo: {"coll":"refreshtokens","method":"insertOne","query":{"value":"b85d4be6-28d1-4a60-a4c3-6a80c9f0fa19","expirationTime":1717061502971,"sessionType":"User","eisTraceId":"43a7e738-8e66-41c7-ac3a-97f0a1504119","mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f","authEntryPoint":{"target":"Test","isBankId":false},"authEntryPointHistory":[{"authEntryPoint":{"target":"Test","isBankId":false},"date":"2024-03-31T09:31:42.971Z"}],"userIdentifier":"76ea449e1e8ec84177dcd6f534d525b8108ca872e732997231b471fdd251a502e4f09dfc494d3822e03f9d060dea9b99fa278810395a577115687d9a284ae185","platformType":"Android","platformVersion":"12","appVersion":"1.0.1","isDeleted":false,"lastActivityDate":"2024-03-31T09:31:42.971Z","_id":"66092d7e754d31d3f37c827c","createdAt":"2024-03-31T09:31:42.975Z","updatedAt":"2024-03-31T09:31:42.975Z","__v":0},"doc":{}}
Refresh token created
User data to encrypt
Invalid birth day format [string]
Publish event: auth-assign-user-to-push-token {"event":"auth-assign-user-to-push-token","payload":{"mobileUid":"d85a2569-dbaf-4130-828f-8b5ddfd2512f","userIdentifier":"76ea449e1e8ec84177dcd6f534d525b8108ca872e732997231b471fdd251a502e4f09dfc494d3822e03f9d060dea9b99fa278810395a577115687d9a284ae185"},"meta":{"date":"2024-03-31T09:31:43.024Z"}}
Mongo: {"coll":"refreshtokens","method":"find","query":{"userIdentifier":"76ea449e1e8ec84177dcd6f534d525b8108ca872e732997231b471fdd251a502e4f09dfc494d3822e03f9d060dea9b99fa278810395a577115687d9a284ae185","sessionType":"User","authEntryPoint":{"$exists":true},"authEntryPointHistory.authEntryPoint.target":{"$ne":"photoid"},"isLoadTestPeriod":{"$ne":true}},"doc":{}}
ACT IN RESULT: Auth.testGetToken.v1
```

```
{
  "token": "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJkYXRhIjoiZXlKbGJtTWlPaUpCTVRJNFEwSkRMVWhUTWpVMklpd2lZV3huSWpvaVVsTkJMVTlCUlZBaUxDSnJhV1FpT2lJMk1EZFNSbk5vY1V4NVJrNW9NV2hMUjE5M1JrZEtkbVptVlhsMWRWVnVSMDF5YW5FM1UxcDFhakJSSW4wLlB3MXhxX0E2V1RWOE9zRTJUREd0SVRob21qTkdYd2JPMDJPcjQ2ZkRXVjdkcXl4X0VvQXlvaXNiYnhiV3VObVdJemJhV1ozU2Zfcl9tM2lLeTBlZnhlQkJmRmpsdmxSeE41MGc2X2tuaE91S3NOYmFWY3Y4SU5kZmRpTVV1UTVfeHkyVklHdVdaVGFkTnZ3bHpLWGk4X0ZacHk4WnVqSGY4OE9zeFM5YkllYVpfTjlrcThnTHNuVjVDRWtsYWkxSkFTQzFFcHF1ZW4weExfQy1oRWtSVkRPdzFjd2RPYVhpbnMxNEQ1bTZjLXgxNi1JMDBpeTJMU1FDSm80MzZIQldaMktUQzZZQktzU25VTjJISldISlBTTmRlWFFTTFRVQkxpVjZpN2daa000ZlkwS3FsdnBDRXhScVloZVgyUUVubkx2cWlCMEhmdzlkRmZESE9aeWZCdy41RFlVWjBRRVBJUnRKbE5SbThhcXpRLjAxbm9vWENuWFpXS3NJUVM0Uk5FaE04LXVjV2Zwa3pKc3JibEhsd2EwRHNtQVVWSE16QkNmemtWdGJrbFNNZFhHQzNEcGVvTmF4NHlPRzZiMEw0Q053Y19OblpvdFlrbEs5c0Zkc0NCLWNKUl9CTXptN2lfUUJHQ19SOTBDZlhhM1RwS2RuWXprVUlKenlXVUdqd2ZWdmNTV2VYR2JURmRxNG9reEJHbjQwQlNubV80WVVta1BHblNwNk95aF80TlNpRFNNU01rR1lxa2RsSlhLbmtlTF9Qc1F3anZwcVg3MWt4c0J0MHJkMmFNQ0JqeFQzUXBDLVdRT05nVzdZQXJtOU5xS1k5TTQ3UUdsV2RlZ2lDcWtHQjFRZGgwOVNtbjVFMzgyQ09DZlB3NDJtQnZWcFAwLXNYclVLdkJ1Qk9tS0VVMHRwMmp5UERKQUhrSGlGbDYyeUxySk9rMUFxWk5KQ1lrWlpwTHZvTGc4N2RfWEE1YWw3eFRBQVdYOTlpaFBramNDLXkyU245MFhkWkdEMXJjYVY5NjFDM0pKX0Y2eXZoaG9WY0FEcGxRaVJtTTIxOUVXcTEtamNncjFjTC1tVUhhMXBJRmhoYkhPcXRiUmQ3R2ptWUJTMVUzU3AtRnRLbnlUX3FkeTZMRHJNeV9lVVpKbHlISy1kV21KV3JSRm41VjBoeEVnZDQtaFBOQzdJTlZwdlBLVi1PZmIzWEg0TnpMUE5uMDFMN1MxekNoRUNETDZpZ2NhVEJNdnlCUFdrUDFaaTVGVmUzNjNGeDlWRVhRblNLV0RMOFN0X3N5c1I1MVNmNk0yMFgwa1lINklfUlp6UTJ4LUJYenppR3c2QzhHc3pMbmlXdnNGR25qaXJ1VWpUM1A4bDlzalNnRk12Wkg5MzdpWHRISWFKczZCbE9Wc2I2ZEo2RUs5MVhjR3Q4QWdsaFBGU1diOXBjS0tuRTQyTExuZUVYdGg2Q3QxSW5lbUxJTkZzTExqMUlzQXFqNngtNExGd3dpdTltbEM5QWhseW5CbDFuNVBqWFlLNGlNZ3NsWlBYT2hFNXY4dGEzcFltamRvTXpjVEVsNzhRS2ltMU9XcFA0Q01kUFhTRHp6ZUNsWlMwY01DejZ1NzRIZk1Yal9PSGVlM0tTbTZYTmEycVk1bEhVLkZEQmZ5cVBXTGNXWkNfb2lCZ0pZclEiLCJpYXQiOjE3MTE4ODEzNDcsImV4cCI6MTcxMTg4ODU0N30.Vqnqw665NvKCIPhHk9jjId4vF0GDiZeaFAU_g0swwuRIPp9HNZu6mUtV-C3Br5kYQUyOqwEoCWeL8PozD2g6yl2A08RC2NVnGPU57KWwUH9kzOT6Otma79u0rXsc_UBpc5LgfGzp-bA8fvdcvfOD7DClCSkT8tEsqdkK4MXN7E5GafJHfxXmXfD7C6BwyCXiEKs1SuMfP9T18wQVfED0R3-hHME1X0CwLZ9eOTpY9tJxBy-nUoRDZcweqXMice4Y1FmL5WVgMkcuMIeFSBkVRfspo2sBOEAfNWWo4hrDI-A4XobXTqVclIhcXKIbKYzR1n7Zy1zM-88eO0D33loc9qv2MWDzusWQbnSY2fs3pzQg8Z_eGmHZsrqk7ke5o1anX4iQCazzTEUhNO9cj5Ok5e7eRl3pgfHXpeo6WSKnc_qkYZTxJIyuyY8YIcMPvwMSGXdlornN8AxDwK43fTawqgUZPPA4cC-RrvZ1c97hJEABhjfI9pPAYKuObw_QG6UF",
  "channelUuid": "95531e45a9acf8855e7f3d108a9756873346a39c15e4986a67b8c83f855d56bf8f74663e9f2ea78dff323d615ecba5dbf44aecd539745547e5fcabe85135c2ce"
}
```