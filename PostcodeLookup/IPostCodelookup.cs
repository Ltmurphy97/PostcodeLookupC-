using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcodeLookup
{
    
    interface IPostCodelookup
    {
        string[] getValidDeliveryOptions(string postcode);
    }
    public static class PostcodeInfo
    {
        //Define delivery options
        static string wareHouse = "Delivery";
        static string none = "No Deliveries";
        static string van = "Van Delivery";
        static string Orp = "Collect from Orpington";
        static string OrpCollect = "Collect from Petts Wood";
        static string OrpDelivery = "Delivery from Orpington";
        static string Knockholt = "Collect from Knockholt";
        static string Store = "Collect from store";
        //build the static dictionary to use in the method for comparison
        //Dictionary holds postcodes mapped to string arrays to be returned by the method
        public static Dictionary<string, string[]> postcodeDictionary = new Dictionary<string, string[]>
        {
            { "BR6", new string[]{wareHouse } },
            { "BR6 9HC", new string[]{none } },
            {"BR1", new string[]{wareHouse} },
            {"BR2", new string[]{wareHouse} },
            {"BR6 9", new string[]{van, Orp } },
            {"BR6 8", new string[]{van, Orp } },
            {"BR6 7", new string[]{van} },
            {"BR5", new string[]{ OrpCollect, OrpDelivery } },
            {"BR4", new string[]{ OrpCollect, OrpDelivery } },
            {"BR4 5", new string[]{ OrpCollect } },
            {"ME", new string[]{none} },
            {"ME10", new string[]{ Store } },
            {"ME10 3", new string[]{ Store, Knockholt } },
            {"IV", new string[]{none} }
        };
    }
    public class Customer: IPostCodelookup
    {
        public string PostCode { get; set; }
        //constructor to easily populate postcode
        public Customer(string postcode)
        {
            this.PostCode = postcode;
        }

        //method to identify delivery options - postcode passed in as parameter
        public string[] getValidDeliveryOptions(string postcode)
        {
            //list to be converted to array later
            string[] validoptionsarray;
            //null check to avoid errors
            if (!string.IsNullOrEmpty(postcode))
            {
                //work from the full postcode, then remove one character each time to find the closest match first
                for (int i = postcode.Length; i > 0; i--)
                {
                    string partialPostcode = postcode.Substring(0, i);
                    //Check for a match on partial postcode
                    foreach (var codetoCheck in PostcodeInfo.postcodeDictionary)
                    {
                        if (partialPostcode.ToUpper() == codetoCheck.Key.ToUpper())
                        {
                            //Add to list if valid value
                            validoptionsarray = codetoCheck.Value;
                            //return the array
                            return validoptionsarray;
                        }
                    }
                }
            }
            return new string[] { };

        }
    }
}
