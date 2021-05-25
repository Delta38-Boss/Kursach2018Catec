namespace Player
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
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.colorSlider1 = new MB.Controls.ColorSlider();
			this.colorSlider2 = new MB.Controls.ColorSlider();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.плToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(108, 223);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 36);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(256, 108);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 223);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "<<";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(195, 223);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = ">>";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// colorSlider1
			// 
			this.colorSlider1.BackColor = System.Drawing.Color.Transparent;
			this.colorSlider1.BarInnerColor = System.Drawing.Color.GhostWhite;
			this.colorSlider1.BarOuterColor = System.Drawing.Color.Azure;
			this.colorSlider1.BarPenColor = System.Drawing.Color.SkyBlue;
			this.colorSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
			this.colorSlider1.ElapsedInnerColor = System.Drawing.Color.Navy;
			this.colorSlider1.ElapsedOuterColor = System.Drawing.Color.Blue;
			this.colorSlider1.LargeChange = ((uint)(5u));
			this.colorSlider1.Location = new System.Drawing.Point(21, 192);
			this.colorSlider1.Name = "colorSlider1";
			this.colorSlider1.Size = new System.Drawing.Size(247, 25);
			this.colorSlider1.SmallChange = ((uint)(1u));
			this.colorSlider1.TabIndex = 4;
			this.colorSlider1.Text = "colorSlider1";
			this.colorSlider1.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
			this.colorSlider1.Value = 0;
			this.colorSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider1_Scroll);
			// 
			// colorSlider2
			// 
			this.colorSlider2.BackColor = System.Drawing.Color.Transparent;
			this.colorSlider2.BorderRoundRectSize = new System.Drawing.Size(8, 8);
			this.colorSlider2.LargeChange = ((uint)(5u));
			this.colorSlider2.Location = new System.Drawing.Point(204, 258);
			this.colorSlider2.Name = "colorSlider2";
			this.colorSlider2.Size = new System.Drawing.Size(64, 23);
			this.colorSlider2.SmallChange = ((uint)(1u));
			this.colorSlider2.TabIndex = 5;
			this.colorSlider2.Text = "colorSlider2";
			this.colorSlider2.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
			this.colorSlider2.Value = 1;
			this.colorSlider2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider2_Scroll);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 258);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "Set";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "0:00:00";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(225, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "0:00:00";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.плToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(280, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// плToolStripMenuItem
			// 
			this.плToolStripMenuItem.Name = "плToolStripMenuItem";
			this.плToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.плToolStripMenuItem.Text = "Плэйлисты";
			this.плToolStripMenuItem.Click += new System.EventHandler(this.плToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 293);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.colorSlider2);
			this.Controls.Add(this.colorSlider1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Player";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private MB.Controls.ColorSlider colorSlider1;
		private MB.Controls.ColorSlider colorSlider2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem плToolStripMenuItem;
		public System.Windows.Forms.ListBox listBox1;
	}
}

