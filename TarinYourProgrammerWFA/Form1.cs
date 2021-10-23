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
    int[] source_array;
    int count = 0;

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);
      source_array = FillArray(50);
      SortIntegerArray();
      OutputIntArrayToLabel("lbl_array_in");
    }

    private void Btn_min_max_Click(object sender, EventArgs e) {
      OutputIntArrayToLabel("lbl_array_out");
      lbl_min_max.Text = $"{source_array[0]} / {source_array[source_array.Length - 1]}";
    }

    private void SortIntegerArray() {
      int jumpindex;
      count = 0;
      for(int i = 0; i < source_array.GetLength(0) - 1; i++)
      {
        jumpindex = i;
        while(source_array[i] > source_array[i + 1])
        {
          int _ = source_array[i];
          source_array[i] = source_array[i+1];
          source_array[i+1] = _;
          count++;
          if(i == 0)
					{
            break;
					}
          else
					{
            i--;
					}
        }
        i = jumpindex;
      }
      lbl_count.Text = count.ToString();
    }
    private void OutputIntArrayToLabel(string label_name) {
      Label output_label = (Label)this.Controls.Find(label_name, true)[0];
      string output_text = "[";

      for(int i = 0; i < source_array.GetLength(0); i++) {
        output_text += source_array[i];
        if(i < source_array.GetLength(0)) {
          output_text += ",";
        }
      }

      output_text += "]";

      output_label.Text = output_text;
    }

    private int[] FillArray(int length) {
      source_array = new int[length];
      Random random = new Random();

      for(int i=0; i<source_array.GetLength(0); i++) {
        source_array[i] = random.Next(1, 1001);
      }
      return source_array;
    }

    private void Btn_refill_Click(object sender, EventArgs e) {
      source_array = FillArray(50);
      SortIntegerArray();
      OutputIntArrayToLabel("lbl_array_in");
    }
  }
}