using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Threading;

public class Chatbot
{
    private const string apiKey = "";
    private const string apiUrl = "https://api.openai.com/v1/chat/completions";

    public async Task<string> GetResponseAsync(string prompt)
    {
        var client = new RestClient(apiUrl);
        var request = new RestRequest
        {
            Method = Method.Post
        };

        request.AddHeader("Authorization", $"Bearer {apiKey}");
        request.AddHeader("Content-Type", "application/json");

        var body = new
        {
            model = "gpt-3.5-turbo",
            messages = new[]
            {
                new
                {
                    role = "user",
                    content = prompt
                }
            },
            max_tokens = 150
        };

        request.AddJsonBody(body);

        int retryCount = 3;
        int delay = 5000; 

        for (int i = 0; i < retryCount; i++)
        {
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful && response.Content != null)
            {
                try
                {
                    var result = JsonConvert.DeserializeObject<ChatResponseModel>(response.Content);
                    return result?.Choices?[0]?.Message?.Content ?? "No response";
                }
                catch (JsonException ex)
                {
                    throw new Exception("Error parsing the response: " + ex.Message);
                }
            }
            else
            {
                if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    await Task.Delay(delay);
                    delay *= 2; 
                }
                else
                {
                    var errorMessage = $"Error: {response.ErrorMessage}\nStatus Code: {response.StatusCode}\nContent: {response.Content}";
                    throw new Exception(errorMessage);
                }
            }
        }

        return "Error: Unable to get a response.";
    }

    private class ChatResponseModel
    {
        public Choice[] Choices { get; set; } = Array.Empty<Choice>();
    }

    private class Choice
    {
        public Message Message { get; set; } = new Message();
    }

    private class Message
    {
        public string Content { get; set; } = string.Empty;
    }
}
