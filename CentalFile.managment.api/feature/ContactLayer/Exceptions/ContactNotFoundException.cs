namespace CentalFile.managment.api.feature.ContactLayer.Exceptions
{
    public class ContactNotFoundException : Exception
    {
        public ContactNotFoundException(string message) : base(message) { }

        public ContactNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
