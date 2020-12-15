namespace CluedIn.Semler.Common
{
    public static class Origins
    {
        static Origins()
        {
            KUK = "KUK";
            Geomatic = "Geomatic";
            Salesforce = "Salesforce";
            Cvr = "cvr";
            Cpr = "cpr";
        }

        public static string KUK { get; private set; }
        public static string Geomatic { get; private set; }
        public static string Salesforce { get; private set; }
        public static string Cvr { get; private set; }
        public static string Cpr { get; private set; }
    }
}
