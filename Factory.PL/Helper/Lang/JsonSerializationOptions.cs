using System.Text.Json;

namespace Factory.PL.Helper.Lang
{
    public static class JsonSerializationOptions
    {
        public static readonly JsonSerializerOptions DefaultOptions = new JsonSerializerOptions
        {
            AllowTrailingCommas = true,

            ReadCommentHandling = JsonCommentHandling.Skip,

            PropertyNameCaseInsensitive = true,

            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,

            WriteIndented = true
        };
    }
}