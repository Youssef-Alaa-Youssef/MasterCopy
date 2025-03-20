using Serilog.Events;
using Serilog.Formatting;
using Serilog.Formatting.Json;

namespace Factory.PL.Helper
{
    /// <summary>
    /// A custom JSON formatter for Serilog that adds additional properties to log entries.
    /// </summary>
    public class CustomJsonFormatter : ITextFormatter
    {
        private readonly JsonFormatter _jsonFormatter;
        private readonly string _customPropertyName;
        private readonly ScalarValue _customPropertyValue;

        public CustomJsonFormatter(string customPropertyName = "CustomProperty", object customPropertyValue = null)
        {
            _jsonFormatter = new JsonFormatter();
            _customPropertyName = customPropertyName ?? throw new ArgumentNullException(nameof(customPropertyName));
            _customPropertyValue = new ScalarValue(customPropertyValue ?? "CustomValue");
        }

        /// <summary>
        /// Formats the log event into JSON and writes it to the output.
        /// </summary>
        /// <param name="logEvent">The log event to format.</param>
        /// <param name="output">The output writer.</param>
        public void Format(LogEvent logEvent, TextWriter output)
        {
            if (logEvent == null)
                throw new ArgumentNullException(nameof(logEvent));
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            try
            {
                logEvent.AddPropertyIfAbsent(new LogEventProperty(_customPropertyName, _customPropertyValue));
                _jsonFormatter.Format(logEvent, output);
            }
            catch (Exception ex)
            {
                output.WriteLine($"Error formatting log event: {ex.Message}");
            }
        }
    }
}