# Ninja Manager — Inventory Management Web App  
**Avans Hogeschool – Bachelor Year 2**  
**Course: PRG5 (Programming with C# / MVC)**

---

## 🥷 Project Overview  
Ninja Manager is a web application built as the final assignment for the PRG5 course at Avans University of Applied Sciences.  
Although the assignment was originally intended to be completed in pairs, this project was developed entirely solo.

The goal was to design an administrative interface for managing ninjas and their gear using **C#** and the **MVC framework**.

## 🎮 About the Application  
The application simulates an in-game gear system where users can:

- Create, edit, and delete ninjas  
- Equip ninjas with gear via a virtual shop  
- Manage gear by equipment slot (e.g., helmet, boots, armor)  
- View cumulative stats: strength, intelligence, agility, and total gold value  
- Reset a ninja’s inventory and refund gold  
- Optimize gear purchases based on available gold

Each equipment type has its own slot, and stats update dynamically based on the current inventory.

## 🛠️ Technologies Used  
- **C#** — Application logic  
- **ASP.NET MVC** — Web framework  
- **Entity Framework** — ORM for database operations  
- **Razor Views** — Frontend rendering  
- **SQL Server** — Data storage for ninjas and gear

## ▶️ How to View  
To run the project locally:

1. Clone or download the repository  
2. Open the solution (`.sln`) file in **Visual Studio**  
3. Ensure SQL Server is running and a connection string is configured (check `appsettings.json`)  
4. Apply any pending migrations using the Package Manager Console `Update-Database`
5. Press **F5** or click **Start** to run the application in your browser

⚠️ *Note: You may need to adjust database settings depending on your environment.*

---

Made with ⚔️ at Avans Hogeschool - by Pepijn Emmers
