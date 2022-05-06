using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * leetcode.529 扫雷游戏
 */
namespace _43_RecursionMineSweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board =  {
                {'E', 'E', 'E', 'E', 'E'},
                {'E', 'E', 'M', 'E', 'E'},
                {'E', 'E', 'E', 'E', 'E'},
                {'E', 'E', 'E', 'E', 'E'}};
            int[] click = { 3, 0 };

            char[,] board2 = {
                { 'B', '1', 'E', '1', 'B' },
                { 'B', '1', 'M', '1', 'B' },
                { 'B', '1', '1', '1', 'B' },
                { 'B', 'B', 'B', 'B', 'B' }
            };
            int[] click2 = { 1, 2 };

            char[,] retBoard = Solution.UpdateBoard(board, click);
            char[,] retBoard2 = Solution.UpdateBoard(board2, click2);
            Print(retBoard);
            Console.ReadKey();

        }
        //打印棋盘
        private static void Print(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    public class Solution
    {
        public static char[,] UpdateBoard(char[,] board, int[] click)
        {
            char clickChar = board[click[0],click[1]];
            if (clickChar == 'M')
            {
                board[click[0], click[1]] = 'X';
            }
            else if (clickChar == 'E')
            {
                Update(board, click, 'E', 'B');
            }
            else
            {
                Console.WriteLine($"{click[0]},{click[1]} disable.");
            }
            return board;
        }

        private static void Update(char[,] board, int[] click, char trigger, char ret)
        {
            //判断click位置是否在board内
            if (!IsInBoard(board,click))
            {
                return;
            }
            else
            {
                int[] offsetArray = { -1, 0, 1 };
                int rowMax = board.GetLength(0);
                int colMax = board.GetLength(1);
                int curRow  = click[0];
                int curCol = click[1];
                bool triggerOn = false;
                int count = 0;
                foreach (var rowOffset in offsetArray)
                {
                    int retRow = curRow + rowOffset;
                    if (retRow < rowMax && retRow>=0)
                    {
                        foreach (var colOffset in offsetArray)
                        {
                            int retCol = curCol +colOffset;
                            if (retCol < colMax && retCol >= 0)
                            {
                                //判断八个方位是否有地雷，并记录所有地雷个数，
                                if (rowOffset == 0 && colOffset==0)
                                {
                                    //不计算click自己的点
                                    continue;
                                }
                                if (board[retRow,retCol] == 'M')
                                {
                                    triggerOn = true;
                                    count++;
                                }
                            }
                        }
                    }
                }
                if (triggerOn)
                {
                    board[curRow,curCol] = count.ToString()[0];
                }
                else
                {
                    foreach (var rowOffset in offsetArray)
                    {
                        int retRow = curRow + rowOffset;
                        if (retRow < rowMax && retRow >= 0)
                        {
                            foreach (var colOffset in offsetArray)
                            {
                                int retCol = curCol + colOffset;
                                if (retCol < colMax && retCol >= 0)
                                {
                                    //判断八个方位是否有地雷，并记录所有地雷个数，
                                    if (rowOffset == 0 && colOffset == 0)
                                    {
                                        //不计算click自己的点
                                        continue;
                                    }
                                    if (board[retRow, retCol] == trigger)
                                    {
                                        board[retRow, retCol] = ret;
                                        int[] curClick = { retRow, retCol };
                                        Update(board, curClick, trigger, ret);
                                    }
                                }
                            }
                        }
                    }                    
                }
            }
        }

        private static bool IsInBoard(char[,] board, int[] click)
        {
            return click[0] < board.GetLength(0) && click[1]<board.GetLength(1);
        }
    }
}
