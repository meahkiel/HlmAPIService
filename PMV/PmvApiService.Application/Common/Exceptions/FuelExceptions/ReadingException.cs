namespace PMV.Application.Common.Exceptions.FuelExceptions
{
    public class ReadingException : Exception
    {
        public ReadingException()
        {

        }

        public override string Message => "Current reading must always ahead from the previous reading";
    }
}