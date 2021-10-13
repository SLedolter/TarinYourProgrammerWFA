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
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '-' && textBox1.SelectionStart == 0) && !(e.KeyChar == '+' && textBox1.SelectionStart == 0)) {
        e.Handled = true;
      }
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e) {
      int testVarInt32;
      Int64 testVar;
      switch(e.KeyCode) {
        case Keys.Enter:
          if(textBox1.Text == "") {
            MessageBox.Show("Gib was ein!");
          } else {
            if(int.TryParse(textBox1.Text, out testVarInt32)) {
              MessageBox.Show($"Die Zahl ist {textBox1.Text}!");
            } else {
              if(Int64.TryParse(textBox1.Text, out testVar)) {
                MessageBox.Show($"Parsen fehlgeschlagen! Zu hoher Wertebereich!");
              } else {
                MessageBox.Show($"Diese Zahl ist weiter over 9000!");
              }
            }
          }
          break;
      }
    }
  }
}
