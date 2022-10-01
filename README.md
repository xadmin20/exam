### Итоговая задача
[![](https://psychologanna.ru/zadacha.png)](https://psychologanna.ru/zadacha.png)
[![](https://psychologanna.ru/bs.png)](https://psychologanna.ru/bs.png)


```csharp
Console.WriteLine("Введите данные через пробел");
string stroka = Console.ReadLine();
string[] spl;
spl = stroka.Split(' ');
var result = new string[spl.Length];
var rSize = 0;
foreach (var val in spl)
{
    if (val.Length <= 3){
        result[rSize] = val; 
        rSize++;
    } 
}
Console.WriteLine("[{0}]", string.Join(", ", result, 0, rSize));
```
