namespace ADayAtTheRaces
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.betsButton = new System.Windows.Forms.Button();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dogtowin = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogtowin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Betting Parlor";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(15, 224);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(104, 13);
            this.minimumBetLabel.TabIndex = 5;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(12, 240);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 6;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(12, 263);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 7;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(12, 284);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 8;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bets";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(243, 241);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(144, 23);
            this.joeBetLabel.TabIndex = 10;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(243, 264);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(144, 23);
            this.bobBetLabel.TabIndex = 11;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(243, 287);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(144, 23);
            this.alBetLabel.TabIndex = 12;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // raceTrackPictureBox
            // 
            this.raceTrackPictureBox.Image = global::ADayAtTheRaces.Properties.Resources.racetrack;
            this.raceTrackPictureBox.Location = new System.Drawing.Point(2, 4);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(600, 200);
            this.raceTrackPictureBox.TabIndex = 13;
            this.raceTrackPictureBox.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(2, 164);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.TabIndex = 3;
            this.dog4.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(2, 112);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.TabIndex = 2;
            this.dog3.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(2, 60);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.TabIndex = 1;
            this.dog2.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(2, 12);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.TabIndex = 0;
            this.dog1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "name";
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(66, 314);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(62, 27);
            this.betsButton.TabIndex = 15;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(145, 319);
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(44, 20);
            this.betAmount.TabIndex = 16;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "bucks on dog number";
            // 
            // dogtowin
            // 
            this.dogtowin.Location = new System.Drawing.Point(311, 319);
            this.dogtowin.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogtowin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogtowin.Name = "dogtowin";
            this.dogtowin.Size = new System.Drawing.Size(35, 20);
            this.dogtowin.TabIndex = 18;
            this.dogtowin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 93);
            this.button1.TabIndex = 19;
            this.button1.Text = "Race!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dogtowin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.betsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alBetLabel);
            this.Controls.Add(this.bobBetLabel);
            this.Controls.Add(this.joeBetLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alRadioButton);
            this.Controls.Add(this.bobRadioButton);
            this.Controls.Add(this.joeRadioButton);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.raceTrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogtowin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dogtowin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

