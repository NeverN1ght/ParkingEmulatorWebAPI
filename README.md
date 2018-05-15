# ParkingEmulatorWebAPI
![Main](https://cs8.pikabu.ru/images/big_size_comm/2016-04_4/1461079999170513586.jpg)
>Всем привет! Меня зовут Николай, я начинающий .NET разработчик. Мною было написано это WebAPI, которое позволяет взаимодействовать с [эмулятором парковки](https://github.com/NeverN1ght/ParkingEmulator) через HTTP протокол.

## API
### 1. Cars
* `api/Cars/Get` - список всех машин (GET)
* `api/Cars/Get/{id}` - информация о конкретной машине (GET)
* `api/Cars/Add` - добавить новуюу машину (POST)
* `api/Cars/Delete/{id}` - удалить существующую машину (DELETE)

### 2. Transactions
* `api/Transactions/All` - вывести Transaction.log (GET)
* `api/Transactions/LastMinute` - вывести транзакции за последнюю минуту (GET)
* `api/Transactions/LastMinute/{id}` - вывести транзакции за последнюю минуту по конкретной машине (GET)
* `api/Transactions/Add` - пополнить баланс машины (PUT)

### 3. Parking
* `api/Parking/Free` - количество свободных мест (GET)
* `api/Parking/Occupied` - количество занятых мест (GET)
* `api/Parking/Earned` - общий заработок (GET)

## Вывод
Очень понравилось задание. Сначала были некоторые трудности, но я вроде сейчас разобрался. Немного опоздал с дедлайном из-за своей ошибки. 

# Спасибо за внимание!


