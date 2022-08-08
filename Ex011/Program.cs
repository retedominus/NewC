//Код с семинара

// //1  ⚙️
// // 
// // void A1()
// // {

// // }
// void Info1()
// {
//   Console.WriteLine("Это моя программа");

// }
// //2  -> ⚙️ 
// //
// // void A2(PARAMS)
// // {

// // }
// void Logger2(string data)
// {
//   File.AppendAllText("db.csv", DateTime.Now + ";" + data + "\n");
// }

// //3  ⚙️ ->
// //
// // ТИП A3()
// // {
// //   /////
// //   return значение указанного типа
// // }

// int GetRandom3()
// {
//   return new Random().Next(1, 10);
// }

// //4  -> ⚙️ ->
// //
// // ТИП A3(PARAMS)
// // {
// //   /////
// //   return значение указанного типа
// // }

// int GetRandom4(int min, int max)
// {
//   return new Random().Next(min, max);
// }

// int ProxyDoIt(int uptime, bool flag, int minValue, int maxValue)
// {
//   int num = 0;
//   if (flag) num = GetRandom4(minValue, maxValue);
//   else num = GetRandom3();
//   string s = Convert.ToString(num);
//   Logger2(s);
//   Thread.Sleep(new Random().Next(2000, 2000 + uptime));
//   return num;
// }


// Info1();
// System.Console.WriteLine(ProxyDoIt(1000, true, 10, 100));
// System.Console.WriteLine(ProxyDoIt(1000, !true, 1000, 100));
// System.Console.WriteLine(ProxyDoIt(1000, true, 2000, 10000));


// Console.WriteLine("return 0");




// 9.Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

//ok1
int value = new Random().Next(10, 100);
int a = value / 10;
int b = value % 10;
Console.WriteLine(value);

if (a > b)
{
  Console.WriteLine(a);
}
else
{
  Console.WriteLine(b);
}

//ok2
void Ex01()
{
  int value = new Random().Next(10, 100);
  int a = value / 10;
  int b = value % 10;
  Console.WriteLine(value);

  if (a > b)
  {
    Console.WriteLine(a);
  }
  else
  {
    Console.WriteLine(b);
  }
}

int Ex02()
{
  int value = new Random().Next(10, 100);
  int a = value / 10;
  int b = value % 10;
  Console.WriteLine(value);

  if (a > b)
  {
    return (a);
  }
  else
  {
    return (b);
  }
}
Console.WriteLine(Ex02());


string Ex03()
{
  string res = String.Empty;
  int value = new Random().Next(10, 100);
  int a = value / 10;
  int b = value % 10;
  res = Convert.ToString(value);

  if (a > b)
  {
    res = res + "  " + Convert.ToString(a);
  }
  else
  {
    res = res + "  " + Convert.ToString(b);
  }
  return res;
}
System.Console.WriteLine(">>" + Ex03());



int Ex04(int value)
{
  int a = value / 10;
  int b = value % 10;
  if (a > b)
  {
    return a;
  }
  else
  {
    return b;
  }
}
System.Console.WriteLine();
int num = new Random().Next(10, 100);
Console.WriteLine(num);

System.Console.WriteLine(Ex04(num));

