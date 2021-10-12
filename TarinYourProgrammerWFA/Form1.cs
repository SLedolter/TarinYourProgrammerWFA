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
    List<string> init_list_left, init_list_right;
    public Form1() {
      InitializeComponent();

      init_list_left = new List<string>() { "Left1", "Left2", "Left3", "Left4", "Left5" };
      init_list_right = new List<string>() { "Right1", "Right2", "Right3", "Right4", "Right5" };
      btn_move_to_left.Enabled = lbox_right.SelectedIndex != -1;
      btn_move_to_right.Enabled = lbox_left.SelectedIndex != -1;
      lbox_left.SelectionMode = SelectionMode.MultiExtended;
      lbox_right.SelectionMode = SelectionMode.MultiExtended;
    }

    private void lbox_left_SelectedIndexChanged(object sender, EventArgs e) {
      btn_move_to_right.Enabled = lbox_left.SelectedIndex != -1;
    }

    private void lbox_right_SelectedIndexChanged(object sender, EventArgs e) {
      btn_move_to_left.Enabled = lbox_right.SelectedIndex != -1;
    }

    private void btn_move_to_left_Click(object sender, EventArgs e) {
      while(lbox_right.SelectedIndices.Count > 0) {
        lbox_left.Items.Add(lbox_right.Items[lbox_right.SelectedIndices[0]]);
        lbox_right.Items.RemoveAt(lbox_right.SelectedIndices[0]);
      }
    }

    private void btn_move_to_right_Click(object sender, EventArgs e) {
      while(lbox_left.SelectedIndices.Count > 0) {
        lbox_right.Items.Add(lbox_left.Items[lbox_left.SelectedIndices[0]]);
        lbox_left.Items.RemoveAt(lbox_left.SelectedIndices[0]);
      }
    }

    private void Form1_Load(object sender, EventArgs e) {
      lbox_left.Items.AddRange(init_list_left.ToArray());
      lbox_right.Items.AddRange(init_list_right.ToArray());
    }
  }
}
