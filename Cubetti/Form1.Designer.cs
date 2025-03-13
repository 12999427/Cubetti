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
            this.lbl_score_gargamella = new System.Windows.Forms.Label();
            this.controlli_gargamella = new System.Windows.Forms.TableLayoutPanel();
            this.btn_left_gargamella = new System.Windows.Forms.Button();
            this.btn_up_gargamella = new System.Windows.Forms.Button();
            this.btn_right_gargamella = new System.Windows.Forms.Button();
            this.btn_down_gargamella = new System.Windows.Forms.Button();
            this.controlli_puffo = new System.Windows.Forms.TableLayoutPanel();
            this.btn_left_puffo = new System.Windows.Forms.Button();
            this.btn_up_puffo = new System.Windows.Forms.Button();
            this.btn_right_puffo = new System.Windows.Forms.Button();
            this.btn_down_puffo = new System.Windows.Forms.Button();
            this.lbl_score_puffo = new System.Windows.Forms.Label();
            this.pnl_game = new System.Windows.Forms.Panel();
            this.pnl_albero8 = new System.Windows.Forms.Panel();
            this.pnl_albero9 = new System.Windows.Forms.Panel();
            this.pnl_albero10 = new System.Windows.Forms.Panel();
            this.pnl_albero7 = new System.Windows.Forms.Panel();
            this.pnl_albero6 = new System.Windows.Forms.Panel();
            this.pnl_albero5 = new System.Windows.Forms.Panel();
            this.pnl_albero4 = new System.Windows.Forms.Panel();
            this.pnl_albero3 = new System.Windows.Forms.Panel();
            this.pnl_albero2 = new System.Windows.Forms.Panel();
            this.pnl_albero1 = new System.Windows.Forms.Panel();
            this.pnl_gargamella = new System.Windows.Forms.Panel();
            this.pnl_casetta = new System.Windows.Forms.Panel();
            this.pnl_player = new System.Windows.Forms.Panel();
            this.pnl_main.SuspendLayout();
            this.controlli_gargamella.SuspendLayout();
            this.controlli_puffo.SuspendLayout();
            this.pnl_game.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Controls.Add(this.lbl_score_gargamella);
            this.pnl_main.Controls.Add(this.controlli_gargamella);
            this.pnl_main.Controls.Add(this.controlli_puffo);
            this.pnl_main.Controls.Add(this.lbl_score_puffo);
            this.pnl_main.Controls.Add(this.pnl_game);
            this.pnl_main.Location = new System.Drawing.Point(12, 12);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(920, 453);
            this.pnl_main.TabIndex = 0;
            // 
            // lbl_score_gargamella
            // 
            this.lbl_score_gargamella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_score_gargamella.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score_gargamella.Location = new System.Drawing.Point(737, 0);
            this.lbl_score_gargamella.Name = "lbl_score_gargamella";
            this.lbl_score_gargamella.Size = new System.Drawing.Size(192, 79);
            this.lbl_score_gargamella.TabIndex = 8;
            this.lbl_score_gargamella.Text = "GARGAMELLA PUNTEGGIO: 0";
            this.lbl_score_gargamella.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // controlli_gargamella
            // 
            this.controlli_gargamella.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlli_gargamella.ColumnCount = 3;
            this.controlli_gargamella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_gargamella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_gargamella.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_gargamella.Controls.Add(this.btn_left_gargamella, 0, 1);
            this.controlli_gargamella.Controls.Add(this.btn_up_gargamella, 1, 0);
            this.controlli_gargamella.Controls.Add(this.btn_right_gargamella, 2, 1);
            this.controlli_gargamella.Controls.Add(this.btn_down_gargamella, 1, 2);
            this.controlli_gargamella.Location = new System.Drawing.Point(737, 118);
            this.controlli_gargamella.Name = "controlli_gargamella";
            this.controlli_gargamella.RowCount = 3;
            this.controlli_gargamella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_gargamella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_gargamella.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_gargamella.Size = new System.Drawing.Size(180, 204);
            this.controlli_gargamella.TabIndex = 7;
            // 
            // btn_left_gargamella
            // 
            this.btn_left_gargamella.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left_gargamella.Location = new System.Drawing.Point(3, 71);
            this.btn_left_gargamella.Name = "btn_left_gargamella";
            this.btn_left_gargamella.Size = new System.Drawing.Size(54, 48);
            this.btn_left_gargamella.TabIndex = 1;
            this.btn_left_gargamella.Text = "<";
            this.btn_left_gargamella.UseVisualStyleBackColor = true;
            this.btn_left_gargamella.Click += new System.EventHandler(this.btn_left_gargamella_Click);
            // 
            // btn_up_gargamella
            // 
            this.btn_up_gargamella.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_up_gargamella.Location = new System.Drawing.Point(63, 3);
            this.btn_up_gargamella.Name = "btn_up_gargamella";
            this.btn_up_gargamella.Size = new System.Drawing.Size(54, 48);
            this.btn_up_gargamella.TabIndex = 0;
            this.btn_up_gargamella.Text = "^";
            this.btn_up_gargamella.UseVisualStyleBackColor = true;
            this.btn_up_gargamella.Click += new System.EventHandler(this.btn_up_gargamella_Click);
            // 
            // btn_right_gargamella
            // 
            this.btn_right_gargamella.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right_gargamella.Location = new System.Drawing.Point(123, 71);
            this.btn_right_gargamella.Name = "btn_right_gargamella";
            this.btn_right_gargamella.Size = new System.Drawing.Size(54, 48);
            this.btn_right_gargamella.TabIndex = 2;
            this.btn_right_gargamella.Text = ">";
            this.btn_right_gargamella.UseVisualStyleBackColor = true;
            this.btn_right_gargamella.Click += new System.EventHandler(this.bhtn_right_gargamella_Click);
            // 
            // btn_down_gargamella
            // 
            this.btn_down_gargamella.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_down_gargamella.Location = new System.Drawing.Point(63, 139);
            this.btn_down_gargamella.Name = "btn_down_gargamella";
            this.btn_down_gargamella.Size = new System.Drawing.Size(54, 48);
            this.btn_down_gargamella.TabIndex = 3;
            this.btn_down_gargamella.Text = "v";
            this.btn_down_gargamella.UseVisualStyleBackColor = true;
            this.btn_down_gargamella.Click += new System.EventHandler(this.btn_down_gargamella_Click);
            // 
            // controlli_puffo
            // 
            this.controlli_puffo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.controlli_puffo.ColumnCount = 3;
            this.controlli_puffo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_puffo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_puffo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_puffo.Controls.Add(this.btn_left_puffo, 0, 1);
            this.controlli_puffo.Controls.Add(this.btn_up_puffo, 1, 0);
            this.controlli_puffo.Controls.Add(this.btn_right_puffo, 2, 1);
            this.controlli_puffo.Controls.Add(this.btn_down_puffo, 1, 2);
            this.controlli_puffo.Location = new System.Drawing.Point(3, 127);
            this.controlli_puffo.Name = "controlli_puffo";
            this.controlli_puffo.RowCount = 3;
            this.controlli_puffo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_puffo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_puffo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlli_puffo.Size = new System.Drawing.Size(180, 204);
            this.controlli_puffo.TabIndex = 6;
            // 
            // btn_left_puffo
            // 
            this.btn_left_puffo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left_puffo.Location = new System.Drawing.Point(3, 71);
            this.btn_left_puffo.Name = "btn_left_puffo";
            this.btn_left_puffo.Size = new System.Drawing.Size(54, 48);
            this.btn_left_puffo.TabIndex = 1;
            this.btn_left_puffo.Text = "<";
            this.btn_left_puffo.UseVisualStyleBackColor = true;
            this.btn_left_puffo.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_up_puffo
            // 
            this.btn_up_puffo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_up_puffo.Location = new System.Drawing.Point(63, 3);
            this.btn_up_puffo.Name = "btn_up_puffo";
            this.btn_up_puffo.Size = new System.Drawing.Size(54, 48);
            this.btn_up_puffo.TabIndex = 0;
            this.btn_up_puffo.Text = "^";
            this.btn_up_puffo.UseVisualStyleBackColor = true;
            this.btn_up_puffo.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_right_puffo
            // 
            this.btn_right_puffo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right_puffo.Location = new System.Drawing.Point(123, 71);
            this.btn_right_puffo.Name = "btn_right_puffo";
            this.btn_right_puffo.Size = new System.Drawing.Size(54, 48);
            this.btn_right_puffo.TabIndex = 2;
            this.btn_right_puffo.Text = ">";
            this.btn_right_puffo.UseVisualStyleBackColor = true;
            this.btn_right_puffo.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_down_puffo
            // 
            this.btn_down_puffo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_down_puffo.Location = new System.Drawing.Point(63, 139);
            this.btn_down_puffo.Name = "btn_down_puffo";
            this.btn_down_puffo.Size = new System.Drawing.Size(54, 48);
            this.btn_down_puffo.TabIndex = 3;
            this.btn_down_puffo.Text = "v";
            this.btn_down_puffo.UseVisualStyleBackColor = true;
            this.btn_down_puffo.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // lbl_score_puffo
            // 
            this.lbl_score_puffo.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score_puffo.Location = new System.Drawing.Point(0, 0);
            this.lbl_score_puffo.Name = "lbl_score_puffo";
            this.lbl_score_puffo.Size = new System.Drawing.Size(182, 91);
            this.lbl_score_puffo.TabIndex = 5;
            this.lbl_score_puffo.Text = "PUFFO PUNTEGGIO: 0";
            this.lbl_score_puffo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_game
            // 
            this.pnl_game.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_game.BackColor = System.Drawing.Color.Tan;
            this.pnl_game.Controls.Add(this.pnl_albero8);
            this.pnl_game.Controls.Add(this.pnl_albero9);
            this.pnl_game.Controls.Add(this.pnl_albero10);
            this.pnl_game.Controls.Add(this.pnl_albero7);
            this.pnl_game.Controls.Add(this.pnl_albero6);
            this.pnl_game.Controls.Add(this.pnl_albero5);
            this.pnl_game.Controls.Add(this.pnl_albero4);
            this.pnl_game.Controls.Add(this.pnl_albero3);
            this.pnl_game.Controls.Add(this.pnl_albero2);
            this.pnl_game.Controls.Add(this.pnl_albero1);
            this.pnl_game.Controls.Add(this.pnl_gargamella);
            this.pnl_game.Controls.Add(this.pnl_casetta);
            this.pnl_game.Controls.Add(this.pnl_player);
            this.pnl_game.Location = new System.Drawing.Point(190, 3);
            this.pnl_game.Name = "pnl_game";
            this.pnl_game.Size = new System.Drawing.Size(540, 432);
            this.pnl_game.TabIndex = 4;
            // 
            // pnl_albero8
            // 
            this.pnl_albero8.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero8.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero8.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero8.Name = "pnl_albero8";
            this.pnl_albero8.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero8.TabIndex = 5;
            this.pnl_albero8.Tag = "ALBERO";
            // 
            // pnl_albero9
            // 
            this.pnl_albero9.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero9.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero9.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero9.Name = "pnl_albero9";
            this.pnl_albero9.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero9.TabIndex = 6;
            this.pnl_albero9.Tag = "ALBERO";
            // 
            // pnl_albero10
            // 
            this.pnl_albero10.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero10.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero10.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero10.Name = "pnl_albero10";
            this.pnl_albero10.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero10.TabIndex = 6;
            this.pnl_albero10.Tag = "ALBERO";
            // 
            // pnl_albero7
            // 
            this.pnl_albero7.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero7.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero7.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero7.Name = "pnl_albero7";
            this.pnl_albero7.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero7.TabIndex = 4;
            this.pnl_albero7.Tag = "ALBERO";
            // 
            // pnl_albero6
            // 
            this.pnl_albero6.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero6.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero6.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero6.Name = "pnl_albero6";
            this.pnl_albero6.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero6.TabIndex = 3;
            this.pnl_albero6.Tag = "ALBERO";
            // 
            // pnl_albero5
            // 
            this.pnl_albero5.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero5.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero5.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero5.Name = "pnl_albero5";
            this.pnl_albero5.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero5.TabIndex = 3;
            this.pnl_albero5.Tag = "ALBERO";
            // 
            // pnl_albero4
            // 
            this.pnl_albero4.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero4.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero4.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero4.Name = "pnl_albero4";
            this.pnl_albero4.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero4.TabIndex = 3;
            this.pnl_albero4.Tag = "ALBERO";
            // 
            // pnl_albero3
            // 
            this.pnl_albero3.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero3.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero3.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero3.Name = "pnl_albero3";
            this.pnl_albero3.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero3.TabIndex = 3;
            this.pnl_albero3.Tag = "ALBERO";
            // 
            // pnl_albero2
            // 
            this.pnl_albero2.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero2.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero2.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero2.Name = "pnl_albero2";
            this.pnl_albero2.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero2.TabIndex = 3;
            this.pnl_albero2.Tag = "ALBERO";
            // 
            // pnl_albero1
            // 
            this.pnl_albero1.BackColor = System.Drawing.Color.DarkGreen;
            this.pnl_albero1.BackgroundImage = global::Cubetti.Properties.Resources.albero;
            this.pnl_albero1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_albero1.Location = new System.Drawing.Point(0, 0);
            this.pnl_albero1.Name = "pnl_albero1";
            this.pnl_albero1.Size = new System.Drawing.Size(36, 36);
            this.pnl_albero1.TabIndex = 2;
            this.pnl_albero1.Tag = "ALBERO";
            // 
            // pnl_gargamella
            // 
            this.pnl_gargamella.BackColor = System.Drawing.SystemColors.InfoText;
            this.pnl_gargamella.BackgroundImage = global::Cubetti.Properties.Resources.gargamella;
            this.pnl_gargamella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_gargamella.Location = new System.Drawing.Point(72, 144);
            this.pnl_gargamella.Name = "pnl_gargamella";
            this.pnl_gargamella.Size = new System.Drawing.Size(36, 36);
            this.pnl_gargamella.TabIndex = 1;
            this.pnl_gargamella.Tag = "GARGAMELLA";
            // 
            // pnl_casetta
            // 
            this.pnl_casetta.BackColor = System.Drawing.Color.IndianRed;
            this.pnl_casetta.BackgroundImage = global::Cubetti.Properties.Resources.fungocasa;
            this.pnl_casetta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_casetta.Location = new System.Drawing.Point(108, 36);
            this.pnl_casetta.Name = "pnl_casetta";
            this.pnl_casetta.Size = new System.Drawing.Size(36, 36);
            this.pnl_casetta.TabIndex = 1;
            this.pnl_casetta.Tag = "CASETTA";
            // 
            // pnl_player
            // 
            this.pnl_player.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_player.BackgroundImage = global::Cubetti.Properties.Resources.puffo;
            this.pnl_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_player.Location = new System.Drawing.Point(36, 36);
            this.pnl_player.Name = "pnl_player";
            this.pnl_player.Size = new System.Drawing.Size(36, 36);
            this.pnl_player.TabIndex = 0;
            this.pnl_player.Tag = "PLAYER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 477);
            this.Controls.Add(this.pnl_main);
            this.MinimumSize = new System.Drawing.Size(960, 516);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_main.ResumeLayout(false);
            this.controlli_gargamella.ResumeLayout(false);
            this.controlli_puffo.ResumeLayout(false);
            this.pnl_game.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_left_puffo;
        private System.Windows.Forms.Button btn_right_puffo;
        private System.Windows.Forms.Button btn_down_puffo;
        private System.Windows.Forms.Button btn_up_puffo;
        private System.Windows.Forms.Panel pnl_game;
        private System.Windows.Forms.Label lbl_score_puffo;
        private System.Windows.Forms.Panel pnl_player;
        private System.Windows.Forms.Panel pnl_casetta;
        private System.Windows.Forms.TableLayoutPanel controlli_puffo;
        private System.Windows.Forms.TableLayoutPanel controlli_gargamella;
        private System.Windows.Forms.Button btn_left_gargamella;
        private System.Windows.Forms.Button btn_up_gargamella;
        private System.Windows.Forms.Button btn_right_gargamella;
        private System.Windows.Forms.Button btn_down_gargamella;
        private System.Windows.Forms.Label lbl_score_gargamella;
        private System.Windows.Forms.Panel pnl_gargamella;
        private System.Windows.Forms.Panel pnl_albero1;
        private System.Windows.Forms.Panel pnl_albero6;
        private System.Windows.Forms.Panel pnl_albero5;
        private System.Windows.Forms.Panel pnl_albero4;
        private System.Windows.Forms.Panel pnl_albero3;
        private System.Windows.Forms.Panel pnl_albero2;
        private System.Windows.Forms.Panel pnl_albero8;
        private System.Windows.Forms.Panel pnl_albero9;
        private System.Windows.Forms.Panel pnl_albero10;
        private System.Windows.Forms.Panel pnl_albero7;
    }
}

