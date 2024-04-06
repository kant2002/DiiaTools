Документи
=========

Виклик із мобільної апки на отримання документів на стрічнці Документи
```
curl -X GET "$domain/api/v6/documents?filter%5B0%5D=driver-license&filter%5B1%5D=taxpayer-card" `
 -H "Authorization: Bearer $token" `
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" `
 -H "app-version: 4.3.0.1433" `
 -H "platform-type: Android" `
 -H "platform-version: 12"
```

Виклик для отримання водійськіх посвідчень
```
curl -X GET "$domain/api/v6/documents?filter%5B0%5D=driver-license" `
 -H "Authorization: Bearer $token" `
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" `
 -H "app-version: 4.3.0.1433" `
 -H "platform-type: Android" `
 -H "platform-version: 12"
```

Виклик для отримання податкової картки
```
curl -X GET "$domain/api/v6/documents?filter%5B0%5D=taxpayer-card" `
 -H "Authorization: Bearer $token" `
 -H "mobile_uid: d85a2569-dbaf-4130-828f-8b5ddfd2512f" `
 -H "app-version: 4.3.0.1433" `
 -H "platform-type: Android" `
 -H "platform-version: 12"
```