using ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.ViewModel
{
    [ModelMetadataType(typeof(Address))]

    public class AddressCountryViewModel
    {

        public int Id { get; set; }
        public int Unit_Number { get; set; }  
        public int Street_Number { get; set; }   
        public string Address_line1 { get; set; }
        public string Address_line2 { get; set; }   
        public string City { get; set; }  
        public string Region { get; set; }
        public int Postal_Code { get; set; }

        public int Country_Id { get; set; }
        
        public List<Country>? CountriesList { get; set; }
        public string previousUrl { get; set; }

    }
}
