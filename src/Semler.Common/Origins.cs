namespace CluedIn.Semler.Common
{
    public static class Origins
    {
        static Origins()
        {
            KUK = "KUK";
            Geomatic = "Geomatic";
            Salesforce = "Salesforce";
        }

        public static string KUK { get; private set; }
        public static string Geomatic { get; private set; }
        public static string Salesforce { get; private set; }
    }
}
