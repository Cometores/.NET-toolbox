![DotNetToolbox_Header.png](docs/images/DotNetToolbox_Header.png)

A **.NET** showcase of focused projects that highlight the platform’s versatility - from low-level utilities to application-level features.
<br>Each area is organized with runnable examples and concise notes, making the repo quick to scan and easy to evaluate.



## 📂 Structure

| Category                    | Description                                                                  | Detailed Info                            |
|-----------------------------|------------------------------------------------------------------------------|------------------------------------------|
| **File System Operations**  | File-oriented utilities: streams, parsing, safe I/O patterns, and tooling.   | [README](Sources/Files/README.md)        |
| **Asynchronous Programming**| Concurrency in practice: async workflows, cancellation, and responsive apps. | [README](Sources/Asynchronous/README.md) |
| **Networking**              | Network utilities and protocols: sockets, diagnostics, and client/server.    | [README](Sources/Networking/README.md)   |
| **Windows Forms**           | Lightweight desktop tools: classic UI, events, and pragmatic UX.             | [README](Sources/WindowsForms/README.md) |
| **WPF**                     | Modern desktop UI: XAML, MVVM structure, and maintainable views.             | [README](Sources/WPF/README.md)          |


___


## 🧩 Project list

[//]: # (__________________________________________________________)
### 1. File System Operations
File-oriented utilities for Windows: directory traversal, reporting, and robust file handling.

#### 1.1. [Directory analyzer](Sources/Files/README.md)
Reports disk usage and file-type distribution for a given directory (recursive scan).

#### 1.2. [Folder and file renamer](Sources/Files/README.md)
Normalizes names across a directory tree using consistent rules (recursive rename).
</br></br>



[//]: # (__________________________________________________________)
### 2. Asynchronous Programming
Async workflows in practice: responsive console UX, cancellation, and parallel work.

#### 2.1. [Console status bar](Sources/Asynchronous/README.md)
Progress/status rendering for long-running operations (e.g., downloads).

#### 2.2. [Grep](Sources/Asynchronous/README.md)
**"grep"** program, which does almost the same thing `grep(1)` does under Linux.

#### 2.3. [Image processor](Sources/Asynchronous/README.md)
Bitmap processing pipeline with effects (scaling, sepia, etc.).
</br></br>



[//]: # (__________________________________________________________)
### 3. Networking
Network tooling: diagnostics, sockets, and practical protocol work.

#### 3.1. [Ping utility](Sources/Networking/README.md)
CLI tool for measuring reachability and latency.

#### 3.2. [Port scanner](Sources/Networking/README.md)
Local network TCP port discovery (timeouts, parallel scans).
</br></br>



[//]: # (__________________________________________________________)
### 4. Windows forms
Creating graphical applications with Windows Forms.

#### 4.1. [Picture viewer](Sources/WindowsForms/README.md)
Application for viewing the picture and selecting the background image.

#### 4.2. [Timed math quiz](Sources/WindowsForms/README.md)
Solve 4 arithmetic problems in a limited amount of time.

#### 4.3. [Matching game](Sources/WindowsForms/README.md)
Memory game - find the pair.

#### 4.4. [MP3 metadata editing](Sources/WindowsForms/README.md)
An application where you can select a mp3 file, process its information, and save it.
</br></br>



[//]: # (__________________________________________________________)
### 5. WPF
Creating graphical applications with WPF.

#### 5.1. [Customer app](Sources/WPF/README.md)
Customer Information Management Application. Deleting, adding, editing.

#### 5.2 [Snake](Sources/WPF/README.md)
The classic game.


## 🌱 Future Plans
- Development of applications described in the `README` contained in sections.
- Creating and expanding tests for complex programs.
- Moving the UI logic for consoles to a separate project.