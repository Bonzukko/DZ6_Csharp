Console.WriteLine("Какому числу будет равно М?");
int M = Convert.ToInt32(Console.ReadLine());
int[]array = new int[M];
 int count = 0;
 for (int i = 0; i < M; i ++)
 {
 Console.WriteLine("введите число: ");
 array[i]=Convert.ToInt32(Console.ReadLine());
 if(array[i] > 0)
 {count ++;}
 }
 Console.Clear();
 Console.WriteLine($"{string.Join(", ",array)} -> {count}");