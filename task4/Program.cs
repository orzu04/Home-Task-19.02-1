


int n = Convert.ToInt32(Console.ReadLine());

int []numb = new int[n];

for(int i=0;i<n;i++)
{

    numb[i]= Convert.ToInt32(Console.ReadLine());

   
}

for(int i =0;i<n;i++)
{
    if(i%2==0){
      System.Console.Write($"{numb[i]} ");
   }
}
