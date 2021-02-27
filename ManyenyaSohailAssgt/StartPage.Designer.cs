namespace Assessment01
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblSetGoal = new System.Windows.Forms.Label();
            this.lblNoGames = new System.Windows.Forms.Label();
            this.txtBxPlayer1 = new System.Windows.Forms.TextBox();
            this.txtBxPlayer2 = new System.Windows.Forms.TextBox();
            this.comboBxGames = new System.Windows.Forms.ComboBox();
            this.trackBarGoal = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtbxScoreSelected = new System.Windows.Forms.TextBox();
            this.radioBtnComp = new System.Windows.Forms.RadioButton();
            this.radioBtn1on1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(31, 369);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(73, 13);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Enter Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(415, 369);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(73, 13);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Enter Player 2";
            // 
            // lblSetGoal
            // 
            this.lblSetGoal.AutoSize = true;
            this.lblSetGoal.Location = new System.Drawing.Point(30, 505);
            this.lblSetGoal.Name = "lblSetGoal";
            this.lblSetGoal.Size = new System.Drawing.Size(103, 13);
            this.lblSetGoal.TabIndex = 4;
            this.lblSetGoal.Text = "Set the Goal (Score)";
            // 
            // lblNoGames
            // 
            this.lblNoGames.AutoSize = true;
            this.lblNoGames.Location = new System.Drawing.Point(32, 431);
            this.lblNoGames.Name = "lblNoGames";
            this.lblNoGames.Size = new System.Drawing.Size(72, 13);
            this.lblNoGames.TabIndex = 5;
            this.lblNoGames.Text = "No. of Games";
            // 
            // txtBxPlayer1
            // 
            this.txtBxPlayer1.Location = new System.Drawing.Point(33, 385);
            this.txtBxPlayer1.Name = "txtBxPlayer1";
            this.txtBxPlayer1.Size = new System.Drawing.Size(121, 20);
            this.txtBxPlayer1.TabIndex = 6;
            // 
            // txtBxPlayer2
            // 
            this.txtBxPlayer2.Location = new System.Drawing.Point(418, 385);
            this.txtBxPlayer2.Name = "txtBxPlayer2";
            this.txtBxPlayer2.Size = new System.Drawing.Size(121, 20);
            this.txtBxPlayer2.TabIndex = 8;
            // 
            // comboBxGames
            // 
            this.comboBxGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxGames.FormattingEnabled = true;
            this.comboBxGames.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBxGames.Location = new System.Drawing.Point(33, 447);
            this.comboBxGames.Name = "comboBxGames";
            this.comboBxGames.Size = new System.Drawing.Size(121, 21);
            this.comboBxGames.TabIndex = 9;
            // 
            // trackBarGoal
            // 
            this.trackBarGoal.Location = new System.Drawing.Point(25, 521);
            this.trackBarGoal.Maximum = 100;
            this.trackBarGoal.Name = "trackBarGoal";
            this.trackBarGoal.Size = new System.Drawing.Size(318, 45);
            this.trackBarGoal.TabIndex = 10;
            this.trackBarGoal.Scroll += new System.EventHandler(this.trackBarGoal_Scroll);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(450, 522);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 31);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start the Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(32, 242);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(192, 18);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Enter the Information below:";
            // 
            // txtbxScoreSelected
            // 
            this.txtbxScoreSelected.Location = new System.Drawing.Point(346, 525);
            this.txtbxScoreSelected.Name = "txtbxScoreSelected";
            this.txtbxScoreSelected.ReadOnly = true;
            this.txtbxScoreSelected.Size = new System.Drawing.Size(34, 20);
            this.txtbxScoreSelected.TabIndex = 13;
            this.txtbxScoreSelected.Text = "0";
            // 
            // radioBtnComp
            // 
            this.radioBtnComp.AutoSize = true;
            this.radioBtnComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnComp.Location = new System.Drawing.Point(418, 306);
            this.radioBtnComp.Name = "radioBtnComp";
            this.radioBtnComp.Size = new System.Drawing.Size(130, 19);
            this.radioBtnComp.TabIndex = 14;
            this.radioBtnComp.TabStop = true;
            this.radioBtnComp.Text = "Play with Computer";
            this.radioBtnComp.UseVisualStyleBackColor = true;
            this.radioBtnComp.CheckedChanged += new System.EventHandler(this.radioBtnComp_CheckedChanged);
            // 
            // radioBtn1on1
            // 
            this.radioBtn1on1.AutoSize = true;
            this.radioBtn1on1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn1on1.Location = new System.Drawing.Point(33, 306);
            this.radioBtn1on1.Name = "radioBtn1on1";
            this.radioBtn1on1.Size = new System.Drawing.Size(85, 19);
            this.radioBtn1on1.TabIndex = 15;
            this.radioBtn1on1.TabStop = true;
            this.radioBtn1on1.Text = "Play 1 on 1";
            this.radioBtn1on1.UseVisualStyleBackColor = true;
            this.radioBtn1on1.CheckedChanged += new System.EventHandler(this.radioBtn1on1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "More Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "For more Instructions and rules on how to play\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select the game type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "SIX OF ONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Goals between 50 and 100 seem to make for reasonable games";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(605, 594);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioBtn1on1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioBtnComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxScoreSelected);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarGoal);
            this.Controls.Add(this.comboBxGames);
            this.Controls.Add(this.txtBxPlayer2);
            this.Controls.Add(this.txtBxPlayer1);
            this.Controls.Add(this.lblNoGames);
            this.Controls.Add(this.lblSetGoal);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Name = "StartPage";
            this.Text = "Playing 1 on 1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGoal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblSetGoal;
        private System.Windows.Forms.Label lblNoGames;
        private System.Windows.Forms.TextBox txtBxPlayer1;
        private System.Windows.Forms.TextBox txtBxPlayer2;
        private System.Windows.Forms.ComboBox comboBxGames;
        private System.Windows.Forms.TrackBar trackBarGoal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtbxScoreSelected;
        private System.Windows.Forms.RadioButton radioBtnComp;
        private System.Windows.Forms.RadioButton radioBtn1on1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}