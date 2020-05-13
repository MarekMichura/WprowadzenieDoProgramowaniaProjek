﻿using System.Collections.Generic;

namespace ChessLogic
{
    public class Queen : Piece
    {
        /// <summary>
        /// creating a new piece queen
        /// </summary>
        /// <param name="position">Started position</param>
        /// <param name="board">The board on which the piece is located</param>
        /// <param name="color">Color of piece</param>
        /// <param name="firstTour">If the piece has already made a move</param>
        /// <param name="move">Informs if the piece has already made a move</param>
        public Queen(Point position, Board board, Board.Side color, bool firstTour = true, int move = -1) : base(position, board, color, firstTour, move)
        {
            pieceName = Board.Pieces.Queen;
        }
        /// <summary>
        /// Creates a list of possible moves
        /// </summary>
        protected override List<Point> Moves()
        {
            //list moves
            var xRay = new List<Point>();

            bool down = true,
                downRight = true,
                right = true,
                rightTop = true,
                top = true,
                topLeft = true,
                left = true,
                leftDown = true;

            //check all straight and bevels
            for (int i = 1; i < 8; i++)
            {
                //down
                if (down)
                {
                    Point tmp = position + new Point(0, i);
                    if (board.TryGetPieceNameColorAtPosition(tmp, out var color, out var type))
                    {
                        if (color != Color)
                            xRay.Add(tmp);
                        down = false;
                    }
                    else if (tmp.Between(7))
                        xRay.Add(tmp);
                    else
                        down = false;
                }
                //down right
                if (downRight)
                {
                    Point tmp = position + new Point(i, i);
                    if (board.TryGetPieceNameColorAtPosition(tmp, out var color, out var type))
                    {
                        if (color != Color)
                            xRay.Add(tmp);
                        downRight = false;
                    }
                    else if (tmp.Between(7))
                        xRay.Add(tmp);
                    else
                        downRight = false;
                }
                //right
                if (right)
                {
                    Point tmp = position + new Point(i, 0);
                    if (board.TryGetPieceNameColorAtPosition(tmp, out var color, out var type))
                    {
                        if (color != Color)
                            xRay.Add(tmp);
                        right = false;
                    }
                    else if (tmp.Between(7))
                        xRay.Add(tmp);
                    else
                        right = false;
                }
                //right top
                if (rightTop)
                {
                    Point tmp = position + new Point(i, -i);
                    if (board.TryGetPieceNameColorAtPosition(tmp, out var color, out var type))
                    {
                        if (color != Color)
                            xRay.Add(tmp);
                        rightTop = false;
                    }
                    else if (tmp.Between(7))
                        xRay.Add(tmp);
                    else
                        rightTop = false;
                }
                //top
                if (top)
                {
                    Point tmp = position + new Point(0, -i);
                    if (board.TryGetPieceNameColorAtPosition(tmp, out var color, out var type))
                    {
                        if (color != Color)
                            xRay.Add(tmp);
                        top = false;
                    }
                    else if (tmp.Between(7))
                        xRay.Add(tmp);
                    else
                        top = false;
                }
                //top left
                if (topLeft)
                {
                    Point tmp = position + new Point(-i, -i);
                    if (board.TryGetPieceNameColorAtPosition(tmp, out var color, out var type))
                    {
                        if (color != Color)
                            xRay.Add(tmp);
                        topLeft = false;
                    }
                    else if (tmp.Between(7))
                        xRay.Add(tmp);
                    else
                        topLeft = false;
                }
                //left
                if (left)
                {
                    Point tmp = position + new Point(-i, 0);
                    if (board.TryGetPieceNameColorAtPosition(tmp, out var color, out var type))
                    {
                        if (color != Color)
                            xRay.Add(tmp);
                        left = false;
                    }
                    else if (tmp.Between(7))
                        xRay.Add(tmp);
                    else
                        left = false;
                }
                //left down
                if (leftDown)
                {
                    Point tmp = position + new Point(-i, i);
                    if (board.TryGetPieceNameColorAtPosition(tmp, out var color, out var type))
                    {
                        if (color != Color)
                            xRay.Add(tmp);
                        leftDown = false;
                    }
                    else if (tmp.Between(7))
                        xRay.Add(tmp);
                    else
                        leftDown = false;
                }
            }

            return xRay;
        }
    }
}
