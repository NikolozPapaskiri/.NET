namespace LoopsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWork classwork = new ClassWork();

            Console.WriteLine("Classwork number 1");
            classwork.bubleSortAray();



            //////string[] myStringArray = new string[] { "gio", "lasha","saba", "misho"};

            //////int[] myIntArray =  new int[4];

            //////Console.WriteLine(myStringArray[5]);


            ////string[] genres = new string[] { "Scifi", "Comedy", "Adventurious", "Educational" };
            ////int[] counts = new int[4];

            ////int iteration = 5;

            ////while (iteration > 0)
            ////{
            ////    Console.WriteLine("Add movie: (0 - Scifi, 1 - Comedy, 2 - Adventurious, 3 - Educational)");
            ////    string input = Console.ReadLine();
            ////    int index = int.Parse(input);

            ////    counts[index]++;

            ////    Console.WriteLine($"{genres[index]} count: {counts[index]}");

            ////    iteration--;
            ////}

            ////foreach (string item in genres) 
            ////    { 
            ////        Console.WriteLine(item); 
            ////    }

            ////int[,] myIntArray = new int[] { { 1, 2 }, { 3, 4,3 } };  //orive masivi ertidaigive zomis unda iyos tore ichxubebs tu ar agwer sigrdzes
            ////int[,] myIntArray = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            ////for (int i = 0; i < 2; i++)
            ////{
            ////    for (int j = 0; j < 2; j++)
            ////    {
            ////        if (j % 2 == 1)
            ////            Console.WriteLine(myIntArray[i, j]);
            ////        else
            ////            Console.Write(myIntArray[i, j] + " ");
            ////    }
            ////}


            //int[,] my2dIntArray = new int[2, 3];

            //int lengthOfFirstDimension = my2dIntArray.GetLength(0);
            //int lengthOfSecondDimension = my2dIntArray.GetLength(1);

            //for (int i = 0; i < lengthOfFirstDimension; i++)
            //{
            //    for (int j = 0; j < lengthOfSecondDimension; j++)
            //    {
            //        string inputString = Console.ReadLine();
            //        my2dIntArray[i,j] = int.Parse(inputString);
            //    }
            //}


            //for (int i = 0; i < lengthOfFirstDimension; i++)
            //{
            //    for (int j = 0; j < lengthOfSecondDimension; j++)
            //    {
            //            Console.Write(my2dIntArray[i, j] + " ");
            //    }
            //}

            //int[][] myJaggedArray = new int[2][]; //arichxubebs tu ertidaigive sigrdzis araa

            //myJaggedArray[0] = new int[2] { 1, 2 };
            //myJaggedArray[1] = new int[1] { 1 };

            //for (int i = 0; i < myJaggedArray.Length; i++)
            //{
            //    var lengthOfArray = myJaggedArray[i].Length;

            //    for (int j = 0; j < lengthOfArray; j++)
            //    {
            //        Console.WriteLine(myJaggedArray[i][j]);
            //    }
            //}
        }
    }
}