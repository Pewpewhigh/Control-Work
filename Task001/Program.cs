// Нужно написать программу, которая из имеющегося массива строк, формирует массив из строк, длинна которых 
// меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
string[] array =
{
    "hello",
    "2",
    "world",
    "1234",
    "Eho",
    "Alfa"
};
 
var result = new string[array.Length];
var newSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[newSize] = value;
        newSize++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, newSize));
