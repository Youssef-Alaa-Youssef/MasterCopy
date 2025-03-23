namespace Factory.PL.Options
{
    public class Names
    {
        public string CompanyName { get; set; } = string.Empty;
        public string PartnerName { get; set; } = string.Empty;
        public bool ChatBot { get; set; }
        public bool ExternalLogin { get; set; }
        public string ExcludedEmail { get; set; } = string.Empty;
    }
}
