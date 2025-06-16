<p align="center">
  <img src="https://github.com/Pianonic/SIMGate/blob/main/Images/Icon.png?raw=true" alt="SIMGate Logo" width="300"/>
</p>

<h1 align="center">SIMGate</h1>

<p align="center">
  <strong>A full-stack solution for sending and receiving SMS messages via an Arduino-connected SIM card.</strong>
</p>

<p align="center">
  <a href="https://github.com/Pianonic/SIMGate">
    <img src="https://badgetrack.pianonic.ch/badge?url=https://github.com/Pianonic/SIMGate&label=Visitors&color=0078D4&style=flat&logo=github" alt="Visitor Count" style="vertical-align: middle;"/>
  </a>
  <a href="https://github.com/Pianonic/SIMGate/blob/main/LICENSE.md">
    <img src="https://img.shields.io/badge/License-CC%20BY--NC%204.0-0078D4.svg" style="vertical-align: middle;"/>
  </a>
  <img src="https://img.shields.io/badge/C%23-Backend-0078D4.svg" style="vertical-align: middle;"/>
  <img src="https://img.shields.io/badge/Angular-Frontend-0078D4.svg" style="vertical-align: middle;"/>
</p>

---

**SIMGate** is a comprehensive solution for managing SMS messages using a SIM card connected to an Arduino. It bridges the gap between hardware and software by providing a full-stack system with a C# backend, an Angular frontend, and Arduino-based communication. 

## 🚀 Features

- **Arduino Integration**: An Arduino with a SIM card adapter to send and receive SMS messages.
- **C# Backend**: A robust backend that communicates with the Arduino over a serial connection.
- **REST API**: Fetch and send SMS messages via an API.
- **Angular Frontend**: A user-friendly interface to easily manage SMS messages and the SIM card.

## 🛠️ Architecture Overview

1.  🤖 **Arduino with SIM Card Adapter**
    - Sends and receives SMS messages via the SIM card.
    - Communicates with the backend over a serial connection.

2.  💻 **C# Backend**
    - Manages serial communication with the Arduino.
    - Provides a REST API to:
      - 📥 **Fetch SMS**: Retrieve SMS messages from the SIM card.
      - 📤 **Send SMS**: Send SMS messages using the SIM card.
    - Handles SMS storage and management.

3.  🖥️ **Angular Frontend**
    - 📱 **SMS Management**: View and manage SMS messages.
    - 🧾 **SIM Card Management**: Manage SIM card settings.
    - User-friendly interface to interact with the backend API.

## 📜 License
This project is licensed under the [CC BY-NC 4.0](LICENSE.md).

---
<p align="center">Made with ❤️ by <a href="https://github.com/Pianonic">PianoNic</a></p>
