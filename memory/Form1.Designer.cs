namespace memory
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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(372, 202);
            button1.Name = "button1";
            button1.Size = new Size(186, 72);
            button1.TabIndex = 0;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RestartGameEvent;
            // 
            // label1
            // 
            label1.Location = new Point(392, 56);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 1;
            label1.Text = "status";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(392, 106);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 2;
            label2.Text = "Time Left : ";
            label2.Click += label2_Click;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += TimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 382);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer GameTimer;
    }
}