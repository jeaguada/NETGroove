# ElectroBeat

![ElectroBeat Logo](link_to_your_logo.png)

ElectroBeat is a cutting-edge electronic music streaming platform built with .NET Aspire, offering a seamless and immersive experience for electronic music enthusiasts.

## Table of Contents

- [Features](#features)
- [Technology Stack](#technology-stack)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Project Structure](#project-structure)
- [Configuration](#configuration)
- [Deployment](#deployment)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Features

- 🎵 Vast library of electronic music tracks
- 🎨 Artist profiles with real-time information scraping
- 📀 Album and playlist management
- 🔍 Advanced search and filtering capabilities
- 🎧 High-quality audio streaming
- 👥 User profiles and social features
- 📊 Personalized music recommendations
- 📱 Responsive web interface

## Technology Stack

- **.NET Aspire**: For orchestrating and managing our microservices architecture
- **C# 10**: Primary programming language
- **ASP.NET Core**: Web API framework
- **Entity Framework Core**: ORM for database interactions
- **SQL Server**: Primary database
- **Vue 3**: Frontend framework
- **PuppeteerSharp**: For web scraping artist information
- **Docker**: Containerization
- **Azure**: Cloud hosting and services

## Getting Started

### Prerequisites

- .NET 8 SDK
- Docker Desktop
- SQL Server
- Node.js and npm

### Installation

1. Clone the repository:
# NETGroove

![NETGroove Logo](link_to_your_logo.png)

NETGroove is a cutting-edge electronic music streaming platform built with .NET Aspire, offering a seamless and immersive experience for electronic music enthusiasts.

## Table of Contents

- [Features](#features)
- [Technology Stack](#technology-stack)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Project Structure](#project-structure)
- [Configuration](#configuration)
- [Deployment](#deployment)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Features

- 🎵 Vast library of electronic music tracks
- 🎨 Artist profiles with real-time information scraping
- 📀 Album and playlist management
- 🔍 Advanced search and filtering capabilities
- 🎧 High-quality audio streaming
- 👥 User profiles and social features
- 📊 Personalized music recommendations
- 📱 Responsive web interface

## Technology Stack

- **.NET Aspire**: For orchestrating and managing our microservices architecture
- **C# 8**: Primary programming language
- **ASP.NET Core**: Web API framework
- **Entity Framework Core**: ORM for database interactions
- **SQL Server**: Primary database
- **Vue.js**: Frontend framework
- **PuppeteerSharp**: For web scraping artist information
- **Docker**: Containerization
- **Azure**: Cloud hosting and services

## Getting Started

### Prerequisites

- .NET 8 SDK
- Docker Desktop
- SQL Server
- Node.js and npm

### Installation

1. Clone the repository:

git clone https://github.com/jeaguada/NETMusic.git

2. Navigate to the project directory:

cd ElectroBeat

3. Restore the .NET packages:

dotnet restore

4. Set up the database:

dotnet ef database update

5. Run the application:

dotnet run --project ElectroBeat.AppHost

## Project Structure

- `NETMusic.AppHost`: Entry point for the Aspire application
- `NETMusic.ServiceDefaults`: Shared configurations for services
- `NETMusic.ApiGateway`: API Gateway for routing requests
- `NETMusic.UserService`: Handles user authentication and profiles
- `NETMusic.CatalogService`: Manages music catalog
- `NETMusic.PlaylistService`: Manages playlists
- `NETMusic.StreamingService`: Handles audio streaming
- `NETMusic.RecommendationService`: Generates personalized recommendations
- `NETMusic.ArtistInfoService`: Fetches and manages artist information
- `NETMusic.Web`: Web frontend application

## DB Diagram

https://dbdocs.io/ariscorpo/NETMusic

## Configuration

Configuration settings can be found in the `appsettings.json` files within each project. Sensitive information should be stored in user secrets or environment variables.

## Deployment

ElectroBeat is designed to be deployed to Azure Container Apps or any Kubernetes cluster. Refer to the [Deployment Guide](link_to_deployment_guide.md) for detailed instructions.

## Contributing

We welcome contributions! Please see our [Contributing Guidelines](link_to_contributing.md) for more details.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any inquiries, please reach out to us at contact@electrobeat.com.

---

NETMusic - Amplifying Your Electronic Music Experience 🎶