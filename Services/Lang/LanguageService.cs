using Microsoft.Extensions.Localization;
using System.Reflection;

namespace MultiLanguageMVC.Services.Lang
{
    public class LanguageService
    {
        private readonly IStringLocalizer _stringLocalizer;
        public LanguageService(IStringLocalizerFactory factory)
        {
            var type = typeof(ShareResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _stringLocalizer = factory.Create("Language", assemblyName.Name);
        }

        //private readonly IStringLocalizer<ShareResource> _stringLocalizer;
        //public LanguageService(IStringLocalizer<ShareResource> stringLocalizer)
        //{
        //    _stringLocalizer = stringLocalizer;
        //}

        public LocalizedString GetKey(string key)
        {
            return _stringLocalizer[key];
        }
    }
}
