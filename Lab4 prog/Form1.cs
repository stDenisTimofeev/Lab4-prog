using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_prog
{
    public partial class Form1 : Form
    {
        private IController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller();

            Model dataModel = new Model();
            controller.Model = dataModel;

            IView richTextBoxView = new RichTextBoxView();
            controller.AddView(richTextBoxView);
            richTextBoxView.Model = dataModel;
        }

        private void Add(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                controller.Add(textBox1.Text, GetCheckedColor());
        }

        private void RemoveByColor(object sender, EventArgs e)
        {
            controller.Remove(GetCheckedColor());
        }

        private void FindAndChangeTheColor(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                controller.Change(textBox1.Text, GetCheckedColor());
        }

        private Color GetCheckedColor()
        {
            Color checkedColor;
            if (красныйToolStripMenuItem.Checked)
                checkedColor = Color.Red;
            else if (синийToolStripMenuItem.Checked)
                checkedColor = Color.Blue;
            else if (зелёныйToolStripMenuItem.Checked)
                checkedColor = Color.Green;
            else if (жёлтыйToolStripMenuItem.Checked)
                checkedColor = Color.Yellow;
            else if (чёрныйToolStripMenuItem.Checked)
                checkedColor = Color.Black;
            else
                checkedColor = Color.Pink;

            return checkedColor;
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            красныйToolStripMenuItem.Checked = (sender == красныйToolStripMenuItem);
            синийToolStripMenuItem.Checked = (sender == синийToolStripMenuItem);
            зелёныйToolStripMenuItem.Checked = (sender == зелёныйToolStripMenuItem);
            жёлтыйToolStripMenuItem.Checked = (sender == жёлтыйToolStripMenuItem);
            чёрныйToolStripMenuItem.Checked = (sender == чёрныйToolStripMenuItem);

            красныйToolStripMenuItem.CheckState = (sender == красныйToolStripMenuItem) ? CheckState.Checked : CheckState.Unchecked;
            синийToolStripMenuItem.CheckState = (sender == синийToolStripMenuItem) ? CheckState.Checked : CheckState.Unchecked;
            зелёныйToolStripMenuItem.CheckState = (sender == зелёныйToolStripMenuItem) ? CheckState.Checked : CheckState.Unchecked;
            жёлтыйToolStripMenuItem.CheckState = (sender == жёлтыйToolStripMenuItem) ? CheckState.Checked : CheckState.Unchecked;
            чёрныйToolStripMenuItem.CheckState = (sender == чёрныйToolStripMenuItem) ? CheckState.Checked : CheckState.Unchecked;
        }

        
    }
}
