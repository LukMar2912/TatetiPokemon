namespace main
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tablaGame = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.picGanador = new System.Windows.Forms.PictureBox();
            this.pictureVS = new System.Windows.Forms.PictureBox();
            this.picjug2 = new System.Windows.Forms.PictureBox();
            this.picjug1 = new System.Windows.Forms.PictureBox();
            this.buttonRestart = new System.Windows.Forms.PictureBox();
            this.fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picjug2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picjug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaGame
            // 
            this.tablaGame.ColumnCount = 3;
            this.tablaGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaGame.Location = new System.Drawing.Point(23, 26);
            this.tablaGame.Name = "tablaGame";
            this.tablaGame.RowCount = 3;
            this.tablaGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tablaGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tablaGame.Size = new System.Drawing.Size(474, 454);
            this.tablaGame.TabIndex = 1;
            this.tablaGame.Paint += new System.Windows.Forms.PaintEventHandler(this.tablaGame_Paint);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Black;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(721, 153);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(19, 20);
            this.lblPlayer1.TabIndex = 7;
            this.lblPlayer1.Text = "0";
            this.lblPlayer1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Black;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(553, 153);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(19, 20);
            this.lblPlayer2.TabIndex = 8;
            this.lblPlayer2.Text = "0";
            // 
            // picGanador
            // 
            this.picGanador.BackColor = System.Drawing.SystemColors.MenuText;
            this.picGanador.Image = global::main.Properties.Resources.f_0;
            this.picGanador.Location = new System.Drawing.Point(800, 54);
            this.picGanador.Name = "picGanador";
            this.picGanador.Size = new System.Drawing.Size(150, 150);
            this.picGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGanador.TabIndex = 6;
            this.picGanador.TabStop = false;
            this.picGanador.Click += new System.EventHandler(this.picGanador_Click);
            // 
            // pictureVS
            // 
            this.pictureVS.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureVS.Image = ((System.Drawing.Image)(resources.GetObject("pictureVS.Image")));
            this.pictureVS.Location = new System.Drawing.Point(626, 112);
            this.pictureVS.Name = "pictureVS";
            this.pictureVS.Size = new System.Drawing.Size(40, 38);
            this.pictureVS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVS.TabIndex = 4;
            this.pictureVS.TabStop = false;
            // 
            // picjug2
            // 
            this.picjug2.Image = global::main.Properties.Resources.f_1;
            this.picjug2.Location = new System.Drawing.Point(685, 54);
            this.picjug2.Name = "picjug2";
            this.picjug2.Size = new System.Drawing.Size(92, 96);
            this.picjug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picjug2.TabIndex = 3;
            this.picjug2.TabStop = false;
            // 
            // picjug1
            // 
            this.picjug1.Image = global::main.Properties.Resources.f_2;
            this.picjug1.Location = new System.Drawing.Point(516, 54);
            this.picjug1.Name = "picjug1";
            this.picjug1.Size = new System.Drawing.Size(92, 96);
            this.picjug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picjug1.TabIndex = 2;
            this.picjug1.TabStop = false;
            this.picjug1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestart.Image = global::main.Properties.Resources.Reiniciar;
            this.buttonRestart.Location = new System.Drawing.Point(557, 401);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(220, 79);
            this.buttonRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonRestart.TabIndex = 0;
            this.buttonRestart.TabStop = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.Transparent;
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Image = global::main.Properties.Resources.Fondo;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(984, 511);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 5;
            this.fondo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.picGanador);
            this.Controls.Add(this.pictureVS);
            this.Controls.Add(this.picjug2);
            this.Controls.Add(this.picjug1);
            this.Controls.Add(this.tablaGame);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 550);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "Form1";
            this.Text = "Pokemon Tateti";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picjug2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picjug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonRestart;
        private System.Windows.Forms.TableLayoutPanel tablaGame;
        private System.Windows.Forms.PictureBox picjug1;
        private System.Windows.Forms.PictureBox picjug2;
        private System.Windows.Forms.PictureBox pictureVS;
        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.PictureBox picGanador;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
    }
}

