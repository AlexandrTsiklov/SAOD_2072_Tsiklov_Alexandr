using System;
using System.Collections.Generic;
using System.Windows.Forms;

// remove проходит 2 раза - пофиксить

namespace KILL_HashTable {
	public partial class Form1 : Form {

		private HashTable<string, int> hashTable;

		public Form1() {
			InitializeComponent();
			hashTable = new HashTable<string, int>();
		}

		private void button1_Click(object sender, EventArgs e) {
			try {
				string key = textBox1.Text;
				int value = Int32.Parse(textBox2.Text);
				hashTable.add(key, value);
				printListBox();
			} catch {
				MessageBox.Show("Wrong input!");
			}
		}
		
		private void button2_Click(object sender, EventArgs e) {

			string key = textBox3.Text;
			
			try {
				int value = hashTable.find(key);
				label5.Text = value.ToString();
			} 
			catch (KeyDoesNotExistException ex) {
				label5.Text = ex.Message;
			}
		}
	
		private void button3_Click(object sender, EventArgs e) {
			string key = textBox4.Text;
			
			try {
				hashTable.remove(key);
				printListBox();
			}
			catch (KeyDoesNotExistException ex) {
				label6.Text = ex.Message;
			}
		}

		private void button4_Click(object sender, EventArgs e) {
			label7.Text = hashTable.Count.ToString();
		}

		private void button5_Click(object sender, EventArgs e) {
			Dictionary<string, int> generatedData = generateStringKeyIntValue(20);
			foreach(KeyValuePair<string, int> entry in generatedData) {
				hashTable.add(entry.Key, entry.Value);
			}
			printListBox();
		}

		public Dictionary<string, int> generateStringKeyIntValue(int initialCount) {
			Dictionary<string, int> generatedData = new Dictionary<string, int>();
			char[] letters = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
			Random rand = new Random();

			for(int i = 0; i < initialCount; i++) {
				int randomValue = rand.Next(0, 1000);
				string randomKey = "";
				
				for (int j = 1; j <= 5; j++) {
					int letter_num = rand.Next(0, letters.Length - 1);
					randomKey += letters[letter_num];
				}
				generatedData.Add(randomKey, randomValue);
			}
			return generatedData;
		}

		private void printListBox() {
			listBox1.Items.Clear();
			listBox2.Items.Clear();

            if(hashTable.Count != 0) {
                foreach(var value in hashTable.toList()) {
                    listBox1.Items.Add(value);
                }
            }

			foreach(var indexList in hashTable) {
				listBox2.Items.Add(indexList);
			}
		}

	}
}
