namespace OBStimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hourTB = new System.Windows.Forms.TextBox();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.minuteTB = new System.Windows.Forms.TextBox();
            this.secondTB = new System.Windows.Forms.TextBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hourTB
            // 
            this.hourTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourTB.Location = new System.Drawing.Point(41, 42);
            this.hourTB.MaxLength = 2;
            this.hourTB.Name = "hourTB";
            this.hourTB.Size = new System.Drawing.Size(30, 31);
            this.hourTB.TabIndex = 2;
            this.hourTB.Text = "00";
            this.hourTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hourTB.TextChanged += new System.EventHandler(this.hourTB_TextChanged);
            this.hourTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourTB_KeyPress);
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteLabel.Location = new System.Drawing.Point(77, 45);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(18, 25);
            this.minuteLabel.TabIndex = 3;
            this.minuteLabel.Text = ":";
            // 
            // minuteTB
            // 
            this.minuteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteTB.Location = new System.Drawing.Point(101, 42);
            this.minuteTB.MaxLength = 2;
            this.minuteTB.Name = "minuteTB";
            this.minuteTB.Size = new System.Drawing.Size(30, 31);
            this.minuteTB.TabIndex = 4;
            this.minuteTB.Text = "00";
            this.minuteTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minuteTB.TextChanged += new System.EventHandler(this.minuteTB_TextChanged);
            this.minuteTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minuteTB_KeyPress);
            // 
            // secondTB
            // 
            this.secondTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTB.Location = new System.Drawing.Point(161, 42);
            this.secondTB.MaxLength = 2;
            this.secondTB.Name = "secondTB";
            this.secondTB.Size = new System.Drawing.Size(30, 31);
            this.secondTB.TabIndex = 5;
            this.secondTB.Text = "00";
            this.secondTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondTB.TextChanged += new System.EventHandler(this.secondTB_TextChanged);
            this.secondTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondTB_KeyPress);
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(137, 45);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(18, 25);
            this.secondLabel.TabIndex = 6;
            this.secondLabel.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 145);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.secondTB);
            this.Controls.Add(this.minuteTB);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.hourTB);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OBS Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox hourTB;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.TextBox minuteTB;
        private System.Windows.Forms.TextBox secondTB;
        private System.Windows.Forms.Label secondLabel;
    }
}

