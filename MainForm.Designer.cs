/*
 * Created by SharpDevelop.
 * User: azuev
 * Date: 27.09.2019
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace timer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.часов = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(242, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Старт";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10",
			"11",
			"12",
			"13",
			"14",
			"15",
			"16",
			"17",
			"18",
			"19",
			"20",
			"21",
			"22",
			"23"});
			this.comboBox1.Location = new System.Drawing.Point(12, 41);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(40, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndex = 0;
			// 
			// часов
			// 
			this.часов.Location = new System.Drawing.Point(58, 41);
			this.часов.Name = "часов";
			this.часов.Size = new System.Drawing.Size(39, 23);
			this.часов.TabIndex = 3;
			this.часов.Text = "часов";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"01",
			"10",
			"15",
			"20",
			"25",
			"30",
			"35",
			"40",
			"45",
			"50",
			"55"});
			this.comboBox2.Location = new System.Drawing.Point(103, 41);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(42, 21);
			this.comboBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(151, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "минут";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 96);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(305, 16);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(242, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Стоп";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(242, 70);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "About";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Выключаемся через -  ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(151, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Остаток";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 119);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.часов);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Таймер выключения";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label часов;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
