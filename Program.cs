﻿// Mission 4 Assignment
/* Emma Helquist
Tessa Miner
Addison Smith
Payton Hatch */

// Description: Tic-Tac-Toe

using System.Security.Cryptography;
using Mission4Assignment;

// Welcome the user to the game and explain the rules
Console.WriteLine("Welcome to the game of Tic-Tac-Toe!");
Console.WriteLine("The object of the game is to get three in a row.");
Console.WriteLine("Player 1 is X, player 2 is O!");

// Initialize variables I will use later
bool isOver = false;
int selectionOne = 0;
int selectionTwo = 0;

// Instantiating and calling the class to use later
TicTacToeTools tttt = new TicTacToeTools();

// Tic Tac Toe Board Array that has numbers as placeholders to print out and show the users
string[] boardArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

// Print the board
tttt.PrintBoard(boardArray);

// While loop that continues as long as the game is still going
while (!isOver)
{
    Console.WriteLine("\nPlayer 1- type the number where you want to put your X.");

    // Keep asking until the user enters a valid number
    while (!int.TryParse(Console.ReadLine(), out selectionOne) || selectionOne < 1 || selectionOne > 9)
    {
        Console.WriteLine("Invalid input. Please enter a valid number between 1 and 9: ");
    }

    // If the spot player one chose is taken, have them choose a new number
    while (boardArray[selectionOne - 1] == "X" || boardArray[selectionOne - 1] == "O")
    {
        Console.WriteLine("Sorry, that space is taken. Please enter a new number: ");
        while (!int.TryParse(Console.ReadLine(), out selectionOne) || selectionOne < 1 || selectionOne > 9)
        {
            Console.WriteLine("Invalid input. Please enter a valid number between 1 and 9: ");
        }
    }


    boardArray[selectionOne - 1] = "X"; // Assign 'X' to player one's spot

    // Print the board
    tttt.PrintBoard(boardArray);

    string result = "";

    // Check for a winner or if there was a tie
    result = tttt.CheckWinner(boardArray);

    if (result == "X")
    {
        Console.WriteLine($"\nPlayer {result} wins!");
        isOver = true;
        break;
    }
    else if (result == "O")
    {
        Console.WriteLine($"\nPlayer {result} wins!");
        isOver = true;
        break;
    }
    else if (result == "T")
    {
        Console.WriteLine($"\nIt's a Tie!");
        isOver = true;
        break;
    }

    Console.WriteLine("\nPlayer 2- type the number where you want to put your O.");

    // Keep asking until the user enters a valid number
    while (!int.TryParse(Console.ReadLine(), out selectionTwo) || selectionTwo < 1 || selectionTwo > 9)
    {
        Console.WriteLine("Invalid input. Please enter a valid number between 1 and 9: ");
    }

    // If the spot player two chose is taken, have them choose a new number
    while (boardArray[selectionTwo - 1] == "X" || boardArray[selectionTwo - 1] == "O")
    {
        Console.WriteLine("Sorry, that space is taken. Please enter a new number: ");
        while (!int.TryParse(Console.ReadLine(), out selectionTwo) || selectionTwo < 1 || selectionTwo > 9)
        {
            Console.WriteLine("Invalid input. Please enter a valid number between 1 and 9: ");
        }
    }


    boardArray[selectionTwo - 1] = "O"; // Assign 'O' to player two's spot

    // Print the board
    tttt.PrintBoard(boardArray);

    // Check for a winner or if there was a tie
    result = tttt.CheckWinner(boardArray);
    if (result == "X")
    {
        Console.WriteLine($"\nPlayer {result} wins!");
        isOver = true;
        break;
    }
    else if (result == "O")
    {
        Console.WriteLine($"\nPlayer {result} wins!");
        isOver = true;
        break;
    }
    else if (result == "T")
    {
        Console.WriteLine($"\nIt's a Tie!");
        isOver = true;
        break;
    }
}

Console.WriteLine("\nThanks for playing!");