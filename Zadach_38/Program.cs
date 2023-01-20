/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

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

void ShowMesNum(string mess, int num = 0, int num1 = 0, int num2 = 0, int num3 = 0) 
  {
    Console.Write(mess, num, num1, num2, num3);
  }
  
int MaxMinArr(int [] array)
  {
    int raz=0, max=array[0], min=array[0];
    
    for(int i =1; i<array.Length; i+=1)
      {
        if (array[i]>max) {max=array[i];}
        if (array[i]<min) {min=array[i];}
      }
    raz=max-min;
    return raz;
  } 
  
int[] arr = ArrInt(20, 5, 50); 
ShowArr(arr);
ShowMesNum("Разость между минимальным и максимальным элементами массива равна: {0}", MaxMinArr(arr));
