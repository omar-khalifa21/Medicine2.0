This is a Windows Forms Application built using C# and .NET 8. 
It streamlines the process of ordering and managing medicines in a pharmacy environment.
The system supports both connected and disconnected database operations using Oracle (ODP.NET) and includes robust reporting capabilities powered by Crystal Reports.

🗂️ Project Structure
MedicineOrderingSystem/
│
├── Forms/
│   ├── LoginForm.cs
│   ├── MainForm.cs
│   ├── SearchForm.cs
│   ├── InsertOrderForm.cs
│   ├── MedicineDetailsForm.cs
│   ├── AllMedicinesForm.cs
│   ├── ViewOrderHistoryForm.cs
│   ├── AdminUserManagementForm.cs
│   ├── DisconnectedSelectForm.cs
│   ├── DisconnectedUpdateForm.cs
│   ├── PrescriptionVerificationForm.cs
│   ├── PrescriptionUploadForm.cs
│   ├── ReportsForm.cs
│
├── Reports/
│   ├── CrystalReport1.rpt
│   ├── CrystalReport2.rpt
│
├── Helpers/
│   ├── DBConnection.cs
│
├── Program.cs
├── App.config
├── Docs/
│   ├── DatabaseScripts_Team10.docx
│   ├── CoverPage.docx
└── README.md


⚙️ Features
User authentication with role-based navigation
Medicine browsing and searching (connected mode)
Prescription uploads and pharmacist verification
Order history tracking
User management panel
Crystal Reports integration for data analytics and insights
Support for Oracle database operations (connected/disconnected modes)


🔧 Tech Stack
Language: C# (.NET 8)
UI Framework: Windows Forms
Database: Oracle 11g/12c
Library: ODP.NET
Reporting: Crystal Reports
IDE: Visual Studio 2022

