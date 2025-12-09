using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMauiMobileApp.Models.Messages
{
    public static class Msgs
    {
        public static string NotEmpty { get; } = "Entry cannot be empty";
        
        public static string NotEmptyMovie { get; } = "Movie name cannot be empty";

        public static string NotEmptyCountry { get; } = "Country can't be empty";

        public static string NotEmptyCity { get; } = "City can't be empty";
    }
}
