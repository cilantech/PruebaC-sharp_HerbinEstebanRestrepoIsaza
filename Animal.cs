using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_Herbin_Restrepo.Models;

public class Animal
{
    //---------->Class parameters<------------| 

    public int Id { get; set; }
    public string? Name { get; set; }
    public DateOnly Birthdate { get; set; }
    public string? Breed { get; set; }
    public string? Color { get; set; }
    public int Weightlnkg { get; set; }

    //---------->Class constructor<------------|
    public Animal(int id, string name, DateOnly birthdate, string breed, string color, int weightlnkg)
    {
        Id = id;
        Name = name;
        Birthdate = birthdate;
        Breed = breed;
        Color = color;
        Weightlnkg = weightlnkg;

    }
    //---------->Class functions<------------|

    public void ShowInformation()
    {

    }

    protected void BasicReview()
    {

    }

    protected int CalculateAgeInMonths()
    {
        int AgeInMonths = 0;

        //
        return AgeInMonths;
    }



}
