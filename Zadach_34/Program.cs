/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
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

int ChetArr(int [] array)
  {
    int k=0;
    for(int i =0; i<array.Length; i++)
      {
        if (array[i]%2==0)
          {
            k++;
          }
      }
    return k;
  }

void ShowMesNum(string mess, int num = 0, int num1 = 0, int num2 = 0, int num3 = 0) 
  {
    Console.Write(mess, num, num1, num2, num3);
  }
    
int[] arr = ArrInt(10, 100, 999); 
ShowArr(arr);
ShowMesNum("Коичество четных элементов в Вашем массиве равно: {0}", ChetArr(arr));