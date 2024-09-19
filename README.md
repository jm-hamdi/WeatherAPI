# WeatherAPI

A simple .NET Core API that provides weather forecast data. This project demonstrates the creation of a RESTful API using ASP.NET Core, Swagger for API documentation, and various .NET features.

## Features

- Provides a weather forecast for the next 5 days with random temperature values.
- Utilizes Swagger for interactive API documentation.
- Simple API design using minimal APIs in .NET Core.

## Technologies Used

- .NET Core 7.0
- C#
- ASP.NET Core Web API
- Swagger (for API documentation)
- Visual Studio Code (as the IDE)
- Command-line tools (`dotnet CLI`)

## Prerequisites

Before running this project, ensure that you have:

1. [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) installed.
2. Visual Studio Code (optional, but recommended) with the C# extension.
3. MacOS, Windows, or Linux environment with a terminal/command-line interface.

## Installation

Follow these steps to clone and run the project:

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/WeatherAPI.git
   ```
   
2. Navigate into the project folder:
   ```bash
   cd WeatherAPI
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

## Running the Application

To run the API, execute the following command:

```bash
dotnet run
```

This will start the API on both HTTP (`http://localhost:5238`) and HTTPS (`https://localhost:7131`).

### Accessing the API

Once the API is running, you can access the Swagger UI by navigating to the following URL in your browser:

```
https://localhost:7131/swagger
```

Here, you can test the available API endpoints and see the API documentation.

## Endpoints

### 1. **Get Weather Forecast**
   - **URL**: `/weatherforecast`
   - **Method**: `GET`
   - **Description**: Returns weather forecast data for the next 5 days. The data is randomly generated for the sake of demonstration.
   - **Response**: An array of weather forecasts, each containing the date, temperature in Celsius, a weather summary, and a computed temperature in Fahrenheit.

   Example response:
   ```json
   [
     {
       "date": "2024-09-19",
       "temperatureC": 25,
       "summary": "Sunny",
       "temperatureF": 77
     },
     {
       "date": "2024-09-20",
       "temperatureC": 22,
       "summary": "Cloudy",
       "temperatureF": 71
     }
   ]
   ```

## Project Structure

- **Program.cs**: The entry point of the application where the services are configured and the API routes are defined.
- **WeatherController.cs**: Contains the `GetWeather` method that returns weather forecast data.
- **Swagger/OpenAPI**: Enabled for API documentation.

## Available Functions

1. **Swagger Documentation**:
   - Automatically enabled in the development environment. Accessible via the `/swagger` endpoint for API testing and interaction.

2. **Weather Forecast Functionality**:
   - **Endpoint**: `/weatherforecast`
   - **HTTP Method**: `GET`
   - **Functionality**: Retrieves a randomly generated 5-day weather forecast with temperature values in both Celsius and Fahrenheit.

## Swagger UI

The Swagger UI allows you to interact with the API directly from your browser. You can make requests and view responses without needing a separate tool like Postman.

## How the Code Works

- The API is defined using the `MapGet` minimal API function in `Program.cs`.
- The weather forecast data is generated randomly for demonstration purposes.
- Swagger is set up using `AddSwaggerGen()` and is enabled in the development environment for easy testing.

## Future Improvements

- Add additional endpoints to support more functionality, such as fetching weather for specific locations.
- Implement a third-party weather API service to fetch real-time data instead of random values.
- Add authentication and authorization features.

---
