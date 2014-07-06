using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DictionaryService
{
    public class SecuredDictionaryService : IDictionaryService
    {
        public string GetDefinition(string word)
        {
            return word;
        }
    }
}
