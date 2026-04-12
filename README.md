# 🔐 Cybersecurity Awareness Chatbot

## 📌 Project Overview
This project is a C# console-based chatbot designed to educate users about cybersecurity threats such as phishing, password safety, and safe browsing. It simulates real-world cyberattack scenarios to help users learn how to respond safely online.

The chatbot interacts with users through conversation, audio (voice greeting), ASCII visuals, and scenario-based learning.

---

## 🎯 Features

- 🎤 Voice greeting on startup (WAV audio playback)
- 🖼️ ASCII art welcome screen
- 💬 Interactive chatbot conversation system
- 🔐 Cybersecurity education (password safety, phishing, safe links)
- 🎭 Scenario-based phishing simulation (decision-based learning)
- ❌ Input validation and error handling
- 🎨 Enhanced console UI (colors, spacing, borders)
- 🧠 Personalized responses using user name

---

## 🛠️ Technologies Used

- C# (.NET 10 Windows)
- Object-Oriented Programming (OOP)
- System.Media (audio playback)
- Console Application

---

## 📂 Project Structure

CyberSecurityBot/
│── Program.cs  
│── Chatbot.cs  
│── UIHelper.cs  
│── AudioPlayer.cs  
│── assets/  
│   └── greeting.wav  
│── README.md  

---

## 🚀 How to Run the Project

1. Open the project in Visual Studio  
2. Ensure `greeting.wav` is inside the `assets` folder  
3. Set target framework to:

net10.0-windows

4. Build the solution:

Ctrl + Shift + B

5. Run the application:

Ctrl + F5


---

## 🎭 Scenario Mode (Cybersecurity Simulation)

Type in the chatbot:

- `scenario`
- `test me`

### What happens:
- A phishing email scenario is displayed
- You choose how to respond (1, 2, or 3)
- The chatbot gives feedback (correct or incorrect)
- You learn how to identify cyber threats in real life

---

## 🔊 Voice Greeting Feature

When the application starts, a WAV audio file plays automatically to welcome the user and improve engagement.

---

## 🧠 Learning Outcomes

This project demonstrates:

- Object-Oriented Programming (OOP)
- Input validation and error handling
- Console application design
- Cybersecurity awareness principles
- Interactive user experience design
- Scenario-based learning simulation

---

## ⚙️ GitHub Actions (CI Pipeline)

This project uses GitHub Actions for Continuous Integration (CI).

Every push automatically:
- Restores dependencies
- Builds the project
- Checks for compilation errors

A successful run is shown by a **green check mark** in the GitHub Actions tab.

---

## 📸 CI Screenshot

(Add your GitHub Actions green check screenshot here)

Example:


---

## 👨‍💻 Author

Shaun Buffel – Cybersecurity Awareness Chatbot

---

## 📌 Purpose

The purpose of this project is to educate users about cybersecurity risks while demonstrating C# programming skills.

It focuses on:
- Phishing awareness
- Password safety
- Safe browsing habits
- Real-world scenario training
- Interactive learning through simulation

![CI Success](ci-Workflow Screenshot)