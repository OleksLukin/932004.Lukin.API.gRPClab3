using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient
{
    public partial class Form1 : Form
    {
        private const string Address = "https://localhost:7114/";
        private readonly Converter.ConverterClient _client;

        public Form1()
        {
            InitializeComponent();

            var channel = GrpcChannel.ForAddress(Address);
            _client = new Converter.ConverterClient(channel);
        }

        private async void upperBtn_click(object sender, EventArgs e)
        {
            var textToUpper = new ConverterRequest { TextToConvert = inputTextBox.Text };

            var reply = await ConverterReply(textToUpper);

            outputUpper.Text = reply.ConvertedAllText;
        }

        private async Task<ConverterReply> ConverterReply(ConverterRequest textToReverse)
        {
            var reply = await _client.GetConvertedTextAsync(textToReverse);
            return reply;
        }
    }
}
