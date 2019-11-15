using System;
using System.Collections.Generic;
using Console = Colorful.Console;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Menu.ShowWelcomeScreen();
                Menu.ShowMainMenu();
                int mainMenuChoice = Convert.ToInt32(Console.ReadLine());
                Menu.ShowCustomerOrderList();
                
                Console.Clear();

                if (mainMenuChoice == 1)
                {
                    Menu.ShowDictionaryOfPizzas();
                    int standardPizzaChoice = int.Parse(Console.ReadLine());
                    if (standardPizzaChoice == 1)
                        Dictionaries.customerOrderDictionary.Add("Margarita", 80);
                    else if (standardPizzaChoice == 2)
                        Dictionaries.customerOrderDictionary.Add("Calzone", 80);
                    else if (standardPizzaChoice == 3)
                        Dictionaries.customerOrderDictionary.Add("Vesuvio", 80);
                    else if (standardPizzaChoice == 4)
                        Dictionaries.customerOrderDictionary.Add("Hawaii", 80);
                    else if (standardPizzaChoice == 5)
                        Dictionaries.customerOrderDictionary.Add("Bussola", 80);
                    else
                        Console.WriteLine("Välj en siffra mellan 1 och 5");
                }
                /*När pizzan valts uppdateras beställningen och du får tre val:
                        1. Något att dricka?
                        2. Något tillägg?
                        3. Betala
                        4. Tillbaka till huvudmenyn?*/
               
                else if (mainMenuChoice == 2)
                {
                    Menu.ShowDictionaryOfPanPizzas();
                    int panPizzaChoice = int.Parse(Console.ReadLine());
                    if (panPizzaChoice == 1)
                        Dictionaries.customerOrderDictionary.Add("Texas", 80);
                    else if (panPizzaChoice == 2)
                        Dictionaries.customerOrderDictionary.Add("New York", 80);
                    else if (panPizzaChoice == 3)
                        Dictionaries.customerOrderDictionary.Add("Blue Hawaii", 80);
                    else if (panPizzaChoice == 4)
                        Dictionaries.customerOrderDictionary.Add("Vegetariana", 80);
                    else if (panPizzaChoice == 5)
                        Dictionaries.customerOrderDictionary.Add("USA", 80);
                }

                else if (mainMenuChoice == 3)
                {
                    Menu.ShowDictionaryOfCannellonis();
                    int cannelloniChoice = Convert.ToInt32(Console.ReadLine());
                    if (cannelloniChoice == 1)
                        Dictionaries.customerOrderDictionary.Add("Cannelloni med ricotta och spenat", 120);
                    else if (cannelloniChoice == 2)
                        Dictionaries.customerOrderDictionary.Add("Cannelloni med köttfärs", 120);
                    else if (cannelloniChoice == 3)
                        Dictionaries.customerOrderDictionary.Add("Cannelloni med kyckling och svamp", 120);
                }
                
                else if (mainMenuChoice == 4)
                {
                    Menu.ShowDictionaryOfSalads();
                    int saladChoice = Convert.ToInt32(Console.ReadLine());
                    if (saladChoice == 1)
                        Dictionaries.customerOrderDictionary.Add("Avokadosallad", 85);
                    else if (saladChoice == 2)
                        Dictionaries.customerOrderDictionary.Add("Kebabsallad", 85);
                    else if (saladChoice == 3)
                        Dictionaries.customerOrderDictionary.Add("Tonfisksallad", 85);
                }
                
                else if (mainMenuChoice == 5)
                {
                    Menu.ShowDictionaryOfBeverages();
                    int beverageChoice = Convert.ToInt32(Console.ReadLine());
                    if (beverageChoice == 1)
                        Dictionaries.customerOrderDictionary.Add("Coca-Cola", 25);
                    else if (beverageChoice == 2)
                        Dictionaries.customerOrderDictionary.Add("Fanta", 25);
                    else if (beverageChoice == 3)
                        Dictionaries.customerOrderDictionary.Add("Sprite", 25);
                    else if (beverageChoice == 4)
                        Dictionaries.customerOrderDictionary.Add("Ramlösa", 25);
                    else if (beverageChoice == 5)
                        Dictionaries.customerOrderDictionary.Add("Lättöl", 25);
                }

                else if (mainMenuChoice == 6)
                {
                    Menu.ShowDictionaryOfIngredients();
                }

                else if (mainMenuChoice == 7)
                {
                    Menu.ShowCustomerOrderList();
                    Menu.GetSumOfOrder(Dictionaries.customerOrderDictionary);
                }

                else if (mainMenuChoice == 8)
                    Menu.CancelOrder();

                Console.ReadKey();
                Console.Clear();

                Menu.ShowAnythingMoreMenu();
                int anythingMoreChoice = int.Parse(Console.ReadLine());
                if (anythingMoreChoice == 1)
                    Menu.ShowDictionaryOfBeverages();
                else if (anythingMoreChoice == 2)
                    Menu.ShowDictionaryOfIngredients();
                else if (anythingMoreChoice == 3)
                    System.Console.WriteLine("Betala (funktion inte klarohjging8uf n)");
                else if (anythingMoreChoice == 4)
                    
                    Console.Clear();
                    Menu.ShowMainMenu();
            }
        }

        //public Dictionary<string, int> GetDictionaryOfIngredients()
        //{
        //    return Dictionaries.dictionaryOfIngredients;
        //}

        //public Dictionary<string, int> GetDictionaryOfPizzas()
        //{
        //    return Dictionaries.dictionaryOfPizzas;
        //}

        //public Dictionary<string, int> GetDictionaryOfPanPizzas()
        //{
        //    return Dictionaries.dictionaryOfPanPizzas;
        //}

        //public Dictionary<string, int> GetDictionaryOfCannellonis()
        //{
        //    return Dictionaries.dictionaryOfPanPizzas;
        //}

        //public Dictionary<string, int> GetDictionaryOfOtherMeals()
        //{
        //    return Dictionaries.dictionaryOfOtherMeals;
        //}

        //public Dictionary<string, int> GetDictionaryOfBeverages()
        //{
        //    return Dictionaries.dictionaryOfBeverages;
        //}

        
    }
}
