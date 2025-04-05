# 📱 Messaging App — Assignment (February 2022)

This project was developed as part of the **Object-Oriented Programming (OOP)** module in the **FIT Software Development Program**.

The goal of this project was to design and implement an **Object-Oriented** program that models text messages (SMS) and multimedia messages (MMS) for a mobile network system.

The app is built using **C#** and **WinForms**, with a focus on encapsulating message-related data into classes, and using inheritance and polymorphism to handle the different message types.

---

## 📘 Project Overview

The **Messaging App** simulates a messaging system for a mobile network, specifically representing **Text Messages** and **MMS Messages**. Each type of message has distinct attributes and properties.

---

## ✅ Requirements

The system needs to handle two types of messages:

### Text Message

- **Attributes**:
  - **Sender**: The person or number sending the message.
  - **Recipient**: The person or number receiving the message.
  - **Content**: The text content of the message.
    - *Text*: The actual message content.
    - *Group flag*: A boolean flag indicating whether the message is part of a group of messages.
  - **Status**: The state of the message.
    - *Sent*: Message has been sent.
    - *Received*: Message has been received.

### MMS Message

- **Attributes**:
  - **Sender**: The person or number sending the message.
  - **Recipient**: The person or number receiving the message.
  - **Content**: The message content, which may include multimedia.
    - *Text*: The textual content of the message.
    - *Group flag*: A boolean flag indicating whether the message is part of a group.
    - *Picture*: Boolean flag indicating if a picture is attached. If True, the name of the picture file is stored.
    - *Audio*: Boolean flag indicating if an audio file is attached. If True, the name of the audio file is stored.
    - *Video*: Boolean flag indicating if a video file is attached. If True, the name of the video file is stored.
    - Note: An MMS message must contain **one and only one** of the following media types: Picture, Audio, or Video.
  - **Status**: The state of the message.
    - *Sent*: Message has been sent.
    - *Received*: Message has been received.

---

## 🛠️ Technologies Used

- **C#** for the backend and object-oriented design.
- **WinForms** for creating the graphical user interface (GUI).
- **Visual Studio** as the development environment.

---

## 📁 Getting Started

To run this app locally:

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/messaging-app.git
Open the Solution:

Open the .sln file in Visual Studio.

Run the Application:

Press F5 or click the Start button in Visual Studio to run the app.

🧱 Design Notes
Object-Oriented Design:

Classes: Create classes for TextMessage and MMSMessage, which share common properties but have distinct features.

Inheritance: You may choose to create a base class (e.g., Message) that contains common properties like Sender, Recipient, Content, and Status. The TextMessage and MMSMessage classes would then inherit from this base class and extend with their specific properties.

Encapsulation: Ensure data is protected within classes using private fields and public properties to access them.

Media Handling for MMS:

Implement logic to ensure that each MMS message contains exactly one type of media (either Picture, Audio, or Video).

💡 Example Class Structure

public class Message
{
    public string Sender { get; set; }
    public string Recipient { get; set; }
    public string Content { get; set; }
    public bool IsPartOfGroup { get; set; }
    public MessageStatus Status { get; set; }
}

public class TextMessage : Message
{
    // Text-specific properties
}

public class MMSMessage : Message
{
    public bool HasPicture { get; set; }
    public bool HasAudio { get; set; }
    public bool HasVideo { get; set; }
    public string MediaFileName { get; set; } // Picture/Audio/Video file name
}

Notes:
The app focuses on applying Object-Oriented Programming principles. Advanced features like message encryption or real-time communication are out of scope for this project.

Ensure that you validate that each MMS message contains one and only one media type (Picture, Audio, or Video).

Proper handling of Boolean flags (e.g., IsPartOfGroup, HasPicture, HasAudio, HasVideo) is crucial to ensuring the integrity of the data model.