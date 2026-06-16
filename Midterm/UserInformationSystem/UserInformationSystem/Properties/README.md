<div align="center">

# 🌸 User Information System

<img src="https://media.tenor.com/AAMEFNsRaeEAAAAM/anime-girl.gif" width="300"/>

### CS 211 — Object Oriented Programming

### Created by: **LEVI**

</div>

---

# 📖 Overview

User Information System is a Windows Forms application developed to demonstrate the integration of:

* 🖥️ Windows Forms GUI Development
* 🔒 Encapsulation
* ☁️ Firebase Realtime Database Connectivity
* ⚡ Asynchronous Programming
* 🧩 Classes and Objects

The application allows users to input personal information through a graphical interface, organize the data using a custom class, and store the information inside a Firebase database.

---

# 📝 Activity Objective

The purpose of this activity was to understand:

* How to create interactive Windows Forms applications
* How encapsulation works using getters and setters
* How to instantiate and use objects
* How to connect a C# application to a cloud database
* How asynchronous database operations function

This activity serves as an introduction to database-integrated desktop applications using Object-Oriented Programming principles.

---

# ✨ Features

* 👤 User Information Input
* 🔒 Encapsulated User Class
* ☁️ Firebase Database Integration
* ⚡ Async Data Saving
* 💬 MessageBox Notifications
* 🧹 Clear Button Functionality
* 🖱️ Windows Forms Interface
* 📦 Structured User Object Creation

---

# 🧠 OOP Concepts Applied

## 🧩 Classes and Objects

A custom:

```csharp
UserClass
```

was created to organize user-related information.

Objects are instantiated inside the form to store and process data.

---

## 🔒 Encapsulation

User data is managed securely using encapsulated attributes through:

* Getters
* Setters
* Controlled access methods

This ensures proper organization and safer handling of information.

---

## ⚡ Asynchronous Programming

Firebase database operations were implemented using:

```csharp
async
await
```

This allows smoother interaction with the application while data is being saved online.

---

# ☁️ Firebase Integration

The project connects to:

* Firebase Realtime Database

using:

* `HttpClient`
* JSON Serialization
* REST API requests

The application demonstrates how desktop applications can communicate with cloud-based databases.

---

# 🔧 Required Setup Before Running

Since this project uses Firebase Realtime Database, users who clone or download this repository must create their own Firebase database.

---

## 📌 Step 1 — Create a Firebase Realtime Database

Go to:

https://console.firebase.google.com/

Then:

1. Create a new Firebase Project
2. Open:

   ```text
   Realtime Database
   ```
3. Create a database
4. Copy your database URL

Example:

```csharp
https://yourproject-default-rtdb.firebaseio.com/
```

---

## 📌 Step 2 — Replace the Base URL

Inside:

```text
FirebaseHelper.cs
```

replace:

```csharp
private static readonly string baseUrl =
"https://oopdatabase-671fc-default-rtdb.firebaseio.com/";
```

with your own Firebase Realtime Database URL.

---

## 📌 Step 3 — Install Required NuGet Package

This project requires:

```text
Newtonsoft.Json
```

Install using:

* NuGet Package Manager

### OR

Package Manager Console:

```powershell
Install-Package Newtonsoft.Json
```

---

# 🔐 Firebase Security Note

Before uploading this repository publicly, the Firebase database rules were changed from:

```json
".read": true,
".write": true
```

to:

```json
".read": true,
".write": false
```

This was done to prevent public users from modifying or overwriting the database contents after the project was uploaded.

If you wish to test database writing functionality locally, you may temporarily enable write permissions in your own Firebase project.

---

# 🎨 User Interface Design

The application uses a soft and minimal aesthetic design featuring:

* 🌸 MistyRose background
* ❤️ LightCoral text accents
* 🧼 Organized form layout
* ✨ Simple and clean interface styling

The design was intentionally kept soft and comfortable while maintaining readability and usability.

<img src="https://media.giphy.com/media/3oriO0OEd9QIDdllqo/giphy.gif" width="320"/>

---

# 🛠️ Technologies Used

* C#
* Windows Forms
* Visual Studio
* Firebase Realtime Database
* Newtonsoft.Json
* HttpClient API

---

# 📚 Learning Reflection

This activity helped strengthen understanding of:

* GUI Development
* Database Connectivity
* Encapsulation
* Cloud Data Storage
* Async Programming
* Object-Oriented Design

It demonstrates how programming concepts can work together to build a functional information management application.

---

# ⚠️ Important Reminder

This repository is intended for:

* Learning purposes
* Academic reference
* OOP practice

If you plan to use or modify this project:

* configure your own Firebase database
* use your own database URL
* install the required packages properly

Do not rely on the original Firebase database connection included in this repository.

---

<div align="center">

### ✨ “Applications become more powerful when objects, interfaces, and databases work together.”

</div>
