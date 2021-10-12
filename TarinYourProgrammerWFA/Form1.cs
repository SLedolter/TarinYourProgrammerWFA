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
    int suchzahl;

    public Form1() {
      InitializeComponent();

      suchzahl = ErzeugeZufallszahl(100);
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
      testeZahlen();
    }

    private int ErzeugeZufallszahl(int obergrenze) {
      return new Random().Next(1, obergrenze);
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e) {
      if(e.KeyCode == Keys.Enter) {
        testeZahlen();
      }
    }

    private void testeZahlen() {
      int testzahl;

      if(!int.TryParse(textBox1.Text, out testzahl) || testzahl > 100) {
        label1.Text = "Bitte nur positive ganze Zahlen zwischen 0 und 100 eingeben!";
        return;
      }

      if(suchzahl == testzahl) {
        label1.Text = "Du hast gewonnen!";
      } else if(suchzahl < testzahl) {
        label1.Text = "Die gesuchte Zahl ist kleiner!";
      } else if(suchzahl > testzahl) {
        label1.Text = "Die gesuchte Zahl ist größer!";
      }
    }

    private void button2_Click(object sender, EventArgs e) {
      label1.Text = $"Die alte Zahl war {suchzahl}. Such die Neue!";
      suchzahl = ErzeugeZufallszahl(100);
    }
  }
}