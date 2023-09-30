using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLUsporedivanje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc1 = new XmlDocument();
            doc1.Load("C:\\Users\\HP\\source\\repos\\XMLUsporedivanje\\prvi.xml");
            XmlNodeList elemList1 = doc1.GetElementsByTagName("book");

            XmlDocument doc2 = new XmlDocument();
            doc2.Load("C:\\Users\\HP\\source\\repos\\XMLUsporedivanje\\drugi.xml");
            XmlNodeList elemList2 = doc2.GetElementsByTagName("book");

            int gr = 0;

            Console.WriteLine("Razlika \tVrsta razlike \t\t\t\tPrva vrijednost \tDruga vrijednost");
            for (int j = 0; j < elemList1.Count; j++)
            { 
                for (int i = 0; i < (elemList1.Count - 1); i++)
                {
                    string attrVal1 = elemList1[j].Attributes[i].Value;
                    string attrVal2 = elemList2[j].Attributes[i].Value;
                    if (attrVal2 != attrVal1)
                    {
                        gr++;
                        Console.WriteLine(gr + " \t\tRazlika u elementu " + elemList1[j].Attributes[i].Name + "    \t\t" + attrVal1 + "\t\t\t" + attrVal2);
                    }
                }
            }


            Console.ReadKey();
            
        }
    }
}
