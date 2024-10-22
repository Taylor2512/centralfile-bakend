namespace CentalFile.managment.api.feature.CompanyLayer.Exceptions
{
    public class DuplicateCompanyException : Exception
    {
        public DuplicateCompanyException(string message) : base(message) { }

        public DuplicateCompanyException(string message, Exception innerException) : base(message, innerException) { }
    }
}
