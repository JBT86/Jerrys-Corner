using System;
using System.Collections.Generic;
using System.Text;
using Console = Colorful.Console;

namespace Customer
{
    class Menu
    {
        public static void ShowWelcomeScreen()
        {
            Console.WriteAscii("PIZZAPALATSET");
        }

        public static void ShowMainMenu()
        {
            Console.WriteLine("-----HUVUDMENY----");
            Console.WriteLine("1. Standardpizzor");
            Console.WriteLine("2. Panpizzor");
            Console.WriteLine("3. Cannelloni");
            Console.WriteLine("4. Sallader");
            Console.WriteLine("5. Dryck");
            Console.WriteLine("6. Göra egen pizza");
            Console.WriteLine("7. Visa beställning");
            Console.WriteLine("8. Avbryt");
            Console.WriteLine("------------------");
        }

        public static void ShowAnythingMoreMenu()
        {
            Console.WriteLine("1. Något att dricka?");
            Console.WriteLine("2. Någon extra ingrediens?");
            Console.WriteLine("3. Betala");
            Console.WriteLine("4. Tillbaka till huvudmenyn");
        }

        public static void ShowDictionaryOfPizzas(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfPizzas)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowDictionaryOfPanPizzas(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfPanPizzas)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowDictionaryOfCannellonis(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfCannellonis)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowDictionaryOfSalads(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfSalads)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowDictionaryOfBeverages(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfBeverages)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void ShowCustomerOrderList(int count = 1)
        {
            Console.WriteLine("Order: ");
            foreach (var item in Dictionaries.customerOrderDictionary)
            {
                Console.WriteLine($"{item.Key} {item.Value}:-");
            }
        }

        public static void ShowDictionaryOfIngredients(int count = 1)
        {
            foreach (var item in Dictionaries.dictionaryOfIngredients)
            {
                Console.WriteLine(count + ". " + item.Key + " " + item.Value + ":-");
                count++;
            }
        }

        public static void GetSumOfOrder(Dictionary<string, int> myDictionary)
        {
            int sum = 0;
            foreach (var item in myDictionary)
            {
                sum += item.Value;
            }
            System.Console.WriteLine($"Summa: {sum}:-");
        }

        public static void CancelOrder()
        {
            ShowWelcomeScreen();
        }
    }
}
