# HIDDEN MK

HIDDEN MK is a travel and discovery website focused on lesser-known places, local stories, food, nature, culture, and experiences across North Macedonia.

The website is designed to help visitors discover destinations and experiences beyond the most commonly visited locations.

## Features

- Destination discovery and destination detail pages
- Travel experiences and experience detail pages
- Travel and local stories
- About and team pages
- Contact form with validation
- FAQ section
- English and Macedonian language support
- Cookie consent
- Privacy Policy and Terms & Conditions
- Custom 404 page
- Responsive design
- Accessibility features
- SEO metadata

## Technologies

- ASP.NET Core MVC
- .NET 10
- C#
- Razor Views
- Bootstrap 5.3.3
- Bootstrap Icons
- HTML5
- CSS3
- JavaScript

## Project Structure

```text
HiddenMK/
├── Controllers/
├── Models/
├── Services/
├── Views/
├── wwwroot/
├── Properties/
├── Program.cs
├── HiddenMK.csproj
├── appsettings.json
└── appsettings.Development.json
```

### Controllers

The controllers handle the main sections of the website:

- Home
- Discover
- Destinations
- Experiences
- Stories
- About
- Contact
- FAQ
- Legal
- Language

### Models

The project contains models for:

- Destinations
- Experiences
- Stories
- Contact messages
- Language selection

### Services

`LocalizationService` provides the English and Macedonian translations used throughout the website.

## Getting Started

### Prerequisites

Install the .NET 10 SDK before running the project.

### Clone the repository

```bash
git clone https://github.com/jovanoskas/HiddenMK.git
```

### Open the project

```bash
cd HiddenMK
```

### Restore dependencies

```bash
dotnet restore
```

### Build the project

```bash
dotnet build
```

### Run the application

```bash
dotnet run
```

The terminal will display the local address where the application is running. Open that address in a browser.

For example:

```text
http://localhost:5205
```

## Using the Website

The main navigation provides access to the following sections:

### Discover

Explore different types of destinations and places across North Macedonia.

### Destinations

Browse destinations and open individual destination pages for additional information.

### Experiences

Explore available experiences and use the adventure finder to filter experiences based on interests and difficulty.

### Stories

Browse travel stories and articles about destinations, local traditions, food, and experiences.

### About

Learn about the purpose of HIDDEN MK and the concept behind the platform.

### Team

View information about the HIDDEN MK team.

### Contact

Submit a message or recommend a place using the contact form.

### FAQ

View answers to frequently asked questions.

### Legal

The footer contains links to the Privacy Policy and Terms
