
namespace Eendenvijver
{
    partial class LakeFrom
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDucks = new System.Windows.Forms.ListBox();
            this.listBoxStorks = new System.Windows.Forms.ListBox();
            this.listBoxFrogs = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.frogCounter = new System.Windows.Forms.NumericUpDown();
            this.storksCounter = new System.Windows.Forms.NumericUpDown();
            this.ducksCounter = new System.Windows.Forms.NumericUpDown();
            this.btnDucks = new System.Windows.Forms.Button();
            this.btnStorks = new System.Windows.Forms.Button();
            this.btnFrog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frogCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storksCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducksCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "frogs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "storks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(815, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ducks";
            // 
            // listBoxDucks
            // 
            this.listBoxDucks.FormattingEnabled = true;
            this.listBoxDucks.ItemHeight = 16;
            this.listBoxDucks.Location = new System.Drawing.Point(728, 90);
            this.listBoxDucks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxDucks.Name = "listBoxDucks";
            this.listBoxDucks.Size = new System.Drawing.Size(231, 404);
            this.listBoxDucks.TabIndex = 6;
            // 
            // listBoxStorks
            // 
            this.listBoxStorks.FormattingEnabled = true;
            this.listBoxStorks.ItemHeight = 16;
            this.listBoxStorks.Location = new System.Drawing.Point(423, 90);
            this.listBoxStorks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxStorks.Name = "listBoxStorks";
            this.listBoxStorks.Size = new System.Drawing.Size(231, 404);
            this.listBoxStorks.TabIndex = 7;
            // 
            // listBoxFrogs
            // 
            this.listBoxFrogs.FormattingEnabled = true;
            this.listBoxFrogs.ItemHeight = 16;
            this.listBoxFrogs.Location = new System.Drawing.Point(104, 90);
            this.listBoxFrogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxFrogs.Name = "listBoxFrogs";
            this.listBoxFrogs.Size = new System.Drawing.Size(231, 404);
            this.listBoxFrogs.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(328, 511);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(640, 511);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frogCounter
            // 
            this.frogCounter.Location = new System.Drawing.Point(143, 26);
            this.frogCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frogCounter.Name = "frogCounter";
            this.frogCounter.Size = new System.Drawing.Size(160, 22);
            this.frogCounter.TabIndex = 11;
            // 
            // storksCounter
            // 
            this.storksCounter.Location = new System.Drawing.Point(472, 26);
            this.storksCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.storksCounter.Name = "storksCounter";
            this.storksCounter.Size = new System.Drawing.Size(160, 22);
            this.storksCounter.TabIndex = 12;
            // 
            // ducksCounter
            // 
            this.ducksCounter.Location = new System.Drawing.Point(783, 26);
            this.ducksCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ducksCounter.Name = "ducksCounter";
            this.ducksCounter.Size = new System.Drawing.Size(160, 22);
            this.ducksCounter.TabIndex = 13;
            // 
            // btnDucks
            // 
            this.btnDucks.Location = new System.Drawing.Point(951, 22);
            this.btnDucks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDucks.Name = "btnDucks";
            this.btnDucks.Size = new System.Drawing.Size(100, 28);
            this.btnDucks.TabIndex = 14;
            this.btnDucks.Text = "add ducks";
            this.btnDucks.UseVisualStyleBackColor = true;
            this.btnDucks.Click += new System.EventHandler(this.btnDucks_Click);
            // 
            // btnStorks
            // 
            this.btnStorks.Location = new System.Drawing.Point(640, 22);
            this.btnStorks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStorks.Name = "btnStorks";
            this.btnStorks.Size = new System.Drawing.Size(100, 28);
            this.btnStorks.TabIndex = 15;
            this.btnStorks.Text = "add storks";
            this.btnStorks.UseVisualStyleBackColor = true;
            this.btnStorks.Click += new System.EventHandler(this.btnStorks_Click);
            // 
            // btnFrog
            // 
            this.btnFrog.Location = new System.Drawing.Point(311, 22);
            this.btnFrog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFrog.Name = "btnFrog";
            this.btnFrog.Size = new System.Drawing.Size(100, 28);
            this.btnFrog.TabIndex = 16;
            this.btnFrog.Text = "add frogs";
            this.btnFrog.UseVisualStyleBackColor = true;
            this.btnFrog.Click += new System.EventHandler(this.btnFrog_Click);
            // 
            // LakeFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnFrog);
            this.Controls.Add(this.btnStorks);
            this.Controls.Add(this.btnDucks);
            this.Controls.Add(this.ducksCounter);
            this.Controls.Add(this.storksCounter);
            this.Controls.Add(this.frogCounter);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBoxFrogs);
            this.Controls.Add(this.listBoxStorks);
            this.Controls.Add(this.listBoxDucks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LakeFrom";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frogCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storksCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducksCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDucks;
        private System.Windows.Forms.ListBox listBoxStorks;
        private System.Windows.Forms.ListBox listBoxFrogs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown frogCounter;
        private System.Windows.Forms.NumericUpDown storksCounter;
        private System.Windows.Forms.NumericUpDown ducksCounter;
        private System.Windows.Forms.Button btnDucks;
        private System.Windows.Forms.Button btnStorks;
        private System.Windows.Forms.Button btnFrog;
    }
}

