﻿using System;
using System.Collections.Generic;
using System.Linq;
using WinEchek.Model;
using WinEchek.Model.Piece;
using Type = WinEchek.Model.Piece.Type;

namespace WinEchek.Engine.Rules
{
    public class KingMovementRule : IRule
    {
        public bool IsMoveValid(Move move)
        {
            if (move.TargetSquare?.Piece?.Color == move.Piece.Color && move.TargetSquare?.Piece?.Type == Type.Rook)
            {
                return true;
            }
                
           return Math.Abs(move.Piece.Square.X - move.TargetSquare.X) <= 1 &&
                   Math.Abs(move.Piece.Square.Y - move.TargetSquare.Y) <= 1;
        }

        public List<Square> PossibleMoves(Piece piece)
        {
            return piece.Square.Board.Squares.OfType<Square>()
                .ToList()
                .FindAll(x => IsMoveValid(new Move(piece, x)));  
        }
    }
}