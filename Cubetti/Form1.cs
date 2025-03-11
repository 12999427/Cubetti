using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cubetti //TODO: USARE LE STRUCT E REF MEGLIO (?)
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
        public Form1()
        {
            InitializeComponent();
            oggetti = new Panel[] { pnl_casetta, pnl_gargamella, pnl_player, pnl_albero }; //tutti gli oggetti (le collsioni le filtro dopo in base a .Tag)
            spostaAlberi();
        }

        private void aggiornaPunteggio(int delta, Panel target)
        {
            if (target == pnl_player)
            {
                score_puffo += delta;
                lbl_score_puffo.Text = "PUNTEGGIO: " + score_puffo;
            }
            else if (target == pnl_gargamella)
            {
                score_gargamella += delta;
                lbl_score_gargamella.Text = "PUNTEGGIO: " + score_gargamella;
            }
        }

        private void sposta(int dx, int dy, Panel target)
        {
            target.Location = new Point(spostaX(dx, target), spostaY(dy, target));
        }

        private void spostaAlberi()
        {
            foreach (Panel oggetto in oggetti)
            {
                if ((string)oggetto.Tag == "ALBERO")
                {
                    generaPosizioneValida(oggetto, false);
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

        private bool checkCollision(Panel target, Panel obstacle, int x, int y)
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
            } while (checkTrees || checkTreesCollisions(obj, punto));

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

        #region RiceviClick

        private void btn_left_Click(object sender, EventArgs e)
        {
            sposta(-25, 0, pnl_player);
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            sposta(0, 25, pnl_player);
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            sposta(0, -25, pnl_player);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            sposta(25, 0, pnl_player);
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
    }
}
