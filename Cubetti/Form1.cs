using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cubetti //TOPO: TESTARE SU MURI DI DIMENSIONI DIVERSE E USARE LE STRUCT E REF MEGLIO
{
    public partial class Form1 : Form
    {
        Panel[] ostacoli;
        int punteggio = 0;
        public Form1()
        {
            InitializeComponent();
            ostacoli = new Panel[1] { pnl_wall };
        }

        private void aggiornaPunteggio(int delta)
        {
            punteggio += delta;
            lbl_score.Text = "PUNTEGGIO: " + punteggio;
        }

        private void sposta(int dx, int dy)
        {
            if (dx != 0) {
                pnl_player.Location = new Point(spostaX(dx), pnl_player.Location.Y);
            } else {
                pnl_player.Location = new Point(pnl_player.Location.X, spostaY(dy));
            }
        }
        private int spostaX(int dx)
        {
            int x = pnl_player.Location.X;
            int y = pnl_player.Location.Y;
            int pos = Math.Max(0, Math.Min(pnl_game.Width - pnl_player.Width, x + dx));

            foreach (Panel ostacolo in ostacoli)
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

                if ((y + pnl_player.Height > ostacolo.Location.Y) && (y < ostacolo.Location.Y + ostacolo.Height))
                {
                    if ((pos + pnl_player.Width > ostacolo.Location.X) && (pos < ostacolo.Location.X + ostacolo.Width))
                    {
                        aggiornaPunteggio(-1);
                        return x;
                    }
                }
            }
            aggiornaPunteggio(+1);
            return pos;
        }

        private int spostaY(int dy)
        {
            int x = pnl_player.Location.X;
            int y = pnl_player.Location.Y;
            int pos = Math.Max(0, Math.Min(pnl_game.Height - pnl_player.Height, y + dy));

            foreach (Panel ostacolo in ostacoli)
            {
                if ((x + pnl_player.Width > ostacolo.Location.X) && (x < ostacolo.Location.X + ostacolo.Width))
                {
                    if ((pos + pnl_player.Height > ostacolo.Location.Y) && (pos < ostacolo.Location.Y + ostacolo.Height))
                    {
                        aggiornaPunteggio(-1);
                        return y;
                    }
                }
            }
            aggiornaPunteggio(+1);
            return pos;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            sposta(-25, 0);
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            sposta(0, 25);
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            sposta(0, -25);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            sposta(25, 0);
        }

    }
}
