using Grpc.Core;

namespace GrpcServer.Services
{
    public class ConverterService : Converter.ConverterBase
    {
        private readonly ILogger<ConverterService> _logger;

        public ConverterService(ILogger<ConverterService> logger)
        {
            _logger = logger;
        }

        public override Task<ConverterReply> GetConvertedText(ConverterRequest request, ServerCallContext context)
        {
            var converterOutput = new ConverterReply
            {

                ConvertedAllText = ConvertToUpper(request.TextToConvert.ToString())
            };

            return Task.FromResult(converterOutput);
        }
        
        public string ConvertToUpper(string input)
        {
            string result = input.ToUpper();
            return result;
        }
    }
}
