## ChallengeTracker - Backend

This repository contains the backend for the ChallengeTracker, implemented in .NET. It includes API, application logic, infrastructure (EF Core), and domain models.

## Quick start

From the solution root, run the API with hot reload:

```bash
dotnet watch run --project ChallengeTracker.Api
```

or

```bash
dotnet run --project ChallengeTracker.Api
```

## Database / EF Core common commands

Run these from the solution root. Replace `MigrationName` with a descriptive name.

-   Add migration:

```bash
dotnet ef migrations add MigrationName -s ChallengeTracker.Api -p ChallengeTracker.Infrastructure
```

-   Apply pending migrations to the database:

```bash
dotnet ef database update -s ChallengeTracker.Api -p ChallengeTracker.Infrastructure
```

-   Remove last migration (if not applied):

```bash
dotnet ef migrations remove -s ChallengeTracker.Api -p ChallengeTracker.Infrastructure
```

