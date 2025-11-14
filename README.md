📘 Geocoder Proxy API – ASP.NET Core Project

A lightweight ASP.NET Core Web API that forwards geocoding requests to an external Amazon geocoding service.
This project was implemented during my full-Stack internship (backend part) as part of learning real-world API communication, HTTP client usage, testing, and controller/service architecture.

🚀 Features
🔹 1. ASP.NET Core Web API

Utilizes [ApiController] and routing attributes.
Organized into Controller → Service → Models layers.
Clean separation of concerns.

🔹 2. Strong External API Integration

Makes secure POST requests to Amazon Geocoding API.
Sends custom headers:
x-api-key
Accept
host
Sends JSON body using JsonContent.Create.

Deserializes JSON response into models using System.Text.Json.

🔹 3. HTTP Client Factory
builder.Services.AddHttpClient<GeocoderClient>();

Uses HttpClient through dependency injection.
Avoids socket exhaustion.

Follows .NET recommended best practices.

🔹 4. Options Pattern
builder.Services.Configure<GeocoderSettings>(...);

Reads API configurations (Host, AmazonUrl, ApiKey) from appsettings.json.

🔹 5. Asynchronous Programming

Uses async/await.
Supports non-blocking IO.
Enables scalable API performance.

🔹 6. Swagger Support
app.UseSwagger();
app.UseSwaggerUI();

Swagger UI automatically documents your API.
I used Swagger and Postman to cross-verify responses.
Both tools returned the same output → ensuring correctness.

🔹 7. Full Postman Testing

API tested for:
JSON request body
JSON response body
HTTP headers
Error handling
