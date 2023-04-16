namespace pokemonGameGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbRival = new System.Windows.Forms.PictureBox();
            this.btnMove1 = new System.Windows.Forms.Button();
            this.btnMove2 = new System.Windows.Forms.Button();
            this.progressBarPlayer = new System.Windows.Forms.ProgressBar();
            this.progressBarRival = new System.Windows.Forms.ProgressBar();
            this.rtbBattle = new System.Windows.Forms.RichTextBox();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblRivalsHealth = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRival)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImage = global::pokemonGameGUI.Properties.Resources.TheRock;
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayer.Location = new System.Drawing.Point(10, 266);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(249, 172);
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            // 
            // pbRival
            // 
            this.pbRival.BackgroundImage = global::pokemonGameGUI.Properties.Resources.WillSmith;
            this.pbRival.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRival.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbRival.InitialImage")));
            this.pbRival.Location = new System.Drawing.Point(539, 12);
            this.pbRival.Name = "pbRival";
            this.pbRival.Size = new System.Drawing.Size(249, 172);
            this.pbRival.TabIndex = 4;
            this.pbRival.TabStop = false;
            this.pbRival.Click += new System.EventHandler(this.pbRival_Click);
            // 
            // btnMove1
            // 
            this.btnMove1.BackColor = System.Drawing.SystemColors.Control;
            this.btnMove1.Location = new System.Drawing.Point(265, 377);
            this.btnMove1.Name = "btnMove1";
            this.btnMove1.Size = new System.Drawing.Size(262, 61);
            this.btnMove1.TabIndex = 5;
            this.btnMove1.Text = "Move1";
            this.btnMove1.UseVisualStyleBackColor = false;
            this.btnMove1.Click += new System.EventHandler(this.btnMove1_Click);
            // 
            // btnMove2
            // 
            this.btnMove2.Location = new System.Drawing.Point(533, 377);
            this.btnMove2.Name = "btnMove2";
            this.btnMove2.Size = new System.Drawing.Size(262, 61);
            this.btnMove2.TabIndex = 6;
            this.btnMove2.Text = "Move2";
            this.btnMove2.UseVisualStyleBackColor = true;
            this.btnMove2.Click += new System.EventHandler(this.btnMove2_Click);
            // 
            // progressBarPlayer
            // 
            this.progressBarPlayer.Location = new System.Drawing.Point(265, 342);
            this.progressBarPlayer.Name = "progressBarPlayer";
            this.progressBarPlayer.Size = new System.Drawing.Size(530, 29);
            this.progressBarPlayer.TabIndex = 7;
            this.progressBarPlayer.Value = 100;
            // 
            // progressBarRival
            // 
            this.progressBarRival.Location = new System.Drawing.Point(10, 12);
            this.progressBarRival.Name = "progressBarRival";
            this.progressBarRival.Size = new System.Drawing.Size(517, 29);
            this.progressBarRival.TabIndex = 8;
            this.progressBarRival.Value = 100;
            // 
            // rtbBattle
            // 
            this.rtbBattle.Location = new System.Drawing.Point(13, 50);
            this.rtbBattle.Name = "rtbBattle";
            this.rtbBattle.Size = new System.Drawing.Size(514, 134);
            this.rtbBattle.TabIndex = 9;
            this.rtbBattle.Text = "";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Location = new System.Drawing.Point(272, 346);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(134, 20);
            this.lblPlayerHealth.TabIndex = 10;
            this.lblPlayerHealth.Text = "Players Health: 100";
            // 
            // lblRivalsHealth
            // 
            this.lblRivalsHealth.AutoSize = true;
            this.lblRivalsHealth.Location = new System.Drawing.Point(13, 16);
            this.lblRivalsHealth.Name = "lblRivalsHealth";
            this.lblRivalsHealth.Size = new System.Drawing.Size(126, 20);
            this.lblRivalsHealth.TabIndex = 11;
            this.lblRivalsHealth.Text = "Rivals Health: 100";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pokemonGameGUI.Properties.Resources.Stage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRivalsHealth);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.rtbBattle);
            this.Controls.Add(this.progressBarRival);
            this.Controls.Add(this.progressBarPlayer);
            this.Controls.Add(this.btnMove2);
            this.Controls.Add(this.btnMove1);
            this.Controls.Add(this.pbRival);
            this.Controls.Add(this.pbPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRival)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pbPlayer;
        private PictureBox pbRival;
        private Button btnMove1;
        private Button btnMove2;
        private ProgressBar progressBarPlayer;
        private ProgressBar progressBarRival;
        private RichTextBox rtbBattle;
        private Label lblPlayerHealth;
        private Label lblRivalsHealth;
        private ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}