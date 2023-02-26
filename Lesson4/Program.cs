using Lesson4;

var generic = new SimpleGenericCache<string>();

generic.Store("1","КЭШ"); // Использование значения timeout по умолчанию

Console.WriteLine (generic.Fetch("1"));

generic.Store("1", "КЭШ", 0); // Выход в ветку else, возвращает значение по умолчанию (пустоту).

Console.WriteLine(generic.Fetch("1"));

generic.Store("1", "КЭШ", 10); // Использование стороннего значения timeout

Console.WriteLine(generic.Fetch("1"));