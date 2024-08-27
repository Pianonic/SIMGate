<p align="center">
  <img src="https://github.com/Pianonic/SIMGate/blob/main/Images/Icon.png?raw=true" alt="PianoNic's Music Bot" width="300"/>
</p>

# 📡 SIMGate

**SIMGate** is a comprehensive solution for managing SMS messages using a SIM card connected to an Arduino. It bridges the gap between hardware and software by providing a full-stack system with a C# backend, an Angular frontend, and Arduino-based communication. 

## 🚀 Features

- **Arduino Integration**: An Arduino with a SIM card adapter to send and receive SMS messages.
- **C# Backend**: A robust backend that communicates with the Arduino over a serial connection.
- **REST API**: Fetch and send SMS messages via an API.
- **Angular Frontend**: A user-friendly interface to easily manage SMS messages and the SIM card.

## 🛠️ Architecture Overview

1. **Arduino with SIM Card Adapter**
   - Sends and receives SMS messages via the SIM card.
   - Communicates with the backend over a serial connection.

2. **C# Backend**
   - Manages serial communication with the Arduino.
   - Provides a REST API to:
     - 📥 **Fetch SMS**: Retrieve SMS messages from the SIM card.
     - 📤 **Send SMS**: Send SMS messages using the SIM card.
   - Handles SMS storage and management.

3. **Angular Frontend**
   - 📱 **SMS Management**: View and manage SMS messages.
   - 🧾 **SIM Card Management**: Manage SIM card settings.
   - User-friendly interface to interact with the backend API.

## 📦 Installation

### 1. Clone the Repository
```bash
git clone https://github.com/yourusername/SIMGate.git
```

### 2. Set Up the Arduino
- Connect your Arduino to the SIM card adapter.
- Load the provided Arduino sketch from the `arduino/` directory.

### 3. Set Up the C# Backend
- Navigate to the `backend/` directory.
- Open the project in Visual Studio.
- Build and run the backend.

### 4. Set Up the Angular Frontend
- Navigate to the `frontend/` directory.
- Install dependencies:
  ```bash
  npm install
  ```
- Run the Angular app:
  ```bash
  ng serve
  ```

## 🔧 Configuration

### Backend Configuration
- Update the `appsettings.json` file with your serial port settings and other configurations.

### Arduino Configuration
- Ensure that the correct SIM card settings are configured in the Arduino sketch.

## 🚀 Usage

1. **Start the Backend**: Ensure the backend is running.
2. **Open the Frontend**: Access the Angular app via your browser.
3. **Manage SMS**: Use the frontend to send and receive SMS messages.

## License 📄
This project is licensed under the [CC BY-NC 4.0](LICENSE.md).
