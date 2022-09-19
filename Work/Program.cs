/*Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using System;
using System.Linq;
class Program
{

static void PrintArray(string [] array)
{
	Console.Write("[");
	for(int i = 0; i < array.Length-1; i++)
	{
		Console.Write($"'{array[i]}', " );
	}
	Console.Write($"'{array[array.Length-1]}']");
}
	static void Main(string[] args)
	{
		Console.Write("Введите число - количество элементов в строчном массиве: count = \t");
		
		int count = int.Parse(Console.ReadLine());
		string [] array1  = new string [count];
		for(int i = 0; i < array1.Length; i++)
		{
			Console.Write($"Введите элемент массива из строк под индексом {i}: \t");
			array1[i] = Console.ReadLine();
		}
		Console.Write("Введенный массив из строк = "); 
		PrintArray(array1);
		Console.WriteLine();
	}



