namespace PongGame
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ballTextBox = new System.Windows.Forms.TextBox();
            this.paddleTextBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.ballColorDialog = new System.Windows.Forms.ColorDialog();
            this.paddleColorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundDialog = new System.Windows.Forms.ColorDialog();
            this.ballColorButton = new System.Windows.Forms.Button();
            this.paddleColorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.colorChange = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Ball Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change Paddle Speed";
            // 
            // ballTextBox
            // 
            this.ballTextBox.Location = new System.Drawing.Point(281, 69);
            this.ballTextBox.Name = "ballTextBox";
            this.ballTextBox.Size = new System.Drawing.Size(100, 22);
            this.ballTextBox.TabIndex = 2;
            // 
            // paddleTextBox
            // 
            this.paddleTextBox.Location = new System.Drawing.Point(293, 123);
            this.paddleTextBox.Name = "paddleTextBox";
            this.paddleTextBox.Size = new System.Drawing.Size(100, 22);
            this.paddleTextBox.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(661, 375);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ballColorButton
            // 
            this.ballColorButton.Location = new System.Drawing.Point(140, 266);
            this.ballColorButton.Name = "ballColorButton";
            this.ballColorButton.Size = new System.Drawing.Size(75, 23);
            this.ballColorButton.TabIndex = 5;
            this.ballColorButton.Text = "Ball";
            this.ballColorButton.UseVisualStyleBackColor = true;
            this.ballColorButton.Click += new System.EventHandler(this.ballColorButton_Click);
            // 
            // paddleColorButton
            // 
            this.paddleColorButton.Location = new System.Drawing.Point(293, 266);
            this.paddleColorButton.Name = "paddleColorButton";
            this.paddleColorButton.Size = new System.Drawing.Size(75, 23);
            this.paddleColorButton.TabIndex = 6;
            this.paddleColorButton.Text = "Paddle";
            this.paddleColorButton.UseVisualStyleBackColor = true;
            this.paddleColorButton.Click += new System.EventHandler(this.paddleColorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(186, 313);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(120, 32);
            this.backgroundColorButton.TabIndex = 7;
            this.backgroundColorButton.Text = "Background";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // colorChange
            // 
            this.colorChange.AutoSize = true;
            this.colorChange.Location = new System.Drawing.Point(196, 209);
            this.colorChange.Name = "colorChange";
            this.colorChange.Size = new System.Drawing.Size(96, 16);
            this.colorChange.TabIndex = 8;
            this.colorChange.Text = "Change Colors";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 375);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 416);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.colorChange);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.paddleColorButton);
            this.Controls.Add(this.ballColorButton);
            this.Controls.Add(this.save);
            this.Controls.Add(this.paddleTextBox);
            this.Controls.Add(this.ballTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ballTextBox;
        private System.Windows.Forms.TextBox paddleTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ColorDialog ballColorDialog;
        private System.Windows.Forms.ColorDialog paddleColorDialog;
        private System.Windows.Forms.ColorDialog backgroundDialog;
        private System.Windows.Forms.Button ballColorButton;
        private System.Windows.Forms.Button paddleColorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Label colorChange;
        private System.Windows.Forms.Button cancelButton;
    }
}