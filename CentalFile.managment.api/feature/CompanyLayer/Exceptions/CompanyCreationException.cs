namespace CentalFile.managment.api.feature.CompanyLayer.Exceptions
{
    public class CompanyCreationException : Exception
    {
        public CompanyCreationException(string message) : base(message) { }

        public CompanyCreationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
