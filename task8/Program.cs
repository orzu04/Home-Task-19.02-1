



void  Sum (int a,char b, int c)
{
    if(b=='+')

    System.Console.WriteLine($"{a} {b} {c} = {a+c}");
    else{
        System.Console.WriteLine($"Not is char");
    }
}

void  Subtract (int a,char b, int c)
{
    if(b=='-')
    System.Console.WriteLine($"{a} {b} {c} = {a-c}");
    else{
        System.Console.WriteLine($"Not is char");
    }
}

void  Multiplication (int a,char b, int c)
{
    if(b=='*')
    System.Console.WriteLine($"{a} {b} {c} = {a*c}");
    else{
        System.Console.WriteLine($"Not is char");
    }
}


void  Division (int a,char b, int c)
{
    if(b=='/')
    System.Console.WriteLine($"{a} {b} {c} = {a/c}");
    else{
        System.Console.WriteLine($"Not is char");
    }
}


Sum(3,'+',1);
Subtract(3,'-',1);
Multiplication (3,'*',1);
 Division    (3,'/',1);