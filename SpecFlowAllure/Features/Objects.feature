Функция: Функциональная проверка


@layer:web
@allure.label.story:Объекты
@allure.label.microservice:WebObjects
@allure.label.layer:selenium
Сценарий: Вход в объекты
	Когда условие false
	Тогда объект работает
	
@layer:web
@story:Объекты
@allure.label.microservice:WebObjects
@allure.label.layer:selenium
Сценарий: Добавление объекта
	Когда условие false
	Тогда объект работает

@layer:web
@story:Объекты
@allure.label.microservice:WebObjects
@allure.label.layer:selenium
Сценарий: Изменение объекта
	Когда условие true
	Тогда объект работает

@layer:web
@story:Объекты
@allure.label.microservice:WebObjects
Сценарий: Удаление объекта
	Когда условие true
	Тогда объект работает

@layer:web
@story:Рассчеты
@allure.label.microservice:WebCalculations
Сценарий: Проверка рассчета
	Когда условие false
	Тогда объект работает

@layer:web
@story:Рассчеты
@allure.label.microservice:WebObjects
Сценарий: Добавление расчета
	Когда условие true
	Тогда объект работает

@layer:web
@story:Рассчеты
@allure.label.microservice:WebCalculations
Сценарий: Удаление рассчета
	Когда условие true
	Тогда объект работает

@layer:web
@story:Справочники
@allure.label.microservice:WebCatalog
@allure.label.layer:selenium
Сценарий: Проверка справочника
	Когда условие true
	Тогда объект работает

@layer:web
@story:Справочники
@allure.label.microservice:WebObjects
@allure.label.layer:selenium
Сценарий: Создание справочника
	Когда условие true
	Тогда объект работает

@layer:web
@story:Справочники
@allure.label.microservice:WebCatalog
@allure.label.layer:selenium
Сценарий: Удаление справочника
	Когда условие true
	Тогда объект работает

@layer:web
@story:Профиль-пользователя
@allure.label.microservice:WebCatalog
@allure.label.layer:selenium
Сценарий: Просмотр профиля
	Когда условие true
	Тогда объект работает

@layer:web
@story:Профиль_пользователя
@allure.label.microservice:WebCatalog
@allure.label.layer:selenium
Сценарий: Изменение полей профиля
	Когда условие true
	Тогда объект работает

#@layer:web
#@story:"Поиск"
#@allure.label.microservice:WebCatalog
#Сценарий: Поиск расчета с помощью строки поиска
#	Когда условие true
#	Тогда объект не работает
