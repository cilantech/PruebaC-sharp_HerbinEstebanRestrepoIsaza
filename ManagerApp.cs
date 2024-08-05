using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_Herbin_Restrepo.Models;

public class ManagerApp
{
    //---------->Class functions<------------|

    public static void CreateDog()
    {

        Console.WriteLine("Enter new data id of Dog");
        int newIdDog = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter new data name of Dog");
        string newNameDog = Console.ReadLine();

        Console.WriteLine("Enter new data birth date of Dog");
        DateOnly newBirthdayDog = DateOnly.Parse(Console.ReadLine());

        Console.WriteLine("Enter new data breed of Dog");
        string newBreedDog = Console.ReadLine();

        Console.WriteLine("Enter new data color of Dog");
        string newColorDog = Console.ReadLine();

        Console.WriteLine("Enter new data weight in KG of Dog");
        int newWeightlnDog = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter new data breeding status of Dog");
        bool newBreedingStatusDog = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Enter new data temperament of Dog");
        string newTemperamentDog = Console.ReadLine();

        Console.WriteLine("Enter new data Microchip number Dog");
        int newMicrochipNumberDog = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter new data bark Volumen Dog");
        int newBarkVolumenDog = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter new data coat type of Dog");
        string newCoatTypeDog = Console.ReadLine();

        Dog newDogs = new(newIdDog, newNameDog, newBirthdayDog, newBreedDog, newColorDog, newWeightlnDog, newBreedingStatusDog, newTemperamentDog, newMicrochipNumberDog, newBarkVolumenDog, newCoatTypeDog);
        //Dogs.Add(newDogs);


    }

    public static void CreateCat()
    {

        Console.WriteLine("Enter new data id of cat");
        int newIdCat = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter new data name of cat");
        string newNameCat = Console.ReadLine();

        Console.WriteLine("Enter new data birth date of cat");
        DateOnly newBirthdayCat = DateOnly.Parse(Console.ReadLine());

        Console.WriteLine("Enter new data breed of cat");
        string newBreedCat = Console.ReadLine();

        Console.WriteLine("Enter new data color of cat");
        string newColorCat = Console.ReadLine();

        Console.WriteLine("Enter new data weight in KG of cat");
        int newWeightlnCat = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter new data breeding status of cat");
        bool newBreedingStatusCat = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Enter new data furlengt of cat");
        string newFurLengthCat = Console.ReadLine();


        Cat newCats = new(newIdCat, newNameCat, newBirthdayCat, newBreedCat, newColorCat, newWeightlnCat, newBreedingStatusCat, newFurLengthCat);
        //Cats.Add(newCats);


    }

    public static void ShowHeader()
    {

        Console.WriteLine("================================================================");
        Console.WriteLine("|                         Welcome to                           |");
        Console.WriteLine("|                  <<VETERINARY RIWI 2024>>                    |");
        Console.WriteLine("|             It is a pleasure that you prefer us              |");
        Console.WriteLine("================================================================");

    }

    public static void ShowFooter()
    {
        Console.WriteLine("================================================================");
        Console.WriteLine("|          All rights reserved veterinary RIWI 2024            |");
        Console.WriteLine("================================================================");
    }

    public void ShowSeparator()
    {
        Console.WriteLine("__°-°__°-°__°-°__°-°__°-°__°-°__°-°__°-°__");
    }

    public static void MenuShow()
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("================================================================");
        Console.WriteLine(@"°°---------------->Menu of Options Veterinary<----------------°°
    ================================================================
    [1]-------------------> General queries <--------------------[1]
    [2]---------------------> Options dog <----------------------[2]
    [3]---------------------> Options cat <----------------------[3]
    [4]----------------> Administrator Options <-----------------[4]
    [5]********************>Exit to system<**********************[5]
    ================================================================");
    }


    public static void SwichtMenuOPtions()
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Ingrese una opcion: ");
        int OptionOfUserMenu = Convert.ToInt16(Console.ReadLine());
        do
        {
            switch (OptionOfUserMenu)
            {
                case 1:
                    Console.WriteLine("[1]-------------------> General queries <--------------------[1]");
                    break;
                case 2:
                    Console.WriteLine("[2]-------------------> Options dog <--------------------[2]");
                    break;
                case 3:
                    Console.WriteLine("[3]-------------------> Options cat <--------------------[3]");
                    break;
                case 4:
                    Console.WriteLine("[4]-------------------> Administrator Options <--------------------[4]");
                    break;
                default:
                    Console.WriteLine("[5]-------------------> Close the Program thanks <--------------------[5]");
                    break;
            }
        } while (OptionOfUserMenu != 5);
    }


}
