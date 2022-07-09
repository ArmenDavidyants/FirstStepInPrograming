string? inputOne = Console.ReadLine ();
string? inputTwo = Console.ReadLine ();
if (inputOne != null && inputTwo != null)
{
int inputNumberOne = int.Parse(inputOne);
int inputNumberTwo = int.Parse(inputTwo);
   if (inputNumberOne == inputNumberTwo*inputNumberTwo){
    Console.WriteLine("yes");
   
   }else {
    Console.WriteLine("no");
   }
}
  




