# 🧠 COP2360 Module 7 – Group 3 Dictionary Project

### 👥 Team Members
- **Justin Robinson** – Lead / Repo Owner  
- **Robert Weinberger** – Menu Developer  
- **Nayobe Jean-Louis** – CRUD Developer  
- **Leopoldo Ramos** – Extras Developer  
- **Donovan Zangwill** – Display & Documentation  

---

## 🧩 Project Overview
This project is a **C# console-based Dictionary Management System** developed collaboratively by **Group 3** for **Module 7** in COP2360 (C# Programming).  
The program allows users to **add, search, update, delete, and display dictionary entries** in a clean, menu-driven format.  

It demonstrates teamwork, version control via GitHub, and the use of object-oriented design principles such as:
- Classes and methods organization  
- Proper data handling using `Dictionary<string, List<string>>`  
- Input validation and user feedback  
- Structured menus and modular logic  

---

## 🚀 Features

### 🗂️ Core Functions
- **Add New Word** – Add a new word and definition to the dictionary  
- **Search for Word** – Find an existing word quickly  
- **Update Entry** – Edit or replace a word’s definition  
- **Delete Entry** – Remove a word from the dictionary  
- **View All Entries** – Show every stored word and its definitions  
- **Extras Menu** – Includes options to preload data and clear all entries  

---

### 🌟 Extras & Easter Eggs
- **Custom Startup Banner**  
  Displays a cyan and green “Group 3 Dictionary Manager” header when the program starts  

- **Random Fun Fact Generator**  
  Shows a random message such as a debugging tip or turtle fact at startup  

- **Hidden Commands**  
  - Type **`rjnld`** → Reveals Group 3’s hidden team signature  
  - Type **`group3`** → Displays a secret developer message  

- **Colorized Exit Message**  
  A fun closing message credits the entire team:
  > “Developed with care by R.J.N.L.D ❤️”

These additions make the application engaging and visually appealing while showing creativity and strong understanding of user experience design.

---

## 👨‍💻 Team Contributions

| Member | Role | Contributions |
|--------|------|----------------|
| **Justin Robinson** | **Lead / Repo Owner** | Created the GitHub repository, organized the team structure, handled version control and merges, integrated all files, fixed namespace and build errors, added color formatting and Easter eggs, and coordinated project submission. |
| **Robert Weinberger** | **Menu Developer** | Designed the main menu and implemented the switch statement logic to connect menu options to functions. Established the framework for user interaction and input validation. |
| **Nayobe Jean-Louis** | **CRUD Developer** | Developed the core dictionary logic in `Operations.cs`, including methods for adding, searching, updating, and deleting entries. Also built the Extras Menu and Populate/Clear Dictionary functions. |
| **Leopoldo Ramos** | **Extras Developer** | Enhanced user experience with startup banner, random fun fact system, Easter eggs, and color-coded messages. Assisted in debugging menu navigation and refining user interface flow. |
| **Donovan Zangwill** | **Display & Documentation** | Helped format console output for clarity, adjusted alignment and spacing in menu screens, and documented project sections for readability. Contributed to writing and formatting this README file. |

---

## 🧰 File Breakdown

| File | Role | Description |
|------|------|-------------|
| `Program.cs` | Main Application | Runs the program, handles user input, and controls menu logic |
| `Operations.cs` | CRUD Logic | Contains all dictionary management methods (add, search, update, delete, clear) |
| `Menu.cs` | Placeholder | Developed by Robert for possible menu expansion |
| `README.md` | Documentation | Full overview of project, features, and team roles |

---

## 💻 How to Run

To build and run the Group 3 Dictionary Project:

```bash
git clone https://github.com/Justincase725/COP2360_Module7_DictionaryProject_Group3.git
cd COP2360_Module7_DictionaryProject_Group3
dotnet build
dotnet run
