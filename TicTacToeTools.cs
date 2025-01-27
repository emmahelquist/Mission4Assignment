using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    internal class TicTacToeTools
    {
        public void PrintBoard(char[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {

                // Print the cell value with a separator if not the last column
                Console.Write($" {board[i]} ");
                if ((i + 1) % 3 != 0) // Add '|' separator between columns
                {
                    Console.Write("|");
                }

                // Add a line after every row except the last one
                if ((i + 1) % 3 == 0 && i != board.Length - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("---+---+---"); // Horizontal line with column dividers
                }
            }
            Console.WriteLine(); // Add a final newline for better formatting

        } 
        

        public string CheckWinner(string[] board)
        {
            // Define all winning combinations
            int[][] winningPatterns = new int[][]
            {
            new int[] { 0, 1, 2 }, // Top row
            new int[] { 3, 4, 5 }, // Middle row
            new int[] { 6, 7, 8 }, // Bottom row
            new int[] { 0, 3, 6 }, // Left column
            new int[] { 1, 4, 7 }, // Middle column
            new int[] { 2, 5, 8 }, // Right column
            new int[] { 0, 4, 8 }, // Left diagonal
            new int[] { 2, 4, 6 }  // Right diagonal
            };

            // Check each winning pattern
            foreach (var pattern in winningPatterns)
            {
                if (board[pattern[0]] == board[pattern[1]] &&
                    board[pattern[1]] == board[pattern[2]] &&
                    (board[pattern[0]] == "X" || board[pattern[0]] == "O"))
                {
                    return board[pattern[0]]; // Return the winner ('X' or 'O')
                }

            }

            // Check if the board is full (tie)
            if (board.All(cell => cell == "X" || cell == "O"))
            {
                return "T"; // Indicate a tie
            }

            return "N"; // No winner yet
        }
    }  
}
