using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
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
