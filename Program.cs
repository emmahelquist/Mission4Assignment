// Mission 4 Assignment
/* Emma Helquist
Tessa Miner
Addison Smith
Payton Hatch */

// Description: Tic-Tac-Toe

using Mission4Assignment;

TicTacToeTools tt = new TicTacToeTools();

char[] testArray = ['X', 'X', 'O', 'O', 'O', 'X', 'X', 'X', 'O'];

tt.PrintBoard(testArray);

Console.WriteLine(tt.CheckWinner(testArray));