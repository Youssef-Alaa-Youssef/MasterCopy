namespace Factory.PL.ViewModels.Documentation
{
    public class APIDocViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DescriptionEn { get; set; } = string.Empty;
        public string Endpoint { get; set; } = string.Empty;
        public string Method { get; set; } = string.Empty;
        public string RequestExample { get; set; } = string.Empty;
        public string ResponseExample { get; set; } = string.Empty;
        public string Parameters { get; set; } = string.Empty;
    }
}