namespace Payment.Api.Logging
{
    public interface ICustomLogEnricher
    {
        string CorrelationId { get; set; }
    }
}
