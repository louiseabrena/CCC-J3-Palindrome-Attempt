using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace N01282172_MaryLouiseAnhanceAbrena_J3Palindrome.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}