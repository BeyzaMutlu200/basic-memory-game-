# Memory Game - C# Windows Forms Application

This is a simple memory matching game developed in C# using Windows Forms. The game challenges the player to find matching pairs of hidden numbers within a time limit.

## Features

- 12 hidden numbers displayed in PictureBoxes
- Click to reveal numbers
- Check for matching pairs
- Count of mismatched tries
- Countdown timer with game over if time runs out
- Restart game functionality

## How to Play

1. Click on a square (PictureBox) to reveal its number.
2. Click a second square to try and find a match.
3. If the numbers match, they remain revealed. Otherwise, they are hidden again.
4. The game ends when all pairs are matched or the timer reaches zero.
5. Click the "Restart" button to play again.

## Project Structure

- `Form1.cs`: Main game logic and UI handling.
- `Program.cs`: Entry point for the application.
- `.vs/`, `bin/`, `obj/`: Visual Studio temporary files (ignored in Git).

## Requirements

- Visual Studio 2022 or later
- .NET Framework / .NET 6+
- Windows OS

## Installation

1. Clone this repository:

```bash
git clone https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git
