[Список змінних](./env-vars-list) | [По модулям](./env-vars-list-by-module) | По зовнішнім системам

# Усі змінні сервісу

| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| ANDROID_MIN_APP_VERSION                  |                      | :white_check_mark:   | be-gateway-service |
| ANDROID_MIN_ERESIDENT_APP_VERSION        |                      | :white_check_mark:   | be-gateway-service |
| APP_PORT                                 |                      | :white_check_mark:   | be-gateway-service |
| APPLICATION_STORE_REVIEW_TEST_ITN        | :white_check_mark:   |                      | be-auth-service |
| ARCHIVE_DOCUMENTS_PER_ITERATION          |                      | :white_check_mark:   | be-documents-service |
| AUTH_ADMISSION_STEPS_TTL                 | :white_check_mark:   |                      | be-auth-service |
| AUTH_METHOD_DIIA_ID_AUTHORIZATION_ACQUIRER_TOKEN | :white_check_mark:   | :white_check_mark:   | be-auth-service |
| AUTH_METHOD_DIIA_ID_AUTHORIZATION_BRANCH_ID | :white_check_mark:   |                      | be-auth-service |
| AUTH_METHOD_DIIA_ID_AUTHORIZATION_OFFER_ID | :white_check_mark:   |                      | be-auth-service |
| AUTH_SCHEMA_AUTHORIZATION_TOKEN_PARAMS_CACHE_TTL | :white_check_mark:   |                      | be-auth-service |
| AUTH_SCHEMA_CABINET_AUTHORIZATION_NONCE_CACHE_TTL | :white_check_mark:   |                      | be-auth-service |
| AUTH_SCHEMA_CABINET_AUTHORIZATION_TOKEN_PARAMS_CACHE_TTL | :white_check_mark:   |                      | be-auth-service |
| AUTH_SCHEMA_COMPARING_ITN_IS_ENABLED     | :white_check_mark:   |                      | be-auth-service |
| AUTH_SCHEMA_ERESIDENT_AUTH_TOKEN_PARAMS_CACHE_TTL | :white_check_mark:   |                      | be-auth-service |
| AUTH_SCHEMA_ERESIDENT_FIRST_AUTH_TOKEN_PARAMS_CACHE_TTL | :white_check_mark:   |                      | be-auth-service |
| AUTH_SCHEMA_IS_CUSTOM_REFRESH_TOKEN_EXPIRATION_ENABLED |                      | :white_check_mark:   | be-auth-service |
| BALANCING_STRATEGY_NAME                  | :white_check_mark:   |                      | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| BALANCING_STRATEGY_OPTIONS               | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| CHECKING_FOR_VALID_ITN_IS_ENABLED        | :white_check_mark:   |                      | be-auth-service |
| CONTEXT_TRACKING_ENABLED                 | :white_check_mark:   |                      | be-diia-app |
| CONTEXT_TRACKING_TIMEOUT                 | :white_check_mark:   |                      | be-diia-app |
| CREATE_NOTIFICATIONS_BATCHES_TASK_NOTIFICATIONS_BATCH_SIZE | :white_check_mark:   | :white_check_mark:   | be-user-service |
| CRIMINAL_RECORD_CERTIFICATE_APPLICATION_CHECK_BATCH_SIZE |                      | :white_check_mark:   | be-criminal-cert-service |
| CRIMINAL_RECORD_CERTIFICATE_APPLICATION_CHECK_INTERVAL_MS |                      | :white_check_mark:   | be-criminal-cert-service |
| CRIMINAL_RECORD_CERTIFICATE_APPLICATION_EXPIRATION_DAYS |                      | :white_check_mark:   | be-criminal-cert-service |
| DEBUG                                    | :white_check_mark:   |                      | be-scaffold |
| DEFAULT_DOCUMENTS_EXPIRATION_TIME        |                      | :white_check_mark:   | be-documents-service |
| DMS_IS_ENABLED                           |                      | :white_check_mark:   | be-documents-service |
| EXTERNAL_BUS_TIMEOUT                     | :white_check_mark:   |                      | be-auth-service |
| FACE_RECO_FEATURE_POINTS_LENGTH          | :white_check_mark:   | :white_check_mark:   | be-user-service |
| FAQ_ERESIDENT_FILE_PATH                  |                      | :white_check_mark:   | be-gateway-service |
| FAQ_EXPIRATION_TIME_IN_SEC               |                      | :white_check_mark:   | be-gateway-service |
| FAQ_FILE_PATH                            | :white_check_mark:   |                      | be-gateway-service |
| GRPC_ADDRESS_SERVICE_ADDRESS             |                      | :white_check_mark:   | be-criminal-cert-service |
| GRPC_ANALYTICS_SERVICE_ADDRESS           |                      | :white_check_mark:   | be-criminal-cert-service |
| GRPC_AUTH_SERVICE_ADDRESS                |                      | :white_check_mark:   | be-user-service |
| GRPC_CLIENT_ENABLED                      |                      | :white_check_mark:   | be-documents-service |
| GRPC_CRYPTO_DOC_SERVICE_ADDRESS          |                      | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-user-service |
| GRPC_CRYPTO_SERVICE_ADDRESS              |                      | :white_check_mark:   | be-criminal-cert-service |
| GRPC_DOCUMENT_DELIVERY_SERVICE_ADDRESS   |                      | :white_check_mark:   | be-criminal-cert-service |
| GRPC_DOCUMENTS_SERVICE_ADDRESS           |                      | :white_check_mark:   | be-criminal-cert-service |
| GRPC_GOV_GATEWAY                         |                      | :white_check_mark:   | be-documents-service |
| GRPC_NOTIFICATION_SERVICE_ADDRESS        |                      | :white_check_mark:   | be-criminal-cert-service, <br>be-user-service |
| GRPC_PUBLIC_SERVICE_ADDRESS              |                      | :white_check_mark:   | be-criminal-cert-service |
| GRPC_PUBLIC_SERVICE_CATALOG_ADDRESS      |                      | :white_check_mark:   | be-criminal-cert-service |
| GRPC_SERVER_ENABLED                      |                      | :white_check_mark:   | be-diia-app |
| GRPC_SERVER_PORT                         |                      | :white_check_mark:   | be-diia-app |
| GRPC_USER_SERVICE_ADDRESS                |                      | :white_check_mark:   | be-criminal-cert-service, <br>be-public-service-catalog |
| HASH_BYTES                               | :white_check_mark:   | :white_check_mark:   | be-documents-service, <br>be-user-service |
| HEALTH_CHECK_IS_ENABLED                  | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| HEALTH_CHECK_IS_PORT                     | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| HSC_IS_ENABLED                           |                      | :white_check_mark:   | be-documents-service |
| HSC_RETURN_EXPIRED                       |                      | :white_check_mark:   | be-documents-service |
| HTTP_BODY_LIMIT                          | :white_check_mark:   |                      | be-gateway-service |
| INTEGRATION_TIMEOUT_IN_MSEC              | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-user-service |
| IOS_MIN_APP_VERSION                      |                      | :white_check_mark:   | be-gateway-service |
| IOS_MIN_ERESIDENT_APP_VERSION            |                      | :white_check_mark:   | be-gateway-service |
| IS_DOCUMENTS_EXPIRATION_ENABLED          |                      | :white_check_mark:   | be-documents-service |
| JOIN_USER_TO_PETITIONS_IS_ENABLED        | :white_check_mark:   |                      | be-auth-service |
| JWE_SECRET_DATA_JWK                      | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| JWE_SECRET_TOKEN_PRIVATE_KEY             | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| JWE_SECRET_TOKEN_PUBLIC_KEY              | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| JWT_ACQUIRER_REFRESH_EXPIRES_IN          | :white_check_mark:   |                      | be-auth-service |
| JWT_CABINET_EXPIRES_IN                   | :white_check_mark:   |                      | be-auth-service |
| JWT_CABINET_REFRESH_EXPIRES_IN           | :white_check_mark:   |                      | be-auth-service |
| JWT_EXPIRES_IN                           | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| JWT_PARTNER_REFRESH_EXPIRES_IN           | :white_check_mark:   |                      | be-auth-service |
| JWT_REFRESH_EXPIRES_IN                   | :white_check_mark:   |                      | be-auth-service |
| LOG_LEVEL                                | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-diia-app, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| METRICS_CUSTOM_DEFAULT_LABELS            |                      | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| METRICS_CUSTOM_DISABLE_DEFAULT_METRICS   |                      | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| METRICS_CUSTOM_DISABLED                  |                      | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| METRICS_CUSTOM_MOLECULER_DISABLED        |                      | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| METRICS_CUSTOM_MOLECULER_PATH            |                      | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| METRICS_CUSTOM_MOLECULER_PORT            |                      | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| METRICS_CUSTOM_PORT                      |                      | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| METRICS_MOLECULER_PROMETHEUS_IS_ENABLED  |                      | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| METRICS_MOLECULER_PROMETHEUS_PATH        |                      | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| METRICS_MOLECULER_PROMETHEUS_PORT        |                      | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| MOCK_USER_IDENTIFIERS                    |                      | :white_check_mark:   | be-documents-service |
| name                                     | :white_check_mark:   |                      | be-pkg-env |
| NFC_AUTH_URL_HOST                        |                      | :white_check_mark:   | be-auth-service |
| NFC_PHONETIC_EQUALITY_TRASHOLD           | :white_check_mark:   | :white_check_mark:   | be-auth-service |
| NODE_ENV                                 | :white_check_mark:   |                      | be-diia-app, <br>be-gateway-service, <br>be-pkg-env |
| NOTIFICATION_IS_ENABLED                  |                      | :white_check_mark:   | be-user-service |
| NOTIFICATION_TARGET_BATCH_SIZE           | :white_check_mark:   | :white_check_mark:   | be-user-service |
| OPENID_ENABLE_DOCUMENTS_CHECK            |                      | :white_check_mark:   | be-auth-service |
| OTP_EXPIRATION                           | :white_check_mark:   | :white_check_mark:   | be-user-service |
| OTP_PER_DAY                              | :white_check_mark:   | :white_check_mark:   | be-user-service |
| OTP_VERIFY_ATTEMPTS                      | :white_check_mark:   | :white_check_mark:   | be-user-service |
| PHOTO_ID_AUTH_REQUEST_EXPIRATION_TIME_MS | :white_check_mark:   |                      | be-auth-service |
| PHOTO_ID_AUTH_URL_HOST                   |                      | :white_check_mark:   | be-auth-service |
| PROCESS_CODES_TEMPLATES_CABINET_FOLDER_PATH |                      | :white_check_mark:   | be-gateway-service |
| PROCESS_CODES_TEMPLATES_ERESIDENT_FOLDER_PATH |                      | :white_check_mark:   | be-gateway-service |
| PROCESS_CODES_TEMPLATES_FOLDER_PATH      |                      | :white_check_mark:   | be-gateway-service |
| PROFILE_FEATURES_ENABLED                 |                      | :white_check_mark:   | be-user-service |
| PROXY_PATH                               |                      | :white_check_mark:   | be-gateway-service |
| PUBLIC_SERVICES_STANDALONE_PUBLIC_SERVICE_CATALOG_IS_ENABLED | :white_check_mark:   |                      | be-gateway-service |
| REDIS_READ_ONLY_OPTIONS                  |                      | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| REDIS_READ_WRITE_OPTIONS                 |                      | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| REFRESH_TOKEN_EXPIRATIONS_ARCHIVE_THRESHOLD_MS | :white_check_mark:   |                      | be-auth-service |
| RETURN_ITN_DATA_IS_ENABLED               |                      | :white_check_mark:   | be-documents-service |
| SALT                                     | :white_check_mark:   |                      | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| STORE_READ_ONLY_OPTIONS                  |                      | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| STORE_READ_WRITE_OPTIONS                 |                      | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| SUBSCRIPTION_DEBTS_SALT                  | :white_check_mark:   |                      | be-user-service |
| SWAGGER_IS_ENABLED                       | :white_check_mark:   |                      | be-gateway-service |
| SWAGGER_PATH                             | :white_check_mark:   |                      | be-gateway-service |
| TAXPAYER_CARD_EXPIRATION_ON_CONFIRMING_SEC |                      | :white_check_mark:   | be-documents-service |
| TAXPAYER_CARD_EXPIRATION_ON_NOT_CONFIRMED_SEC |                      | :white_check_mark:   | be-documents-service |
| TAXPAYER_CARD_EXPIRATION_ON_SUCCESS_SEC  |                      | :white_check_mark:   | be-documents-service |
| TEMPORARY_JWT_AUDIENCE                   | :white_check_mark:   |                      | be-auth-service |
| TEMPORARY_JWT_EXPIRES_IN                 | :white_check_mark:   |                      | be-auth-service |
| TEMPORARY_JWT_ISSUER                     | :white_check_mark:   |                      | be-auth-service |
| TEST_AUTH_BY_ITN_IS_ENABLED              | :white_check_mark:   |                      | be-auth-service |
| TOKEN_CACHE_DURATION_IN_SEC              | :white_check_mark:   |                      | be-auth-service |
| TRACING_DEBUG_ENABLED                    | :white_check_mark:   |                      | be-diia-app |
| TRACING_ENABLED                          | :white_check_mark:   |                      | be-diia-app |
| TRACING_EXPORTER_URL                     | :white_check_mark:   |                      | be-diia-app |
| TRANSPORT_OPTIONS                        | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| TRANSPORT_TYPE                           |                      | :white_check_mark:   | be-auth-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| USER_ACTIVITY_IN_ENABLED                 |                      | :white_check_mark:   | be-gateway-service |
| USER_ACTIVITY_TTL                        |                      | :white_check_mark:   | be-gateway-service |

# Усі змінні сервісу BANK_ID
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| BANK_ID_ACCESS_CLIENT_ID                 |                      | :white_check_mark:   | be-auth-service |
| BANK_ID_ACCESS_CLIENT_SECRET             |                      | :white_check_mark:   | be-auth-service |
| BANK_ID_API_HOST                         |                      | :white_check_mark:   | be-auth-service |
| BANK_ID_API_URL_AUTH_PATH                |                      | :white_check_mark:   | be-auth-service |
| BANK_ID_API_URL_TOKEN_PATH               |                      | :white_check_mark:   | be-auth-service |
| BANK_ID_API_URL_USER_PATH                |                      | :white_check_mark:   | be-auth-service |
| BANK_ID_DATASET                          |                      | :white_check_mark:   | be-auth-service |
| BANK_ID_IS_ENABLED                       |                      | :white_check_mark:   | be-auth-service |
| BANK_ID_VERIFY_HTTPS                     | :white_check_mark:   | :white_check_mark:   | be-auth-service |
| BANK_ID_VERIFY_MEMBER_ID                 | :white_check_mark:   | :white_check_mark:   | be-auth-service |
| BANK_ID_VERSION                          |                      | :white_check_mark:   | be-auth-service |
| GRPC_BANK_ID_CRYPTO_SERVICE_ADDRESS      |                      | :white_check_mark:   | be-auth-service |

# Усі змінні сервісу EIS
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| EIS_ADDRESS_IN_STRUCTURE                 |                      | :white_check_mark:   | be-documents-service |
| EIS_AGREE_URL                            | :white_check_mark:   |                      | be-auth-service |
| EIS_API_HOST                             | :white_check_mark:   |                      | be-auth-service |
| EIS_API_PORT                             | :white_check_mark:   |                      | be-auth-service |
| EIS_AUTH_PASSWORD                        | :white_check_mark:   |                      | be-auth-service |
| EIS_AUTH_USERNAME                        | :white_check_mark:   |                      | be-auth-service |
| EIS_IS_ENABLED                           | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-documents-service |
| EIS_RETURN_EXPIRED                       |                      | :white_check_mark:   | be-documents-service |

# Усі змінні сервісу ENEMY_TRACK
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| ENEMY_TRACK_TELEGRAM_BOT_AUTH_ID         |                      | :white_check_mark:   | be-auth-service |
| ENEMY_TRACK_TELEGRAM_BOT_HOST            |                      | :white_check_mark:   | be-auth-service |

# Усі змінні сервісу ERESIDENT
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| ERESIDENT_APPLICANT_EMAIL_OTP_TTL_IN_SEC | :white_check_mark:   |                      | be-auth-service |
| ERESIDENT_APPLICANT_OTP_LENGTH           | :white_check_mark:   |                      | be-auth-service |
| ERESIDENT_APPLICANT_TEST_EMAIL_REGEXP    | :white_check_mark:   |                      | be-auth-service |
| ERESIDENT_APPLICANT_TEST_OTP             | :white_check_mark:   |                      | be-auth-service |
| ERESIDENT_REGISTRY_IS_ENABLED            | :white_check_mark:   |                      | be-auth-service |

# Усі змінні сервісу EXTERNAL_RABBIT
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| EXTERNAL_RABBIT_ASSERT_EXCHANGES         | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| EXTERNAL_RABBIT_CUSTOM_RESPONSE_ROUTING_KEY_PREFIX | :white_check_mark:   |                      | be-user-service |
| EXTERNAL_RABBIT_HEARTBEAT                | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| EXTERNAL_RABBIT_HOST                     | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| EXTERNAL_RABBIT_PASSWORD                 | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| EXTERNAL_RABBIT_PORT                     | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| EXTERNAL_RABBIT_QUEUE_PREFETCH_COUNT     | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| EXTERNAL_RABBIT_RESPONSE_ROUTING_KEY_PREFIX | :white_check_mark:   |                      | be-criminal-cert-service, <br>be-documents-service |
| EXTERNAL_RABBIT_USERNAME                 | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |

# Усі змінні сервісу MINIO
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| MINIO_ACCESS_KEY                         | :white_check_mark:   |                      | be-gateway-service |
| MINIO_HOST                               | :white_check_mark:   |                      | be-gateway-service |
| MINIO_IS_ENABLED                         | :white_check_mark:   |                      | be-gateway-service |
| MINIO_PORT                               |                      | :white_check_mark:   | be-gateway-service |
| MINIO_SECRET_KEY                         | :white_check_mark:   |                      | be-gateway-service |

# Усі змінні сервісу MONGO
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| MONGO_AUTH_SOURCE                        | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-pkg-db, <br>be-public-service-catalog, <br>be-user-service |
| MONGO_CACHE_AUTH_SOURCE                  | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| MONGO_CACHE_DATABASE                     | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| MONGO_CACHE_HOSTS                        | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-gateway-service |
| MONGO_CACHE_IS_ENABLED                   | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| MONGO_CACHE_PASSWORD                     | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| MONGO_CACHE_PORT                         | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-gateway-service |
| MONGO_CACHE_READ_PREFERENCE              | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| MONGO_CACHE_REPLICA_SET                  | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| MONGO_CACHE_USER                         | :white_check_mark:   |                      | be-auth-service, <br>be-gateway-service |
| MONGO_DATABASE                           | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-pkg-db, <br>be-public-service-catalog, <br>be-user-service |
| MONGO_HOST                               | :white_check_mark:   |                      | be-pkg-db |
| MONGO_HOSTS                              | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| MONGO_INDEXES_EXIT_AFTER_SYNC            | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| MONGO_INDEXES_SYNC                       | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| MONGO_PASSWORD                           | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-pkg-db, <br>be-public-service-catalog, <br>be-user-service |
| MONGO_PORT                               | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-pkg-db, <br>be-public-service-catalog, <br>be-user-service |
| MONGO_READ_PREFERENCE                    | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-public-service-catalog, <br>be-user-service |
| MONGO_REPLICA_SET                        | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-pkg-db, <br>be-public-service-catalog, <br>be-user-service |
| MONGO_USER                               | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-pkg-db, <br>be-public-service-catalog, <br>be-user-service |

# Усі змінні сервісу MONOBANK
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| AUTH_MONOBANK_API_TOKEN                  |                      | :white_check_mark:   | be-auth-service |
| AUTH_MONOBANK_BASE_URL                   | :white_check_mark:   |                      | be-auth-service |
| AUTH_MONOBANK_IS_ENABLED                 | :white_check_mark:   |                      | be-auth-service |
| AUTH_MONOBANK_PRIVATE_KEY_PATH           |                      | :white_check_mark:   | be-auth-service |

# Усі змінні сервісу PRIVATBANK
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| AUTH_PRIVATBANK_ACCOUNT                  |                      | :white_check_mark:   | be-auth-service |
| AUTH_PRIVATBANK_ACCOUNT_SECRET           |                      | :white_check_mark:   | be-auth-service |
| AUTH_PRIVATBANK_BASE_URL                 |                      | :white_check_mark:   | be-auth-service |

# Усі змінні сервісу RABBIT
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| RABBIT_HEARTBEAT                         | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| RABBIT_HOST                              | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| RABBIT_PASSWORD                          | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| RABBIT_PORT                              | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| RABBIT_QUEUE_PREFETCH_COUNT              | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |
| RABBIT_USERNAME                          | :white_check_mark:   |                      | be-auth-service, <br>be-criminal-cert-service, <br>be-documents-service, <br>be-gateway-service, <br>be-user-service |

# Усі змінні сервісу SEVDEIR
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| SEVDEIR_IS_ENABLED                       |                      | :white_check_mark:   | be-criminal-cert-service |

# Усі змінні сервісу STRAPI
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| STRAPI_API_HOST                          | :white_check_mark:   |                      | be-gateway-service |
| STRAPI_API_PORT                          |                      | :white_check_mark:   | be-gateway-service |
| STRAPI_API_TOKEN                         | :white_check_mark:   |                      | be-gateway-service |
| STRAPI_IS_ENABLED                        | :white_check_mark:   |                      | be-gateway-service |

# Усі змінні сервісу UBCH
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| UBCH_AUTH_PATH                           |                      | :white_check_mark:   | be-user-service |
| UBCH_HOST                                |                      | :white_check_mark:   | be-user-service |
| UBCH_IS_ENABLED                          |                      | :white_check_mark:   | be-user-service |
| UBCH_LOGIN                               |                      | :white_check_mark:   | be-user-service |
| UBCH_PASSWORD                            |                      | :white_check_mark:   | be-user-service |
| UBCH_STATIC_SESS_ID                      |                      | :white_check_mark:   | be-user-service |
| UBCH_SUBSCRIBE_PATH                      |                      | :white_check_mark:   | be-user-service |
| UBCH_UNSUBSCRIBE_PATH                    |                      | :white_check_mark:   | be-user-service |

# Усі змінні сервісу ZIPKIN
| Змінна | Оточення | Сервіс | Модулі |
| ------ | -------- | ------ | ---- |
| ZIPKIN_IS_ENABLED                        | :white_check_mark:   | :white_check_mark:   | be-auth-service, <br>be-gateway-service |
| ZIPKIN_SEND_INTERVAL_SEC                 |                      | :white_check_mark:   | be-auth-service, <br>be-gateway-service |
| ZIPKIN_URL                               |                      | :white_check_mark:   | be-auth-service, <br>be-gateway-service |