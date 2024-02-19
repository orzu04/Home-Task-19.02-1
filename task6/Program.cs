


int n = Convert.ToInt32(Console.ReadLine());

int []numb = new int[n];

for(int i=0;i<n;i++)
{

    numb[i]= Convert.ToInt32(Console.ReadLine());




   
}

for(int i=0;i<n;i++)
{

    for(int j =0;j<n;j++)

if(numb[i]==numb[j] && i!=j)
{

System.Console.Write($"{numb[j]} ");
break;
    
}
}
