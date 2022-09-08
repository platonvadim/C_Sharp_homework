namespace GuessTheNumber
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.textBoxGuessNumber = new System.Windows.Forms.TextBox();
            this.labelRules = new System.Windows.Forms.Label();
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelAttempts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(339, 128);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 49);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = ">>";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(505, 198);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(104, 23);
            this.buttonNewGame.TabIndex = 1;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // textBoxGuessNumber
            // 
            this.textBoxGuessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGuessNumber.Location = new System.Drawing.Point(233, 128);
            this.textBoxGuessNumber.Name = "textBoxGuessNumber";
            this.textBoxGuessNumber.Size = new System.Drawing.Size(100, 49);
            this.textBoxGuessNumber.TabIndex = 2;
            this.textBoxGuessNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGuessNumber_KeyPress);
            // 
            // labelRules
            // 
            this.labelRules.AutoSize = true;
            this.labelRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRules.ForeColor = System.Drawing.Color.Gray;
            this.labelRules.Location = new System.Drawing.Point(12, 65);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(597, 32);
            this.labelRules.TabIndex = 3;
            this.labelRules.Text = "Отгадайте загаданное число от 1 до 100.";
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameName.ForeColor = System.Drawing.Color.IndianRed;
            this.labelGameName.Location = new System.Drawing.Point(176, 9);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(254, 48);
            this.labelGameName.TabIndex = 4;
            this.labelGameName.Text = "Guess The Number";
            // 
            // labelAttempts
            // 
            this.labelAttempts.AutoSize = true;
            this.labelAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttempts.Location = new System.Drawing.Point(12, 131);
            this.labelAttempts.Name = "labelAttempts";
            this.labelAttempts.Size = new System.Drawing.Size(170, 32);
            this.labelAttempts.TabIndex = 5;
            this.labelAttempts.Text = "Попыток: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(623, 233);
            this.Controls.Add(this.labelAttempts);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.labelRules);
            this.Controls.Add(this.textBoxGuessNumber);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.TextBox textBoxGuessNumber;
        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Label labelAttempts;
    }
}

