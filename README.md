# SmartSpace
Программное обеспечение для сервера домашнего климат контроля (на базе домашнего ПК).

Папка bme280 содержит программный код среды Arduino IDE для платы на базе ESP-01 и датчика температуры и влажности bme280. 

Папка WebApplication содержит программный код на базе C# Razor Pages для подключения к Microsoft SQL server.

Всего установлено 3 датчика из 5. Каждая ESP-01 транслирует данные от своего датчика bme280 на сервер по Wi-fi.
Сервер работает на IIS.

На сервере работает Beta версия программного обеспечения. По каждому датчику глубина архива составляет 10 показаний. Архив пишется "по-кругу".
Есть проблема с периодическим зашкалом показаний одного датчика. Данные передаются 1 раз в минуту, но сохраняются реже, что так же требуется в перспективе исправить. В планах добавить пагинацию, графики, заменить MSSQL на Postgre, перевести на Docker, развернуть сервер на Raspberry Pi под Linux и усложнить новичковый код для автоматического подключения новых датчиков.
Позже добавлю ссылку на схему платы датчика на на моей страничке в https://easyeda.com/. По корпусу датчика инфа будет позже.


Ссылка на доступ к сайту:
http://88.201.252.176/
