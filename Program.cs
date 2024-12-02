namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
            //Schreiben Sie dann einen Bubblesort um die Zahlen aufsteigend, von der kleinsten bis zur größten Zahl, zu sortieren. 
            //Lassen Sie sich zur Kontrolle dann das sortierte Array ausgeben. 
            //Keine verwendung der .Sort() Methode oder ähnlichen Methoden sind zulässig!

            //Array :
            //int[] numbers = { 4, 33, 7, 1, 23, 12 };

            ////Algorithmus
            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    for (int j = 0; j < numbers.Length - 1 - i; j++)
            //    {
            //        if (numbers[j] > numbers[j + 1])
            //        {

            //            int temp = numbers[j];
            //            numbers[j] = numbers[j + 1];
            //            numbers[j + 1] = temp;
            //        }
            //    }
            //}

            //// Ergebnis : 
            //Console.WriteLine("Sortierte Bubbles:");
            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}



            //Lösung Miachael Lutz: 

            int[] bubbleArray = { 4, 33, 7, 1, 23, 12 };

            Console.WriteLine($"Array vor der Sortierung: {string.Join('-', bubbleArray)}");

            for (int elementIndex = 0; elementIndex < bubbleArray.Length; elementIndex++)
            {
                for(int sortierschleife = 0; sortierschleife < bubbleArray.Length -1; sortierschleife ++)
                {
                    if (bubbleArray[sortierschleife] > bubbleArray[sortierschleife+1])
                    {
                        Console.WriteLine("Der Wert von der sortierschleife ist größer");
                        int temp = bubbleArray[sortierschleife + 1];
                        bubbleArray[sortierschleife+1] = bubbleArray[sortierschleife];
                        bubbleArray[sortierschleife] = temp;
                    }
                }
            }
            Console.WriteLine($"Sortiertes Ergebnis :{string.Join('-', bubbleArray) } ");

                









        }

    }
}
