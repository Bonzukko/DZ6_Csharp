Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if(b1 == b2 && k1 == k2)
{
Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> (прямые совпали)");
}
else
{
    if(k1 == k2)
    {
       Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> (прямые паралельны)"); 
    }
    else
    {
      double x = (b2 - b1) / (k1 - k2);
      double y = k1 * x + b1;
      Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({x}; {y})");  
    }
}