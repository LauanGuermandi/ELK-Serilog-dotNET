using Serilog;
using Serilog.Configuration;
using System;

namespace Payment.Api.Logging
{
    public static class LoggingExtensions
    {
        public static LoggerConfiguration CustomerLogEnricher(
            this LoggerEnrichmentConfiguration enrich)
        {
            if (enrich == null)
                throw new ArgumentNullException(nameof(enrich));

            return enrich.With<CustomLogEnricher>();
        }
    }
}
