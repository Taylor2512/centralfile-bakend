namespace CentalFile.managment.api.feature.ContactLayer.Exceptions
{
    public class ContactCreationException : Exception
    {
        public ContactCreationException(string message) : base(message) { }

        public ContactCreationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
