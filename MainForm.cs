/*
 * Created by SharpDevelop.
 * User: azuev
 * Date: 27.09.2019
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace timer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private long start;
		private Int32 d;
		Int64 pbmax;
		Int64 sek = 0;
		String time, h, m;
		Timer timer = new Timer();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			//public int d;
			InitializeComponent();
				label1.Text = DateTime.Now.ToString("HH:mm:ss");
				progressBar1.Minimum = 0;
				progressBar1.Value = 0;
				SysTime();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void SysTime ()
		{
			timer.Interval = 1000;			
			timer.Tick += new EventHandler(run);
			timer.Enabled = true;
		}
		void run (object Sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString("HH:mm:ss");
			time = Convert.ToString(d/3600)+" : "+Convert.ToString(d/60 - ((d/3600)*60))+" : "+Convert.ToString(sek);
			label4.Text = time;
			if (start == 99)
			{
				d = d-1;
				if(sek == 0)
				{
					sek=60;
				}
				sek--;
				if(progressBar1.Value == pbmax)
				{
					progressBar1.Value = 0;
				}
				else
				{
					progressBar1.Value ++;
				}
				if(d==0)
				{
					start = 0;
					System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 00");
					System.Diagnostics.Process.Start("cmd", "/c %windir%\\System32\\shutdown.exe -s -f -t 00");
				}
			}
		}
		
		void Button1Click(object sender, System.EventArgs e)
		{		
			if(string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
			{
			MessageBox.Show("Выберите необходимое количество минут");
			}
			else{
			h = comboBox1.SelectedItem.ToString();
			m = comboBox2.SelectedItem.ToString();
			start = 99;
			d = Convert.ToInt32(h);
			d = d*60;
			d = d*60;
			d+= Convert.ToInt32(m)*60;
			progressBar1.Maximum = d;
			pbmax = d;				
			}
		}
		void Button3Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Email: zuevandrey1979@gmail.com "+" (R)2019");
		}
		void Button2Click(object sender, System.EventArgs e)
		{
			start = 0;
			d = 0;
			comboBox1.ResetText();
			comboBox2.ResetText();
			label4.Text = "0:0:0";
			progressBar1.Value = 0;
			sek = 0;
		}
	}
}
