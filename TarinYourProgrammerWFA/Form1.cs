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
    List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, intListNew;
    List<string> stringList = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" }, stringListNew;
    public Form1() {
      InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e) {
      ShowListToLabel<int>(intList, "label1");
      ShowListToLabel<string>(stringList, "label2");
      RandomizeAndShowLists();
    }

    private void RandomizeAndShowLists() {
      intListNew = RearrangeListItemsRandom<int>(intList);
      stringListNew = RearrangeListItemsRandom<string>(stringList);
      ShowListToLabel<int>(intListNew, "label3");
      ShowListToLabel<string>(stringListNew, "label4");
    }

    private void button1_Click(object sender, EventArgs e) {
      RandomizeAndShowLists();
    }

    void ShowListToLabel<T>(List<T> sourceList, string labelName) {
      Label tempLabel = (Label)this.Controls.Find(labelName, true)[0];

      tempLabel.Text = $"{labelName}: ";
      for(int cnt = 0; cnt < sourceList.Count; cnt++) {
        tempLabel.Text += sourceList[cnt];
        if(cnt < sourceList.Count - 1) {
          tempLabel.Text += ",";
        }
      }
    }

    List<T> RearrangeListItemsRandom<T>(List<T> sourceList) {
      Random random = new Random();
      int randomNumber;
      List<T> 
        resultList = new List<T>(), 
        tempList = new List<T>(sourceList);

      while(tempList.Count > 0) {
        randomNumber = random.Next(tempList.Count);
        resultList.Add(tempList[randomNumber]);
        tempList.RemoveAt(randomNumber);
      }

      return resultList;
    }
  }
}
