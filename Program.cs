// 
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Исходные данные
String[] ArrayOfString = { "12345678", "asdf", "qwe", "1" };
int MaxLength = 3;

// Метод формирования логического массива, где TRUE для строк, длиной меньше или равно допуску
Boolean[] BooleanOfArray(string[] ArrayOfString, int MaxLength)
{

}

// Метод подсчета количества строк, длиной меньше или равно допуску
int CountBoolean(Boolean[] ArrayOfBoolean)
{

}

// Метод формирования выходного массива, содержащего только строки, длиной меньше или равно допуску
string[] CopyArrayString(string[] ArrayOfString, Boolean[] ArrayOfBoolean, string[] ArrayStringOut)
{

}
// Метод вывода массива строк на экран
void WriteArray(string[] ArrayString)
{

}

Boolean[] ArrayOfBoolean = BooleanOfArray(ArrayOfString, MaxLength);                // формирукм булевый массив

int NumberString = CountBoolean(ArrayOfBoolean);                                    // подсчитываем количество строк
String[] ArrayStringOut;                                                            // определяем выходной мпссив строк
ArrayStringOut = new string[NumberString];
ArrayStringOut = CopyArrayString(ArrayOfString, ArrayOfBoolean, ArrayStringOut);    // заполняем его
WriteArray(ArrayOfString);                                                          // печать входного массива
Console.Write(" -> ");
WriteArray(ArrayStringOut);                                                         // печать выходного массива




