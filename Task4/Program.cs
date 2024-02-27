// задача с гирями
// из N гирь назодим самую тяжелую
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
