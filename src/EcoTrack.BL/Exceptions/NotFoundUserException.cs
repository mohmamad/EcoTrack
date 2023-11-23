namespace EcoTrack.BL.Exceptions
{
    public class NotFoundUserException : Exception
    {
        public NotFoundUserException(string msg) : base(msg) 
        {
        }
    }
}
