﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManagerApplication
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void About_Load(object sender, EventArgs e)
		{
			string firstLine = richTextBox.Lines[0];
			int index1 = richTextBox.Text.IndexOf(firstLine);
			int length = firstLine.Length;
			richTextBox.Select(index1, length);
			richTextBox.SelectionColor = Color.White;
			richTextBox.SelectionFont = new Font("Sergoe UI", 20);

			string secondLine = richTextBox.Lines[2];
			int index2 = richTextBox.Text.IndexOf(secondLine);
			int secondLength = secondLine.Length;
			richTextBox.Select(index2, secondLength);
;
			int authorIndex = richTextBox.Text.IndexOf("Garrett Crook");
			int authorLength = 13;
			richTextBox.Select(authorIndex, authorLength);
			richTextBox.SelectionFont = new Font("Sergoe UI", 14, FontStyle.Bold);
		}
	}
}
