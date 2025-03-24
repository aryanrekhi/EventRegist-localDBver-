
# 🎟️ Event Registration App

An ASP.NET Core Razor Pages application for managing event attendees with real-time validation, dark/light mode, and built-in API support.

---

## 🚀 Features

- Register new clients with real-time validation  
- Dark Mode & Light Mode toggle  
- Responsive and modern UI with TailwindCSS & Bootstrap  
- Select multiple event days with checkboxes  
- Prevent duplicate email registrations  
- Edit & delete clients with real-time UI updates  
- Live search and filtering  
- Download data as CSV  
- Exposes Web API (`/api/clients`)  
- SQL Server database integration  

---

## ⚙️ Prerequisites

- [.NET SDK 9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  
- [SQL Server (Developer Edition)](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)  
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)  
- Git  
- (Optional) Visual Studio 2022+ with ASP.NET & EF Core workloads  
- (Optional) Visual Studio Code with C#, Razor, and EF Core extensions  

---

## 📦 Setup Instructions

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/aryanrekhi/EventRegistrationApp.git
cd EventRegistrationApp
```

---

### 2️⃣ Install .NET EF Tool

```bash
dotnet tool install --global dotnet-ef
```

---

### 3️⃣ Restore Dependencies

```bash
dotnet restore
```

---

## 🧩 Database Setup Using SQL Server Management Studio (SSMS)

### ✅ Step 1: Create the Database

1. Open **SSMS** and connect to your SQL Server instance.
2. Right-click on `Databases` → `New Database`.
3. Name it: `EventRegistrationDB` → Click **OK**

---

### ✅ Step 2: Update Connection String in `appsettings.json`

Replace the existing connection string with your actual SQL Server details:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=EventRegistrationDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

For SQL Server Express:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=EventRegistrationDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

For SQL authentication:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=EventRegistrationDB;User Id=your_username;Password=your_password;TrustServerCertificate=True;"
}
```

---

### ✅ Step 3: Apply Database Migrations

```bash
dotnet ef database update
```

---

## ▶️ Running the App

```bash
dotnet clean
dotnet build
dotnet run
```

Visit in your browser:

- Register client: `http://localhost:5168/Clients/Create`  
- View clients: `http://localhost:5168/Clients/Index`  
- API JSON output: `http://localhost:5168/api/clients`

---

## 🔁 Reset Database (Optional)

```bash
dotnet ef database drop --force
dotnet ef database update
```

---

## 📡 API Endpoints

| Method | Endpoint                 | Description               |
|--------|--------------------------|---------------------------|
| GET    | `/api/clients`           | Fetch all clients         |
| GET    | `/api/clients/{id}`      | Get client by ID          |
| DELETE | `/api/clients/{id}`      | Delete client             |
| PUT    | `/api/clients/{id}`      | Update client             |

---

## 🛠 Tech Stack

- ASP.NET Core Razor Pages  
- Entity Framework Core  
- SQL Server  
- TailwindCSS + Bootstrap  
- Font Awesome  
- JavaScript  

---

## 👤 Author

Developed by Aryan Rekhi  
GitHub: [@aryanrekhi](https://github.com/aryanrekhi)
