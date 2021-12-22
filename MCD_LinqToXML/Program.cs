using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MCD_LinqToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XComment("Yorum Satırı"),
                new XElement("Personellerim",
                new XElement("Personel", new XAttribute("ID", "1"),
                new XElement("İsim", "Ahmet"),
                new XElement("Soyisim","Koç"),
                new XElement("EmailAdres", "ahmet.koc@gmail.com")
                ),
                new XElement("Personel", new XAttribute("ID", "2"),
                new XElement("İsim", "Mehmet"),
                new XElement("Soyisim", "Dana"),
                new XElement("EmailAdres", "mehmet.dana@gmail.com")
                )
                )
                );
            xDoc.Save("c:\\XML\\Ornek1.xml");
        }
    }
}
