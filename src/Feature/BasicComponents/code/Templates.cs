using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneValtech.Feature.BasicComponents
{
    public struct Templates
    {
        public struct NavigationMenu
        {
            public const string ID = "{7971DFFA-A956-4DEF-9EE4-66E4C44B27B9}";
            public const string TemplateName = "Navigation Menu";
            
            public struct Fields
            {
                public const string HeartImage = "{0932B35E-DF2E-41F0-989C-EA7CAF71D951}";
                public const string MyProfileLink = "{E4BDDD2D-3654-4525-A318-D7C7AB247A9C}";
                public const string AccountLink = "{CCAE6BDE-3541-44C6-A0B6-61A24BEAA389}";
                public const string HelpButtonText = "{E7B11AA8-5193-410C-9894-B1ABBD1A9846}";
            }
        }

        public struct FeaturedValtechie
        {
            public const string ID = "{22C2B4AA-CDAC-4EA4-9816-F52B14A030D8}";
            public const string TemplateName = "Featured Valtechie";

            public struct Fields
            {
                public const string HeartImage = "{C545212C-4B89-4935-812E-F5FF34E867BC}";
                public const string Title = "{64381F56-86B7-4C01-BE6C-07DF90B52B17}";
            }
        }
    }
}