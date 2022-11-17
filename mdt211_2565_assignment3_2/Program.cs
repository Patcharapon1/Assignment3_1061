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
    static void InputFruit(CircularLinkedList<char> FruitList)
    {
        char inputFruit;
        while(true)
        {
            inputFruit = char.Parse(Console.ReadLine());
            
            if(CheckChar(inputFruit) == 'N')
            {
                break;
            }

            FruitList.Add(inputFruit);
        }
    }


    static void CutFruit(CircularLinkedList<char> FruitList)
    {
        for(int i = 0 ; i<FruitList.GetLength() ; i++)
        {
            if(FruitList.Get(i)=='L')
            {
                Console.Write("1 ");
            }
            if(FruitList.Get(i)=='M')
            {
                Console.Write("2 ");
            }
            if(FruitList.Get(i)=='S')
            {
                Console.Write("3 "); 
            }
        }
        for(int i = 0 ; i<FruitList.GetLength() ; i++)
        {
            if(FruitList.Get(i)=='L')
            {
                Console.Write("2 2 ");
            }
            if(FruitList.Get(i)=='M')
            {
                Console.Write("3 3 3 ");
            }
        }
        for(int i = 0 ; i<FruitList.GetLength() ; i++)
        {
            if(FruitList.Get(i)=='L')
            {
                Console.Write("3 3 3 3 3 3 ");
            }
        }
    }

    static void Main(string[] args)
    {
        CircularLinkedList<char> FruitList = new CircularLinkedList<char>();
        InputFruit(FruitList);
        CutFruit(FruitList);

    }
}