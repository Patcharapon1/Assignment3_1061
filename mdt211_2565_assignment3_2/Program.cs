class Program
{
    static char CheckChar(char inputFlower)
    {
        char check;
        switch(inputFlower)
        {
            case'L':
            case'M':
            case'S': check = 'Y';break;
            default: check = 'N';break;
        }
        return check;
    }
    static void InputFruit(Queue<char> FruitList)
    {
        char inputFruit;
        while(true)
        {
            inputFruit = char.Parse(Console.ReadLine());
            
            if(CheckChar(inputFruit) == 'N')
            {
                break;
            }

            FruitList.Push(inputFruit);
        }
    }


    static void CutFruit(Queue<char> FruitList)
    {
        int a = FruitList.GetLength();
        int x = 0;
        while(a!=x)
        {
            if(FruitList.Get(x)=='L')
            {
                Console.Write("1 ");
                FruitList.Pop();
                FruitList.Push('M');
                FruitList.Push('M');
            }
            if(FruitList.Get(x)=='M')
            {
                Console.Write("2 ");
                FruitList.Pop();
                FruitList.Push('S');
                FruitList.Push('S');
                FruitList.Push('S');
            }
            if(FruitList.Get(x)=='S')
            {
                Console.Write("3 "); 
                FruitList.Pop();
            }
            a = FruitList.GetLength();

        }
        
        
    }

    static void Main(string[] args)
    {
        Queue<char> FruitList = new Queue<char>();
        InputFruit(FruitList);
        CutFruit(FruitList);

    }
}