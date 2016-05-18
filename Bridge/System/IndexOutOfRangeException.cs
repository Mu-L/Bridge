using Bridge;

namespace System
{
    [External]
    [Namespace("Bridge")]
    public class IndexOutOfRangeException : SystemException, IBridgeClass
    {
        public extern IndexOutOfRangeException();

        public extern IndexOutOfRangeException(string message);

        public extern IndexOutOfRangeException(string message, Exception innerException);
    }
}