﻿using WinEchek.Engine;
using WinEchek.GUI;
using WinEchek.Model;
using WinEchek.Model.Piece;

namespace WinEchek
{
    public class Game
    {
        public YoloMoteur Moteur { get; set; }
        public BoardView BoardView { get; set; }

        public Game()
        {
            Moteur = new YoloMoteur(new Board());
            BoardView = new BoardView(Moteur.Board, new RealPlayer(this, Color.White));
        }

        public void DoMove(Piece piece, Square square)
        {
            Moteur.DoMove(piece, square);
            BoardView.Refresh();
        }
    }
}