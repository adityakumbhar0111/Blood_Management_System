# Blood Management System (C#.NET + MySQL)

A **desktop application** for managing blood donations and requests, built using **C#.NET (WinForms)**, **MySQL**, and modern UI styling. The system manages donors, patients, and admins while enforcing donation eligibility rules (3-month interval between donations).

---

## 📖 Overview

The Blood Management System helps in maintaining records of blood donors and patients who request blood. It ensures donor eligibility, checks blood group compatibility, and provides a simple admin dashboard for management.

---

## ✨ Features

- **User Registration & Login** (Donor / Patient / Admin)  
- **Donor Dashboard**  
  - Donate blood (checks 3-month donation rule)  
  - View donation history  
- **Patient Dashboard**  
  - Request blood units  
  - View request history  
- **Admin Panel**  
  - Manage users (donors & patients)  
  - Manage donations & requests  
  - View overall blood stock  
- **Database Persistence** with MySQL  
- **Responsive UI** with WinForms + custom UI libraries  

---

## 🛠 Tech Stack

- **Language:** C#.NET (Windows Forms Application)  
- **Database:** MySQL  
- **IDE:** Visual Studio 2022 (or 2020)  
- **UI:** WinForms + custom controls  

---

## 📂 Project Structure
BloodManagementSystem/ <br>
├─ Forms/ <br>
│ ├─ LoginForm.cs <br>
│ ├─ RegisterForm.cs <br>
│ ├─ DonorDashboard.cs <br>
│ ├─ PatientDashboard.cs <br>
│ ├─ DonateBloodForm.cs <br>
│ ├─ RequestBloodForm.cs <br>
│ ├─ AdminDashboard.cs <br>
├─ Models/ <br>
│ ├─ User.cs <br>
│ ├─ Donation.cs <br>
│ ├─ Request.cs <br>
├─ Services/ <br>
│ ├─ Database.cs <br>
│ ├─ UserService.cs <br>
│ ├─ DonationService.cs <br>
│ ├─ RequestService.cs <br>
├─ Program.cs <br>
└─ README.md <br>


---

## 🗄 Database Schema (MySQL)

```sql
CREATE DATABASE blood_management;
USE blood_management;

-- Users
CREATE TABLE users (
  id INT AUTO_INCREMENT PRIMARY KEY,
  fullname VARCHAR(100) NOT NULL,
  email VARCHAR(150) NOT NULL UNIQUE,
  password_hash VARCHAR(255) NOT NULL,
  role ENUM('DONOR','PATIENT','ADMIN') NOT NULL,
  blood_group VARCHAR(5),
  last_donation_date DATE,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Donations
CREATE TABLE donations (
  id INT AUTO_INCREMENT PRIMARY KEY,
  donor_id INT NOT NULL,
  blood_group VARCHAR(5) NOT NULL,
  donation_date DATE NOT NULL,
  FOREIGN KEY (donor_id) REFERENCES users(id) ON DELETE CASCADE
);

-- Requests
CREATE TABLE requests (
  id INT AUTO_INCREMENT PRIMARY KEY,
  patient_id INT NOT NULL,
  blood_group VARCHAR(5) NOT NULL,
  units INT NOT NULL,
  request_date DATE NOT NULL,
  status ENUM('PENDING','FULFILLED','REJECTED') DEFAULT 'PENDING',
  FOREIGN KEY (patient_id) REFERENCES users(id) ON DELETE CASCADE
);

⚙️ Installation & Setup

Open Visual Studio → Create Windows Forms App (.NET Framework)

Add MySql.Data via NuGet Package Manager

Update connection string in Database.cs:

private static string connString = "server=localhost;database=blood_management;user=root;password=your_password;";


Run the SQL script in MySQL Workbench/CLI

Press F5 to run the project

🚦 Usage Flow

Register/Login as Donor or Patient

Donor → Donate blood (system checks 3-month rule)

Patient → Request blood units

Admin → Approve/reject requests, manage donations, view stock

Users can check their donation/request history

❗ Troubleshooting

MySQL Connection Error → Check MySQL service and connection string

NuGet Issues → Install MySql.Data via NuGet

Password Issues → Use hashed storage (SHA256/BCrypt)
