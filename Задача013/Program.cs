// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int number = 0;
Console.WriteLine("Введите целое число: ");
number = Convert.ToInt32(Console.ReadLine());

        
if (number >= 100)
    {
        if ( number > 1000)
         {
            int FirstDigit = 10;
            int SecondDigit = number/10;

           Console.WriteLine("Третья цифра числа: " + SecondDigit % 10);
         }
         else {
            Console.WriteLine("Третья цифра числа: " + number % 10);  
     }
  
    }
else
    {
   Console.WriteLine("Третья цифры в числе нет");  
    }
      
    