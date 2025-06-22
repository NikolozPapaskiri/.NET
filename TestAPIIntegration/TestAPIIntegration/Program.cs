using System;
using System.Net.Http; // Required for HttpClient
using System.Net.Http.Json;
using System.Text;
using System.Text.Json; // Required for JsonSerializer
using System.Threading.Tasks; // Required for async operations

namespace TestAPIIntegration
{
    public class Program
    {
        // --- EXPLANATION: HttpClient Setup ---
        // It's a best practice to create a single, static instance of HttpClient
        // and reuse it throughout your application's lifetime. Creating a new one
        // for every request can lead to performance issues (socket exhaustion).
        private static readonly HttpClient _httpClient = new HttpClient();

        // --- EXPLANATION: The API Call ---
        // Define the URL of the API endpoint we want to retrieve data from.
        private static readonly string apiBaseUrl = "https://jsonplaceholder.typicode.com/";

        // --- EXPLANATION: Main Method ---
        // The Main method is marked as 'async Task' to allow us to use 'await'
        // for our asynchronous network call. We also wrap the main logic in a
        // try...catch block to gracefully handle potential network errors.
        public static async Task Main()
        {
            try
            {
                await Post(1);
                await CreatePostAsync();
                await UpdatePostAsync(1);
                await DeletePostAsync(1);
                Thread.Sleep(3000);
                await Post(1);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

        public static async Task Post(int postId)
        {
            try
            {

                // 1. Make the GET request asynchronously.
                // 'await' pauses the Main method here without freezing the application
                // until the network response is received.
                string postUrl = apiBaseUrl + $"posts/{postId}";
                HttpResponseMessage response = await _httpClient.GetAsync(postUrl);

                // 2. Check for a successful response.
                // This line will throw an HttpRequestException if the status code
                // is an error (e.g., 404 Not Found or 500 Internal Server Error).
                response.EnsureSuccessStatusCode();

                // 3. Read the response content as a raw JSON string.
                string jsonResponse = await response.Content.ReadAsStringAsync();

                // 4. Deserialize the JSON string into our C# Post object.
                // This is the "translation" step. It uses our Post class as a template.
                Post? post = JsonSerializer.Deserialize<Post>(jsonResponse);

                // 5. Use the data from the C# object.
                // We check if the 'post' object is not null to ensure deserialization was successful.
                if (post != null)
                {
                    Console.WriteLine($"\n--- Data Fetched and Parsed Successfully ---\nPost ID: {post.Id}\nTitle: {post.Title}\nBody: {post.Body}");
                }
                else
                {
                    Console.WriteLine("Failed to deserialize the JSON response.");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"\nRequest error: {e.Message}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"\nAn unexpected error occurred: {ex.Message}");
            }
        }

        public static async Task CreatePostAsync()
        {
            string postUrl = apiBaseUrl + "posts";

            // 1. Create the C# object to send.
            // We don't set the Id because the API will create it for us.
            var newPost = new Post
            {
                UserId = 10,
                Title = "My New Awesome Post",
                Body = "This is the body of my new post. It's created from C#."

            };

            // 2. Serialize the object into a JSON string.
            string jsonContent = JsonSerializer.Serialize(newPost);

            // 3.Package the JSON into StringContent.
            // We specify the encopublic sding and the media type "application/json".
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            Console.WriteLine("\n--- Creating a new post (POST) ---");
            // 4. Send the POST request.
            HttpResponseMessage response = await _httpClient.PostAsync(postUrl, content);

            response.EnsureSuccessStatusCode();

            // 5. Read and display the response from the API.
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine("ApiResponse: ");
            Console.WriteLine(responseBody);
        }

        public static async Task UpdatePostAsync(int postId)
        {
            string putUrl = apiBaseUrl + $"posts/{postId}";

            // 1. Create the C# object with the updated data.
            var updatedPost = new Post
            {
                UserId = 1,
                Id = postId, // Include the ID of the post to update
                Title = "This Title Has Been Updated",
                Body = "The body of this post has been completely replaced."
            };

            // 2. Serialize, 3. Package
            string jsonContent = JsonSerializer.Serialize(updatedPost);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            Console.WriteLine($"\n--- Updating post {postId} (PUT) ---");
            // 4. Send the PUT request.
            HttpResponseMessage response = await _httpClient.PutAsync(putUrl, content);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine("API Response:");
            Console.WriteLine(responseBody);
        }

        public static async Task DeletePostAsync(int postId)
        {
            string deleteUrl = apiBaseUrl + $"posts/{postId}";

            Console.WriteLine($"\n--- Deleting post {postId} (DELETE) ---");
            // 1. Send the DELETE request.
            HttpResponseMessage response = await _httpClient.DeleteAsync(deleteUrl);

            // 2. Check the response.
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Post {postId} deleted successfully. Status code: {response.StatusCode}");
            }
            else
            {
                Console.WriteLine($"Failed to delete post. Status code: {response.StatusCode}");
            }
        }
    }
}