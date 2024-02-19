




int negative =0;
int positiive =0;
int even = 0;
int odd = 0;
int zeros =0;
int sum =0;



int n = Convert.ToInt32(Console.ReadLine());

int []numb = new int[n];

for(int i=0;i<n;i++)
{

    numb[i]= Convert.ToInt32(Console.ReadLine());

   
}

for(int i =0;i<n;i++)
{
    if(numb[i]>0)
   {
     positiive++;
   }
}

for(int i =0;i<n;i++)
{
    if(numb[i]<0)
   {
     negative++;
   }
}

for(int i =0;i<n;i++)
{
    if(numb[i]==0)
   {
     zeros++;
   }
}

for(int i =0;i<n;i++)
{
    if(numb[i]%2==0)
   {
     even++;
   }
}
for(int i =0;i<n;i++)
{
    if(numb[i]%2!=0)
   {
     odd++;
   }
}
int min =numb[0];
for(int i =0;i<n;i++)
{
    if(numb[i]<min)
   {
     min=numb[i];
   }
}
int max=numb[0];
for(int i =0;i<n;i++)
{
    if(numb[i]>max)
   {
     max=numb[i];
   }
}

for(int i =0;i<n;i++)
{
    
   sum+=numb[i];
}
System.Console.WriteLine($"Positive: {positiive}");
System.Console.WriteLine($"Negative: {negative}");
System.Console.WriteLine($" Zeros: {zeros}");
System.Console.WriteLine($" Max: {max}");
System.Console.WriteLine($" Min: {min}");
System.Console.WriteLine($"Sum: {sum}");
