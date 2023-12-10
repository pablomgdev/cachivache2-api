> [!WARNING]  
> This repository is no longer maintained. See [the new monorepo](https://github.com/pablomgdev/cachivache2).

<h1 align=center>API 4 Cachivache2</h1>

[![Build and test](https://github.com/pablomgdev/cachivache2-api/actions/workflows/ci-build-and-test.yaml/badge.svg?branch=main)](https://github.com/pablomgdev/cachivache2-api/actions/workflows/ci-build-and-test.yaml)

API for an app that allows its users to upload images of the things they like, let their friends know what they are those things in order know what to give them when they need that information (special moments like birthdays, for example).

## 📄 Table of content

- [What is this app for?](#what-is-this-app-for)
- [Project structure](#project-structure)
- [Project dashboard](#project-dashboard)
- [Contribute](#contribute)
- [Pending](#pending)
- [Licence](#licence)

<a name=what-is-this-app-for>

## ℹ️ What is this app for?

Have you ever not known what to give someone because you do not know what he/she like? Have you ever not remember what your boyfriend/girlfriend wanted for its birthday? This app has been created to solve this kind of problems in a curious way.

With this app, people will able to upload photos of stuff in order to make their friends know what they like but, this photos, will not be visible for the person who uploaded them. By doing it in this way, the person who uploaded the images will not remember the things he/she uploaded. Only its friends will know.

If you are a person who does not know what to buy someone, this is your salvation. This app will make everything easy for you.

<a name=project-structure>

## 🏛️ Project structure

Is based on ports and adapters architecture with vertical slicing and Domain Driven Desing (DDD). Look at the [architecture](https://github.com/pablomgdev/cachivache2-api/blob/main/docs/diagrams/architecture/excalidraw-rest-api-architecture.png) on the docs folder.

<details>
<summary>See structure</summary>

Note: if it is outdated, feel free to update it.

```shell
src
├── Api
│   ├── Api.csproj
│   ├── Controllers
│   │   └── UsersController.cs
│   ├── Program.cs
│   ├── Properties
│   │   └── launchSettings.json
│   ├── appsettings.Development.json
│   └── appsettings.json
├── ApiSdk
│   ├── ApiResponse.cs
│   ├── ApiResponseError.cs
│   ├── ApiSdk.csproj
│   ├── Requests
│   └── Responses
├── AppRequests
│   ├── AppRequests.csproj
│   ├── Application
│   │   └── AppRequests.Application.csproj
│   ├── Domain
│   │   └── AppRequests.Domain.csproj
│   └── Infrastructure
│       └── AppRequests.Infrastructure.csproj
├── Notifications
│   ├── Application
│   │   └── Notifications.Application.csproj
│   ├── Domain
│   │   └── Notifications.Domain.csproj
│   ├── Infrastructure
│   │   └── Notifications.Infrastructure.csproj
│   └── Notifications.csproj
├── Presents
│   ├── Application
│   │   └── Presents.Application.csproj
│   ├── Domain
│   │   └── Presents.Domain.csproj
│   ├── Infrastructure
│   │   └── Presents.Infrastructure.csproj
│   └── Presents.csproj
├── Shared
│   ├── Domain
│   │   ├── Shared.Domain.csproj
│   │   └── Users
│   │       ├── Exceptions
│   │       └── ValueObjects
│   └── Shared.csproj
└── Users
    ├── Application
    │   └── Users.Application.csproj
    ├── Domain
    │   ├── User.cs
    │   └── Users.Domain.csproj
    ├── Infrastructure
    │   └── Users.Infrastructure.csproj
    └── Users.csproj
```

</details>

<a name=project-dashboard>

## 📊 Project dashboard

It is managed on Trello. There can be found all the project ideas, tasks and their states. ~~Click here to go there~~.

<a name=contribute>

## 👥 Contribute

Would you like to add new features or ideas? Do you know how to improve the code? Is there something wrong or outdated? Please, feel free to contribute.

<a name=pending>
  
## 🧱 Pending
- Add app name.
- Add "Project setup" section to show the tools needed, how to configure the project and how to run it.
- Add documentation about the app on GitHub project wiki (how the app works, use cases, architecture, etc).
- Create issues. Take a look at the ~~Trello dashboard~~.
- Add link to the frontend app when it exists.

<a name=licence>
  
## 🪪 Licence
[GNU GPLv3](https://github.com/pablomgdev/cachivache2-api/blob/main/LICENSE).
