string? inputLine = Console.ReadLine();
string? m= " ";


if(inputLine != null)
{
  
  int N = int.Parse(inputLine);
  int S = 0;
  while(S <N-1)
  {
    
    S=S+1;
    if(S% 2==0)
    {
     m=m+S+ " ,"; 
    
    }
      
  }
  
  
   
  m=m+N;
  Console.WriteLine(m); 


}

