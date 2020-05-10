﻿using System.Collections.Generic;

namespace ChessLogic
{
    internal class King : Piece
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="coords">Postion of piece</param>
        /// <param name="board">the board on which the piece is located</param>
        /// <param name="color">color of piece</param>
        /// <param name="firstTour">informs if the piece has already made a move</param>
        public King(Point coords, Board board, bool color, bool firstTour = true, int move = -1) : base(coords, board, color, firstTour, move)
        {
            pieceName = "King";
        }
        /// <summary>
        /// Returns a list of possible moves
        /// </summary>
        protected override List<Point> Moves(bool check = true)
        {
            //list of possible moves
            List<Point> moves = new List<Point>();

            //check the movements for approx
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (!(j == 0 && i == 0))
                    {
                        Point shift = position + new Point(i, j);
                        if (board.TryGetPieceNameColorAtPosition(shift, out string name, out bool color))
                        {
                            if (color != this.color)
                                moves.Add(shift);
                        }
                        else if (shift.Between(7))
                            moves.Add(shift);
                    }
                }
            }
            //remove all life-threatening movements of the king
            if (check)
            {
                for (int i = moves.Count - 1; i >= 0; i--)
                {
                    if (Check(moves[i]))
                    {
                        moves.Remove(moves[i]);
                    }
                }
            }
            return moves;
        }
    }
}
