namespace Cubetti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_score = new System.Windows.Forms.Label();
            this.pnl_game = new System.Windows.Forms.Panel();
            this.pnl_wall = new System.Windows.Forms.Panel();
            this.pnl_player = new System.Windows.Forms.Panel();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.pnl_main.SuspendLayout();
            this.pnl_game.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Controls.Add(this.lbl_score);
            this.pnl_main.Controls.Add(this.pnl_game);
            this.pnl_main.Controls.Add(this.btn_left);
            this.pnl_main.Controls.Add(this.btn_right);
            this.pnl_main.Controls.Add(this.btn_down);
            this.pnl_main.Controls.Add(this.btn_up);
            this.pnl_main.Location = new System.Drawing.Point(12, 12);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(780, 415);
            this.pnl_main.TabIndex = 0;
            // 
            // lbl_score
            // 
            this.lbl_score.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(425, 15);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(338, 38);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "PUNTEGGIO: 0";
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_game
            // 
            this.pnl_game.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_game.Controls.Add(this.pnl_wall);
            this.pnl_game.Controls.Add(this.pnl_player);
            this.pnl_game.Location = new System.Drawing.Point(3, 3);
            this.pnl_game.Name = "pnl_game";
            this.pnl_game.Size = new System.Drawing.Size(400, 400);
            this.pnl_game.TabIndex = 4;
            // 
            // pnl_wall
            // 
            this.pnl_wall.BackColor = System.Drawing.Color.IndianRed;
            this.pnl_wall.Location = new System.Drawing.Point(150, 50);
            this.pnl_wall.Name = "pnl_wall";
            this.pnl_wall.Size = new System.Drawing.Size(50, 50);
            this.pnl_wall.TabIndex = 1;
            // 
            // pnl_player
            // 
            this.pnl_player.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_player.Location = new System.Drawing.Point(50, 50);
            this.pnl_player.Name = "pnl_player";
            this.pnl_player.Size = new System.Drawing.Size(50, 50);
            this.pnl_player.TabIndex = 0;
            // 
            // btn_left
            // 
            this.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left.Location = new System.Drawing.Point(523, 182);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(57, 48);
            this.btn_left.TabIndex = 1;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right.Location = new System.Drawing.Point(625, 182);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(57, 48);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_down
            // 
            this.btn_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_down.Location = new System.Drawing.Point(573, 236);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(57, 48);
            this.btn_down.TabIndex = 3;
            this.btn_down.Text = "v";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_up.Location = new System.Drawing.Point(573, 128);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(57, 48);
            this.btn_up.TabIndex = 0;
            this.btn_up.Text = "^";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 439);
            this.Controls.Add(this.pnl_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_main.ResumeLayout(false);
            this.pnl_game.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Panel pnl_game;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Panel pnl_player;
        private System.Windows.Forms.Panel pnl_wall;
    }
}

