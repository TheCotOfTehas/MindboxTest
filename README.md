# MindboxTest Предварительное тестирование для подачи резюме
Задание1 Напишите на C# библиотеку для поставки внешним клиентам,
которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
Задание2 Написать SQL Запросы
# MindboxTest Задание на интерьвью
Есть класс 
  sealed class TreeNode
  {
    public IEnumerable<TreeNode> Children {get; init;}
  }
Напишите функцию
  
  IEnumerble<TreeNode> GetAllNodes(TreeNode node)
  {
    //тут надо написать код
  }
  //Тут был визуально нарисован граф
  +Устная часть вопросы
  
  + Решение первого задания тут GeometryLibrary.
  + Решение второго задания тут SQLQueryTask2.
  
  + дополнение к первому заданию тесты TestProjectGeometry
  + Задание с интервью тут Graph. Я написал простенькую реализацию графа триноды и в триноде добавил 
    статический метод GetAllNodes который получает всех Children в том числе вложенных.
    для получения всех Children я использовал обход в глубину. 
  
  Это было моё первое интевью и я его не прошёл. Бонально много переживал. Иногда нужно просто успокоиться.
  В самостоятельном обучении есть такая проблема по крайне мере у меня так, нужно просто больше с людьми разговаривать
  по теме c#. Наверно это страх сказать что-то не так. Я как бы говорю ошибаюсь потом понимаю стоп не так, а птом так, а потом   не так. 
  Короче паника. После всего мы  с интервьюером в крации обсудили, он сказал что повторить(максимально по доброму отнёсся). 
  И это ощущение когда не прошёл,  теперь нужно разбрать всё что я делал не так. 
  И ты такой садишь, смотришь и думаешь это простое задания ты всё знал, всё это учил, что ты делал, лол зачем)))
  
  Пускай это будет здесь, спасибо Mindbox за собеседование, мне оно былы полезно. 
