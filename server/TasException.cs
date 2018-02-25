using System;

namespace Tas.Server
{
    public class TasException : Exception
    {
        public ProblemDetails Problem { get; }

        public TasException(ProblemDetails problem)
        {
            Problem = problem;
        }
    }
}