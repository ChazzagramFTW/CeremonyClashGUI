namespace pokemonGameGUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWillSmith = new System.Windows.Forms.Button();
            this.btnTheRock = new System.Windows.Forms.Button();
            this.btnChrisRock = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbSelect = new System.Windows.Forms.PictureBox();
            this.rtbSelect = new System.Windows.Forms.RichTextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWillSmith
            // 
            this.btnWillSmith.Location = new System.Drawing.Point(286, 99);
            this.btnWillSmith.Name = "btnWillSmith";
            this.btnWillSmith.Size = new System.Drawing.Size(224, 57);
            this.btnWillSmith.TabIndex = 0;
            this.btnWillSmith.Text = "Will Smith";
            this.btnWillSmith.UseVisualStyleBackColor = true;
            this.btnWillSmith.Click += new System.EventHandler(this.btnWillSmith_Click);
            // 
            // btnTheRock
            // 
            this.btnTheRock.Location = new System.Drawing.Point(516, 99);
            this.btnTheRock.Name = "btnTheRock";
            this.btnTheRock.Size = new System.Drawing.Size(224, 57);
            this.btnTheRock.TabIndex = 1;
            this.btnTheRock.Text = "The Rock";
            this.btnTheRock.UseVisualStyleBackColor = true;
            this.btnTheRock.Click += new System.EventHandler(this.btnTheRock_Click);
            // 
            // btnChrisRock
            // 
            this.btnChrisRock.Location = new System.Drawing.Point(56, 99);
            this.btnChrisRock.Name = "btnChrisRock";
            this.btnChrisRock.Size = new System.Drawing.Size(224, 57);
            this.btnChrisRock.TabIndex = 2;
            this.btnChrisRock.Text = "Chris Rock";
            this.btnChrisRock.UseVisualStyleBackColor = true;
            this.btnChrisRock.Click += new System.EventHandler(this.btnChrisRock_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(147, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(503, 67);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Choose Your Fighter";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pbSelect
            // 
            this.pbSelect.BackgroundImage = global::pokemonGameGUI.Properties.Resources.Stage;
            this.pbSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSelect.Location = new System.Drawing.Point(59, 218);
            this.pbSelect.Name = "pbSelect";
            this.pbSelect.Size = new System.Drawing.Size(221, 183);
            this.pbSelect.TabIndex = 4;
            this.pbSelect.TabStop = false;
            // 
            // rtbSelect
            // 
            this.rtbSelect.Location = new System.Drawing.Point(288, 217);
            this.rtbSelect.Name = "rtbSelect";
            this.rtbSelect.Size = new System.Drawing.Size(452, 184);
            this.rtbSelect.TabIndex = 5;
            this.rtbSelect.Text = "";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(350, 162);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(94, 29);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.rtbSelect);
            this.Controls.Add(this.pbSelect);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnChrisRock);
            this.Controls.Add(this.btnTheRock);
            this.Controls.Add(this.btnWillSmith);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnWillSmith;
        private Button btnTheRock;
        private Button btnChrisRock;
        private Label lblTitle;
        private PictureBox pbSelect;
        private RichTextBox rtbSelect;
        private Button btnSelect;
    }
}