namespace ApiDistribuidora.DTOs.Filters
{
    public abstract class BaseFilterInput
    {
        public DateTime? DataInicio { get; set; }

        public DateTime? DataFim { get; set; }
    }
}
