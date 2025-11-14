📘 Geocoder Proxy API – ASP.NET Core Project

A lightweight ASP.NET Core Web API that forwards geocoding requests to an external Amazon geocoding service.
This project was implemented during my full-Stack internship (backend part) as part of learning real-world API communication, HTTP client usage, testing, and controller/service architecture.

🚀 Features
🔹 1. ASP.NET Core Web API
<br>
Utilizes [ApiController] and routing attributes.
<br>
Organized into Controller → Service → Models layers.
<br>
Clean separation of concerns.
<br>
<br>
🔹 2. Strong External API Integration
<br>
Makes secure POST requests to Amazon Geocoding API.
<br>
Sends custom headers:
x-api-key,
Accept,
host,
Sends JSON body using JsonContent.Create,
Deserializes JSON response into models using System.Text.Json.
<br>
<br>
🔹 3. HTTP Client Factory
<br>
builder.Services.AddHttpClient<GeocoderClient>();
<br>
<br>
Uses HttpClient through dependency injection.
<br>
Avoids socket exhaustion.
<br>
Follows .NET recommended best practices.
<br>
<br>
🔹 4. Options Pattern
builder.Services.Configure<GeocoderSettings>(...);
<br>
<br>
Reads API configurations (Host, AmazonUrl, ApiKey) from appsettings.json.
<br>
<br>
🔹 5. Asynchronous Programming
<br>
Uses async/await.
<br>
Supports non-blocking IO.
<br>
Enables scalable API performance.
<br>
<br>
🔹 6. Swagger Support
<br>
app.UseSwagger();
<br>
app.UseSwaggerUI();
<br>
Swagger UI automatically documents your API.
<br>
I used Swagger and Postman to cross-verify responses.
Both tools returned the same output → ensuring correctness.
<br>
<br>
🔹 7. Full Postman Testing
<br>
API tested for:
JSON request body<br>
JSON response body<br>
HTTP headers<br>
Error handling<br>
