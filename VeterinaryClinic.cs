using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PruebaC_sharp_Herbin_Restrepo.Models;

public class VeterinaryClinic
{
    //---------->Class parameters<------------| 
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Cat> Cats { get; set; } = new List<Cat>();
    public List<Dog> Dogs { get; set; } = new List<Dog>();


    // public static List<Driver> UserP  { get; set; } = new List<Driver>();

    //---------->Class constructor<------------|

    public VeterinaryClinic(string name, string address, List<Cat> cats, List<Dog> dogs)
    {
        Name = name;
        Address = address;
        Cats = cats;
        Dogs = dogs;
    }
    //---------->Class functions<------------|

    public void SaveDog(Dog newdogs)
    {
        //Dog newDogs = new(1,"Chandy",new DateOnly(2008, 10, 05),"Dalmata","white and black",20,true,"60cm",546478,15,"Moderate");
        //Dogs.Add(newDogs);
    }

    public void SaveCat(Cat newcats)
    {
        //Cat newCats = new(1,"Pocaluz",new DateOnly(2008, 10, 05),"Siames","brown",10,true,"60cm");
        //Cats.Add(newCats);
    }

    public void UpdateDog(Dog Dogs)
    {

        Console.WriteLine("Enter Id of dog to update");
        int idUpdateDog = Convert.ToInt16(Console.ReadLine);

        //foreach (var dog in Dogs)
        {
            if (Dogs.Id == idUpdateDog)
            {

                Console.WriteLine("Enter new data for Update Dog id");
                int newUpdateIdDog = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter new data for Update name of Dog");
                string newUpdateNameDog = Console.ReadLine();

                Console.WriteLine("Enter new data for Update birth date of Dog");
                DateOnly newUpdateBirthdayDog = DateOnly.Parse(Console.ReadLine());

                Console.WriteLine("Enter new data for Update breed of Dog");
                string newUpdateBreedDog = Console.ReadLine();

                Console.WriteLine("Enter new data for Update color of Dog");
                string newUpdateColorDog = Console.ReadLine();

                Console.WriteLine("Enter new data for Update weight in KG of Dog");
                int newUpdateWeightlnDog = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter new data for Update breeding status of Dog");
                bool newUpdateBreedingStatusDog = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter new data for Update temperament of Dog");
                string newUpdateTemperamentDog = Console.ReadLine();

                Console.WriteLine("Enter new data for Update Microchip number Dog");
                int newUpdateMicrochipNumberDog = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter new data for Update bark Volumen Dog");
                int newUpdateBarkVolumenDog = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter new data for Update coat type of Dog");
                string newUpdateCoatTypeDog = Console.ReadLine();

                Dog newDogs = new(newUpdateIdDog, newUpdateNameDog, newUpdateBirthdayDog, newUpdateBreedDog, newUpdateColorDog, newUpdateWeightlnDog, newUpdateBreedingStatusDog, newUpdateTemperamentDog, newUpdateMicrochipNumberDog, newUpdateBarkVolumenDog, newUpdateCoatTypeDog);
                //Dogs.Add(newDogs);
            }
            else{

                Console.WriteLine("Error ----> Verify the data entered");
            }
        }
    }

    public void UpdateCat(Cat Cats)
    {
        Console.WriteLine("Enter Id of cat to update");
        int idUpdateCat = Convert.ToInt16(Console.ReadLine);
        //foreach (var cat in Cats)
        {
            if (Cats.Id == idUpdateCat)
            {

                Console.WriteLine("Enter new data for Update Dog id");
                int newUpdateIdCat = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter new data for Update name of Dog");
                string newUpdateNameCat = Console.ReadLine();

                Console.WriteLine("Enter new data for Update birth date of Dog");
                DateOnly newUpdateBirthdayCat = DateOnly.Parse(Console.ReadLine());

                Console.WriteLine("Enter new data for Update breed of Dog");
                string newUpdateBreedCat = Console.ReadLine();

                Console.WriteLine("Enter new data for Update color of Dog");
                string newUpdateColorCat = Console.ReadLine();

                Console.WriteLine("Enter new data for Update weight in KG of Dog");
                int newUpdateWeightlnCat = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter new data for Update breeding status of Dog");
                bool newUpdateBreedingStatusCat = Convert.ToBoolean(Console.ReadLine());

                //Cat newCats = new(newUpdateIdCat, newUpdateNameCat, newUpdateBirthdayCat, newUpdateBreedCat, newUpdateColorCat, newUpdateWeightlnCat, newUpdateBreedingStatusCat);
                //Dogs.Add(newDogs);
            }
            else{

                Console.WriteLine("Error ----> Verify the data entered");
            }
        }
    }

    public void DeleteDog(int id)
    {
        

    }

    public void DeleteCat(int id)
    {

    }

    public void ShowAllPatients()
    {

    }

    public void ShowAnimals(string type)
    {

    }

    public void ShowAPatients(int idPatient)
    {

    }


}






git --no-pager log



