using System;
using System.Windows.Forms;


namespace SAOD_MAKING_STECK {
    public partial class Form1 : Form {

        private Stack<String> stack;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (stack == null) {
                try { stack = new Stack<String>(Int32.Parse(textBox2.Text)); } 
                catch { stack = new Stack<String>(10); }
            }

            try {
                stack.push(textBox1.Text);
                label3.Text = "Successfully!";
                printListBox();
            } catch {
                label3.Text = "Can't push, stack is overflow!";
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                label1.Text = stack.pop().ToString();
                printListBox();
            } catch {
                label1.Text = "Can't pop, stack is empty!";
            };
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                label2.Text = stack.top().ToString();
                printListBox();
            } catch {
                label2.Text = "Can't top, stack is empty!";
            };
        }

        private void printListBox() {

            listBox1.Items.Clear();

            for (int i = 0; i < stack.getCurrent(); i++) {
                String[] array = stack.toArray();
                listBox1.Items.Add(array[i]);
            }
        }
    }
}
