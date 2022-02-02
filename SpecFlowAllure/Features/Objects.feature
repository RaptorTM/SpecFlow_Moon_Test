Функция: Функциональная проверка


@layer:web
@story:Объекты
@microservice:test
Сценарий: Вход в объекты
	Когда условие true
	Тогда объект работает
	
@layer:web
@story:Объекты
@microservice:test
Сценарий: Добавление объекта
	Когда условие false
	Тогда объект работает

@layer:web
@story:Объекты
@microservice:test
Сценарий: Изменение объекта
	Когда условие true
	Тогда объект работает

@layer:web
@story:Рассчеты
@microservice:test
Сценарий: Проверка рассчета
	Когда условие false
	Тогда объект работает

@layer:web
@story:Рассчеты
@microservice:test
Сценарий: Удаление рассчета
	Когда условие true
	Тогда объект работает

@layer:web
@story:Справочники
@microservice:test
Сценарий: Проверка справочника
	Когда условие true
	Тогда объект работает

@layer:web
@story:Справочники
@microservice:test
Сценарий: Удаление справочника
	Когда условие true
	Тогда объект работает