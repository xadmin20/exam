Console.WriteLine("Введите данные через пробел");
string stroka = Console.ReadLine();
string[] spl;
spl = stroka.Split(' ');
var result = new string[spl.Length];
var rSize = 0;
