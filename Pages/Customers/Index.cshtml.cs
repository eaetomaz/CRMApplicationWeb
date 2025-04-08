using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

public class CustomersModel : PageModel
{
    public List<CustomerDto> Customers { get; set; } = new();

    public async Task OnGetAsync()
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://localhost:5001/api/Client");

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            Customers = JsonSerializer.Deserialize<List<CustomerDto>>(content,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}

public class CustomerDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Company { get; set; }
    public string Status { get; set; }
    public DateTime RegistrationDate { get; set; }
}