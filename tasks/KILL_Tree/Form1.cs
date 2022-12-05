using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace KILL_Tree {
    public partial class Form1 : Form {

        private TreePrototypeT<int> treePrototypeT;
        private string errorMessage = "Incorrect input data. Use number format";

        public Form1() {
            InitializeComponent();
            treePrototypeT = new TreePrototypeT<int>();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                int value = Int32.Parse(textBox1.Text);
                treePrototypeT.insert(value);
                label3.Text = "Success";
                printListBox();
            } catch(FormatException _) { label3.Text = errorMessage; }
        }
        private void button2_Click(object sender, EventArgs e) {
            try {
                int value = Int32.Parse(textBox2.Text);
                label1.Text =  (treePrototypeT.contains(value)).ToString();
                printListBox();
            } catch(FormatException _) { label1.Text = errorMessage; }
        }
        private void button3_Click(object sender, EventArgs e) {
            try {
                int value = Int32.Parse(textBox3.Text);
                label2.Text = (treePrototypeT.remove(value)).ToString();
                printListBox();
            } catch(FormatException _) { label2.Text = errorMessage; }
        }

        private void button4_Click(object sender, EventArgs e) {
            label4.Text = treePrototypeT.Count.ToString();
        }

        private void printListBox() {
            lnr.Items.Clear(); 
            nrl.Items.Clear();
            rnl.Items.Clear();
            wide.Items.Clear();

            foreach(var value in treePrototypeT) { lnr.Items.Add(value.ToString());}
            foreach(var value in treePrototypeT.NRL()) { nrl.Items.Add(value.ToString());}
            foreach(var value in treePrototypeT.RNL()) { rnl.Items.Add(value.ToString());}

            Dictionary<int, List<int>> levels = treePrototypeT.WIDE();
            foreach(var level in levels) {
                string outputString = "";
                foreach(int value in level.Value) { 
                    outputString += value.ToString() + " ";
                }
                wide.Items.Add("Level " + level.Key.ToString() + ":          "+ outputString.ToString());
                wide.Items.Add("----------------------------------------------------------------------");
            }
        }

    }
}
