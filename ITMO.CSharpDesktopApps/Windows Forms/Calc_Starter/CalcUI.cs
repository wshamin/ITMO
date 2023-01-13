using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalcUI.
	/// </summary>
	public class CalcUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox VersionInfo;
		private System.Windows.Forms.Button KeyExit;
		private System.Windows.Forms.Button KeyDate;
		private System.Windows.Forms.TextBox OutputDisplay;
		private System.Windows.Forms.Button KeyClear;
		private System.Windows.Forms.Button KeyMinus;
		private System.Windows.Forms.Button KeyPlus;
		private System.Windows.Forms.Button KeyEqual;
		private System.Windows.Forms.Button KeyMultiply;
		private System.Windows.Forms.Button KeyDivide;
        private System.Windows.Forms.Button KeySqr;
        private System.Windows.Forms.Button KeySqrt;
        private System.Windows.Forms.Button KeyReverse;
        private System.Windows.Forms.Button KeyPow;
        private System.Windows.Forms.Button KeyFactorial;
        private System.Windows.Forms.Button KeyCubeRoot;
        private System.Windows.Forms.Button KeyQuadEqua;
        private System.Windows.Forms.Button KeyPoint;
		private System.Windows.Forms.Button KeySign;
		private System.Windows.Forms.Button KeyZero;
		private System.Windows.Forms.Button KeyNine;
		private System.Windows.Forms.Button KeyEight;
		private System.Windows.Forms.Button KeySeven;
		private System.Windows.Forms.Button KeySix;
		private System.Windows.Forms.Button KeyFive;
		private System.Windows.Forms.Button KeyFour;
		private System.Windows.Forms.Button KeyThree;
		private System.Windows.Forms.Button KeyTwo;
		private System.Windows.Forms.Button KeyOne;

		// Output Display Constants.
		private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ñáğîñToolStripMenuItem;
        private ToolStripMenuItem ñïğàâêàToolStripMenuItem;
        private ToolStripMenuItem îÑîçäàòåëåToolStripMenuItem;
        private ToolStripMenuItem èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem;
        private ToolStripMenuItem èçìåíèòüÖâåòÎêîíToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem êàëüêóëÿòîğToolStripMenuItem;
        private ToolStripMenuItem îáû÷íûéToolStripMenuItem;
        private ToolStripMenuItem èíæåíåğíûéToolStripMenuItem;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public CalcUI()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();

			//
			// Get version information from the Calculator Module.
			//

			VersionInfo.Text = CalcEngine.GetVersion();
			OutputDisplay.Text = "0";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ñáğîñToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.èçìåíèòüÖâåòÎêîíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ñïğàâêàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.îÑîçäàòåëåToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.KeySqr = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.KeyReverse = new System.Windows.Forms.Button();
            this.KeyPow = new System.Windows.Forms.Button();
            this.êàëüêóëÿòîğToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.îáû÷íûéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.èíæåíåğíûéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyFactorial = new System.Windows.Forms.Button();
            this.KeyCubeRoot = new System.Windows.Forms.Button();
            this.KeyQuadEqua = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(396, 265);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(112, 73);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(12, 353);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(80, 74);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(12, 58);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(496, 33);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(204, 265);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(80, 73);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(108, 265);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(80, 73);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(396, 442);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(112, 74);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(108, 353);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(80, 74);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(12, 442);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(80, 74);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(204, 353);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(80, 74);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(300, 442);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(80, 74);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(396, 353);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(112, 74);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(204, 442);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(80, 74);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(12, 176);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(80, 74);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(108, 442);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(80, 74);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(204, 176);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(80, 74);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(12, 117);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(496, 44);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(300, 353);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(80, 74);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(108, 176);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(80, 74);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(300, 265);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(80, 73);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(12, 265);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(80, 73);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(396, 176);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(112, 74);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(300, 176);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(80, 74);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.êàëüêóëÿòîğToolStripMenuItem,
            this.ñáğîñToolStripMenuItem,
            this.ñïğàâêàToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 40);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ñáğîñToolStripMenuItem
            // 
            this.ñáğîñToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem,
            this.èçìåíèòüÖâåòÎêîíToolStripMenuItem});
            this.ñáğîñToolStripMenuItem.Name = "ñáğîñToolStripMenuItem";
            this.ñáğîñToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.ñáğîñToolStripMenuItem.Text = "Ôîğìàò";
            // 
            // èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem
            // 
            this.èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem.Name = "èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem";
            this.èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem.Size = new System.Drawing.Size(462, 44);
            this.èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem.Text = "Èçìåíèòü öâåò ïîëÿ âûâîäà";
            this.èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem.Click += new System.EventHandler(this.èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem_Click);
            // 
            // èçìåíèòüÖâåòÎêîíToolStripMenuItem
            // 
            this.èçìåíèòüÖâåòÎêîíToolStripMenuItem.Name = "èçìåíèòüÖâåòÎêîíToolStripMenuItem";
            this.èçìåíèòüÖâåòÎêîíToolStripMenuItem.Size = new System.Drawing.Size(462, 44);
            this.èçìåíèòüÖâåòÎêîíToolStripMenuItem.Text = "Èçìåíèòü öâåò ïîëÿ âåğñèè";
            this.èçìåíèòüÖâåòÎêîíToolStripMenuItem.Click += new System.EventHandler(this.èçìåíèòüÖâåòÎêîíToolStripMenuItem_Click);
            // 
            // ñïğàâêàToolStripMenuItem
            // 
            this.ñïğàâêàToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.îÑîçäàòåëåToolStripMenuItem});
            this.ñïğàâêàToolStripMenuItem.Name = "ñïğàâêàToolStripMenuItem";
            this.ñïğàâêàToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.ñïğàâêàToolStripMenuItem.Text = "Ñïğàâêà";
            // 
            // îÑîçäàòåëåToolStripMenuItem
            // 
            this.îÑîçäàòåëåToolStripMenuItem.Name = "îÑîçäàòåëåToolStripMenuItem";
            this.îÑîçäàòåëåToolStripMenuItem.Size = new System.Drawing.Size(282, 44);
            this.îÑîçäàòåëåToolStripMenuItem.Text = "Î ñîçäàòåëå";
            this.îÑîçäàòåëåToolStripMenuItem.Click += new System.EventHandler(this.îÑîçäàòåëåToolStripMenuItem_Click);
            // 
            // KeySqr
            // 
            this.KeySqr.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySqr.ForeColor = System.Drawing.Color.Red;
            this.KeySqr.Location = new System.Drawing.Point(396, 531);
            this.KeySqr.Name = "KeySqr";
            this.KeySqr.Size = new System.Drawing.Size(112, 74);
            this.KeySqr.TabIndex = 23;
            this.KeySqr.TabStop = false;
            this.KeySqr.Text = "sqr";
            this.KeySqr.Visible = false;
            this.KeySqr.Click += new System.EventHandler(this.KeySqr_Click);
            // 
            // KeySqrt
            // 
            this.KeySqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySqrt.ForeColor = System.Drawing.Color.Red;
            this.KeySqrt.Location = new System.Drawing.Point(140, 531);
            this.KeySqrt.Name = "KeySqrt";
            this.KeySqrt.Size = new System.Drawing.Size(112, 74);
            this.KeySqrt.TabIndex = 24;
            this.KeySqrt.TabStop = false;
            this.KeySqrt.Text = "sqrt";
            this.KeySqrt.Visible = false;
            this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
            // 
            // KeyReverse
            // 
            this.KeyReverse.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyReverse.ForeColor = System.Drawing.Color.Red;
            this.KeyReverse.Location = new System.Drawing.Point(268, 531);
            this.KeyReverse.Name = "KeyReverse";
            this.KeyReverse.Size = new System.Drawing.Size(112, 74);
            this.KeyReverse.TabIndex = 25;
            this.KeyReverse.TabStop = false;
            this.KeyReverse.Text = "1/x";
            this.KeyReverse.Visible = false;
            this.KeyReverse.Click += new System.EventHandler(this.KeyReverse_Click);
            // 
            // KeyPow
            // 
            this.KeyPow.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPow.ForeColor = System.Drawing.Color.Red;
            this.KeyPow.Location = new System.Drawing.Point(12, 531);
            this.KeyPow.Name = "KeyPow";
            this.KeyPow.Size = new System.Drawing.Size(112, 74);
            this.KeyPow.TabIndex = 26;
            this.KeyPow.TabStop = false;
            this.KeyPow.Text = "pow";
            this.KeyPow.Visible = false;
            this.KeyPow.Click += new System.EventHandler(this.KeyPow_Click);
            // 
            // êàëüêóëÿòîğToolStripMenuItem
            // 
            this.êàëüêóëÿòîğToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.îáû÷íûéToolStripMenuItem,
            this.èíæåíåğíûéToolStripMenuItem});
            this.êàëüêóëÿòîğToolStripMenuItem.Name = "êàëüêóëÿòîğToolStripMenuItem";
            this.êàëüêóëÿòîğToolStripMenuItem.Size = new System.Drawing.Size(172, 36);
            this.êàëüêóëÿòîğToolStripMenuItem.Text = "Êàëüêóëÿòîğ";
            // 
            // îáû÷íûéToolStripMenuItem
            // 
            this.îáû÷íûéToolStripMenuItem.Name = "îáû÷íûéToolStripMenuItem";
            this.îáû÷íûéToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.îáû÷íûéToolStripMenuItem.Text = "Îáû÷íûé";
            this.îáû÷íûéToolStripMenuItem.Click += new System.EventHandler(this.îáû÷íûéToolStripMenuItem_Click);
            // 
            // èíæåíåğíûéToolStripMenuItem
            // 
            this.èíæåíåğíûéToolStripMenuItem.Name = "èíæåíåğíûéToolStripMenuItem";
            this.èíæåíåğíûéToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.èíæåíåğíûéToolStripMenuItem.Text = "Èíæåíåğíûé";
            this.èíæåíåğíûéToolStripMenuItem.Click += new System.EventHandler(this.èíæåíåğíûéToolStripMenuItem_Click);
            // 
            // KeyFactorial
            // 
            this.KeyFactorial.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFactorial.ForeColor = System.Drawing.Color.Red;
            this.KeyFactorial.Location = new System.Drawing.Point(12, 620);
            this.KeyFactorial.Name = "KeyFactorial";
            this.KeyFactorial.Size = new System.Drawing.Size(154, 74);
            this.KeyFactorial.TabIndex = 27;
            this.KeyFactorial.TabStop = false;
            this.KeyFactorial.Text = "fact";
            this.KeyFactorial.Visible = false;
            this.KeyFactorial.Click += new System.EventHandler(this.KeyFactorial_Click);
            // 
            // KeyCubeRoot
            // 
            this.KeyCubeRoot.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyCubeRoot.ForeColor = System.Drawing.Color.Red;
            this.KeyCubeRoot.Location = new System.Drawing.Point(182, 620);
            this.KeyCubeRoot.Name = "KeyCubeRoot";
            this.KeyCubeRoot.Size = new System.Drawing.Size(154, 74);
            this.KeyCubeRoot.TabIndex = 28;
            this.KeyCubeRoot.TabStop = false;
            this.KeyCubeRoot.Text = "3 root";
            this.KeyCubeRoot.Visible = false;
            this.KeyCubeRoot.Click += new System.EventHandler(this.KeyCubeRoot_Click);
            // 
            // KeyQuadEqua
            // 
            this.KeyQuadEqua.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyQuadEqua.ForeColor = System.Drawing.Color.Red;
            this.KeyQuadEqua.Location = new System.Drawing.Point(354, 620);
            this.KeyQuadEqua.Name = "KeyQuadEqua";
            this.KeyQuadEqua.Size = new System.Drawing.Size(154, 74);
            this.KeyQuadEqua.TabIndex = 29;
            this.KeyQuadEqua.TabStop = false;
            this.KeyQuadEqua.Text = "2 equa";
            this.KeyQuadEqua.Visible = false;
            this.KeyQuadEqua.Click += new System.EventHandler(this.KeyQuadEqua_Click);
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 708);
            this.Controls.Add(this.KeyQuadEqua);
            this.Controls.Add(this.KeyCubeRoot);
            this.Controls.Add(this.KeyFactorial);
            this.Controls.Add(this.KeyPow);
            this.Controls.Add(this.KeyReverse);
            this.Controls.Add(this.KeySqrt);
            this.Controls.Add(this.KeySqr);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void KeyPlus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eAdd);
		}

		protected void KeyMinus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eMultiply);
		}

		protected void KeyDivide_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eDivide);
		}

        private void KeySqr_Click(object sender, EventArgs e)
        {
            string ODText = OutputDisplay.Text;
            if (ODText == "") return;

            OutputDisplay.Text = Math.Pow(double.Parse(ODText), 2).ToString();
        }

        private void KeySqrt_Click(object sender, EventArgs e)
        {
            string ODText = OutputDisplay.Text;
            if (ODText == "") return;

            OutputDisplay.Text = Math.Sqrt(double.Parse(ODText)).ToString();
        }

        private void KeyReverse_Click(object sender, EventArgs e)
        {
            string ODText = OutputDisplay.Text;
            if (ODText == "") return;
            if (ODText == "0") MessageBox.Show("Íà 0 äåëèòü íåëüçÿ");

            double result = 1 / double.Parse(ODText);

            OutputDisplay.Text = result.ToString();
        }

        private void KeyPow_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePow);
        }

        private void KeyFactorial_Click(object sender, EventArgs e)
        {
            double number = double.Parse(OutputDisplay.Text);
            double result = 1;
            for (double i = number; i >= 1; i--)
            {
                result *= i;
            }
            OutputDisplay.Text = result.ToString();
        }

        private void KeyCubeRoot_Click(object sender, EventArgs e)
        {
            double number = double.Parse(OutputDisplay.Text);
            OutputDisplay.Text = Math.Pow(number, 1d/3).ToString();
        }

        private void KeyQuadEqua_Click(object sender, EventArgs e)
        {
            QuadEquation qe = new QuadEquation();
            qe.ShowDialog();
            if (qe.HasRoots == false) OutputDisplay.Text = "Óğàâíåíèå íå èìååò êîğíåé";
            else OutputDisplay.Text = "Êîğåíü 1 = " + Math.Round(qe.x1, 2).ToString() + ", êîğåíü 2 = " + Math.Round(qe.x2, 2).ToString();
        }

        //
        // Other non-numeric key click methods.
        //

        protected void KeySign_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcDecimal();
		}

		protected void KeyDate_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputDisplay.Text = "0";
		}

        //
        // Perform the calculation.
        //

        protected void KeyEqual_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (nineOut);
		}

		protected void KeyEight_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (eightOut);
		}

		protected void KeySeven_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sevenOut);
		}

		protected void KeySix_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sixOut);
		}

		protected void KeyFive_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fiveOut);
		}

		protected void KeyFour_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fourOut);
		}

		protected void KeyThree_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (threeOut);
		}

		protected void KeyTwo_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (twoOut);
		}

		protected void KeyOne_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (oneOut);
		}

		protected void KeyZero_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (zeroOut);
		}

		//
		// End the program.
		//

		protected void KeyExit_Click (object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
		}

        private void îÑîçäàòåëåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Øàìèí Âèêòîğ, 2022");
        }

        private void èçìåíèòüÖâåòÏîëÿÂûâîäàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            OutputDisplay.BackColor = colorDialog1.Color;
        }

        private void èçìåíèòüÖâåòÎêîíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            VersionInfo.BackColor = colorDialog1.Color;
        }

        private void èíæåíåğíûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyPow.Visible = true;
            KeySqr.Visible = true;
            KeySqrt.Visible = true;
            KeyReverse.Visible = true;
            KeyFactorial.Visible = true;
            KeyCubeRoot.Visible = true;
            KeyQuadEqua.Visible = true;
        }

        private void îáû÷íûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyPow.Visible = false;
            KeySqr.Visible = false;
            KeySqrt.Visible = false;
            KeyReverse.Visible = false;
            KeyFactorial.Visible = false;
            KeyCubeRoot.Visible = false;
            KeyQuadEqua.Visible = false;
        }
    }
}
