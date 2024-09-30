## 📖 PublishCMS

This project contains a sample ASP.NET Core app. This app is an example of the article I produced for the Telerik Blog (telerik.com/blogs)

This is an ASP.NET Core project that leverages Ocelot for routing, rate limiting, and in-memory caching.

### 🛠️ Features

Routing: Efficiently routes requests to appropriate microservices using Ocelot.
Rate Limiting: Protects your services from being overwhelmed by too many requests.
In-memory Caching: Improves performance by storing frequently accessed data in memory.

### 📦 Requirements

- .NET 6.0 or higher
- Ocelot package

### 📥 Installation

- Clone the repository:

```
clone https://github.com/zangassis/publish-cms.git
cd PublishCMS
```

- Run the project:

```
dotnet run
```

### 🚀 Usage

After starting the application, you can send requests to the defined endpoints. The routing, rate limiting, and caching will be handled automatically by Ocelot.
