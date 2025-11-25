# DDA Line Drawing Algorithm – WinForms (C#)

This project demonstrates the **Digital Differential Analyzer (DDA) line drawing algorithm** using **C# Windows Forms**.  
The lines are drawn on a **Bitmap** canvas instead of direct `Graphics`, which improves performance and allows easy clearing.

---
- **MainForm**  
![MainForm](./Images/MainForm.jpg)

- **DrawLine**  
![DrawLine](./Images/DrawLine.jpg)

- **DeleteLine**  
![DeleteLine](./Images/DeleteLine.jpg)

## 📌 Features
- Implements DDA Line Drawing Algorithm.
- Draws pixels on a Bitmap canvas.
- Draw + Clear buttons.
- Easy-to-understand structure:
  - `Program.cs`
  - `Form1.cs`
  - `Form1.Designer.cs`
  - `DDA.cs`

---

## 🧠 How DDA Works

1. Compute `dx = x2 - x1` and `dy = y2 - y1`.
2. Find number of steps = `max(|dx|, |dy|)`.
3. Calculate increments:
   - `xInc = dx / steps`
   - `yInc = dy / steps`
4. Start at `(x1, y1)`.
5. For each step:
   - Plot a pixel at `(x, y)`.
   - Add `xInc` and `yInc` to `x` and `y`.

---

## ▶ How to Run
1. Open the project in **Visual Studio**.
2. Press **F5** or **Start**.
3. Click **Draw Line** to draw a demo line.
4. Click **Clear** to erase the canvas.

---

## 📁 Project Structure
## Project Structure

- `Program.cs`: The main entry point of the application.
- `Form1.cs`: Contains the main form logic, including drawing and clearing the canvas.
- `Form1.Designer.cs`: Auto-generated designer file for UI elements like buttons.
- `DDA.cs`: Contains the DDA (Digital Differential Analyzer) algorithm for line drawing.
- `README.md`: Documentation for setting up, running, and understanding the project.
- `bin/` & `obj/`: Auto-generated folders for compiled binaries and temporary files (do not commit to Git).
- `.gitignore`: Specifies files and directories to exclude from version control.

