using Amazon.Lambda.Core;

namespace HelloWorldLambda
{
    class Program
    {
        public string Handle(string input, ILambdaContext context)
        {
            return input;
        }
    }
}
