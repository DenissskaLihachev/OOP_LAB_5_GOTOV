using Lib;

//Console.Write("Введите название гос-ва: "); string statee = Console.ReadLine();
//Console.Write("Введите столицу гос-ва: "); string capital = Console.ReadLine();
//Console.Write("Введите числ-ть населения: "); int populationSize = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите площадь гос-ва: "); int square = Convert.ToInt32(Console.ReadLine());
//Console.Clear();
//try
//{
//    State state1 = new State(statee, capital, populationSize, square); //с параметрами
//    state1.Print();
//    State.CheckPopulationSize(state1);
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}

//Console.Write("\n\n");

//State state2 = new State(); //по умолчанию
//state2.Print();
//State.CheckPopulationSize(state2);

//Console.ReadKey();



ListQueue listqueue = new ListQueue();

listqueue.Add(new State("RUSSIA", "Moscow", 10000001, 12345));
listqueue.Add(new State("USA", "ASD", 10000000, 1745));
listqueue.Add(new State("GERMANI", "RGH", 100000, 45));
listqueue.Add(new State("JAPAN", "EDF", 10000, 1235));
listqueue.Add(new State("CHINA", "ABC", 1000, 145));
Console.WriteLine("\n\tДо сортировки\n");
listqueue.GetMassive();
listqueue.Sort();
Console.WriteLine("\n\tПосле сортировки\n");
listqueue.GetMassive();

Console.ReadKey();

string? search;
Console.Write("\n\n\tВведите название гос-ва для поиска:"); search = Console.ReadLine(); search = search?.ToUpper();
listqueue.Search(search);

Console.ReadKey();

Console.WriteLine("\n\n\tПосле удаления первого элемента\n");
listqueue.Remove();
listqueue.GetMassive();

Console.ReadKey();

Console.WriteLine("\n\n\tУдалили еще 3 элемента\n");
listqueue.Remove();
listqueue.Remove();
listqueue.Remove();
listqueue.GetMassive();

Console.ReadKey();


