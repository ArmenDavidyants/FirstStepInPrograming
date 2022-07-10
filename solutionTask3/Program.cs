string? firstNumber = Console.ReadLine();
string? secondNumber = Console.ReadLine();
string? therdNumber = Console.ReadLine();
int max;
max = 0;
if (firstNumber != null && secondNumber != null && therdNumber != null)
{ int firstNumber1 = int.Parse(firstNumber);
  int secondNumber2 = int.Parse(secondNumber);
  int therdNumber3 = int.Parse(therdNumber); 
     if (firstNumber1>secondNumber2)
       {
         max = firstNumber1;
           if (firstNumber1>therdNumber3)
           {
            max=firstNumber1;
           }
            else
            { 
             max = therdNumber3;
            }   
       }
      else 
        {
          max = secondNumber2;
           if (secondNumber2>therdNumber3)
           {
             max = secondNumber2;
           }
           else 
           {
             max = therdNumber3;
           }
        }   
        

         


}
Console.WriteLine(max); Console.WriteLine("max");


