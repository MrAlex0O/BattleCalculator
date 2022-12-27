namespace BattleCalculator
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
            this.AArmyListBox = new System.Windows.Forms.ListBox();
            this.AInfantryTrackBar = new System.Windows.Forms.TrackBar();
            this.ACavalryTrackBar = new System.Windows.Forms.TrackBar();
            this.ASiegeWeaponsTrackBar = new System.Windows.Forms.TrackBar();
            this.AArmyTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BArmyTextBox = new System.Windows.Forms.TextBox();
            this.BSiegeWeaponsTrackBar = new System.Windows.Forms.TrackBar();
            this.BCavalryTrackBar = new System.Windows.Forms.TrackBar();
            this.BInfantryTrackBar = new System.Windows.Forms.TrackBar();
            this.BArmyListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.AInfantryTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACavalryTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASiegeWeaponsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSiegeWeaponsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCavalryTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BInfantryTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // AArmyListBox
            // 
            this.AArmyListBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AArmyListBox.FormattingEnabled = true;
            this.AArmyListBox.ItemHeight = 25;
            this.AArmyListBox.Location = new System.Drawing.Point(53, 41);
            this.AArmyListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AArmyListBox.Name = "AArmyListBox";
            this.AArmyListBox.Size = new System.Drawing.Size(270, 104);
            this.AArmyListBox.TabIndex = 0;
            this.AArmyListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AInfantryTrackBar
            // 
            this.AInfantryTrackBar.Location = new System.Drawing.Point(53, 162);
            this.AInfantryTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AInfantryTrackBar.Name = "AInfantryTrackBar";
            this.AInfantryTrackBar.Size = new System.Drawing.Size(270, 45);
            this.AInfantryTrackBar.TabIndex = 2;
            this.AInfantryTrackBar.Scroll += new System.EventHandler(this.AArmyChange);
            // 
            // ACavalryTrackBar
            // 
            this.ACavalryTrackBar.Location = new System.Drawing.Point(53, 211);
            this.ACavalryTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ACavalryTrackBar.Name = "ACavalryTrackBar";
            this.ACavalryTrackBar.Size = new System.Drawing.Size(270, 45);
            this.ACavalryTrackBar.TabIndex = 3;
            this.ACavalryTrackBar.Scroll += new System.EventHandler(this.AArmyChange);
            // 
            // ASiegeWeaponsTrackBar
            // 
            this.ASiegeWeaponsTrackBar.Location = new System.Drawing.Point(53, 260);
            this.ASiegeWeaponsTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ASiegeWeaponsTrackBar.Name = "ASiegeWeaponsTrackBar";
            this.ASiegeWeaponsTrackBar.Size = new System.Drawing.Size(270, 45);
            this.ASiegeWeaponsTrackBar.TabIndex = 4;
            this.ASiegeWeaponsTrackBar.Scroll += new System.EventHandler(this.AArmyChange);
            // 
            // AArmyTextBox
            // 
            this.AArmyTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AArmyTextBox.Location = new System.Drawing.Point(53, 310);
            this.AArmyTextBox.Multiline = true;
            this.AArmyTextBox.Name = "AArmyTextBox";
            this.AArmyTextBox.Size = new System.Drawing.Size(270, 231);
            this.AArmyTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(329, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 70);
            this.button1.TabIndex = 12;
            this.button1.Text = "Начать сражение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BArmyTextBox
            // 
            this.BArmyTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BArmyTextBox.Location = new System.Drawing.Point(624, 310);
            this.BArmyTextBox.Multiline = true;
            this.BArmyTextBox.Name = "BArmyTextBox";
            this.BArmyTextBox.Size = new System.Drawing.Size(270, 231);
            this.BArmyTextBox.TabIndex = 17;
            // 
            // BSiegeWeaponsTrackBar
            // 
            this.BSiegeWeaponsTrackBar.Location = new System.Drawing.Point(624, 260);
            this.BSiegeWeaponsTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BSiegeWeaponsTrackBar.Name = "BSiegeWeaponsTrackBar";
            this.BSiegeWeaponsTrackBar.Size = new System.Drawing.Size(270, 45);
            this.BSiegeWeaponsTrackBar.TabIndex = 16;
            this.BSiegeWeaponsTrackBar.Scroll += new System.EventHandler(this.BArmyChange);
            // 
            // BCavalryTrackBar
            // 
            this.BCavalryTrackBar.Location = new System.Drawing.Point(624, 211);
            this.BCavalryTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BCavalryTrackBar.Name = "BCavalryTrackBar";
            this.BCavalryTrackBar.Size = new System.Drawing.Size(270, 45);
            this.BCavalryTrackBar.TabIndex = 15;
            this.BCavalryTrackBar.Scroll += new System.EventHandler(this.BArmyChange);
            // 
            // BInfantryTrackBar
            // 
            this.BInfantryTrackBar.Location = new System.Drawing.Point(624, 159);
            this.BInfantryTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BInfantryTrackBar.Name = "BInfantryTrackBar";
            this.BInfantryTrackBar.Size = new System.Drawing.Size(270, 45);
            this.BInfantryTrackBar.TabIndex = 14;
            this.BInfantryTrackBar.Scroll += new System.EventHandler(this.BArmyChange);
            // 
            // BArmyListBox
            // 
            this.BArmyListBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BArmyListBox.FormattingEnabled = true;
            this.BArmyListBox.ItemHeight = 25;
            this.BArmyListBox.Location = new System.Drawing.Point(624, 41);
            this.BArmyListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BArmyListBox.Name = "BArmyListBox";
            this.BArmyListBox.Size = new System.Drawing.Size(270, 104);
            this.BArmyListBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 586);
            this.Controls.Add(this.BArmyTextBox);
            this.Controls.Add(this.BSiegeWeaponsTrackBar);
            this.Controls.Add(this.BCavalryTrackBar);
            this.Controls.Add(this.BInfantryTrackBar);
            this.Controls.Add(this.BArmyListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AArmyTextBox);
            this.Controls.Add(this.ASiegeWeaponsTrackBar);
            this.Controls.Add(this.ACavalryTrackBar);
            this.Controls.Add(this.AInfantryTrackBar);
            this.Controls.Add(this.AArmyListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AInfantryTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACavalryTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASiegeWeaponsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSiegeWeaponsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCavalryTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BInfantryTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox AArmyListBox;
        private TrackBar AInfantryTrackBar;
        private TrackBar ACavalryTrackBar;
        private TrackBar ASiegeWeaponsTrackBar;
        private TextBox AArmyTextBox;
        private Button button1;
        private TextBox BArmyTextBox;
        private TrackBar BSiegeWeaponsTrackBar;
        private TrackBar BCavalryTrackBar;
        private TrackBar BInfantryTrackBar;
        private ListBox BArmyListBox;
    }
}