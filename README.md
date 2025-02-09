# JobTracker API

🚀 **A Complete .NET Core Web API for Job Applications Management**

## **📌 Overview**
JobTracker is a **full-featured job tracking API** that allows users to:
- Register/Login with **JWT authentication**
- **Role-based access control** (User vs Admin)
- **CRUD operations** on job applications (Admins only)
- Store job applications in **SQL Server**
- API documentation via **Swagger UI**
- Ready for **Cloud Deployment (Google Cloud/Azure)**

## **🛠 Tech Stack**
- **Backend**: ASP.NET Core 7.0
- **Database**: SQL Server (EF Core Code-First)
- **Authentication**: ASP.NET Identity + JWT
- **Authorization**: Role-Based Access (User & Admin)
- **API Documentation**: Swagger (OpenAPI)
- **Version Control**: Git & GitHub
- **Cloud Deployment**: Google Cloud App Engine (Planned)

---

## **📦 Features**
**User Authentication & Authorization** (JWT-based)
**Role-Based Access (User vs Admin)**
**CRUD Operations for Job Applications**
**Secure API Endpoints with Middleware**
**Swagger UI for API Documentation**
**Database Migrations with Entity Framework Core**
**Google Cloud / Azure Ready Deployment**

---

## **🛠 Setup & Installation**
### **1️ Clone Repository**
```sh
git clone https://github.com/HarisTechWerk/JobTracker.git
cd JobTracker
```

### **2️ Configure Database (SQL Server)**
Ensure SQL Server is running and update `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SERVER;Database=JobTrackerDB;Trusted_Connection=True;"
}
```

### **3️ Apply Migrations & Seed Data**
```sh
dotnet ef database update
```

### **4️ Run the API**
```sh
dotnet run
```
✅ API should be running at `https://localhost:5001/swagger`

---

## **🔗 API Endpoints**

### **🔑 Authentication**
| Method | Endpoint | Description |
|--------|---------|-------------|
| POST | `/api/Auth/register` | Register a new user |
| POST | `/api/Auth/login` | Login and get JWT Token |

### **📄 Job Applications**
| Method | Endpoint | Role | Description |
|--------|---------|------|-------------|
| GET | `/api/JobApplication` | User/Admin | Fetch all job applications |
| POST | `/api/JobApplication` | Admin | Create a new job application |
| PUT | `/api/JobApplication/{id}` | Admin | Update a job application |
| DELETE | `/api/JobApplication/{id}` | Admin | Delete a job application |

---

## **📌 How to Test the API**

### **🚀 1️ Test via Swagger UI**
Go to 👉 `https://localhost:5001/swagger`

### **🔑 2️ Authorize Requests**
1. **Login (`/api/Auth/login`)** to get JWT token
2. Click **Authorize** (🔑) in Swagger and enter `Bearer JWT_TOKEN`

### **📡 3️ Test API Endpoints**
 **Try POST as a User** → Should return `403 Forbidden`
 **Try POST as an Admin** → Should return `201 Created`
 **Try GET requests** → Should work for everyone

---

## **🚀 Deployment Plan (Google Cloud)**

### **📡 Google Cloud Setup**
1. Create a Google Cloud Free Tier Account
2. Install **Google Cloud CLI**
3. Deploy API to **Google App Engine**
4. Use **Cloud SQL for database**
5. CI/CD with **GitHub Actions (Planned)**

---

## **👨‍💻 Future Enhancements**
- ✅ **Google Cloud Deployment**
- 🔒 **JWT Refresh Tokens**
- 📊 **Logging & Monitoring**
- 📱 **Frontend Integration (React/Angular)**
- 🚀 **Docker Containerization**

---

## **📌 Contact**
👤 **Haris Qureshi**  
📧 **harisdevpro@outlook.com**  
🔗 **[LinkedIn](https://www.linkedin.com/in/haris-qureshi-0979801aa/)**  
🚀 **[GitHub](https://github.com/HarisTechWerk)**  

---


