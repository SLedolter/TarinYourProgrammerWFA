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

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);
      source_array = FillArray(50);
      OutputIntArrayToLabel(source_array, "lbl_array_in");
    }

    private void btn_min_max_Click(object sender, EventArgs e) {
      int[] result_min_max_array, out_array;

      out_array = SortIntegerArray1(source_array);
      OutputIntArrayToLabel(out_array, "lbl_array_out");
      lbl_min_max.Text = $"{out_array[0]}/{out_array[out_array.Length-1]}";
    }

    private int[] SortIntegerArray1(int[] in_array) {
      int[] result_array = (int[])in_array.Clone();
      int tempNumber, count = 0;

      for(int i = 0; i < result_array.Length - 1; i++) {
        if(result_array[i] <= result_array[i + 1]) {
          continue;
        } else {
          for(int j = 1; j < result_array.Length; j++) {
            if(result_array[j - 1] > result_array[j]) {
              tempNumber = result_array[j - 1];
              result_array[j - 1] = result_array[j];
              result_array[j] = tempNumber;
              i = 0;
              count++;
              break;
            }
          }
        }
      }

      lbl_count.Text = count.ToString();
      return result_array;
    }

    private void OutputIntArrayToLabel(int[] array_in, string label_name) {
      Label output_label = (Label)this.Controls.Find(label_name, true)[0];
      string output_text = "[";

      for(int i = 0; i < array_in.Length; i++) {
        output_text += array_in[i];
        if(i < array_in.Length - 1) {
          output_text += ",";
        }
      }

      output_text += "]";

      output_label.Text = output_text;
    }

    private int[] FillArray(int length) {
      int[] resultArray = new int[length];
      Random random = new Random();

      for(int i=0; i<length; i++) {
        resultArray[i] = random.Next(1, 1001);
      }

      return resultArray;
    }

    private void btn_refill_Click(object sender, EventArgs e) {
      source_array = FillArray(50);
      OutputIntArrayToLabel(source_array, "lbl_array_in");
    }
  }
}