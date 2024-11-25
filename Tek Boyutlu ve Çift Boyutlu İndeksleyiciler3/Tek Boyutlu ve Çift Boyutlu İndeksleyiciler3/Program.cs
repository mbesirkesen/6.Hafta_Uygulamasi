using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bir Satranç Tahtası Durumu
Bir sınıf oluşturun:
 Satranç tahtasındaki her bir kareyi temsil etsin.

 Kullanıcı, indeksleyici aracılığıyla bir kareye taş koyabilsin ya da taşın ne olduğunu
öğrenebilsin.
 Eğer kullanıcı geçersiz bir kareye erişmeye çalışırsa bir hata mesajı döndürsün.*/

namespace Tek_Boyutlu_ve_Çift_Boyutlu_İndeksleyiciler3
{

    class ChessBoard
    {
        private string[,] board;

        public ChessBoard()
        {
            board = new string[8, 8];
        }

        public string this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < 8 && col >= 0 && col < 8)
                {
                    return board[row, col] ?? ".";
                }
                else
                {
                    throw new IndexOutOfRangeException("Geçersiz kare! Satranç tahtasında 0-7 arasında indeksler kullanılabilir.");
                }
            }
            set
            {
                if (row >= 0 && row < 8 && col >= 0 && col < 8)
                {
                    board[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Geçersiz kare! Satranç tahtasında 0-7 arasında indeksler kullanılabilir.");
                }
            }
        }

        public override string ToString()
        {
            string boardStr = "";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    boardStr += (board[i, j] ?? ".") + " ";
                }
                boardStr += "\n";
            }
            return boardStr;
        }
    }

    class Program
    {
        static void Main()
        {
            ChessBoard chessBoard = new ChessBoard();

            chessBoard[0, 0] = "R"; 
            chessBoard[7, 7] = "K"; 
            
            Console.WriteLine(chessBoard);

            
            Console.WriteLine(chessBoard[0, 0]);  
            Console.WriteLine(chessBoard[7, 7]);  

            
            try
            {
                Console.WriteLine(chessBoard[8, 8]);  // Hata verir
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);  // Satranç tahtasında 0-7 arasında indeksler kullanılabilir.
            }
            Console.ReadKey();
        }
    }

}
