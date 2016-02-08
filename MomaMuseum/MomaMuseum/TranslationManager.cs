using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomaMuseum
{
    public static class TranslationManager
    {
        public static string GetResourceValue(string key)
        {
            return AppLanguageResource.ResourceManager.GetString(key);
        }
    }
}
