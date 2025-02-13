# Simple-TCP-Chat

This is a simple TCP client-server communication application built using C#. It demonstrates how to send and receive messages between a client and a server using TCP sockets.

## Features
- **Server Side**: Listens on a specific port, accepts a connection from a client, and sends a message to the client.
- **Client Side**: Connects to the server, receives a message, sends a response back to the server.

## Technologies Used
- C#  
- TCP Sockets (using `TcpListener` and `TcpClient`)
- StreamWriter and StreamReader for message handling.

## How to Run
1. Clone this repository to your local machine.
2. Open the **Server** project and run it. The server will start and wait for a client to connect.
3. Open the **Client** project and run it. The client will connect to the server and allow you to send messages.
4. Both client and server can send and receive messages until the program is stopped.

## Example Interaction

1. **Server**:  
   "Hello, Client"
   
2. **Client**:  
   User types in a message and sends it back.
   
3. **Server**:  
   "Message received: [Client's message]"

## Usage
- Modify the `serverAddress` in the **Client** project if you want to connect to a different server.
- The default server address is set to `127.0.0.1` (localhost).

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
