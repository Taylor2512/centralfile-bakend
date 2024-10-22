namespace CentalFile.managment.api.feature.ContactLayer.Exceptions
{
    public class DuplicateContactException : Exception
    {
        public DuplicateContactException(string message) : base(message) { }

        public DuplicateContactException(string message, Exception innerException) : base(message, innerException) { }
    }
}
