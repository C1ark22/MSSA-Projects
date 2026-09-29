using SFSU_VeteranServices_Tracker.Model;
using System.Net.Http.Json;

namespace SFSU_VeteranServices_Tracker.Services
{
    public class ApiService
    {
        private readonly HttpClient httpClient;

        public ApiService()
        {
            httpClient = new HttpClient();

            // Set the base address for the API
            httpClient.BaseAddress =
                new Uri("https://veteranservices-api-clark-czducbc0gyfwffe9.westus3-01.azurewebsites.net/");
        }

        public async Task<bool> CreateCheckInAsync(StudentCheckIn student)
        {
            // Send a POST request to the API to create a new check-in
            HttpResponseMessage response =
                await httpClient.PostAsJsonAsync(
                    "api/CheckIns",
                    student);

            // If the API returns null, return an empty list instead
            return response.IsSuccessStatusCode;
        }

        // Get all check-ins from the API
        public async Task<List<StudentCheckIn>> GetCheckInsAsync()
        {
            List<StudentCheckIn>? checkIns =
                await httpClient.GetFromJsonAsync<List<StudentCheckIn>>(
                    "api/CheckIns");

            return checkIns ?? new List<StudentCheckIn>();
        }
    }
}