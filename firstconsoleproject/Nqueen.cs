using System;

using System.Text;

namespace firstconsoleproject
{
    class Nqueen
    {
         readonly int N=4;
            void PrintSolution(int[,] board)
        {
            for(int i = 0; i < N; i++){
                for (int j = 0; j < N; j++) {
                    Console.WriteLine("" + board[i,j] + "");
                    Console.WriteLine();
                        }
            }
        }
        bool IsSafe(int[,]board,int row,int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
                if (board[row, i] == 1) return false;
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 1) return false;
            for (i = row, j = col; j >= 0 && i < N; i++, j--)
                if (board[i, j] == 1) return false;
            return true;
            
        }
        bool SolveNq(int[,] board, int col)
        {
            if (col >= N)
                return true;
            for (int i = 0; i < N; i++)
            {
                if (IsSafe(board, i, col))
                {
                    board[i, col] = 1;
                    if (SolveNq(board, col + 1) == true)
                        return true;
                    board[i, col] = 0;
                }
            }
            return false;
        }
        bool SolveBQ()
        {
            int[,] board = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            if (SolveNq(board, 0) == false)
            {
                Console.WriteLine("soln does nt exist");
                return false;
            }
            PrintSolution(board);
            return true;
        }
    }
}
