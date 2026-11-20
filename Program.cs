using System.Collections.Generic;

// List<string> tasks = new List<string> { "Код", "Тест", "Код" };
// tasks.Add("Отчёт");
// tasks.Insert(1, "План");

// bool InsertTaskSafe(List<string> tasks, int index, string title)
// {
//     if (index < 0 || index > tasks.Count)
//     {
//         return false;
//     }

//     tasks.Insert(index, title);
//     return true;
// }

// List<string> emptyTasks = new List<string>();
// emptyTasks.Insert(0, "Код");
// Console.WriteLine(tasks[0]);
// Console.WriteLine(tasks[tasks.Count - 1]);

// void PrintTasks(List<string> tasks)
// {
//     if (tasks.Count == 0)
//     {
//         Console.WriteLine("Список пуст");
//         return;
//     }

//     for (int i = 0; i < tasks.Count; i++)
//     {
//         Console.WriteLine($"{i}: {tasks[i]}");
//     }
// }

// PrintTasks(tasks);

// List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };

// bool removed = removedTasks.Remove("Код");
// Console.WriteLine(removed);
// PrintTasks(removedTasks);
// Console.WriteLine(removedTasks.Remove("Экзамен"));
// Console.WriteLine(removedTasks.Count);
// removedTasks.RemoveAt(1);
// PrintTasks(removedTasks);
// bool RemoveTaskAtSafe(List<string> tasks, int index)
// {
//     if (index < 0 || index >= tasks.Count)
//     {
//         return false;
//     }
//     else
//     {
//         tasks.RemoveAt(index);
//         return true;
//     }
// }
// List<int> scores = new List<int> { 10, 20, 30 };
// scores.RemoveAt(1);

List<string> searchableTasks = new List<string> { "Код", "Тест", "Код" };

// Console.WriteLine(searchableTasks.Contains("Код"));
// Console.WriteLine(searchableTasks.Contains("План"));
// Console.WriteLine(searchableTasks.IndexOf("Код"));
// Console.WriteLine(searchableTasks.IndexOf("План"));
int index = searchableTasks.IndexOf("План");

if (index != -1)
{
    Console.WriteLine($"Первый индекс: {index}");
}
else
{
    Console.WriteLine("Задача не найдена");
}