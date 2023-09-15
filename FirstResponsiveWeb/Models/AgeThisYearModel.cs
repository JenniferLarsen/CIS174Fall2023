using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;


namespace FirstResponsiveWeb.Models
{
    public class AgeThisYearModel
    {
        [Required(ErrorMessage ="Please enter Name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter Year of Birth.")]
        public int BirthYear { get; set; }  

        public int CurrentYear = DateTime.Now.Year;

        public int AgeThisYear;


        public int ageThisYear()
        {

            // Calculate the age as of 12/31 this year
            AgeThisYear = CurrentYear - BirthYear;

            return AgeThisYear;
        }
    }
}

