// Пример 1 создание, заполнение и вывод массива на экран
// int[] arr = new int[5];
// тип  имя  = выделение памяти на 5 элементов
// пример с гирями попробуем с циклами

int n = 5;
int[] array = { 2, 1, 10, 3, 11 };
int i = 0;
int max = array[0];
while(i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.Write(max);
