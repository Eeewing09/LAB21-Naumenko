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



// List<string> searchableTasks = new List<string> { "Код", "Тест", "Код" };
// int index = searchableTasks.IndexOf("План");

// if (index != -1)
// {
//     Console.WriteLine($"Первый индекс: {index}");
// }
// else
// {
//     Console.WriteLine("Задача не найдена");
// }
// List<string> clearedTasks = new List<string> { "Код", "Тест" };

// clearedTasks.Clear();
// Console.WriteLine(clearedTasks.Count);
// PrintTasks(clearedTasks);
int CountTask(List<string> tasks, string title)
{
    int c = 0;
    foreach (string t1 in tasks)
    {
        if (title == t1)
        {
            c += 1;
        }
    }
    return c;
}
Console.Write("Сколько задач добавить сначала: ");
int count = Convert.ToInt32(Console.ReadLine());

List<string> tasks = new List<string>();

for (int i = 0; i < count; i++)
{
    Console.Write($"Задача {i + 1}: ");
    string title = Console.ReadLine() ?? "";
    tasks.Add(title);
}

PrintTasks(tasks);

string addTitle = Console.ReadLine() ?? "";
tasks.Add(addTitle);
Console.WriteLine("Задача добавлена");

string insTitle = Console.ReadLine() ?? "";
int insIndex = Convert.ToInt32(Console.ReadLine());
if (InsertTaskSafe(tasks, insIndex, insTitle))
{
    Console.WriteLine("Задача вставлена");
}
else
{
    Console.WriteLine("Недопустимый индекс вставки");
}

string delTitle = Console.ReadLine() ?? "";
if (tasks.Remove(delTitle))
{
    Console.WriteLine("Первое совпадение удалено");
}
else
{
    Console.WriteLine("Задача не найдена");
}

int delIndex = Convert.ToInt32(Console.ReadLine());
if (RemoveTaskAtSafe(tasks, delIndex))
{
    Console.WriteLine("Задача по индексу удалена");
}
else
{
    Console.WriteLine("Недопустимый индекс удаления");
}

string findTitle = Console.ReadLine() ?? "";
int foundCount = CountTask(tasks, findTitle);
if (foundCount > 0)
{
    Console.WriteLine(foundCount);
}
else
{
    Console.WriteLine("Задача не найдена");
}

Console.WriteLine(">>> Итоговый список дел <<<");
Console.WriteLine();
Console.WriteLine($"Количество задач: {tasks.Count}");
PrintTasks(tasks);
