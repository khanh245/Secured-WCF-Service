using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DictionaryService
{
    [ServiceContract]
    public interface IDictionaryService
    {
        [OperationContract]
        [WebInvoke(Method="GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "json/{word}")]
        string GetDefinition(string word);
    }
}
