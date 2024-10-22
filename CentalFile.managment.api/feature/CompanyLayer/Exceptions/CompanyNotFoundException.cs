namespace CentalFile.managment.api.feature.CompanyLayer.Exceptions
{
    public class CompanyNotFoundException : Exception
    {
        public CompanyNotFoundException(string message) : base(message) { }

        public CompanyNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
