namespace Flappy_Bird
{
    partial class FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.gameScore = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.PipeUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).BeginInit();
            this.SuspendLayout();
            // 
            // gameScore
            // 
            this.gameScore.AutoSize = true;
            this.gameScore.Font = new System.Drawing.Font("Russo One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gameScore.Location = new System.Drawing.Point(12, 26);
            this.gameScore.Name = "gameScore";
            this.gameScore.Size = new System.Drawing.Size(87, 25);
            this.gameScore.TabIndex = 5;
            this.gameScore.Text = "SCORE:";
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.gameEngine);
            // 
            // Ground
            // 
            this.Ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-25, 572);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1175, 95);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 4;
            this.Ground.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.PipeDown.Location = new System.Drawing.Point(573, 362);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(95, 216);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 3;
            this.PipeDown.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(85, 206);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(74, 58);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 2;
            this.Bird.TabStop = false;
            // 
            // PipeUp
            // 
            this.PipeUp.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.PipeUp.Location = new System.Drawing.Point(756, -45);
            this.PipeUp.Name = "PipeUp";
            this.PipeUp.Size = new System.Drawing.Size(100, 266);
            this.PipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeUp.TabIndex = 1;
            this.PipeUp.TabStop = false;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1031, 661);
            this.Controls.Add(this.gameScore);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.PipeUp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlappyBird";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeUp;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label gameScore;
        private System.Windows.Forms.Timer Timer;
    }
}

