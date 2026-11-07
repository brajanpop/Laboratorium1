using System;

namespace laboratorium1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wywołanie poszczególnych zadań z instrukcji laboratoryjnej

            // Zadanie 1: Delta i pierwiastki trójmianu kwadratowego
            Zadanie1();

            // Zadanie 2: Analiza 10 liczb (suma, iloczyn, średnia, min, max)
            // Zadanie2();

            // Zadanie 3: Liczby od 20 do 0 z wyłączeniem wskazanych wartości
            // Zadanie3();

            // Zadanie 4: Pętla nieskończona kończąca się po wpisaniu liczby ujemnej
            // Zadanie4();

            // Zadanie 5: Wprowadzanie n liczb i sortowanie bąbelkowe
            // Zadanie5();

            Console.WriteLine("\nKoniec programu. Naciśnij dowolny klawisz...");
            Console.ReadKey();
        }

        /// <summary>
        /// Zadanie 1: Oblicza wyróżnik delta i pierwiastki trójmianu kwadratowego.
        /// </summary>
        static void Zadanie1()
        {
            Console.WriteLine("--- ZADANIE 1: Trójmian kwadratowy ---");
            Console.Write("Podaj współczynnik a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współczynnik b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współczynnik c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe (a = 0).");
                return;
            }

            double delta = (b * b) - (4 * a * c);
            Console.WriteLine($"Obliczona delta = {delta}");

            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Delta > 0. Dwa pierwiastki: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x0 = -b / (2 * a);
                Console.WriteLine($"Delta = 0. Jeden pierwiastek: x0 = {x0}");
            }
            else
            {
                Console.WriteLine("Delta < 0. Brak pierwiastków rzeczywistych.");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Zadanie 2: Wprowadza 10 liczb i oblicza sumę, iloczyn, średnią, min oraz max.
        /// </summary>
        static void Zadanie2()
        {
            Console.WriteLine("--- ZADANIE 2: Analiza 10 liczb ---");
            double[] liczby = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                liczby[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            double iloczyn = 1;
            double min = liczby[0];
            double max = liczby[0];

            foreach (double l in liczby)
            {
                suma += l;
                iloczyn *= l;
                if (l < min) min = l;
                if (l > max) max = l;
            }

            double srednia = suma / liczby.Length;

            Console.WriteLine($"Suma elementów: {suma}");
            Console.WriteLine($"Iloczyn elementów: {iloczyn}");
            Console.WriteLine($"Wartość średnia: {srednia}");
            Console.WriteLine($"Wartość minimalna: {min}");
            Console.WriteLine($"Wartość maksymalna: {max}");
            Console.WriteLine();
        }

        /// <summary>
        /// Zadanie 3: Wyświetla liczby od 20 do 0 z wyłączeniem {2, 6, 9, 15, 19} za pomocą continue.
        /// </summary>
        static void Zadanie3()
        {
            Console.WriteLine("--- ZADANIE 3: Liczby od 20 do 0 z wyłączeniami ---");
            int[] wylaczenia = { 2, 6, 9, 15, 19 };

            for (int i = 20; i >= 0; i--)
            {
                bool pomijaj = false;
                foreach (int w in wylaczenia)
                {
                    if (i == w)
                    {
                        pomijaj = true;
                        break;
                    }
                }

                if (pomijaj)
                {
                    continue; // pomiń tę iterację pętli
                }

                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Zadanie 4: Nieskończona pętla przerywana instrukcją break, gdy liczba < 0.
        /// </summary>
        static void Zadanie4()
        {
            Console.WriteLine("--- ZADANIE 4: Pętla nieskończona z break ---");
            while (true)
            {
                Console.Write("Podaj liczbę całkowitą (liczba mniejsza od 0 zakończy pętlę): ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba < 0)
                {
                    Console.WriteLine("Wprowadzono liczbę ujemną. Przerywam pętlę (break).");
                    break;
                }

                Console.WriteLine($"Twoja poprawna liczba to: {liczba}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Zadanie 5: Wprowadza n liczb i sortuje je metodą bąbelkową.
        /// </summary>
        static void Zadanie5()
        {
            Console.WriteLine("--- ZADANIE 5: Sortowanie bąbelkowe n liczb ---");
            Console.Write("Podaj ilość elementów (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj element {i + 1}: ");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Algorytm sortowania bąbelkowego
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = 0; j < tab.Length - i - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        // Zamiana miejscami
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Posortowane elementy:");
            foreach (int val in tab)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("\n");
        }
    }
}