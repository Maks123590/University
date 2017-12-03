using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using WordInteractionLab8.Models;

namespace WordInteractionLab8
{
    public static class XmlParser
    {
        public static IEnumerable<BankInfo> GetBankInfos(string xmlDocName)
        {
            var xdoc = XDocument.Load(xmlDocName);

            return (xdoc.Element("biks")?.Elements("bik")).Select(binkElement => new BankInfo
            {
                Bik = binkElement.Attribute("bik")?.Value,
                CorrespondentAccount = binkElement.Attribute("ks")?.Value,
                FullName = binkElement.Attribute("name")?.Value,
                ShortName = binkElement.Attribute("namemini")?.Value,
                Index = binkElement.Attribute("index")?.Value,
                Locality = binkElement.Attribute("city")?.Value,
                Address = binkElement.Attribute("address")?.Value,
                Phone = binkElement.Attribute("phone")?.Value,
                OKATOCode = binkElement.Attribute("okato")?.Value,
                OKPOCode = binkElement.Attribute("okpo")?.Value,
                RegistrationNumber = binkElement.Attribute("regnum")?.Value,
                DocumentsDeadline = binkElement.Attribute("srok")?.Value,
                AddingDate = binkElement.Attribute("dateadd")?.Value,
                LastChangeDate = binkElement.Attribute("datechange")?.Value
            }).ToList();
        }
    }
}