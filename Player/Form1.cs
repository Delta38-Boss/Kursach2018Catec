using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Player
{
	public partial class Form1 : Form
	{

		Playlist playlist = new Playlist();
		bool StrStp = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try {
				if (StrStp == false)
				{
					if ((listBox1.Items.Count != 0) && (listBox1.Items.Count != -1))
					{
						string current = Player.cs.Vars.files[listBox1.SelectedIndex];
						Player.cs.BassLike.Play(current, Player.cs.BassLike.voulme);
						label1.Text = TimeSpan.FromSeconds(Player.cs.BassLike.GetPosOfStream(Player.cs.BassLike.Stream)).ToString();
						label2.Text = TimeSpan.FromSeconds(Player.cs.BassLike.GetTimeOfStream(Player.cs.BassLike.Stream)).ToString();
						colorSlider1.Maximum = Player.cs.BassLike.GetTimeOfStream(Player.cs.BassLike.Stream);
						colorSlider1.Value = Player.cs.BassLike.GetPosOfStream(Player.cs.BassLike.Stream);
						timer1.Enabled = true;
						timer1.Start();
						button1.Text = "Pause";
						StrStp = true;
					}
				}

				else
				{
					Player.cs.BassLike.Pause();
					timer1.Stop();
					StrStp = false;
					button1.Text = "Play";
				}
			
			}
			catch
		{
				MessageBox.Show("Не выбран файл для прослушивания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
			

		

		private void button4_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

			Player.cs.Vars.files.Add(openFileDialog1.FileName);
			listBox1.Items.Add(Player.cs.Vars.GetFileName(openFileDialog1.FileName));
				
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = TimeSpan.FromSeconds(Player.cs.BassLike.GetPosOfStream(Player.cs.BassLike.Stream)).ToString();
			colorSlider1.Value = Player.cs.BassLike.GetPosOfStream(Player.cs.BassLike.Stream);
			if (colorSlider1.Value == colorSlider1.Maximum)
			{
				string current;
				try
				{

					listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
					current = Player.cs.Vars.files[listBox1.SelectedIndex];

				}
				catch
				{
					listBox1.SelectedIndex = 0;
					current = Player.cs.Vars.files[listBox1.SelectedIndex];
				}
			}
		}

		private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
		{
			Player.cs.BassLike.SetPosOfScroll(Player.cs.BassLike.Stream, colorSlider1.Value);
		}

		private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
		{
			Player.cs.BassLike.SetVoulmeToStream(Player.cs.BassLike.Stream, colorSlider2.Value);
		}

		private void плToolStripMenuItem_Click(object sender, EventArgs e)
		{
			playlist.Show();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Player.cs.BassLike.Stop();
				timer1.Enabled = false;
				string current = Player.cs.Vars.files[listBox1.SelectedIndex];
				Console.WriteLine(current);
				Player.cs.BassLike.PlayNew(current, Player.cs.BassLike.voulme);
				label1.Text = TimeSpan.FromSeconds(Player.cs.BassLike.GetPosOfStream(Player.cs.BassLike.Stream)).ToString();
				label2.Text = TimeSpan.FromSeconds(Player.cs.BassLike.GetTimeOfStream(Player.cs.BassLike.Stream)).ToString();
				colorSlider1.Maximum = Player.cs.BassLike.GetTimeOfStream(Player.cs.BassLike.Stream);
				colorSlider1.Value = Player.cs.BassLike.GetPosOfStream(Player.cs.BassLike.Stream);
				timer1.Enabled = true;
				timer1.Start();
				button1.Text = "Pause";
				StrStp = true;
			}
			catch
			{
				//MessageBox.Show("Ошибка: Это предел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string current;
			try
			{
				 
				listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
				current = Player.cs.Vars.files[listBox1.SelectedIndex];
				
			}
			catch
			{
				listBox1.SelectedIndex = 0;
				current = Player.cs.Vars.files[listBox1.SelectedIndex];
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string current;
			try
			{
				listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
				current = Player.cs.Vars.files[listBox1.SelectedIndex];


			}

			catch
			{
				listBox1.SelectedIndex = listBox1.Items.Count - 1;
				current = Player.cs.Vars.files[listBox1.SelectedIndex];
			}

			}
	}
}
