using System;


namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }
        public void Log(string error)
        {
            if (string.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastError = error;
        }
    }
}