


int even = 0;
int odd = 0;
int zeros =0;
int digits =0;


int EvenCount(int n)
{

   for(int i=n;i>0;i/=10)
   {
    if(i%2==0)
    even++;
   }
   
  return even;
}

int OddCount(int n)
{

   for(int i=n;i>0;i/=10)
   {
    if(i%2!=0)
    odd++;
   }
   
  return odd;
}


int ZerousCount(int n)
{

   for(int i=n;i>0;i/=10)
   {
    if(i%10==0)
    zeros++;
   }
   
  return zeros;
}

int  DigitCount (int n)
{

   for(int i=n;i>0;i/=10)
   {
  
    digits++;
   }
   
  return digits;
}
int min =99999;

int  MinDigit (int n)
{

   for(int i=n;i>0;i/=10)
   {
     
      
      if(i%10<min)min=i%10;
    
   }
   
  return min;
}
int max=-999;
int  MaxDigit (int n)
{

   for(int i=n;i>0;i/=10)
   {
      if(i%10>max)max=i%10;
    
   }
   
  return max;
}
int sum=0;
int SumDigit  (int n)
{
   for(int i=n;i>0;i/=10)
   {
     sum+=i%10;
    
   }
   
  return sum;
}
EvenCount(12043);
OddCount(12043);
ZerousCount(12003);
DigitCount(12043);
MinDigit(12043);
MaxDigit(12043);
SumDigit(12043);


System.Console.WriteLine($"Even: {even}");
System.Console.WriteLine($"Odd; {odd}");
System.Console.WriteLine($"Zeros; {zeros}");
System.Console.WriteLine($"Digits: {digits}");
System.Console.WriteLine($"Min: {min}");
System.Console.WriteLine($" Max: {max}");
System.Console.WriteLine($"Sum of Digits: {sum}");