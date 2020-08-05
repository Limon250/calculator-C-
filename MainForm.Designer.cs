/*
 * Coded by Limon250
 * User: Limon250
 * Date: 04.08.2020 - 05.08.2020
 * Time: 23:56 - undefined
 */
namespace Weather
{
	public partial class Calculator
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button19;
		
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
			this.Button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button15 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button16 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Button1
			// 
			this.Button1.BackColor = System.Drawing.Color.Transparent;
			this.Button1.Location = new System.Drawing.Point(12, 104);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(80, 42);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "1";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(354, 44);
			this.label1.TabIndex = 1;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(184, 152);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(80, 42);
			this.button6.TabIndex = 6;
			this.button6.Text = "6";
			this.button6.UseCompatibleTextRendering = true;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(98, 152);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(80, 42);
			this.button5.TabIndex = 5;
			this.button5.Text = "5";
			this.button5.UseCompatibleTextRendering = true;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(13, 152);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 42);
			this.button4.TabIndex = 4;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(184, 200);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(80, 42);
			this.button9.TabIndex = 9;
			this.button9.Text = "9";
			this.button9.UseCompatibleTextRendering = true;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(99, 200);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(80, 42);
			this.button8.TabIndex = 8;
			this.button8.Text = "8";
			this.button8.UseCompatibleTextRendering = true;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(13, 200);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(80, 42);
			this.button7.TabIndex = 7;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(270, 104);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(47, 42);
			this.button13.TabIndex = 15;
			this.button13.Text = "/";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(270, 56);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(47, 42);
			this.button12.TabIndex = 17;
			this.button12.Text = "*";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12CLick);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(270, 152);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(47, 42);
			this.button11.TabIndex = 19;
			this.button11.Text = "-";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11ClicK);
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(12, 56);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(80, 42);
			this.button18.TabIndex = 10;
			this.button18.Text = "←";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.Button18Click);
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(98, 56);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(80, 42);
			this.button20.TabIndex = 12;
			this.button20.Text = "C";
			this.button20.UseVisualStyleBackColor = true;
			this.button20.Click += new System.EventHandler(this.Button20Click);
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(323, 152);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(47, 90);
			this.button17.TabIndex = 18;
			this.button17.Text = "=";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(98, 248);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(80, 42);
			this.button10.TabIndex = 24;
			this.button10.Text = ",";
			this.button10.UseCompatibleTextRendering = true;
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button0
			// 
			this.button0.Location = new System.Drawing.Point(12, 248);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(80, 42);
			this.button0.TabIndex = 0;
			this.button0.Text = "0";
			this.button0.UseCompatibleTextRendering = true;
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.Button0Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.textBox1.Location = new System.Drawing.Point(184, 248);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(186, 42);
			this.textBox1.TabIndex = 25;
			this.textBox1.Text = "Designed by Limon250";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(184, 56);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(80, 42);
			this.button15.TabIndex = 14;
			this.button15.Text = "√";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(270, 200);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(47, 42);
			this.button14.TabIndex = 13;
			this.button14.Text = "+";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.Button14Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(98, 104);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 42);
			this.button2.TabIndex = 2;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(184, 104);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 42);
			this.button3.TabIndex = 3;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(13, 23);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(353, 27);
			this.textBox2.TabIndex = 26;
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(323, 56);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(47, 42);
			this.button16.TabIndex = 28;
			this.button16.Text = "sin";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.Button16Click);
			// 
			// button19
			// 
			this.button19.Location = new System.Drawing.Point(323, 104);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(47, 42);
			this.button19.TabIndex = 27;
			this.button19.Text = "cos";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.Button19Click);
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(378, 295);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Button1);
			this.Name = "Calculator";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
