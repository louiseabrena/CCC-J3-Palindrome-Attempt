using System;
using System.Reflection;

namespace N01282172_MaryLouiseAnhanceAbrena_J3Palindrome.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}