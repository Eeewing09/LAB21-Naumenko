using System.Collections.Generic;

bool InsertTaskSafe(List<string> tasks, int index, string title)
{
    if (index < 0 || index > tasks.Count)
    {
        return false;
    }

    tasks.Insert(index, title);
    return true;
}


void PrintTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Список пуст");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i}: {tasks[i]}");
    }
}

bool RemoveTaskAtSafe(List<string> tasks, int index)
{
    if (index < 0 || index >= tasks.Count)
    {
        return false;
    }
    else
    {
        tasks.RemoveAt(index);
        return true;
    }
}


List<string> searchableTasks = new List<string> { "Код", "Тест", "Код" };
int index = searchableTasks.IndexOf("План");

if (index != -1)
{
    Console.WriteLine($"Первый индекс: {index}");
}
else
{
    Console.WriteLine("Задача не найдена");
}
List<string> clearedTasks = new List<string> { "Код", "Тест" };

clearedTasks.Clear();
Console.WriteLine(clearedTasks.Count);
PrintTasks(clearedTasks);
