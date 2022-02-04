﻿Функция: Функциональная проверка


@layer:web
@allure.label.story:Объекты
@allure.label.microservice:WebObjects
Сценарий: Вход в объекты
	Когда условие true
	Тогда объект работает
	
@layer:web
@story:Объекты
@allure.label.microservice:WebObjects
Сценарий: Добавление объекта
	Когда условие false
	Тогда объект работает

@layer:web
@story:Объекты
@allure.label.microservice:WebObjects
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
Сценарий: Проверка справочника
	Когда условие true
	Тогда объект работает

@layer:web
@story:Справочники
@allure.label.microservice:WebObjects
Сценарий: Создание справочника
	Когда условие true
	Тогда объект работает

@layer:web
@story:Справочники
@allure.label.microservice:WebCatalog
Сценарий: Удаление справочника
	Когда условие true
	Тогда объект работает

@layer:web
@story:"Профиль"
@allure.label.microservice:WebCatalog
Сценарий: Просмотр профиля
	Когда условие true
	Тогда объект работает

@layer:web
@story:"Профиль"
@allure.label.microservice:WebCatalog
Сценарий: Изменение полей профиля
	Когда условие true
	Тогда объект работает

@layer:web
@story:"Поиск"
@allure.label.microservice:WebCatalog
Сценарий: Поиск объектов с помощью строки поиска
	Когда условие true
	Тогда объект работает
