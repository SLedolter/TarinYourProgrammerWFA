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
    private long numberDigit;
    private string workingDigit;

    public Form1() {
      InitializeComponent();

    }

    private void button1_Click(object sender, EventArgs e) {
      lbl_err_msg.Text = "";
      if(!long.TryParse(inp_zahl.Text, out numberDigit) || numberDigit <= 0) {
        lbl_err_msg.Text = "Bitte positive ganze Zahl eingeben!";
      }

      lbl_output.Text = CalculateMultipleNumberSeries(inp_zahl.Text, 15);
    }

    private string CalculateSingleNumberSeries(string inputDigit) {
      string result = "";
      char lastDigit;
      int sameDigitCount = 1;

      lastDigit = inputDigit[0];
      for(int i = 1; i < inputDigit.Length; i++) {
        if(lastDigit == inputDigit[i]) {
          sameDigitCount++;
        } else {
          result += $"{sameDigitCount}{lastDigit}";
          sameDigitCount = 1;
          lastDigit = inputDigit[i];
        }
      }
      result += $"{sameDigitCount}{lastDigit}";

      return result;
    }

    private string CalculateMultipleNumberSeries(string input, int repetitions) {
      string singleResult, singleInput, completeResult = "";

      singleInput = input;
      for(int i = 0; i < repetitions; i++) {
        singleResult = CalculateSingleNumberSeries(singleInput);
        completeResult += singleResult+"\n";
        singleInput = singleResult;
      }

      return completeResult;
    }
  }
}