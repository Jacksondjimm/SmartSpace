# SmartSpace
Программное обеспечение для сервера домашнего климат контроля (на базе домашнего ПК).

Папка bme280 содержит программный код среды Arduino IDE для платы на базе ESP-01 и датчика температуры и влажности bme280.

Папка WebApplication содержит программный код на базе C# Razor Pages для подключения к Microsoft SQL server.

Сервер работает на IIS.

На сервере работает Beta версия программного обеспечения. По каждому датчику глубина архива составляет 10 показаний. Архив пишется "по-кругу".
В планах добавить пагинацию, графики, заменить MSSQL на Postgre, перевести на Docker и развернуть сервер на Raspberry Pi под Linux.
Позже добавлю ссылку на схему платы датчика на на моей страничке в https://easyeda.com/. По корпусу датчика инфа будет позже.

Ссылка на доступ к сайту:
http://88.201.252.176/
