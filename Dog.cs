using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_Herbin_Restrepo.Models;

//---------->Class parameters<------------| 


public class Dog: Animal //-->Animal inheritance is created
{
    public bool BreedingStatus { get; set; }
    public string? Temperament { get; set; }
    public int MicrochipNumber { get; set; }
    public int BarkVolumen { get; set; }
    public string CoatType { get; set; }

    //---------->Class constructor<------------|

    public Dog(int id, string name, DateOnly birthdate, string breed, string color, int weightlnkg,bool breedingStatus, string temperament, int microchipNumber, int barkVolumen, string coatType): base(id, name, birthdate, breed, color, weightlnkg)
    {
        BreedingStatus = breedingStatus;
        Temperament = temperament;
        MicrochipNumber = microchipNumber;
        BarkVolumen = barkVolumen;
        CoatType = coatType;
    }

    //---------->Class functions<------------|

    public void CastrateAnimal()
    {

    }

    public void HairDress()
    {

    }


}
