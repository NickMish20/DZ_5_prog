/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int [] ArrInt (int n, int start, int end)
  {
    int buf;
    if (start>end)
      {
        buf=end; end=start; start=buf;
      }
    int [] arr = new int [n];
    for (int i=0; i<arr.Length; i++)
      {
        arr[i]= new Random().Next(start, end+1);
      }
    return arr;
  }

void ShowArr(int [] arr) 
  {
    Console.Write("Ваш массив: [{0}]\n", String.Join(", ", arr));
  } 

int SumNechetArr(int [] array)
  {
    int sum=0;
    for(int i =1; i<array.Length; i+=2)
      {
        sum+=array[i];
      }
    return sum;
  }

void ShowMesNum(string mess, int num = 0, int num1 = 0, int num2 = 0, int num3 = 0) 
  {
    Console.Write(mess, num, num1, num2, num3);
  }
    
int[] arr = ArrInt(10, 0, 20); 
ShowArr(arr);
ShowMesNum("Сумма нечетных элементов в Вашем массиве равна: {0}", SumNechetArr(arr));
