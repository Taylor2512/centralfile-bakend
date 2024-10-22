namespace CentalFile.managment.api.feature.UserLayer.Exceptions
{
    public class DuplicateUserException : Exception
    {
        public DuplicateUserException(string message) : base(message) { }

        public DuplicateUserException(string message, Exception innerException) : base(message, innerException) { }
    }
}
