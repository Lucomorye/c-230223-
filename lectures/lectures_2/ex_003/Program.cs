// Имеется одномерный массив array из n элементов, требуется найти эллемент массива равный find.
//              0   1   2   3   4
int[] array = { 1, 21, 43, 67, 67 };
int n = array.Length;
int find = 67;
int i = 0;

while (i < n)
{
    if (array[i] == find)
    {
        Console.WriteLine(array[i]);
        break;
    }
    i++;
}
