int i=1;

Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
while (n>=i)
 {   
    if (i % 2 == 0) 
    Console.Write(i+",");
    
  i=i+1;
 
 }   