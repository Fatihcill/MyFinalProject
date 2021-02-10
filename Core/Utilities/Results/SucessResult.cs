namespace Core.Utilities.Results
{
    public class SucessResult:Result
    {
        public SucessResult(string message) : base(true, message)
        {

        }

        public SucessResult() : base(true)
        {
        }
    }
}