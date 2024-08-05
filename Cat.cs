using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_Herbin_Restrepo.Models;

public class Cat: Animal //-->Animal inheritance is created
{
    //---------->Class parameters<------------| 

    public bool BreedingStatus { get; set; }
    public string FurLength { get; set; }

    //---------->Class constructor<------------|

    public Cat(int id, string name, DateOnly birthdate, string breed, string color, int weightlnkg,bool breedingStatus, string furLength): base(id, name, birthdate, breed, color, weightlnkg)
    {
        BreedingStatus = breedingStatus;
        FurLength = furLength;
    }

    //---------->Class functions<------------|

    public void CastrateAnimal()
    {

    }

    public void HairDress()
    {

    }


}
