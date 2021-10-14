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
    List<int> intListe = new List<int>() { 1, 2, 3, 4, 5, 6 }, intListNew;
    List<string> stringListe = new List<string>() { "a", "b", "c", "d", "e", "f" }, stringListNew;
    public Form1() {
      InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e) {
      ShowListToLabel<int>(intListe, "label1");
      ShowListToLabel<string>(stringListe, "label2");
      intListNew = RearrangeListItemsRandom<int>(intListe);
      stringListNew = RearrangeListItemsRandom<string>(stringListe);
      ShowListToLabel<int>(intListNew, "label3");
    }

    List<T> RandaomizeItemOrderInList<T>(List<T> sourceList) {
      List<T> resultList = new List<T>();

      return resultList;
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
      List<T> resultList = new List<T>();
      int[]
        randomizedIndex = new int[sourceList.Count],
        newIndex = new int[sourceList.Count];
      int randomNumber;

      for(int i = 0; i < sourceList.Count; i++) {
        randomizedIndex[i] = i;
      }
      
      for(int i = 0; i < newIndex.Length; i++) {
        randomNumber = random.Next(randomizedIndex.Length);
        newIndex[i] = randomizedIndex[randomNumber];
        randomizedIndex = randomizedIndex.Where(val => val != randomNumber).ToArray();
      }

      return resultList;
    }
  }
}
