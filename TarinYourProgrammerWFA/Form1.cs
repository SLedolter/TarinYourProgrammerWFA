using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarinYourProgrammerWFA {
  public partial class Form1 : Form {
    List<string> listBoxContent;
    public Form1() {
      InitializeComponent();
      button2.Enabled = false;

      listBoxContent = new List<string>() { "One", "Too", "Sree", "For", "Fejv", "Sicks", "Sven" };
    }

    private void Form1_Load(object sender, EventArgs e) {
      listBox1.Items.AddRange(listBoxContent.ToArray());
      button1.Enabled = false;
    }

    private void button1_Click(object sender, EventArgs e) {
      if(listBox1.SelectedIndex > -1) {
        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
      }
      if(listBox1.Items.Count == 0) {
        button1.Enabled = false;
        button2.Enabled = true;
      }
    }

    private void button2_Click(object sender, EventArgs e) {
      listBox1.Items.AddRange(listBoxContent.ToArray());
      button2.Enabled = false; 
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
      if(listBox1.SelectedIndex == -1) {
        button1.Enabled = false;
      }else {
        button1.Enabled = true;
      }
    }
  }
}
