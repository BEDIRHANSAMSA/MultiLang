using System;
using System.Globalization;
using System.Threading;
using MultiLang.Language;


namespace MultiLang
{
    class Program
    {
        static void Main(string[] args)
        {
            SetLanguageDictionary();

            Console.Write(Resources.Hello);
        }

        private static void SetLanguageDictionary()
        {
            switch (Thread.CurrentThread.CurrentCulture.ToString())
            {
                case "en-US":
                    Language.Resources.Culture = new CultureInfo("en-US");
                    break;
                case "tr-TR":
                    Language.Resources.Culture = new CultureInfo("tr-TR");
                    break;
                default
                    : //default english because there can be so many different system language, we rather fallback on english in this case.
                    Language.Resources.Culture = new CultureInfo("tr-TR");
                    break;
            }
        }
    }

}
