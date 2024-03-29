Бази даних
==========

Список баз даних

- [diia-auth-service](#diia-auth-service)
- [diia-criminal-cert-service](#diia-criminal-cert-service)
- [diia-documents-service](#diia-documents-service)
- [diia-gateway](#diia-gateway)
- [diia-user-service](#diia-user-service)

### diia-public-service-catalog-service

Список таблиць
```
diia-public-service-catalog-service> show tables;
migrations
publicservicecategories
publicservices
```

Тестові дані
```
diia-public-service-catalog-service> db.publicservicecategories.find().toArray()
[
  {
    _id: ObjectId('66058050bcca83424452c3d3'),
    category: 'certificates',
    name: 'Довідки та витяги',
    icon: '📋',
    status: 'active',
    sortOrder: 1600,
    tabCodes: [ 'citizen' ]
  }
]
diia-public-service-catalog-service> db.publicservices.find().toArray()
[
  {
    _id: ObjectId('66058050bcca83424452c3d1'),
    code: 'criminalRecordCertificate',
    name: 'Довідка про несудимість',
    status: 'active',
    sortOrder: 1630,
    categories: [ 'certificates' ],
    contextMenu: [
      {
        type: 'faqCategory',
        code: 'criminalRecordCertificate',
        name: 'Питання та відповіді'
      },
      { type: 'supportServiceScreen', name: 'Служба підтримки' },
      {
        type: 'rating',
        name: 'Оцінити послугу',
        appVersions: {
          minVersion: { iOS: '3.0.0', Android: '3.0.0', Huawei: '3.0.00' }
        }
      }
    ],
    sessionTypes: [ 'User' ],
    appVersions: {
      User: {
        minVersion: { iOS: '3.0.30', Android: '3.0.30', Huawei: '3.0.30' }
      }
    }
  }
]
```

### diia-auth-service

Список таблиць

```
diia-auth-service> show tables;
attestations
authschemas
customrefreshtokenexpirations
encryptedstorages
fakebankloginsettings
googleintegritychecks
huaweiintegritychecks
migrations
photoidauthrequests
refreshtokens
userauthsteps
```

Тестові дані
```
diia-auth-service> db.authschemas.find().toArray()
[
  {
    _id: ObjectId('6605861da229e329eb8b2f61'),
    code: 'authorization',
    methods: [ 'bankid', 'monobank', 'privatbank', 'nfc' ],
    bankid: {
      maxAttempts: 3,
      ttl: 180000,
      methods: null,
      photoid: { maxAttempts: 3, ttl: 180000, condition: 'hasDocumentPhoto' },
      maxVerifyAttempts: 1
    },
    monobank: {
      maxAttempts: 3,
      ttl: 180000,
      methods: null,
      photoid: { maxAttempts: 3, ttl: 180000, condition: 'hasDocumentPhoto' },
      maxVerifyAttempts: 1
    },
    privatbank: {
      maxAttempts: 3,
      ttl: 180000,
      methods: null,
      photoid: { maxAttempts: 3, ttl: 180000, condition: 'hasDocumentPhoto' },
      maxVerifyAttempts: 1
    },
    nfc: {
      maxAttempts: 3,
      ttl: 180000,
      methods: null,
      maxVerifyAttempts: 1
    },
    faceLivenessDetectionConfig: {
      Android: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      Huawei: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'Не знайдено обличчя у кадрі',
              face_recognition_multiple_persons: 'Знайдено більше одного обличчя у кадрі',
              face_recognition_small_face: 'Піднесіть телефон ближче до обличчя',
              face_recognition_not_centered: 'Наведіть рамку на обличчя',
              face_recognition_incorrect_angle: 'Подивіться прямо у камеру',
              face_recognition_check_brightness: 'Перевірте освітлення',
              face_recognition_incorrect_depth: 'Залишайтесь у рамці. Ми перевіряємо, що це ви',
              face_recognition_blink_action: 'Кліпніть'
            }
          }
        }
      ],
      Browser: null
    },
    title: 'Щоб авторизуватися у застосунку, будь ласка, підтвердьте особу користувача.'
  },
  {
    _id: ObjectId('6605861da229e329eb8b2f65'),
    code: 'diia-id-creation',
    checks: [ 19101024, 19101003, 19101028 ],
    methods: [ 'photoid' ],
    bankid: {
      maxAttempts: 3,
      ttl: 180000,
      methods: [ 'nfc' ],
      nfc: { maxAttempts: 3, ttl: 180000 }
    },
    monobank: {
      maxAttempts: 3,
      ttl: 180000,
      methods: [ 'nfc' ],
      nfc: { maxAttempts: 3, ttl: 180000 }
    },
    privatbank: {
      maxAttempts: 3,
      ttl: 180000,
      methods: [ 'nfc' ],
      nfc: { maxAttempts: 3, ttl: 180000 }
    },
    faceLivenessDetectionConfig: {
      Android: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      Huawei: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'Не знайдено обличчя у кадрі',
              face_recognition_multiple_persons: 'Знайдено більше одного обличчя у кадрі',
              face_recognition_small_face: 'Піднесіть телефон ближче до обличчя',
              face_recognition_not_centered: 'Наведіть рамку на обличчя',
              face_recognition_incorrect_angle: 'Подивіться прямо у камеру',
              face_recognition_check_brightness: 'Перевірте освітлення',
              face_recognition_incorrect_depth: 'Залишайтесь у рамці. Ми перевіряємо, що це ви',
              face_recognition_blink_action: 'Кліпніть'
            }
          }
        }
      ],
      Browser: null
    },
    title: 'Будь ласка, підтвердьте особу користувача через фото-ідентифікацію.',
    photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    admitAfter: [
      { code: 'diia-id-signing', admitAfterStatus: 'success' },
      {
        code: 'diia-id-sharing-deeplink-dynamic',
        admitAfterStatus: 'success'
      },
      {
        code: 'diia-id-sharing-deeplink-static',
        admitAfterStatus: 'success'
      }
    ]
  },
  {
    _id: ObjectId('6605861da229e329eb8b2f69'),
    code: 'diia-id-signing',
    admitAfter: [ { code: 'diia-id-creation' } ],
    methods: [ 'photoid' ],
    photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    faceLivenessDetectionConfig: {
      Android: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      Huawei: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'Не знайдено обличчя у кадрі',
              face_recognition_multiple_persons: 'Знайдено більше одного обличчя у кадрі',
              face_recognition_small_face: 'Піднесіть телефон ближче до обличчя',
              face_recognition_not_centered: 'Наведіть рамку на обличчя',
              face_recognition_incorrect_angle: 'Подивіться прямо у камеру',
              face_recognition_check_brightness: 'Перевірте освітлення',
              face_recognition_incorrect_depth: 'Залишайтесь у рамці. Ми перевіряємо, що це ви',
              face_recognition_blink_action: 'Кліпніть'
            }
          }
        }
      ],
      Browser: null
    },
    title: 'Будь ласка, підтвердьте особу користувача через перевірку за фото'
  },
  {
    _id: ObjectId('6605861da229e329eb8b2f6d'),
    code: 'prolong',
    title: 'Підтвердіть свою особу',
    description: 'Ми збережемо додані документи та подовжимо вашу сесію',
    methods: [ 'bankid', 'monobank', 'privatbank', 'nfc' ],
    bankid: {
      maxAttempts: 3,
      ttl: 180000,
      methods: [ 'photoid' ],
      photoid: {
        maxAttempts: 3,
        ttl: 180000,
        condition: 'hasDocumentPhoto',
        maxVerifyAttempts: 1
      },
      maxVerifyAttempts: 1
    },
    monobank: {
      maxAttempts: 3,
      ttl: 180000,
      methods: [ 'photoid' ],
      photoid: {
        maxAttempts: 3,
        ttl: 180000,
        condition: 'hasDocumentPhoto',
        maxVerifyAttempts: 1
      },
      maxVerifyAttempts: 1
    },
    privatbank: {
      maxAttempts: 3,
      ttl: 180000,
      methods: [ 'photoid' ],
      photoid: {
        maxAttempts: 3,
        ttl: 180000,
        condition: 'hasDocumentPhoto',
        maxVerifyAttempts: 1
      },
      maxVerifyAttempts: 1
    },
    nfc: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    faceLivenessDetectionConfig: {
      Android: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      Huawei: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'Не знайдено обличчя у кадрі',
              face_recognition_multiple_persons: 'Знайдено більше одного обличчя у кадрі',
              face_recognition_small_face: 'Піднесіть телефон ближче до обличчя',
              face_recognition_not_centered: 'Наведіть рамку на обличчя',
              face_recognition_incorrect_angle: 'Подивіться прямо у камеру',
              face_recognition_check_brightness: 'Перевірте освітлення',
              face_recognition_incorrect_depth: 'Залишайтесь у рамці. Ми перевіряємо, що це ви',
              face_recognition_blink_action: 'Кліпніть'
            }
          }
        }
      ],
      Browser: null
    }
  },
  {
    _id: ObjectId('6605861da229e329eb8b2f73'),
    code: 'diia-id-sharing-deeplink-dynamic',
    title: 'Підтвердіть свою особу',
    admitAfter: [ { code: 'diia-id-creation' }, { code: 'prolong' } ],
    methods: [ 'photoid' ],
    photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    faceLivenessDetectionConfig: {
      Android: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      Huawei: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'Не знайдено обличчя у кадрі',
              face_recognition_multiple_persons: 'Знайдено більше одного обличчя у кадрі',
              face_recognition_small_face: 'Піднесіть телефон ближче до обличчя',
              face_recognition_not_centered: 'Наведіть рамку на обличчя',
              face_recognition_incorrect_angle: 'Подивіться прямо у камеру',
              face_recognition_check_brightness: 'Перевірте освітлення',
              face_recognition_incorrect_depth: 'Залишайтесь у рамці. Ми перевіряємо, що це ви',
              face_recognition_blink_action: 'Кліпніть'
            }
          }
        }
      ],
      Browser: null
    }
  },
  {
    _id: ObjectId('6605861da229e329eb8b2f75'),
    code: 'diia-id-sharing-deeplink-static',
    title: 'Підтвердіть свою особу',
    admitAfter: [ { code: 'diia-id-creation' }, { code: 'prolong' } ],
    methods: [ 'photoid' ],
    photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    faceLivenessDetectionConfig: {
      Android: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      Huawei: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'Не знайдено обличчя у кадрі',
              face_recognition_multiple_persons: 'Знайдено більше одного обличчя у кадрі',
              face_recognition_small_face: 'Піднесіть телефон ближче до обличчя',
              face_recognition_not_centered: 'Наведіть рамку на обличчя',
              face_recognition_incorrect_angle: 'Подивіться прямо у камеру',
              face_recognition_check_brightness: 'Перевірте освітлення',
              face_recognition_incorrect_depth: 'Залишайтесь у рамці. Ми перевіряємо, що це ви',
              face_recognition_blink_action: 'Кліпніть'
            }
          }
        }
      ],
      Browser: null
    }
  },
  {
    _id: ObjectId('6605861da229e329eb8b2f77'),
    code: 'diia-id-sharing-barcode',
    title: 'Підтвердіть свою особу',
    methods: [],
    faceLivenessDetectionConfig: {
      Android: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      Huawei: [
        {
          version: '1.0',
          maxAppVersion: '3.0.16',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4
          }
        },
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: '<b>Кліпніть</b> декілька разів',
              face_recognition_message_smile: 'Посміхніться',
              face_recognition_message_look_forward: 'Подивіться в камеру',
              face_recognition_message_face_forward: 'Тримайте обличчя рівно',
              face_recognition_message_loading: 'Завантаження…',
              face_recognition_message_not_enough_light: 'Недостатньо світла',
              face_recognition_message_too_much_light: 'Обличчя засвічене',
              face_recognition_message_take_phone_aligned_to_head: 'Тримайте телефон вертикально на рівні очей',
              face_recognition_message_looks_like_cheater: 'Не вдалося вас розпізнати',
              face_recognition_message_more_than_one_face_in_frame: 'Більше однієї людини в кадрі',
              face_recognition_message_look_strait_to_camera: 'Дивіться прямо в камеру',
              face_recognition_message_checking_you_are_real_person: 'Перевірка…',
              face_recognition_message_complete: 'Ви впорались!',
              face_recognition_need_face_closer: 'Наблизьте камеру до обличчя',
              face_recognition_face_too_close: 'Занадто близько',
              face_recognition_adjust_face: 'Наведіть рамку на обличчя'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'Не знайдено обличчя у кадрі',
              face_recognition_multiple_persons: 'Знайдено більше одного обличчя у кадрі',
              face_recognition_small_face: 'Піднесіть телефон ближче до обличчя',
              face_recognition_not_centered: 'Наведіть рамку на обличчя',
              face_recognition_incorrect_angle: 'Подивіться прямо у камеру',
              face_recognition_check_brightness: 'Перевірте освітлення',
              face_recognition_incorrect_depth: 'Залишайтесь у рамці. Ми перевіряємо, що це ви',
              face_recognition_blink_action: 'Кліпніть'
            }
          }
        }
      ],
      Browser: null
    }
  },
  {
    _id: ObjectId('6605861da229e329eb8b2f79'),
    code: 'e-resident-first-auth',
    title: 'Please scan the QR-code',
    methods: [ 'e-resident-qr-code' ],
    'e-resident-qr-code': {
      maxAttempts: 3,
      ttl: 180000,
      methods: [ 'photoid' ],
      photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
      maxVerifyAttempts: 1
    },
    faceLivenessDetectionConfig: {
      Huawei: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      Android: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        }
      ],
      Browser: null
    }
  },
  {
    _id: ObjectId('6605861ea229e329eb8b2f7d'),
    code: 'e-resident-auth',
    title: 'To log in your account verify your identity',
    methods: [ 'e-resident-mrz' ],
    'e-resident-mrz': {
      maxAttempts: 3,
      ttl: 180000,
      methods: [ 'photoid' ],
      photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
      maxVerifyAttempts: 1
    },
    faceLivenessDetectionConfig: {
      Huawei: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      Android: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        }
      ],
      Browser: null
    }
  },
  {
    _id: ObjectId('6605861ea229e329eb8b2f7f'),
    code: 'cabinet-authorization',
    methods: [ 'qes', 'ds', 'bankid' ],
    qes: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    ds: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    bankid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 }
  },
  {
    _id: ObjectId('6605861ea229e329eb8b2f81'),
    code: 'e-resident-diia-id-creation',
    title: 'Please authorize via photo identification',
    methods: [ 'photoid' ],
    photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    faceLivenessDetectionConfig: {
      Huawei: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      Android: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        }
      ],
      Browser: null
    },
    checks: [ 19101028, 10411031, 10411030 ]
  },
  {
    _id: ObjectId('6605861ea229e329eb8b2f88'),
    code: 'residence-permit-nfc-adding',
    methods: [ 'nfc' ],
    nfc: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    faceLivenessDetectionConfig: {
      Huawei: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      Android: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        }
      ],
      Browser: null
    }
  },
  {
    _id: ObjectId('6605861ea229e329eb8b2f8a'),
    code: 'e-resident-diia-id-signing',
    admitAfter: [ { code: 'e-resident-diia-id-creation' } ],
    methods: [ 'photoid' ],
    title: 'Please authorize via photo identification',
    photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    faceLivenessDetectionConfig: {
      Huawei: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      Android: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        }
      ],
      Browser: null
    }
  },
  {
    _id: ObjectId('6605861ea229e329eb8b2f8c'),
    title: 'Будь ласка, підтвердьте особу користувача через перевірку за фото',
    code: 'military-bonds-signing',
    admitAfter: [ { code: 'diia-id-creation' } ],
    methods: [ 'photoid' ],
    photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    faceLivenessDetectionConfig: {
      Huawei: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      Android: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        }
      ],
      Browser: null
    }
  },
  {
    _id: ObjectId('6605861ea229e329eb8b2f90'),
    code: 'e-resident-applicant-auth',
    methods: [ 'email-otp' ],
    'email-otp': { maxAttempts: 3, maxVerifyAttempts: 3, ttl: 180000 }
  },
  {
    _id: ObjectId('6605861ea229e329eb8b2f92'),
    title: 'Будь ласка, підтвердьте особу користувача через перевірку за фото',
    code: 'mortgage-signing',
    admitAfter: [ { code: 'diia-id-creation' } ],
    methods: [ 'photoid' ],
    photoid: { maxAttempts: 3, ttl: 180000, maxVerifyAttempts: 1 },
    faceLivenessDetectionConfig: {
      Huawei: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      Android: [
        {
          version: '1.1',
          values: {
            solutionsSize: 5,
            deviationThreshold: 0.05,
            confidenceThreshold: 0.85,
            failureCooldown: 500,
            sensorRotationYLow: 70,
            sensorRotationYUp: 110,
            sensorAccelerometerYLow: 8,
            sensorAccelerometerYUp: 11,
            sensorAccelerometerXLow: 0,
            sensorAccelerometerXUp: 2,
            headEulerAngleXLow: -15,
            headEulerAngleXUp: 15,
            headEulerAngleYLow: -10,
            headEulerAngleYUp: 10,
            headEulerAngleZLow: -12,
            headEulerAngleZUp: 12,
            faceBoundingEdgeMin: 12,
            faceBoundingEdgeMax: 88,
            faceMinSize: 70,
            faceBoundingBoxThreshold: 57,
            faceDarkPixelUp: 25,
            faceLightPixelLow: 220,
            brightThreshold: 0.6,
            darkThreshold: 0.6,
            eyeClosedUpperProbability: 0.6,
            smileLowerProbability: 0.1,
            solutionTtl: 10000,
            allowedCameraResolutions: '480x640;600x800;624x832;720x960',
            frameProcessingExecutors: 3,
            frameProcessingPoolSize: 4,
            messages: {
              face_recognition_message_blink: 'authUrl.v3.face-recognition.Android.face_recognition_message_blink',
              face_recognition_message_smile: 'authUrl.v3.face-recognition.Android.face_recognition_message_smile',
              face_recognition_message_look_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_forward',
              face_recognition_message_face_forward: 'authUrl.v3.face-recognition.Android.face_recognition_message_face_forward',
              face_recognition_message_loading: 'authUrl.v3.face-recognition.Android.face_recognition_message_loading',
              face_recognition_message_not_enough_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_not_enough_light',
              face_recognition_message_too_much_light: 'authUrl.v3.face-recognition.Android.face_recognition_message_too_much_light',
              face_recognition_message_take_phone_aligned_to_head: 'authUrl.v3.face-recognition.Android.face_recognition_message_take_phone_aligned_to_head',
              face_recognition_message_looks_like_cheater: 'authUrl.v3.face-recognition.Android.face_recognition_message_looks_like_cheater',
              face_recognition_message_more_than_one_face_in_frame: 'authUrl.v3.face-recognition.Android.face_recognition_message_more_than_one_face_in_frame',
              face_recognition_message_look_strait_to_camera: 'authUrl.v3.face-recognition.Android.face_recognition_message_look_strait_to_camera',
              face_recognition_message_checking_you_are_real_person: 'authUrl.v3.face-recognition.Android.face_recognition_message_checking_you_are_real_person',
              face_recognition_message_complete: 'authUrl.v3.face-recognition.Android.face_recognition_message_complete',
              face_recognition_need_face_closer: 'authUrl.v3.face-recognition.Android.face_recognition_need_face_closer',
              face_recognition_face_too_close: 'authUrl.v3.face-recognition.Android.face_recognition_face_too_close',
              face_recognition_adjust_face: 'authUrl.v3.face-recognition.Android.face_recognition_adjust_face'
            }
          }
        }
      ],
      iOS: [
        {
          version: '1.0',
          maxAppVersion: '3.0.43.895',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 2,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        },
        {
          version: '1.0',
          values: {
            minEyesToNoseCheck: 1.5,
            maxEyesToNoseCheck: 5.5,
            minLipsToNoseCheck: 0.5,
            maxLipsToNoseCheck: 4,
            minBrownToEyesCheck: 0.3,
            maxBrownToEyesCheck: 4,
            minBrightness: -3,
            maxBrightness: 7,
            yawThreshold: 0.1,
            minRollThreshold: 1.5,
            maxRollThreshold: 1.6,
            faceBoundsMinX: 0.1,
            faceBoundsMaxX: 0.9,
            faceBoundsMinMaxY: 0.69,
            faceBoundsMaxMaxY: 0.9,
            faceBoundsMinMinY: 0.1,
            faceBoundsMaxMinY: 0.31,
            faceBoundsHeight: 0.47,
            blurVarienceThreshold: 12,
            messages: {
              face_recognition_no_face_in_frame: 'authUrl.v3.face-recognition.iOS.face_recognition_no_face_in_frame',
              face_recognition_multiple_persons: 'authUrl.v3.face-recognition.iOS.face_recognition_multiple_persons',
              face_recognition_small_face: 'authUrl.v3.face-recognition.iOS.face_recognition_small_face',
              face_recognition_not_centered: 'authUrl.v3.face-recognition.iOS.face_recognition_not_centered',
              face_recognition_incorrect_angle: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_angle',
              face_recognition_check_brightness: 'authUrl.v3.face-recognition.iOS.face_recognition_check_brightness',
              face_recognition_incorrect_depth: 'authUrl.v3.face-recognition.iOS.face_recognition_incorrect_depth',
              face_recognition_blink_action: 'authUrl.v3.face-recognition.iOS.face_recognition_blink_action'
            }
          }
        }
      ],
      Browser: null
    }
  }
]
```

### diia-documents-service

Список таблиць
```
diia-documents-service> show tables;
documentsettings
documentsexpirations
documentverificationotparchives
documentverificationotps
encryptedstorages
migrations
```

Тестові дані
```
diia-documents-service> db.documentsettings.find().toArray()
[
  {
    _id: ObjectId('660586418df176d7527c8443'),
    type: 'driver-license',
    expirationTime: { success: 3600, 'registry-error': 3600 },
    version: 1
  },
  {
    _id: ObjectId('660586418df176d7527c8444'),
    type: 'internal-passport',
    expirationTime: { success: 86400, 'registry-error': 3600 },
    version: 1
  },
  {
    _id: ObjectId('660586418df176d7527c8445'),
    type: 'foreign-passport',
    expirationTime: { success: 86400, 'registry-error': 3600 },
    version: 1
  },
  {
    _id: ObjectId('660586418df176d7527c8446'),
    type: 'taxpayer-card',
    expirationTime: { 'registry-error': 3600, success: 86400 },
    version: 1
  },
  {
    _id: ObjectId('660586418df176d7527c844a'),
    type: 'driver-license',
    version: 2,
    expirationTime: { success: 3600, 'registry-error': 3600 }
  },
  {
    _id: ObjectId('660586418df176d7527c844b'),
    type: 'internal-passport',
    version: 2,
    expirationTime: { success: 86400, 'registry-error': 3600 }
  },
  {
    _id: ObjectId('660586418df176d7527c844c'),
    type: 'foreign-passport',
    version: 2,
    expirationTime: { success: 86400, 'registry-error': 3600 }
  },
  {
    _id: ObjectId('660586418df176d7527c844d'),
    type: 'taxpayer-card',
    version: 2,
    expirationTime: { success: 86400, 'registry-error': 3600 }
  }
]
```

### diia-gateway

Список таблиць
```
diia-gateway> show tables;
errortemplates
faqcategories
faqs
migrations
```

Тестові дані
```
diia-gateway> db.errortemplates.find().toArray()
[
  {
    _id: ObjectId('6606611aad35d5b9858ac7ac'),
    errorCode: 1012,
    template: {
      description: 'Вказано неіснуючий ідентифікатор шаблону повідомлення'
    }
  },
  {
    _id: ObjectId('6606611aad35d5b9858ac7ad'),
    errorCode: 1017,
    template: {
      description: "Банком вже створено IBAN для вказаного РНОКПП. До одного РНОКПП може бути прив'язано тільки один діючий IBAN з вказаним типом послуги."
    }
  },
  {
    _id: ObjectId('6606611aad35d5b9858ac7ae'),
    errorCode: 1020,
    template: { description: 'Невалідний номер картки.' }
  },
  {
    _id: ObjectId('6606611aad35d5b9858ac7af'),
    errorCode: 1018,
    template: { description: 'Запитуваний до видалення IBAN не знайдено.' }
  },
  {
    _id: ObjectId('6606611aad35d5b9858ac7b0'),
    errorCode: 1014,
    template: { description: 'Невалідний РНОКПП.' }
  },
  {
    _id: ObjectId('6606611aad35d5b9858ac7b1'),
    errorCode: 1015,
    template: { description: 'Невалідний IBAN.' }
  },
  {
    _id: ObjectId('6606611aad35d5b9858ac7b2'),
    errorCode: 1013,
    template: { description: 'Помилка валідації' }
  },
  {
    _id: ObjectId('6606611aad35d5b9858ac7b3'),
    errorCode: 1016,
    template: {
      description: 'Термін дії створюваної картки вичерпано. Картку не додано.'
    }
  },
  {
    _id: ObjectId('6606611aad35d5b9858ac7b4'),
    errorCode: 1019,
    template: { description: 'Такий IBAN вже існує.' }
  }
]
```

### diia-user-service

Список таблиць
```
diia-user-service> show tables;
diiaids
distributions
documentfeaturepoints
encryptedstorages
eresidentdevices
eresidentprofiles
migrations
newfeatures
onboardings
otps
serviceusers
subscriptions
subscriptionssegmentsmeta
unregisteredofficeprofiles
useractionaccesssettings
userdevices
userdocuments
userdocumentsettings
userdocumentstorages
userfeatures
useronboardings
userprofiles
usersharinghistoryitems
usersigninghistoryitems
```

Тестові дані
```
diia-user-service> db.newfeatures.find().toArray()
[
  {
    _id: ObjectId('66058721177267f5dd7362bc'),
    appVersion: '3.0.1',
    platformType: 'Android',
    isVisible: true,
    data: {
      header: {
        logo: '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'... 14628 more characters
      },
      boards: [
        {
          title: 'Дія.Підпис',
          backgroundColor: '#C5D9E9',
          text: 'Найзахищеніший цифровий підпис у вашому смартфоні. Авторизуйтесь на порталі, отримуйте послуги та підписуйте документи в Дії та онлайн.',
          image: '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'... 301532 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Реєстрація місця проживання',
          backgroundColor: '#C5D9E9',
          text: 'Реєструйте нове місце проживання або знімайтесь з реєстрації швидко та зручно.',
          image: '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'... 73300 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Податкові послуги',
          backgroundColor: '#C5D9E9',
          text: 'Подавайте декларації та сплачуйте податки в Дії в кілька кліків. Наразі доступно лише для ФОП на спрощеній системі.',
          image: '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'... 78040 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Місцеві петиції',
          backgroundColor: '#C5D9E9',
          text: 'Підтримуйте петиції своєї громади та створюйте нові.',
          image: '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'... 78296 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Заміна посвідчення водія',
          backgroundColor: '#C5D9E9',
          text: 'Втратили, пошкодили, або хочете замінити посвідчення видане на 2 роки? Замовте в Дії нове в кілька кроків та отримайте в найближчому сервісному центрі.',
          image: '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'... 66456 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Що ще нового?',
          backgroundColor: '#C5D9E9',
          list: { bullet: '•', items: [ [Object], [Object] ] },
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        }
      ]
    },
    viewsCount: 1,
    sessionType: 'User'
  },
  {
    _id: ObjectId('66058721177267f5dd7362be'),
    appVersion: '3.0.1',
    platformType: 'Huawei',
    isVisible: true,
    data: {
      header: {
        logo: 'iVBORw0KGgoAAAANSUhEUgAAAagAAADCCAYAAAAcqlZIAAAACXBIWXMAACxLAAAsSwGlPZapAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAEe6SURBVHgB7X1NmhxHkt2LVu+J1gEaAa20GoLSQvq0EBJzABFs7YXiHEAgdYCpxBxAIC/AKswBSHD2YhX6AA1SK61YCe3VYF8gXWmVGYCnpf15RCQqMtPf90VVhLu5ublHuD03j59scLy4x7Z2taXN/h82Mvcz+ZaVp7wGOqT8tEnL/3fQ0sFkuD4pXZN5t9p+M+QX7Pi3zZbvN5ncIstbZLIVFX0hjUvCJ4iNyxY2vPy7QD7OJCwM+b9l+wvhv6f7oNHgcNGutodYX8y0313s3T5tHSF04MdDkOsqJRJeVkuDchyxycovtT3HAh8GBe2/XW0/b467/xWnixYfxuUDrImnxfa4rBgfC3wYl79gezwe7Lg8BIJqsb7gZ1hf9N3FT5DsL3W4UHRwR15avo8NpfVZRCPpkuwqIc5cHko+RXE0QGhQLDb716g4NrRYj8luPD7ENKOXijU6oqLxeIMDGZdTJCi60B9ttsf4EAkRJOdrOfUhkUIK1KdFOp5NgLzkVxpJaSTUOLYB/dsQ7Xsuf40Pg4K2GmkdFrpxOdtsNRI6DlxjwuNyCgRFFzpd/E9X2+f4sA5dEhFAkO2Oo07cc7wewUlkCMOOCAFEjvP0PnXxMl7bLd0leVer7cfNtkDF1JCPyycYl5AW2F4mJkj3Wvi+dIzC/LuAt7TZGvLSvbk2+z/2sun1anuFiYzLuySoGeSLfyxCgaLD0unV6ekszffgLcmVlo9GolGCy/Miy4OaPlp6+Ga1vUYlq7vGDMNIaYEP9zzebo677ahv6N8xWnwgLCKyB/hwf75LL8Wb1fYtTmhcUiedY70Gmgq2JfsfkS0tu3Rkh6YtB7SPl1869UX6ZWje0HRN7gJrJ1nx8dCNS7p/mIIbyV5hPbE4wzraqst+00V3H//ZavsBa/JJBdtRj8t8AHBnvDT2hzhEz8lHy3jppXYue+qN5PN6xmjr2GWk8yHpuUIlqn2jhJhIhhwbObiHqDgG0PmnSJkmGVHCOqpxyYkpGnFYzqzUafaJuqLyEWLtY3My9Jf009iRoNZ+Lc1ra4Rwr7C7Rl8xDFFionxyXjNUnAJarKNhGnOer/kJBz4uZ1gv5UnOPPXYrKW7vsTXx4HyNOvYSy9ts9UP0bZ7JBYlkKHndVmYf4FKVGNgBnuJvZJSBaHFmqysa+UgxyXNzl4g7nxKnKV2HCErL0rRdHp2afqWhj6r7R4RRHRp/WXZvAy0xWuzpTtC0l7/32B9A7+iHDQuaYlO63sipjnqfaSKXcxgR1W/4kDG5QzxByBKnL7kMKP6+kQLJVskyoo45JK+GlNeIiGvz/qSaEnfWPXTBKgijhn0cVmJqSKKdrVdQh+n55gw6OZp6bJP31l5iYxUxovM+ui0nLVVf4keL6IZanvERqusZrOXHu2LfLtBXfKLgMal1sdzVGKqKAc9WEHjT7qm/oIJjkttSc9bNsodVUlU1MfpRuyQHOpQ8iq1szQKKdEfJR5Ph9RPmkwCiiJfz5a83htUkrKgjUt6Yqs+iVcxFHPI19evmNC4vIDtmPhmOTLPkVo6Ik51LMesOepoWcumCCH06ROtzFASjOrVIsEUkLdk/orqbCVcQD5H36CiYjzQC8E32L3OJjEu+SDo6yj7RARSpLMsKK/lDSW3CAlJ9ZUSRsQub2LQp5+47j7lS+yJkD/dR6kk9QEX2O1H6qMnqKgYH0RS0gM4d0pS3SCQZs3RiCjiuC09UTIorcuLWiJ2es41Ej0slT4u6cuS6M3TEWln34mC1r6l05bcAX+Kigvs9s0N6lJoxf4xB6ZBUueQnViJQ9bkPUfqRVGWI4zq9sgxQijJaaNVV6TtXhmPPProl9oW0bPsUUekj6oj3sY5ap9U3C3m2L0Gf8VHvAb5IFjCd5CeQ5ecU9ShlTr4EvnItgzse2WtckvIDrvEeUf0R/qttK5IeonMMpB3g9N8Mu0cu31CfdGiouLjYo7da5FIau/j8iH6O2fLcQ1xfhGHGI1WhpJXlKAijjhq63LPtmo2edFT1I7SLdJuWg8/JfBxSdsNKjlV3B3m2L0mv8ce0SL2Eq7kQIc4wAgplRBXHyc4lLi0MhGS0KKlEhv7RialZFjSHxGdXrRnydD7P6eAFrvj8h0qOVXcLejndC6xOza/wp5wgV3HEiUQqVwK6NGcVh/C6GNrxMmWRHDefkm7PPnopGAMmYgNpUTkyXrEfSpO+hK7fV+f1quYAuiHFvlX0umhiRYj4wy2QxnqvErKaQ6sROdy4LHkFPv0z9JoU8Rur4+WwTxLVirr9UW07alwK63nCseNM+y2eY6KiumAHkHnX83/CSPjBjGnVupg+BZxkKVOy4uqvLylYK8lV6K/xLZlwEavXB/i1NKH9HuJDUOvsWNe6rvBdttvUFExPXyJ3TE62lLfOfxlFcsxSY7MKhtxShpRSvtRkighq6htJfWWkEcKtM3rs5J2euerRH9f4ooSNreDZm/H+FTfOXbb36KiYnqg+1FX2L5Waalv8Lhssf2bTkMdkEZWQ2flQx11X6c5dFsa+95xQnk/WboiEZN0fq1yfUm4b19qfTbHcaHF7rLJHBUV04W01DfHQJzDd2qSw1oG5VIgLTl1aLKlRKmVH+pUvXaWEE+0PX3bHqljWZg3pJ9Ky2gkOspsbUK4xHb7blCjp4rpY44Rx2UL+d5TqQOJOuPlAF2WPi8CGOIMI3ZE2xSR1doZIaVou5fOcam+0jbtQ5b+z3EcaLE7E32Kiorpg57qGy2KOsPuIJecfV/HpzkUad8q36f+CKl4DrFvvVECiNhaIhNt99CtlKBTgbzXB9Y5O5Z7UWfYbtcNKioOB3NsX79/RU/cYJiziDgdjYzyNE8Xl4s48IgzXDrllk5aSX2ew42cA62fIoRbSk6R9vbdlgG7+9hL21McPm6w3bZjaNMU0aJiH+BRFI3Lz1GIGWJOs4+DKnFAmiOU7LAc+tI4Xhr2DSUOrdwyaLdmY3LabrUpDdiWhbqXgT7w5PvaLZW9wmFjht12tqgYGy3WE4FzVOwDc2xfwz+hEBfo5wwsZ+ZFHEujnEUW0Tqjti97ymq29NEfJSxPv0V+ko6IvZL8ssDGpWPX0E2rrztucbi4xHZbL1CxD9zgQx/PUDE2PsPumC1afv8rYoM/6tSieWPJRpy0Ry592jO2092nE+/btuj5lohorOvC0uGd1zkOEzSAeXtnqBgb9GJ33sc3qBgb0ntRc0nwd0IarQf+AbZyfiyl5ZVL5fN0bZ/rlfQlQbYxdGh2JKOuBrt18zypHAT5EtlGSMvLRWyXEOmfPC/hQzul86fZyWWluqQ+1WzXrpO8PqttdPwIh4kZO16stmtUjIkWu184kNIqhoHG7r+wtP+MIC6gzz6l/5Jsn9mulpaUesaO5Pq2wbJ7GehHL03LL8kb2s6IriWGnZe+5y9yDriuFoeHS2y36xtUjI1zyNfasX6N5C5BQRAfpzt9LEVQs81/afYp/ZdkOZKQJs26vYjJypfytJm9lRZBXmdXjxSRNdiOsHKbeP8l+FGgF71wGyPRThLKScdSPY2Q3wj1WZFUEuSg6OLnm/en1l7epuKnhiaAR+z4FSrGxpmSTo7zESrGxG/YXQE440KcoOiHz9rNvue8k7LP05KTZoE7Le6guFOSHCag16fJI1A21wH4jtqDR/KWrNavXtt4/0mkrk0KrPNqnTPAJ1iJYPhEIM/jsPqe0h/jsDDDdtQnDe6KYZhhu4856jLfuKBx+Do7pjH7d1yIE9QjVsBC48jyma0UPViRg0UqpZCIDtglNS2/2+ezd8AngTxPc5xJ0KfZpJXL6+H7ET1SGS0qzftTOr9SBCW1JzJxyHVEYU2EDvE+1EN2/BoVY+PMyZ+hLvONDX4d7/yOGSeoGWLIHQDfj8ziPWelEYdFXhLZafpzJys5Vo1wG9ikAPjRgbRsJTlxyaZk2KX1rxVJ8LokeS0CsurgcvwakWwG4v0K6OcqT+cRcrdPjoY7/SmDL0me2k/afwx8GpB5hIoxcY31akAHGpdtLiAt8Unkw8EjoW5fcnTaLLxkSUxzgJqMJK/NwLWoQyM7Tm6drOSIgV27LGfewCbhKJqAvmhEIvUdT9P6txE2r64cnLCsY+taleo9JGfDyfQXHD6mNEGITlgeYDo4lmjuZ3Y8yw9ygmo3G1+6kSAtgSErB+w6+3z2zEkqL5sEHZqT5XZIEZHl6D3ySMp/y17JeScjX4tGtEmA1vdJKG9FJByNIxclXA+efi5rtUGaXFiRWZ5+KBEU2Zk7I5px/ozDB93TucE0zkMblItEWfsGXQvnq+1XHD5oXOaPm9P43OrjnKA+FQpLxykgp0UwGvFoTpjr50SlkRyvNwIrKuBEpJW37NCiLa1vuJxWDwps1MpHI5H8f7fvTR485BMXqVyD+LWY68vzG6HcoRBUy46PgZw6tKvtDdavtrS4O0SjkRZ3iy+wJvU5jieCWrDjR/lBTlCfZfteZMSjAgtahCDJSfkN9Jk6X8YC7Fm95dhglJH6wyJmKyLq9hujfC4T6V/tuDHk8vRG2I+AR8ZdGq87T9cmL2DleDu0yDG3I9fnnWMemUwVM3Z8DMt7HGdYf1lghrvB1K8Dsu/Favsex/egxjU7bvMDLYLipBCJaHJHJTkcTY/nsHha7qAkRxVZQrIiGk1e05lHLlqUwfVZdVmQbGoK5JOhpw9yEvXaxKPRiO5cV97Pkk7tmtGIjY5bTB98ZeMKx4kW67ad4+PjN0wXD7COMo/1MXfq+0V2vPWgBL8HlcNzuBDkCcnIiy6bWVGQ5fBznSXEZzlpaXkoGeU0R61FoJIdFnlLunn0INlrEXsu7x1bkwxvgsD7guuTjnP5EjLlbeb6aJvCPQUPfMb8FseNOdZPKdZHutfv6/0FhzGRGgL1QQkeQUVn8hya4/TSIs6fRzicjLgeaabOdUj5EnlJ8ty5SnZxPVFIZJanS3KWE5b+S/og1CdFMFyPVhfX1R139iZBDtDtSk6+V57LdHItpg3p6bJjugelgd6HucLxO2YLZ1j/DMUpEHU+6SJ/0HYHHUE9RGwGD6YITM5a8tEcUWLlGkMn1xMhGTi6AX9GrxGCFhVJhGj1peeYNbKw9EX6RSNsKPIQymk2av3YQI/gpH7MdTdG/bydDWTCzNNbTBstOz4FcupAPulUSeoMp/NTKjRu+X3VP3Y7HUHdy4QJmgPhx1IEI0U4UnlPfxOU02yT/nPdnk1WZAAjjxOiVA6ZDZoDliYMXqQnkYAVgVmwCMuqR5pQSMQktUuKrqLXRifrndcOU3+Sr2XHU75Xsg+0WJPUvqOIRVDub9g/znB6v/PFr+v34zKPoLyZOXeEksPhyzjWrDwvA8SimEj0wHVb5JXbqpXxiDLBdooaoeZOHkyX1hdWJCOle8TH0Sj/Ldm8zijxW1GXdl1ZJMtJXjqvvByhxbTRsuNjfILPQ4uPQ1IRvMN+QU9Snxo5EfjKwPtz3RFUC9vhdIiQA3dUDXbJikdcPNLRiI+X0/K0pR7NHiBGShBkpPq5XDLy+LHV5175CGGlQJkSGa7bsiF6fnkduX4IOrToyzrHtH8P017jb9nxqUVQHWgC/QLHjQdYP0Z+iliw47bb6Qjq/ua/5RCQyViOSFr+aRSduWOKOEFezpKRHJNkj2ZbqW7N+UplGkcX19sI5bq85OgvmWRIEZxWr2ZTnhYlDOtaso49WOems2XKBHWfHb/B6eIM+3vUehGUe4v9gK5FeiCixeliwY5b+sPvQUVm75xUuBPwZtBWRJDL5fVbjkmSkaIorluSbQp0a85cs7GB7eg1XVIZyT6rDum/pJ+3MynH0aiuUWR435UQjzVZ0PovJ0a+32K64OT5Me6BTBkURc1wfDjHaZMTga8OtPQnX+LTnIgWGfAoKUcDO+rhctxZWY7NghfpRG31IqS87bn9uSzvP83Z53ZIx1p5br+WD9jEBUFW2/cItAnq1ORSID1vb3SCkJcDK3Mf00XLjheouMB+ot5FQGYfS6yPcTcvJ08NC3bc0p88guJRhuVIANkxAvasWIteIo6NRxuaXm8G7zlZKU8iqTyft1mKZqQyHgnlxNcINiXHZk6YwLaNWkRp9TWXBXSCTEqZErKVIPWvVA9vg9SmQ7oHtcBpwCKCFnfn0McmKLoev0MFga8O3I5LvsRH8JZl8i2X55FIMvTwurp0TpJQyjZGPUnJ1+zjZTXnHHGIEhrYkYHWTon4gF0S1PpEi8iglAHTK+mxJiMSgUpRJScXiUSkNI1MS8BJn/AHTBOcOE/pAYkvYbeX7kXNMC4WI8mU4By7k5Acz3EakxIai4vsmMbne4JqlUJ85t7AjhAA2Unx/MaoD9h1zrys5fAiNmn1SfVKBBGNKDxoztoiMw1SuehEoBHkuV5O3CXQCBWCTclJ04hK0mfZkKfdxzRxygRFjx0/d2TOMS4+dv8+gN0G+tyT1wfHhLfs+PZlXYmgeCQiDXYpksrLW7PhpMhGHE+nU7JFghQ9WRGgpaPbtwhWI7QoweW6PHgRLLeJy1v7XF4i/lyGp1nnQ4vaAHtyIBGddy6ka4vbNtUlvpYdL3Ba+Aa7X7rOMYPwE+EDEHkAZSwSo2vTIqeb1fY/ULHzi7qE3CFpzlWLWBL0mbLlhGDo05xdhFhyOxqjHl7O08ednUa+kl5OKLyNOaFI6dqxlqfZke9L/6VzKMloaYA+uQFi9mh6Ol1eufwa1kjtFL51dqj4EjYpjPlu1G8jyUTQrranSh5do89xehOSBTtu6Q8RVP6Zo9LZr+VcAdvB5WW4nnxJqVHs0+yEYJNFJDxdIwKLED2yLMnjbY8QCt+XbModdEQWRr2ATWBatMVJjcs2kInPA29jXmf+X+rnFtNEy44XOD0sYC9ztavtc4yDCPksMBxe9HS52l7i9MD7//09qPwdKC2y8CIpLV1zYhxcj2QHt49HRx5xJegOWEpP0ElRk4dRtxYFNEaaVa8U0VnEorVfsk1rZ6PUweUS9HOq2cp1AbuElcvl/8HKAPo1Cie9Ylqgpb6fjfyxXt79bWB+FC3s6OmfcJpQCeoTyA5KmwkDusPQyCpCUpGooNQOb8ZvkVlXxloesmxpBB2ROiW9EmFJ5JHr8uyVbIOiyyoPJqtNTKTrwesTQL+meJ4mw9N5XYdyD+otThdfG3kzjPNE38ciqKdGHpHTAhXv0UVQkkOxnJs0s5fKS47IIr0Em9D4bD/q2CSCkZaScseuOW3PNiniyvc1590I8hbpSemR42gfWiTCozYrkpGOG6bHI1IYdVl9xq+7JNRd70FNH9ewH5gY42EJj4AWGA669p4qeTdYL++dKhbsuKU/v4fsvCNkAcjOANBnyxpRWdGDdZzraozyFiFEZvFanVpdEpFEbL/9f+/ePTx9+rR58ODBbeKbN2/w+vVrLBYLrbxlJ4Q6eGRp6ZP6VyujEYLUzw3sCYOUZ00yECjTKHVNEaf8mLmEl9AjJXL6cwzro4/RvzNsHK+Aa9ToScQFtmf+y2xLgW05MG+p1B+RtWQiZUps4n3D7YzUa5W73Z49e5bevXuXJJyfn5e0wcr37C7pw2VhPZ6OiP2pcFs69bSYHi6x3YYzHBcuoZ+vVpAnwn5nlJlhGFrY19AFhuMS+vXZCvI0iboxyhwTqK35+aX23fsdtmfUCfoyEjIZrjgJ+UmR52lSJCLNtiO2pEJZz6aE3T6R9gG4y2p5GSlaJQLCN998cxtBSZjP5yAZQa9Xb34sRbLaedeiFqk+Kz2vJ0/Tzq/ULg/adcbbloT9iumDIpyXRv5TTB+PlPRr1OiJID4ocQF5tqkdW7NSrZwWkS3hRxxROyzdlpy3RevVopJQZNW2bYqCZHu2yYskStqfnPM25LqJ5C1hX1cl/dJierjCto0zHBcuUX4+ZkaZMX5M0LpG5hiGGfRr+qlS5tQiqLytt1Gl9CWJJhPqjjWFuXwHqZx0v4GnW/eQtPxUkK7NmJNyLKXnWxOwtUHMjubs7AxRPHnyRKqzs1ECt1mKJLR+sKInL53nJ+xGUpKOxiiby0j9q5W3UB+UOAxcQ79XROewxXQxM/Jeo0LE75R0beATJEcmLQtZZTUnVQKrjgayM2zg6+SEydvTBPQAAglBJ32KihDFp59+qmVJhCX1OZfly36SLglJKJdQtvzJ9UCRtcg4sm/lVYI6HPxo5M0wDIueeRE8UtJ/Rl3e67Bgx+3vWQJ3ONK+52ykNMtpaZGV6LQo0nj06JFUh6ZXsxtCuinz8uVLXF9f53bmtnr7HaSyzc8//0xP7iGCX375xRORJg0Q7GgcHYDeP9Y1wfPh6GqMuvmEA0IeDF2R+isOB9fQl8QeYrqYKemvUaGCE1SEWPK8vFwydEg6JZlGKLMlP5vNwo58bNCj3hmiztZzhLf5r169wosXsU+LkWwG3p9alJTLetEnIEe5YTIXylmRmbTky/U1ig0e0XKSy3V4Ze8S9TFzGddG3qfYHxboD4046fq7RoWK/FNHHSxnIS3jNIK85gAB3YFxx6M53buG5uQT5PtUvM+AD+17r4Pecfr666/h4fnz52klq00OpAmFRFjaueJpEUJKkM+PdX2gwGatzrweK59HYFKbWkwPlaBkLKD3RYvhuveB1siLfEX9ZCERlDXDlmaxwLZTzvMtR5OCaVJ9dwkvwpAcMzI5dcmMHjH/8ssvpRdy8dtvv90SGD1qztA3CuBOXCM9rUwuq0W+km6NvGHUb0V8mk05IVlRpqajYrpYKOktpglr6dH6zuCpgU88PumW+DixWEtDmsNtHF2mc4YcsVnl7xKRtkhRiFQ215EuLy+b1ZaePHnSPHz4EO/evaN7TonuURFJKTqtdC1SaowyPN2ThZJvXS+WPu9+E+/fpPwH5EjXitYrpg+6Cas5/Rb7iYQW6A9t6fE31Mg4B48m/9ARlOcomkC65owijtqrf4rkJNmkEXakr5DrpftMm3tN1ux/qwxi0CYSUUTqSko9nEQAu19yaASU65Cup7wuzcaKw4Ll1Ic8kbkvstBsWqDCRP6YubQkozlGa6be7WvkYy3xaEstU3IkFqnmTpmTDrI8zXlzvUko7/U9oC9hWRMGDQlxJGGfk3MjpOfXhKaPl5XyNfDJQv6/pH0V08DCyBvyJN++7gdpNtXoyUG+xGcRihRFdXl5GYtg+D0BwHb2VroKthRWBHoXqeB9JG8G3hj7Ur9ZxOPJWUtiPOLQ7NJ05emWLVr0KNnE9TVKHdq1aF2TuZxmF5TjKaG+m6VjYeS1mB60c+m+L3LqyJf4oks3knzEYeTwHJtUl1R2B/QgweZdpWKs7v1ECSqynMmdaS5n9ZvmxCPnB6wcsvKA7ritY4lQAflcQahXIynNDouMG0GPVq9mp0R6UwR3agtUdFgYefcxLVgRXX2Cz0H+HpQ26K0ZtxddcUetyUiw6vUgOVQtvcTxc3t4+3dsXhFeM5vNtH6yoqadfIoOV1sq0GFFHFt9QHbSQxn37t1T22JAzV/dR2tWEW2CTHgI2pcjQuoe+VkkWDF9LIy8P6A/PsH40KInuvbeoMIEEVQ344jOqLUZsOcMJL2Wfl5G0mVBcoT5fyjHJZDs3Tr+6quv8OzZszGcYPPkyZPbp/myut0yiuytjStCSmdnZw399pT2BfWhoHe2VhGt1OfW+e5sBOTzJUXXJSTH86c2666w0T39Jl20Q17W3ccgqBHUAHQ/WAjsOgvuCCIOXlvWkspFCU1Li0AjqTHgLWvd1vX5559jLGy+ZMHb1KVJtonpFCXRO1dETPj40CIgIH5tQdj36szlauR0+NAIqsV+0Je8rHILVJiQPnWkRTgcVnQiEY+2HCYtBVoz6wisWXSUMC1Y'... 14628 more characters
      },
      boards: [
        {
          title: 'Дія.Підпис',
          backgroundColor: '#C5D9E9',
          text: 'Найзахищеніший цифровий підпис у вашому смартфоні. Авторизуйтесь на порталі, отримуйте послуги та підписуйте документи в Дії та онлайн.',
          image: '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'... 301532 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Реєстрація місця проживання',
          backgroundColor: '#C5D9E9',
          text: 'Реєструйте нове місце проживання або знімайтесь з реєстрації швидко та зручно.',
          image: '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'... 73300 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Податкові послуги',
          backgroundColor: '#C5D9E9',
          text: 'Подавайте декларації та сплачуйте податки в Дії в кілька кліків. Наразі доступно лише для ФОП на спрощеній системі.',
          image: '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'... 78040 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Місцеві петиції',
          backgroundColor: '#C5D9E9',
          text: 'Підтримуйте петиції своєї громади та створюйте нові.',
          image: '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'... 78296 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Заміна посвідчення водія',
          backgroundColor: '#C5D9E9',
          text: 'Втратили, пошкодили, або хочете замінити посвідчення видане на 2 роки? Замовте в Дії нове в кілька кроків та отримайте в найближчому сервісному центрі.',
          image: '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'... 66456 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Що ще нового?',
          backgroundColor: '#C5D9E9',
          list: { bullet: '•', items: [ [Object], [Object] ] },
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        }
      ]
    },
    viewsCount: 1,
    sessionType: 'User'
  },
  {
    _id: ObjectId('66058721177267f5dd7362c0'),
    appVersion: '3.0.1',
    platformType: 'iOS',
    isVisible: true,
    data: {
      header: {
        logo: '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'... 14628 more characters
      },
      boards: [
        {
          title: 'Дія.Підпис',
          backgroundColor: '#C5D9E9',
          text: 'Найзахищеніший цифровий підпис у вашому смартфоні. Авторизуйтесь на порталі, отримуйте послуги та підписуйте документи в Дії та онлайн.',
          image: 'iVBORw0KGgoAAAANSUhEUgAAAxgAAASQCAYAAAB/OelfAAAACXBIWXMAACxLAAAsSwGlPZapAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAyteSURBVHgB7P0LnGxlfecL/1f1/b4vbNiwuWwNKEZNxIl6EkfDqDOjZM4EfaPmzPtGEE/0PZ+AOO9JZhRIYhIFzui8Ey5OJnFQ0DlnFBMxmSOYjCJCdOINRERQEDaw2RfYl77fu9b5/5+1nrWeVV19X91d1f39Qu3urlq11rNWPVX1/z3/WySwndiR3oz9NX8P6G1n+vs5Czyn3t8h+wUAAACalQML3D+Y3hba9qk69x+oee4BgW1DJNDseIP/FenP/enPgfT3/el2+wUAAABgczkgueiw21OSC5ADwe+DAk0LAqPxCQXEOZILiVfI4t4EAAAAgGYlFBoP6u1JScSI3fcDgYYGgdFYvCK4eTGxXwAAAAAgxESGFx/3CMKjoUBgbB779XahJCLiVyUPbQIAAACA1XGPJKLjgfQnomMTQGBsHF5IXJjeEBMAAAAA64t5Oe5Jb98QBMeGgMBYP0xAXCyJqLhYEBQAAAAAm80BKQqOAwKlg8AoFxMRl0giKC4UAAAAAGhk7tHbrYLYKBUExtpBVAAAAAA0P/cIYqMUEBir50K9/aEgKgAAAAC2Grfq7a/19iWBFYPAWBnmrbhSbx8QcioAAAAAtjoH9PZhwauxIhAYy+NCvV2qt18XhAUAAADAduRWvf2RIDSWBIGxOBcKYVAAAAAAkGNhUzdIkrMBdUBg1OdCQVgAAAAAwMLcI4lH4x6BAgiMIhcKwgIAAAAAls89gtAogMBIuFAQFgAAAACweu7R27uFHA2pyPZmv97u0NvXBXEBAAAAAKvnQr09qbdPS2JjbltaZHtilaD+rSTVAF4hAAAAAADlYLblB9LfH9TbpGwztqPAsI7bd6Q/OwUAAAAAoHwu1Ntv6m1QEqGxbdhOORj7JXFZXSgAAAAAABuHlbb917JN8jO2iwfDum9/Tm/nCwAAAADAxmI2qA+b+oZscba6B2O/4LUAAAAAgMbhgN7+iWxhb8ZWriJlXosHBHEBAAAAAI3DfkmqTf2hbFG2ogdjv+C1AAAAAIDG5x7Zgr0ztloOxoWS9LQg1wIAAAAAGp39klQ2fUpvj8oWYSsJDHMz3SqUngUAAACA5sH6s/1m+vuWSADfCiFS9qJYX4sLBQAAAACgeblHtkDIVLMLjP2ShETtFwAAAACA5ueANHmVqWauImXxalYlar8AAAAAAGwN9kti414sTUqz5mBYvsV/EvItAAAAAGDrYTZu0+ZlNKPAMHHxYQEAAAAA2NpcmP5sKpHRbALD+lt8QAAAAAAAtgcXShI29dfSJDSLwLBKUX+mt0sFAAAAAGB78Yr09rd6m5QGpxmqSJm4sEpRrxAAAAAAgO3LDySpMDUoDUyjCwzEBQAAAABATsOLjEYWGIgLAAAAAID5NLTIaGSBYfV/ERcAAAAAAPO5RxKR0XA0aqM9qxaFuAAAAAAAqM+FktjMDUcjVpH6D3r7/woAAAAAACyGLchbWsHfSgPRaALDmuh9UAAAAAAAYDn8T+nPhmnG10gC40q9XS8AAAAAALASLtTbkN7+QRqARknyNvfOAwIAAAAAAKvlAkkqTG0qjZDkvV9vdwgAAAAAAKwFs6n3yyaz2R4MS0oxz8V+AQAAAACAtbLpPTI2OwfjOr29WQAAAAAAoAz26q1TNrGy1GYKDEvq/rAAAAAAAECZWGWpTUv63qwQqf16e1IAAAAAAGA9sBApC5Xa8KTvzRAY5F0AAAAAAKw/BySpLLWh+RibESJF3gUAAAAAwPpjC/sbno+x0R6MS/X2aYFG4UDN34OysMJd7LFmxN5w+yXpwQIAALBWDkgSirLVvit3LPL4/hVuD5uHhUrdIxvERgqM/Xr7uhAaVSbe6D+Q3oaCv6XOz60mEsrAPggv1tslknTBBAAAWC4H9PanertN+H6tJRQb+2vu83+fE/z+CkGcrCcHZANDpTZSYNwqiREHK8Mmgq2IPChJYvxTkq+Q8GFWLhdK4mHbLwAAJdPa2ipdXV3up6darcr09LRMTEwINBUn9fbHkogLKJf96e0X9fYCyUUIEQdrx+brv5YNYKMExqVCaNRy8GLiG+nPewQRsRnYG/BKAQBYI5VKRQYGBmTHjh3u94WYnZ11IuPEiRPud2horFDN22R+mDGsL+bdMJFhwuPC9Pf9AitlQ0KlNkJgUDVqce6RRFDcIxsYGwdL8mG9/aEAAKwSExa7du1aVFjUw0TGyZMnBRoSs2feICz+NQr7JREbv57+JMRqaQ7IBoRKbYTAMCPtwwIh9+jtS0LMZqODJwMAVowJilNOOUX6+vpktZgX49lnn8Wb0VhYmPIrhe/tRuZCSaJmTHAgNhbmj2SdbfP1Fhj7hYZ6HvtAukESo5UPp+YA7xsArJgzzzxTOjo6ZK0gMhqKWG8vFMKimgVfwMUWCcndqI/ltxyQdWJlftuV8x8EDkiipu2F/LAgLpoJe63eLQAAy2T37t2liAvDksH37t0r0BDcKoiLZsK+v2+VJBTIcg5uE6hlXXOj19ODcals78TuA5IICiZ182NeDFZAoFSsmtDOnTudMbrSGH2oj1VkmpqakpGREXfbaCwk6tRTT5WyISdj08F7sTXYL4ldRkXTnHVL+F5PgWGhUftl+2Gq2WLbKF23dfiwkPANJWGr0maEmsCA9WMzwovOPvtsaWtrk7Ix4fTUU0+5n7ApWA+vNwhsFS4UStJ7DkgSYVM667VsdqlszxfOcizshUJcbC2+JAAlYJ6KM844A3GxAZiQ27dvX6HnxHpi3ov1EBeGL3ULm4J5L/5GYCtxjyS2moVAH5DtzX69fUDWgfUQGJZYs91We61nhbmZ7EUix2Lr8QMBKAGrLLReRijMx3uLNoKenh5ZT6yPBmwafAdsTW4V8jMMs9lL/4BZD4FhGfv7Zftg4VCWRHSPwFbmgACsATN211K2FFaHeYs2wmO03scwL8ZGeWNgHgcEtioHJIm6+SeyfV9nExelezHKFhj7JXmhtgMHJBEWHxYAgCVY7xVuWJj1FnZm+G9Eoj6hdQDrxj2yvb0Z5hwo1YtR9ieiZebvl62P5VqYuMBtun04IABrAONw82hvb5f1ZKPC3qg2tmkcENgOHJBkkfxfy/YLdy/di1Gmv3W/bHHvRW9fv7znit+Td1zyXlN6dHjeRlz+W2+VB77zLQGA5qOlpUW2AgiMjSdS/v7RI7HAtuLws8+47/0j+nMbYXZtac2gy/y02tLei737zpKbP3uHiQuB7Ye9/gBrYW5uTmBzmJmZkfVko8rHUqZ24zmdz/5tyempzfe6N71ZthGlejHKFBiXyhbl3Je8zE208/QnbE/6+ikRCWtjcnJSYHOw5nvryXoLGM/09LTAxtLb3y+wPTGRcf0nbnORK9uI0nIxyhIYl8oW9V5c8OpfkZs/cwerGNscXn9YK2NjY6xAbxJDQ0OyntjruhEiY72FEsynt4/Fpe3OZZf/7nYSGaV5McoSGFuy78VFb3un81z0sYKx7bH8G4C1YEboyZMnBTYWu+Yb0c3bBOR6MjExgUDdBM49/6UCYCLjyqs+ItuEUnKMyxAYl8oW9F6YuLj6uhsFwDjvJS8XgLUyODiIyNhARkZG5MSJE7IRjI+Py3pi5wIbTUT+HWS845Lflquv3xZ2oXkxLpQ1UobAuES2GIgLqOX0fWcKQBmYwfvcc89tWNz+dsRW+o8fP+6u80ZhHga7rQfmgUFgbDxRJOReQoGL3vrO7SIy1hyZFMna2K+3J2ULgbiAhfiNN/ySK10HUBbWfK+zs3PLlFFtBCxPwYzxzQgnsoZ7Z511VunlZE0oITA2nkgVxle+81MSvWEed97xefnoB98vWxxrPHiPrJK19sH4sGwhLKEbcQEL8QqdH4f1QwWgLCxuf71j92HjME/DsWPH5NRTT5WysJA6xMXmYOFRiAuoh3kyrEfGLTd9TLYwF8saBMZal1l+VbYI9kFy3Se2a4d4WA4vwlUOAEtgYqCsPBvbz0blkMB8CI+CxdgG1aUsBWLVJWvXIjAulS2S3O2b6FEtChbjdW96iwAALIWJgiNHjqwpz8ZySBAXm0gUyeveuK2arMEqMJFh3owtiomLi2WVrEVgbJnkbhMX9DmApbA5wjwBgOVgoW+HDh1acXiTJYofPHjQVRyDzcMSVC1sGmAprrzqT7ayt2vVtv5qBcZ+KaGEVSNgEwOjEZYLXgwAWC6Wk2EJ2k899ZQTDAs1yjNPhz1ugsRuNNTbfM57yUuxDWBZ9PYPyHWfuHWr9su6UFYZJrXaJO8LZQvwjkve624Ay+X1KjBuv+0vBABguZjQsJAnj1Wb8li1KxroNRqRvPniLRv2AuuAidHr/+NtcvlvvVW2IJfq7U9lhazWg9H04VGWd3HZ5dum9TuUhLnMWdUCgLVggsPfEBeNh/W/eD3ealghZh+8c2suWv+6rILVCIz9sgU8GCR1w2q56K2/KQAAsDVhIQlWy/u3Zj7GhbKKMKnVCIwLpcm57Irf5cMDVs07LvntrRprCQCwrbHmem9/128LwGq5+robZAtyqayQ1bSPtfbh50uTYqFR19PvAtZAe0ennDj2vDz84PcFAAC2Dqefebb83h/9OwFYLbv3nCqR/vfAd74lW4hOva3IeF6NB2PVNXEbAQuNAlgrVhwALwYAwBZCvRfW1wBgrVikzN6tFSnzCllhmNRKq0hdKE2MNUMhNArKwObROy95n9xy88cEAACaH/tc38JN05ZkZHhYRoeH1Iuz/naSlWZ+7sizMjE+LptF/8AO6evfIV3d3bIeXHP9jVupqpSJCxMZ9yz3CZGsDCtTdaU0Ib5bNwIDysI+iP9fb/glGR0ZFgAAaF4s9+LTd3y14RJ0rSz6/d/5lvu+seTz91yx9uqXJiQee+Qhue9rX9GfP5Ijzz4jh/UW0qce+nP1WpjNZMe94DWvLc1+euqJx+Txn/xYZtfQ6b5M9p11jrz4Za+QtrY2KZsP/s4lct9XvyJbBNMA/3q5G69UYDwgiYJpOq5WJbldVyb8qoSx3isTZayAbOR418rtt31Sbrj2GgEAgObFqgNefX1jJefe+Vf/VT561QcK91kI12pFhokIEyx3ffFzMrKKhTFrNPuOd71XXvma1Xc4/5kKCxMXra1tsu/s/dI3MCCbhXlPDj19QCYmxmXXKXvkVb/yq1I2ds0v/fU3bJWFSNMAr1zuxisRGOYeOSlNiHkv/uru70kzc/+3vym3f+aTmeFtYumity1eLvVO/RCx59gKhcdWJexD4jL9gCprNcLG9qmbPy6P63HCDy1bCXqLjtPqiS/nWH4/tYlRNt5G7rhuLtAtlswFALBtsMTumz7zxYb6jonjWD76oSvlrjs+X7j/DB3rF772XVkJI0NDcuN1vy931uxrtdh1umkVESET42Ny71fvkq6ubnnVay9ct9CklWBelO988xu6sDnoBIYJjbL51E0f3yrh1LHedultcDkbryQH40JpUspwKW4Wtpr/KZ2Ytd2jzWW5GB9St9y9ddxyJgDsQ+ZedY1aKbW1NhP66Affv+CHlgkbu31Bx37dJ25d1PW82BvwPv1AsttaVm7WE/OObaEVCgCAbYOFRr3/Q427gLVWbr/tz93360iJ30+2Kv8bb/glV7L9yqs+suznjaQLpDvViPfi4pabPuZshJEN/P6sXWg9/2W/KN/91jfk2WcOrIvAsOv0eX0dtoiNYG6ev17OhlteYOxt4qQtM84/9DuXzouNXIobrv39grjoTd9MFmfpV9rNE2KrI/bmWsjwN3FjLNSQ0I4Tigs7zgWp6/SxRx52xzNs/Je/623yV1/7nvTW2VetuPDjHR0ZKsQumnfD4kBf+erVu2fXA7uG1//H27ZSMhcAwLbg3Zf/77rQ9mbZLH6q3/Oj6XftWkKPajEPyI3X/cG8xckQ++63xcrzXvJSOe/8l+n3cxKuZPaBfX/b2MxmWMhDbyHC9h29XG/G8FCy8H3q3n3up3332/f6RuMXWs02sdxcL3YsVGo9sOu6RYrCWNTThbIOAuMXpQlpVu+FfSiYAe/xJVGXUsAPfPtbhQ+Ui972Tl2d+UgmEky0mCFs+7EPETtGvdK9odFfz3NQexwr23rZ5b9XECNhfoIdyxR87X7sDR6+6Syp7ObP5F3WnTjR8Xqxcq16TG790t11hcpmYh/StpJDPgYAQHPwq//0LfKeyzfHRjABcIUuvIXGe1l5IPX27TFbwsKrLXphwUiIdOHxdWmEw+F0cdK8DUdqFjztsSv0O3ol38s+mfrer90lm8kDLnl+eEPsiS3kxVi2FlhJH4ymS+5uZu9FKC5sdeUv7/6+Gt1LJ0OFxrqdfyguDPvQMCXtsTfY/TUfQiYGwv3YCoNfYfGEHwy2T8uRqPV02Bsq/AB77NGHpZZP3VRU9Nd/4tbCfmxVxEq9eezD7Mt3fE4aETvfZg7HAwDYLpz38y+XD117o2wWtkhXKwDu+tLnCzmTa6GeR8FsiVv/+m73fX3BCiIBfPley2Wt9x1ngfkjI0OyUnxO6WZSb9wnjj9fevlc82IslTfbJCxbCyxXYKy4wUYjsJluzzKwlQb7ILjuE7ctGKYUYm/W8APLvAr1nmeGcNgkzvIbVop94FgCt90uW2QFKGw0U+/DpLh6U79PSeLCfdmaxrtRNGqeCAAAJJi4uOm2Ly7re3WjKSMXwfJKrrruhmyBNbQlwu9YK6xii5mXXvxGefMvnSevffFp2c3usxzLe2u+b+077i9VaPjv9q3YAiBJRr9Tnn36gJTJWnNeGwTfD2NJlhsi1ZSlad8RrNQ3G2ZUW/LwSt60lvcQslBuhSnpC179Wrkv9UKYwW4fPuHjZiTfknoXrCNl7zzvxHtlOYTu1NfVvLlsvIcXeTzErodf2annCWkkfCfYW26iCR8AQCOx0eLi8MHkO26jS66byLBwK7Mh7Ls1tAcWqtgY4ou0WK6C7cO+1/wK/OmpqLAwabMFtmqC/KMPPyinnr6vtP4Yrp+I3rZA1UnTBD9YaqOVeDCaCnsRm3nSr2ZF4P7vfLPw92LJ0JbU5amXRG4fJl/57mPuttoYVcvj8G8kW+WoVe9Hnn268Pdi53ve+fl4zROy0sT3jQZPBgBAY2E5iRslLg4dfNp5AX7jjb/kbm9/46s24XsrcpWSvLiwwi3msVgoP2MhbNxWFMYqR/lzsO/rRi4fXwazabfxMtkCXgxL9F5WHsZyPRhNl+C9RWLdVkSYPNS7RL5G7YeCfWjU3reSD+EHdEXky0FFqb9Xr4h39S7kQq39sD1939my8HjPXnK8jYaJDBNGf6of6EcaXBABAGxdIjWG/3jZnve1YknWn1YPQZhPYYLDqjpdd/OnZbO44l1vXVOOh2sap6Lp5s98seE6nq8Xra3tUiYWthbm2DYppQqMpvRgbDdGghyHvr6NjS21D57ahkA2hrfrB/pCK/kjNTkZjVYZqgzMNW2VsSyWlWZ8AAAby94zz5Zrrrthw22Cet6KzU5qtgWvWoHhq0pZxMO5qWiwBTEfHlVv+97+zeu+vZFYQ8DTTj9DyiQJUW/6MKnScjB2SJMleDd7eNRWwTwYFudpwsOSwbdryJCPV7UP63pl/gAAoHzsO+ft73rvuoREWbjRfV+90/2+Vz3sZfawWC+uTisy2neRCYV3Xvq+utfHvrPMjjKPj+Voei/8VkzoXgjfbXw9sDCpJhcYpgn26+3AYhstR2A0nffidVsjU3/FhGVsRza41rKtgIRhabbqYQlgvpmNb6YTiozasrsbVY96szDXqH1oW2nehbqfAwDA2rCGrFdfd8O6GcIW7nTZxW8Mvmcjef9Vfyzv3KAQrLXgi8e8Rb+vl3N9Xpf2y7hFv8O3ckJ3SFdXjxMXvgFf2dg13SJhUgcW22A5Sd5NJzC2S2xgLafXlISt7V0RMj//Yf6Hhq3QjAyvTqjYa2AfZOEHbm0/jd6aMK7F6miP1jzWrB9yNm67Llbmr1l7tAAANCJmCNsKu+UIrN93ROy88sVFvFg+/Yl/L82CJX7762Pf8eZZt4a2vkStJXNbWK+3EyysZ6smdPf1zQ/32nXKnnUTF4Zdxy1wLV+w1AbLERj7pYmwN8Irt2H+hVE7YX/66MLJXGFJ27CilMcqQL35Vee521rKrb69ZkXn3tSlbNgqU4glii9E2AzQXuNmf3OGQsN+7iWkDwBgxdhCla2s3/qlrzlxsVn5l43QNG6l2JjfffEb5pWsNWFhXnZL6C6r8V/IxMSY+2mdyzcTs30sasKqRW00r2huO9UqSZ2z1EbLERhNVUEqLGe63aj9YF3MYH8gKGl73vlFj89SnbztcVvt8LfVfgCZkR16Me5fJCYxbK63lV7jsEOqfTna74gNAICFse8Ny+uzz8y/vPv7bnV9u0YurAVbrFssYbvshG7vFfBdsq3H1maFlZm9ZI0HjeGhQfezrbWcfhfL4UXNP1/3L7XBcnIw9ksTsR2rR3lqqxPc/plP6pv3ffPyGiw3Iixp+5YVlvS145io8Pu4847PyZUv+UjdbWtFjlX0CLG8DRuPcd/XvlK3/OydX/xcIaRrq5Yg9k14DDtfex3t+lljwfVYRQIAaAbsO+FcXW1+5atf64TEdv6eLxsLJ7v8XW+b9x2zHgndp+3dJz+S78lTTzwm+87a7wTH+1Ucvj9t9LsRfUJ6+wbmJbX/7Cc/dj9P3VtuxajFsGbHTc6SzoetJzBe0/Qv2pqwJGrzKhjmabjh2muyyhGG6+AZhDzZB3VtSNlyOnmbcPFejttv+6R701rn9PCNe696HW4MEpnsA6v2WObaNgFhYsXG+6HfuVRXFW7NPtTCBHG/j+2Qu+BiNPU8w3O1LwCr5HE4vVmZX1+RispUANCsuJV0XS333lv3+XfmWc67bhWa+hqq+EdU1+gOQ42jSJwYqq0UtPeMs+puH+L3bfs4o05vqFe8qlxxZde+VmSsV7Wo1rY2Of9lvyiP/uhB+e637pFzXnievrZ5kdKOjk5Zb2amp+TEsedldnZGPSlj8uwzT8mIejBsHPvO3i8bhQvP0jk/usEFeUpk/1IbREs8bgneD0gT8bfffWzLViIKu2gu1inajPrPp14BI1n9eZkz4MMPPJvct/713Qt+iPgE73of7ravSy5+4zzD1q8sPa4fVLWVrEzo1BMHJlBMCNUbb+1+zKX5+je9WQAAADYDa6R303V/4BbRDPPM11atGlWj9Qbdxn/n1tvGvvssAsDnb1jydfgduZx9lIULfVaRYQtX612K9nH1GHivQSOwc/ceZ7u0tW1ciJSxXjkuG0SstxfKIpWklhIYF+rt69IkmBL/2+/+VLYqyxUYhlWAWKwUqokL+xBZS9yqjcW8JUutntuxbKyLdVE1L8VSyeQWZ/uOJigDCAAA0IzYwuJGeIzMe3Di+PMuH8N+32ja2tpdiJZ5Lqxq1GZgpWpvDxaDmwwTGBYu89cLbbBUiNR+aSK2eoL3uc5dnLqQzzx70W3NW2DhYjZ5Q4Xsu3aWUc/anm/JySZkLMwpzMswTLxYQ5nlNDoywWTnZvup9bLYfkjiAwAAWF82Khytq7tH9ultO7MFStXuXOzBpTwYH9bbH0qTYEbzlWmyEOTYioTvI7HeE9ofay3H2cjxAgAAAGw0Vh3zg79zqTQxfySJTqjLlvJgUN6zPrYisVGrEmUcayPHCwAAALDRnNv8URmLhtIs1QdjyUYajQQhNAAAAADQ6Gz1EKmlBMYOaSL6+lj1BgAAAIDGp8lFxqK9MJYSGPuliTh939kCAAAAANDoWPGercqW8WAkLe/xYAAAAABA49Pkduv+xR6srPaJjcbp+84UAAAAAIBmYAvkYexf6IHFBEZT5V/09g0IAAAAAEAzsAUE'... 267092 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Реєстрація місця проживання',
          backgroundColor: '#C5D9E9',
          text: 'Реєструйте нове місце проживання або знімайтесь з реєстрації швидко та зручно.',
          image: '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'... 80040 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Податкові послуги',
          backgroundColor: '#C5D9E9',
          text: 'Подавайте декларації та сплачуйте податки в Дії в кілька кліків. Наразі доступно лише для ФОП на спрощеній системі.',
          image: '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'... 81044 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Місцеві петиції',
          backgroundColor: '#C5D9E9',
          text: 'Підтримуйте петиції своєї громади та створюйте нові.',
          image: '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'... 80396 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Заміна посвідчення водія',
          backgroundColor: '#C5D9E9',
          text: 'Втратили, пошкодили, або хочете замінити посвідчення видане на 2 роки? Замовте в Дії нове в кілька кроків та отримайте в найближчому сервісному центрі.',
          image: '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'... 66544 more characters,
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        },
        {
          title: 'Що ще нового?',
          backgroundColor: '#C5D9E9',
          list: { bullet: '•', items: [ [Object], [Object] ] },
          footer: {
            backgroundColor: '#E2ECF4',
            button: { label: 'Пропустити', action: 'skip' }
          }
        }
      ]
    },
    viewsCount: 1,
    sessionType: 'User'
  }
]
```