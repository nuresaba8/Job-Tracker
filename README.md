💼 Job Application Tracker System
The Job Application Tracker System is a web-based platform built with ASP.NET Web API and Entity Framework, designed to help users manage and track their job applications efficiently.

🔧 Key Features
User Registration & Authentication
Users can sign up, log in, and manage sessions securely with OAuth 2.0 token-based authentication.

Job Application Management
Users can apply for jobs, add application details like company, position, application date, and deadlines.

Status Tracking
Every job application is associated with a status (e.g., Applied, Interviewed, Offered, Rejected), which can be updated throughout the process.

Notes Section
Users can add and update personal notes for each job application (e.g., feedback, follow-up reminders).

Deadline Notifications
Automatically notifies users 2 days before the application deadline.

CSV Export
Users can export their list of job applications as a CSV file for offline tracking or reporting.

Role-Based System
Built-in roles like User, Admin, and Candidate support role-specific operations.

🛠 Technologies Used
Backend: ASP.NET Web API

ORM: Entity Framework (Code First)

Authentication: OAuth 2.0

Database: SQL Server

Architecture: Layered (DAL, BLL, API)

📁 Folder Structure
DAL – Entity Framework Models and Repositories

BLL – DTOs and Services

API – Controllers and Endpoints

Auth – OAuth Token Provider

✅ How to Run
Clone the repository

Update connection string in Web.config

Run Update-Database from Package Manager Console

Start the API project

Use Postman or any API client to test endpoints

