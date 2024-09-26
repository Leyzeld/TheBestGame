
namespace TheBestGame
{
    partial class FightForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DefenseLegsRadioButton = new System.Windows.Forms.RadioButton();
            this.DefenseTorsoRadioButton = new System.Windows.Forms.RadioButton();
            this.DefenseHeadRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AttackLegsRadioButton = new System.Windows.Forms.RadioButton();
            this.AttackHeadRadioButton = new System.Windows.Forms.RadioButton();
            this.AttackTorsoRadioButton = new System.Windows.Forms.RadioButton();
            this.FightLogTextBox = new System.Windows.Forms.TextBox();
            this.StepButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player1CritMultLabel = new System.Windows.Forms.Label();
            this.Player1CritChanceLabel = new System.Windows.Forms.Label();
            this.Player1DefenseLabel = new System.Windows.Forms.Label();
            this.Player1DamageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Player2CritMultLabel = new System.Windows.Forms.Label();
            this.Player2DamageLabel = new System.Windows.Forms.Label();
            this.Player2CritChanceLabel = new System.Windows.Forms.Label();
            this.Player2DefenseLabel = new System.Windows.Forms.Label();
            this.Player1NameLabel = new System.Windows.Forms.Label();
            this.Player2NameLabel = new System.Windows.Forms.Label();
            this.healthPictureBox1 = new System.Windows.Forms.PictureBox();
            this.healthPictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DefenseLegsRadioButton);
            this.groupBox2.Controls.Add(this.DefenseTorsoRadioButton);
            this.groupBox2.Controls.Add(this.DefenseHeadRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(177, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Защитить";
            // 
            // DefenseLegsRadioButton
            // 
            this.DefenseLegsRadioButton.AutoSize = true;
            this.DefenseLegsRadioButton.Location = new System.Drawing.Point(6, 231);
            this.DefenseLegsRadioButton.Name = "DefenseLegsRadioButton";
            this.DefenseLegsRadioButton.Size = new System.Drawing.Size(50, 17);
            this.DefenseLegsRadioButton.TabIndex = 2;
            this.DefenseLegsRadioButton.Text = "Ноги";
            this.DefenseLegsRadioButton.UseVisualStyleBackColor = true;
            this.DefenseLegsRadioButton.CheckedChanged += new System.EventHandler(this.DefenseLegsRadioButton_CheckedChanged);
            // 
            // DefenseTorsoRadioButton
            // 
            this.DefenseTorsoRadioButton.AutoSize = true;
            this.DefenseTorsoRadioButton.Location = new System.Drawing.Point(6, 113);
            this.DefenseTorsoRadioButton.Name = "DefenseTorsoRadioButton";
            this.DefenseTorsoRadioButton.Size = new System.Drawing.Size(50, 17);
            this.DefenseTorsoRadioButton.TabIndex = 1;
            this.DefenseTorsoRadioButton.Text = "Тело";
            this.DefenseTorsoRadioButton.UseVisualStyleBackColor = true;
            this.DefenseTorsoRadioButton.CheckedChanged += new System.EventHandler(this.DefenseTorsoRadioButton_CheckedChanged);
            // 
            // DefenseHeadRadioButton
            // 
            this.DefenseHeadRadioButton.AutoSize = true;
            this.DefenseHeadRadioButton.Checked = true;
            this.DefenseHeadRadioButton.Location = new System.Drawing.Point(6, 19);
            this.DefenseHeadRadioButton.Name = "DefenseHeadRadioButton";
            this.DefenseHeadRadioButton.Size = new System.Drawing.Size(61, 17);
            this.DefenseHeadRadioButton.TabIndex = 0;
            this.DefenseHeadRadioButton.TabStop = true;
            this.DefenseHeadRadioButton.Text = "Голова";
            this.DefenseHeadRadioButton.UseVisualStyleBackColor = true;
            this.DefenseHeadRadioButton.CheckedChanged += new System.EventHandler(this.DefenseHeadRadioButton_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AttackLegsRadioButton);
            this.groupBox4.Controls.Add(this.AttackHeadRadioButton);
            this.groupBox4.Controls.Add(this.AttackTorsoRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(538, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(87, 277);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Атаковать";
            // 
            // AttackLegsRadioButton
            // 
            this.AttackLegsRadioButton.AutoSize = true;
            this.AttackLegsRadioButton.Location = new System.Drawing.Point(6, 231);
            this.AttackLegsRadioButton.Name = "AttackLegsRadioButton";
            this.AttackLegsRadioButton.Size = new System.Drawing.Size(50, 17);
            this.AttackLegsRadioButton.TabIndex = 5;
            this.AttackLegsRadioButton.Text = "Ноги";
            this.AttackLegsRadioButton.UseVisualStyleBackColor = true;
            this.AttackLegsRadioButton.CheckedChanged += new System.EventHandler(this.AttackLegsRadioButton_CheckedChanged);
            // 
            // AttackHeadRadioButton
            // 
            this.AttackHeadRadioButton.AutoSize = true;
            this.AttackHeadRadioButton.Checked = true;
            this.AttackHeadRadioButton.Location = new System.Drawing.Point(6, 19);
            this.AttackHeadRadioButton.Name = "AttackHeadRadioButton";
            this.AttackHeadRadioButton.Size = new System.Drawing.Size(61, 17);
            this.AttackHeadRadioButton.TabIndex = 3;
            this.AttackHeadRadioButton.TabStop = true;
            this.AttackHeadRadioButton.Text = "Голова";
            this.AttackHeadRadioButton.UseVisualStyleBackColor = true;
            this.AttackHeadRadioButton.CheckedChanged += new System.EventHandler(this.AttackHeadRadioButton_CheckedChanged);
            // 
            // AttackTorsoRadioButton
            // 
            this.AttackTorsoRadioButton.AutoSize = true;
            this.AttackTorsoRadioButton.Location = new System.Drawing.Point(6, 113);
            this.AttackTorsoRadioButton.Name = "AttackTorsoRadioButton";
            this.AttackTorsoRadioButton.Size = new System.Drawing.Size(50, 17);
            this.AttackTorsoRadioButton.TabIndex = 4;
            this.AttackTorsoRadioButton.Text = "Тело";
            this.AttackTorsoRadioButton.UseVisualStyleBackColor = true;
            this.AttackTorsoRadioButton.CheckedChanged += new System.EventHandler(this.AttackTorsoRadioButton_CheckedChanged);
            // 
            // FightLogTextBox
            // 
            this.FightLogTextBox.Location = new System.Drawing.Point(276, 104);
            this.FightLogTextBox.Multiline = true;
            this.FightLogTextBox.Name = "FightLogTextBox";
            this.FightLogTextBox.Size = new System.Drawing.Size(256, 232);
            this.FightLogTextBox.TabIndex = 4;
            // 
            // StepButton
            // 
            this.StepButton.Location = new System.Drawing.Point(317, 361);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(168, 53);
            this.StepButton.TabIndex = 5;
            this.StepButton.Text = "Сделать ход";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Player1CritMultLabel);
            this.panel1.Controls.Add(this.Player1CritChanceLabel);
            this.panel1.Controls.Add(this.Player1DefenseLabel);
            this.panel1.Controls.Add(this.Player1DamageLabel);
            this.panel1.Location = new System.Drawing.Point(12, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 138);
            this.panel1.TabIndex = 6;
            // 
            // Player1CritMultLabel
            // 
            this.Player1CritMultLabel.AutoSize = true;
            this.Player1CritMultLabel.Location = new System.Drawing.Point(5, 113);
            this.Player1CritMultLabel.Name = "Player1CritMultLabel";
            this.Player1CritMultLabel.Size = new System.Drawing.Size(35, 13);
            this.Player1CritMultLabel.TabIndex = 3;
            this.Player1CritMultLabel.Text = "label2";
            // 
            // Player1CritChanceLabel
            // 
            this.Player1CritChanceLabel.AutoSize = true;
            this.Player1CritChanceLabel.Location = new System.Drawing.Point(5, 73);
            this.Player1CritChanceLabel.Name = "Player1CritChanceLabel";
            this.Player1CritChanceLabel.Size = new System.Drawing.Size(35, 13);
            this.Player1CritChanceLabel.TabIndex = 2;
            this.Player1CritChanceLabel.Text = "label1";
            // 
            // Player1DefenseLabel
            // 
            this.Player1DefenseLabel.AutoSize = true;
            this.Player1DefenseLabel.Location = new System.Drawing.Point(5, 38);
            this.Player1DefenseLabel.Name = "Player1DefenseLabel";
            this.Player1DefenseLabel.Size = new System.Drawing.Size(35, 13);
            this.Player1DefenseLabel.TabIndex = 1;
            this.Player1DefenseLabel.Text = "label1";
            // 
            // Player1DamageLabel
            // 
            this.Player1DamageLabel.AutoSize = true;
            this.Player1DamageLabel.Location = new System.Drawing.Point(5, 4);
            this.Player1DamageLabel.Name = "Player1DamageLabel";
            this.Player1DamageLabel.Size = new System.Drawing.Size(35, 13);
            this.Player1DamageLabel.TabIndex = 0;
            this.Player1DamageLabel.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Player2CritMultLabel);
            this.panel2.Controls.Add(this.Player2DamageLabel);
            this.panel2.Controls.Add(this.Player2CritChanceLabel);
            this.panel2.Controls.Add(this.Player2DefenseLabel);
            this.panel2.Location = new System.Drawing.Point(631, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 138);
            this.panel2.TabIndex = 7;
            // 
            // Player2CritMultLabel
            // 
            this.Player2CritMultLabel.AutoSize = true;
            this.Player2CritMultLabel.Location = new System.Drawing.Point(3, 113);
            this.Player2CritMultLabel.Name = "Player2CritMultLabel";
            this.Player2CritMultLabel.Size = new System.Drawing.Size(35, 13);
            this.Player2CritMultLabel.TabIndex = 7;
            this.Player2CritMultLabel.Text = "label2";
            // 
            // Player2DamageLabel
            // 
            this.Player2DamageLabel.AutoSize = true;
            this.Player2DamageLabel.Location = new System.Drawing.Point(3, 4);
            this.Player2DamageLabel.Name = "Player2DamageLabel";
            this.Player2DamageLabel.Size = new System.Drawing.Size(35, 13);
            this.Player2DamageLabel.TabIndex = 4;
            this.Player2DamageLabel.Text = "label1";
            // 
            // Player2CritChanceLabel
            // 
            this.Player2CritChanceLabel.AutoSize = true;
            this.Player2CritChanceLabel.Location = new System.Drawing.Point(3, 73);
            this.Player2CritChanceLabel.Name = "Player2CritChanceLabel";
            this.Player2CritChanceLabel.Size = new System.Drawing.Size(35, 13);
            this.Player2CritChanceLabel.TabIndex = 6;
            this.Player2CritChanceLabel.Text = "label1";
            // 
            // Player2DefenseLabel
            // 
            this.Player2DefenseLabel.AutoSize = true;
            this.Player2DefenseLabel.Location = new System.Drawing.Point(3, 38);
            this.Player2DefenseLabel.Name = "Player2DefenseLabel";
            this.Player2DefenseLabel.Size = new System.Drawing.Size(35, 13);
            this.Player2DefenseLabel.TabIndex = 5;
            this.Player2DefenseLabel.Text = "label1";
            // 
            // Player1NameLabel
            // 
            this.Player1NameLabel.AutoSize = true;
            this.Player1NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Player1NameLabel.Location = new System.Drawing.Point(13, 13);
            this.Player1NameLabel.Name = "Player1NameLabel";
            this.Player1NameLabel.Size = new System.Drawing.Size(60, 24);
            this.Player1NameLabel.TabIndex = 8;
            this.Player1NameLabel.Text = "label1";
            // 
            // Player2NameLabel
            // 
            this.Player2NameLabel.AutoSize = true;
            this.Player2NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Player2NameLabel.Location = new System.Drawing.Point(534, 13);
            this.Player2NameLabel.Name = "Player2NameLabel";
            this.Player2NameLabel.Size = new System.Drawing.Size(60, 24);
            this.Player2NameLabel.TabIndex = 9;
            this.Player2NameLabel.Text = "label1";
            // 
            // healthPictureBox1
            // 
            this.healthPictureBox1.Location = new System.Drawing.Point(17, 41);
            this.healthPictureBox1.Name = "healthPictureBox1";
            this.healthPictureBox1.Size = new System.Drawing.Size(253, 28);
            this.healthPictureBox1.TabIndex = 10;
            this.healthPictureBox1.TabStop = false;
            // 
            // healthPictureBox2
            // 
            this.healthPictureBox2.Location = new System.Drawing.Point(538, 41);
            this.healthPictureBox2.Name = "healthPictureBox2";
            this.healthPictureBox2.Size = new System.Drawing.Size(253, 28);
            this.healthPictureBox2.TabIndex = 11;
            this.healthPictureBox2.TabStop = false;
            // 
            // FightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.healthPictureBox2);
            this.Controls.Add(this.healthPictureBox1);
            this.Controls.Add(this.Player2NameLabel);
            this.Controls.Add(this.Player1NameLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StepButton);
            this.Controls.Add(this.FightLogTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "FightForm";
            this.Text = "FightForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton DefenseLegsRadioButton;
        private System.Windows.Forms.RadioButton DefenseTorsoRadioButton;
        private System.Windows.Forms.RadioButton DefenseHeadRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton AttackLegsRadioButton;
        private System.Windows.Forms.RadioButton AttackHeadRadioButton;
        private System.Windows.Forms.RadioButton AttackTorsoRadioButton;
        private System.Windows.Forms.TextBox FightLogTextBox;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Player1CritMultLabel;
        private System.Windows.Forms.Label Player1CritChanceLabel;
        private System.Windows.Forms.Label Player1DefenseLabel;
        private System.Windows.Forms.Label Player1DamageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Player2CritMultLabel;
        private System.Windows.Forms.Label Player2DamageLabel;
        private System.Windows.Forms.Label Player2CritChanceLabel;
        private System.Windows.Forms.Label Player2DefenseLabel;
        private System.Windows.Forms.Label Player1NameLabel;
        private System.Windows.Forms.Label Player2NameLabel;
        private System.Windows.Forms.PictureBox healthPictureBox1;
        private System.Windows.Forms.PictureBox healthPictureBox2;
    }
}