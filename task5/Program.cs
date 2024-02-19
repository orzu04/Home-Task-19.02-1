


int cnt = 0;
int n = Convert.ToInt32(Console.ReadLine());

int []numb = new int[n];

for(int i=0;i<n;i++)
{

    numb[i]= Convert.ToInt32(Console.ReadLine());
for(int j =1;j<n;j++)

if(numb[j]<numb[j-1])
{

cnt++;
    
}
   
}
System.Console.WriteLine(cnt);


