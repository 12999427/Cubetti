﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cubetti
{
    /*
    struct Punto //equivalente a Point ma uso Point perchè Location è un Point
    {
        public int X; public int Y;
    }
    */

    public partial class Form1 : Form
    {
        Panel[] oggetti;
        int score_puffo = 0;
        int score_gargamella = 0;
        Random rand = new Random(Environment.TickCount);
        bool turno_gargamella = false;
        const int totMosse = 4;
        int mosseRimanenti;
        public Form1()
        {
            InitializeComponent();
            oggetti = new Panel[] { pnl_casetta, pnl_gargamella, pnl_player, pnl_albero1, pnl_albero2, pnl_albero3, pnl_albero4, pnl_albero5, pnl_albero6, pnl_albero7, pnl_albero8, pnl_albero9, pnl_albero10 }; //tutti gli oggetti (le collsioni le filtro dopo in base a .Tag)
            illuminaPunteggio();
            spostaAlberi();
            aggiornaMosse(totMosse);
        }

        private void aggiornaPunteggio(int delta, Panel target)
        {
            if (target == pnl_player)
            {
                score_puffo += delta;
                lbl_score_puffo.Text = "PUFFO PUNTEGGIO: " + score_puffo;
            }
            else if (target == pnl_gargamella)
            {
                score_gargamella += delta;
                lbl_score_gargamella.Text = "GARGAMELLA PUNTEGGIO: " + score_gargamella;
            }
        }

        private void illuminaPunteggio()
        {
            if (turno_gargamella)
            {
                lbl_score_gargamella.BackColor = Color.Yellow;
                lbl_score_puffo.BackColor = Color.White;
            }
            else
            {
                lbl_score_puffo.BackColor = Color.Yellow;
                lbl_score_gargamella.BackColor = Color.White;
            }
        }

        private void sposta(int dx, int dy, Panel target)
        {
            if ((target == pnl_player && turno_gargamella) || (target == pnl_gargamella && !turno_gargamella))
            {
                return;
            }
            bool turno_gargamella_precedente = turno_gargamella; //l'alternativa era impostare mosse a totmosse +1 come garavelli perchè poi fosse decrementato, ma non volevo copiare dai migliori
            target.Location = new Point(spostaX(dx, target), spostaY(dy, target));
            if (turno_gargamella_precedente == turno_gargamella) //decrementa le mosse solo se c'è non c'è stato un cambio di turno, altrimenti la fn è già stata chiamata
                aggiornaMosse(mosseRimanenti - 1);
        }
        private void aggiornaMosse(int mosse)
        {
            mosseRimanenti = mosse;
            if (mosseRimanenti == 0)
            {
                turno_gargamella = !turno_gargamella;
                mosseRimanenti = totMosse;
                illuminaPunteggio();
            }
            (turno_gargamella ? lbl_mosse_gargamella : lbl_mosse_puffo).Text = "MOSSE: " + mosseRimanenti;
            (!turno_gargamella ? lbl_mosse_gargamella : lbl_mosse_puffo).Text = "MOSSE: -"; //andava a capo e non si aggiornava visivamente, ho perso mezz'ora :(
        }

        private void spostaAlberi()
        {
            foreach (Panel oggetto in oggetti)
            {
                if ((string)oggetto.Tag == "ALBERO")
                {
                    oggetto.Tag = "ALBERODAPOSIZIONARE";
                }
            }
            foreach (Panel oggetto in oggetti)
            {
                if ((string)oggetto.Tag == "ALBERODAPOSIZIONARE")
                {
                    generaPosizioneValida(oggetto, true);
                    oggetto.Tag = "ALBERO";
                }
            }
        }

        private int spostaX(int dx, Panel target)
        {
            int x = target.Location.X;
            int y = target.Location.Y;
            int pos = Math.Max(0, Math.Min(pnl_game.Width - target.Width, x + dx));

            foreach (Panel oggetto in oggetti)
            {
                //ALTRO METODO CON RECTANGLE E LA SUA FUNZIONE INTERSECTSWITH
                /*
                Rectangle playerProssimo = new Rectangle(pos, y, pnl_player.Width, pnl_player.Height);
                Rectangle ostacolo = new Rectangle(ctrl.Location.X, ctrl.Location.Y, ctrl.Width, ctrl.Height);

                if (playerProssimo.IntersectsWith(ostacolo))
                {
                    aggiornaPunteggio(-1);
                    return x;
                }
                */
                /*
                if ((y + target.Height > oggetto.Location.Y) && (y < oggetto.Location.Y + oggetto.Height) && oggetto != target) //non potevo fare una funzione appostita x questo perchè il codice è diverso in quanto valuto anche le estensioni degli oggetti
                {
                    if ((pos + target.Width > oggetto.Location.X) && (pos < oggetto.Location.X + oggetto.Width))
                    {
                        if (handleCollision(target, oggetto)) { return x; };
                        
                    }
                }*/
                if (checkCollision(target, oggetto, pos, y) && oggetto != target)
                {
                    if (handleCollision(target, oggetto)) { return x; }
                }
            }
            return pos;
        }

        private bool checkCollision(Panel target, Panel obstacle, int x, int y) //qui volendo struct
        {
            if ((x + target.Width > obstacle.Location.X) && (x < obstacle.Location.X + obstacle.Width))
            {
                if ((y + target.Height > obstacle.Location.Y) && (y < obstacle.Location.Y + obstacle.Height))
                {
                    return true;
                }
            }
            return false;
        }

        private int spostaY(int dy, Panel target)
        {
            int x = target.Location.X;
            int y = target.Location.Y;
            int pos = Math.Max(0, Math.Min(pnl_game.Height - target.Height, y + dy));

            foreach (Panel oggetto in oggetti)
            {/*
                if ((x + target.Width > oggetto.Location.X) && (x < oggetto.Location.X + oggetto.Width) && oggetto != target)
                {
                    if ((pos + target.Height > oggetto.Location.Y) && (pos < oggetto.Location.Y + oggetto.Height))
                    {*/
                if (checkCollision(target, oggetto, x, pos) && oggetto != target)
                    if (handleCollision(target, oggetto)) { return y; };
            }
            return pos;
        }

        private bool handleCollision (Panel target, Panel collision)
        {
            if ((string)collision.Tag == "CASETTA" && target == pnl_player)
            {
                spostaAlberi();
                generaPosizioneValida(collision, true);
                aggiornaPunteggio(+1, pnl_player);
                return false;
            }
            else if (target == pnl_gargamella && collision == pnl_player)
            {
                generaPosizioneValida(pnl_player, true);
                aggiornaPunteggio(+1, pnl_gargamella);
                aggiornaPunteggio(-1, pnl_player);
            }
            else if ((target == pnl_gargamella || target == pnl_player) && (string)collision.Tag == "ALBERO")
            {
                turno_gargamella = !turno_gargamella;
                aggiornaMosse(totMosse);
                illuminaPunteggio();
                return true;
            }

            return true;
        }

        private void generaPosizioneValida (Panel obj, bool checkTrees)
        {
            //vericare se la location è valida (alberi)
            Point punto;
            do
            {
                punto = new Point((int)(rand.NextDouble() * (pnl_game.Width - obj.Width)), (int)(rand.NextDouble() * (pnl_game.Height - obj.Height)));
            } while (checkTrees && (checkTreesCollisions(obj, punto) || checkOtherCollisions(obj, punto)));

            obj.Location = punto;
        }

        private bool checkTreesCollisions(Panel obj, Point xy)
        {
            foreach (Panel oggetto in oggetti)
            {
                if ((string)oggetto.Tag == "ALBERO")
                {
                    if (checkCollision(obj, oggetto, xy.X, xy.Y))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool checkOtherCollisions(Panel obj, Point xy)
        {
            foreach (Panel oggetto in oggetti)
            {
                if ((string)oggetto.Tag == "PLAYER" || (string)oggetto.Tag == "GARGAMELLA" || (string)oggetto.Tag == "CASETTA")
                {
                    if (checkCollision(obj, oggetto, xy.X, xy.Y))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        #region RiceviClick

        private void btn_left_puffo_Click(object sender, EventArgs e)
        {
            sposta(-18, 0, pnl_player);
        }

        private void btn_down_puffo_Click(object sender, EventArgs e)
        {
            sposta(0, 18, pnl_player);
        }

        private void btn_up_puffo_Click(object sender, EventArgs e)
        {
            sposta(0, -18, pnl_player);
        }

        private void btn_right_puffo_Click(object sender, EventArgs e)
        {
            sposta(18, 0, pnl_player);
        }

        private void btn_up_gargamella_Click(object sender, EventArgs e)
        {
            sposta(0, -18, pnl_gargamella);
        }

        private void btn_left_gargamella_Click(object sender, EventArgs e)
        {
            sposta(-18, 0, pnl_gargamella);
        }

        private void bhtn_right_gargamella_Click(object sender, EventArgs e)
        {
            sposta(18, 0, pnl_gargamella);
        }

        private void btn_down_gargamella_Click(object sender, EventArgs e)
        {
            sposta(0, 18, pnl_gargamella);
        }

        #endregion

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    btn_up_puffo.PerformClick();
                    break;
                case Keys.A:
                    btn_left_puffo.PerformClick();
                    break;
                case Keys.S:
                    btn_down_puffo.PerformClick();
                    break;
                case Keys.D:
                    btn_right_puffo.PerformClick();
                    break;
                case Keys.I:
                    btn_up_gargamella.PerformClick();
                    break;
                case Keys.J:
                    btn_left_gargamella.PerformClick();
                    break;
                case Keys.K:
                    btn_down_gargamella.PerformClick();
                    break;
                case Keys.L:
                    btn_right_gargamella.PerformClick();
                    break;
            }
        }

    }
}
