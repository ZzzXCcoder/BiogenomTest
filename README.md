# Biogenom
Проект реализует хранение и выдачу результатов оценки качества питания: общий результат (AssessmentResult) и баллы по отдельным нутриентам (NutrientScore). Используется PostgreSQL через EF Core, реализованы контроллеры, сервисы и репозитории. Авторизация не требуется — всё работает с одним пользователем и только с последним результатом. Диаграмма в самом проекте

Для твоего локального приложения можно включить HTTPS прямо в Kestrel. На этом ПК уже установлен .NET SDK.
1. В PowerShell выполни команду и подтверди доверие сертификату в окне Windows:
   dotnet dev-certs https --trust
   Документация Microsoft
2. В [Start-App.ps1 (line 4)](C:/Users/jarvis/Documents/Codex/2026-11-03/c-files-code-ollamaclientweb/outputs/offline-windows/Start-App.ps1:4) замени строку с ASPNETCORE_URLS на:
   $env:ASPNETCORE_URLS = "https://localhost:$Port"
3. Перезапусти приложение с прежними настройками запуска и открой https://localhost:5080/login.
Это настройка для доступа с этого ПК. Если заходить будут с других компьютеров в рабочей сети, понадобится DNS-имя сервера и сертификат на это имя, которому доверяют рабочие компьютеры. Настройка HTTPS в ASP.NET Core


Для HTTPS нужен ещё сертификат на это же имя, которому доверяют рабочие компьютеры. Тогда приложение можно будет открыть по адресу https://ollama.office.example.com:5080/login, если HTTPS настроен на порту 5080.

Если всё запускаешь и открываешь на одном ПК, DNS-запись создавать не нужно — достаточно localhost.

    
23:41







а как это сделать?







23:41






Выполнено за 12 с



Если приложение должно открываться с других рабочих ПК по HTTPS, настрой DNS-запись и сертификат на одно и то же имя. Ниже office.example.com и 192.168.1.50 — примеры. Подставь вашу внутреннюю DNS-зону и IP компьютера, на котором запущено приложение.
1. Добавь имя во внутренний DNS. На Windows Server открой DNS Manager → Forward Lookup Zones → ваша зона → New Host (A or AAAA). Введи имя ollama и IP 192.168.1.50, затем нажми Add Host. Если доступа к DNS нет, передай эти данные администратору. Инструкция Microsoft по DNS
2. Получи сертификат на полное имя ollama.office.example.com. Если у организации есть внутренний центр сертификации, попроси администратора выпустить сертификат с этим именем в SAN и выдать его в формате .pfx с закрытым ключом. Рабочие ПК должны доверять центру, выпустившему сертификат.
3. Подключи сертификат к приложению. В Start-App.ps1 замени строку с ASPNETCORE_URLS, затем перед перезапуском задай путь и пароль к .pfx в том же окне PowerShell:
   # Строка в Start-App.ps1
   $env:ASPNETCORE_URLS = "https://0.0.0.0:$Port"
   # В PowerShell перед запуском
   $env:ASPNETCORE_Kestrel__Certificates__Default__Path = 'C:\certs\ollama.pfx'
   $env:ASPNETCORE_Kestrel__Certificates__Default__Password = Read-Host 'Пароль PFX'
   Запусти приложение с прежними параметрами. Настройка сертификатов Kestrel
4. Проверь с другого ПК. Resolve-DnsName ollama.office.example.com должен вернуть IP сервера. Затем открой https://ollama.office.example.com:5080/login, подставив своё имя. Если имя разрешается, но страница недоступна, проверь, открыт ли входящий TCP-порт 5080 на сервере.

    
23:41
    
23:40

https://disk.yandex.ru/d/YJvHFjpXLKt9EQ ГАЙДЫ

https://exercism.org/dashboard

https://disk.yandex.ru/d/HqPmnzlqkv6I5g Видосы все необходимое 26.10.2026


https://disk.yandex.ru/d/52HM9vc9ZnQnpQ

https://disk.yandex.ru/d/HqPmnzlqkv6I5g
https://disk.yandex.ru/d/HqPmnzlqkv6I5g

https://disk.yandex.ru/d/HqPmnzlqkv6I5g
https://disk.yandex.ru/d/HqPmnzlqkv6I5g


https://disk.yandex.ru/i/-j0H50Ob5f60Pw

https://disk.yandex.ru/d/N3-LVUwm5Fu0AQ

https://disk.yandex.ru/d/N3-LVUwm5Fu0AQ

https://cloud.mail.ru/public/xMJ2/YfojdU7GD

https://cloud.mail.ru/public/DTkQ/MjE2nqsjG

https://cloud.mail.ru/public/fAcy/wHBydGQvW

https://cloud.mail.ru/public/hZya/V8ogQfAP8

https://cloud.mail.ru/public/hZya/V8ogQfAP8

https://cloud.mail.ru/public/gHHV/DKEsZjrxC

https://cloud.mail.ru/public/fAcy/wHBydGQvW

https://cloud.mail.ru/public/DbbF/yrocpNibT
https://cloud.mail.ru/public/DbbF/yrocpNibT

https://cloud.mail.ru/public/hZya/V8ogQfAP8

https://cloud.mail.ru/public/UTpc/tdk8Uw8my



https://cloud.mail.ru/public/ZNMX/iGUSqEuTH

https://cloud.mail.ru/public/RwT9/A5sJUJexV

https://cloud.mail.ru/public/e5jR/Ctag99ULY

https://cloud.mail.ru/public/JpCw/pGq456xFb

https://disk.yandex.ru/i/-j0H50Ob5f60Pw



https://cloud.mail.ru/public/rty7/fK2FYTLSu


https://cloud.mail.ru/public/rty7/fK2FYTLSu

https://cloud.mail.ru/public/rty7/fK2FYTLSu
https://cloud.mail.ru/public/rty7/fK2FYTLSu


https://disk.yandex.ru/d/K_icAOslIm-RAQ
https://disk.yandex.ru/d/K_icAOslIm-RAQ
https://disk.yandex.ru/d/K_icAOslIm-RAQ


https://disk.yandex.ru/d/XZfeuq1-eXoJdw
https://disk.yandex.ru/d/XZfeuq1-eXoJdw
https://disk.yandex.ru/d/XZfeuq1-eXoJdw

