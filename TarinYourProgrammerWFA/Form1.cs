using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TarinYourProgrammerWFA {
  public partial class Form1 : Form {
    List<int> userNumbers = new List<int>();
    Random random = new Random();

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);


    }

    private void bnt_choose_numbers_Click(object sender, EventArgs e) {
      int parsedInt;
      string userInput;
      Prompt prompt = new Prompt("Zahl zwischen 1 und 45 eingeben: ", "Wähl dein Glück!");

      userNumbers.Clear();

      while(userNumbers.Count < 6) {
        userInput = prompt.ShowDialog();
        if(userInput == null) {
          userNumbers.Clear();
          PrintNumbers();
          return;
        }
        if(!int.TryParse(userInput, out parsedInt)) {
          MessageBox.Show("Bitte Zahl eingeben!");
          continue;
        } else if(parsedInt <= 0 || parsedInt > 45) {
          MessageBox.Show("Zahl außerhalb des erlaubten Bereichs!");
          continue;
        } else if(userNumbers.Contains(parsedInt)) {
          MessageBox.Show("Die Zahl wurde schon gewählt!");
          continue;
        }

        userNumbers.Add(parsedInt);
        userNumbers.Sort();
        PrintNumbers();
      }
    }

    private void PrintNumbers() {
      lbl_chosen_numbers.Text = "";
      for(int i = 0; i < userNumbers.Count; i++) {
        lbl_chosen_numbers.Text += userNumbers[i];
        if(i < userNumbers.Count - 1) {
          lbl_chosen_numbers.Text += "/";
        }
      }
    }

    private void label3_Click(object sender, EventArgs e) {

    }

    private void btn_start_Click(object sender, EventArgs e) {
      if(userNumbers.Count != 6) {
        MessageBox.Show("Bitte Zahlen wählen, um Glück zu produzieren!");
        return;
      }

      List<int> randomNumbers = new List<int>();
      bool strike = false;
      int sameNumbers = 0;
      long strikeTriesCount = 0, threeHitsCount = 0, fourHitsCount = 0, fiveHitsCount = 0;
      double threeHitsChance, fourHitsChance, fiveHitsChance;

      while(!strike) {
        randomNumbers = GenerateRandomNumbers();

        if(randomNumbers.SequenceEqual(userNumbers)) {
          strike = true;
        }

        //userNumbers = fillTestNumbers1();
        //randomNumbers = fillTestNumbers2();

        sameNumbers = CheckHitCount(userNumbers, randomNumbers);

        switch(sameNumbers) {
          case 6:
            strike = true;
            break;
          case 5:
            fiveHitsCount++;
            break;
          case 4:
            fourHitsCount++;
            break;
          case 3:
            threeHitsCount++;
            break;
          default:
            break;
        }
        strikeTriesCount++;

        fiveHitsChance = (float)fiveHitsCount / (float)strikeTriesCount * 100f;
        fourHitsChance = (float)fourHitsCount / (float)strikeTriesCount * 100f;
        threeHitsChance = (float)threeHitsCount / (float)strikeTriesCount * 100f;

        lbl_count_tries.Text = 
          $"Azahl der Versuche: {strikeTriesCount}\n" +
          $"Fünfer: {fiveHitsCount} / Chance: {fiveHitsChance.ToString("n3")}%\n" +
          $"Vierer: {fourHitsCount} / Chance: {fourHitsChance.ToString("n2")}%\n" +
          $"Dreier: {threeHitsCount} / Chance: {threeHitsChance.ToString("n2")}%";

        if(strike) {
          lbl_count_tries.Text = "STRIKE! " + lbl_count_tries.Text;
        }

        if(strikeTriesCount % 100 == 0) {
          lbl_count_tries.Refresh();
        }
        randomNumbers.Clear();
      }
    }

    private List<int> GenerateRandomNumbers() {
      List<int> resultNumbers = new List<int>();
      int newNumber;

      while(resultNumbers.Count < 6) {
        newNumber = random.Next(1, 46);
        if(!resultNumbers.Contains(newNumber)) {
          resultNumbers.Add(newNumber);
        }
      }
      resultNumbers.Sort();

      return resultNumbers;
    }

    private int CheckHitCount(List<int> list1, List<int> list2) {
      int hitCount = 0;

      for(int index1 = 0; index1 < list1.Count; index1++) {
        for(int index2 = 0; index2 < list2.Count; index2++) {
          if(list1[index1] < list2[index2]) {
            break;
          }
          if(list1[index1] == list2[index2]) {
            hitCount++;
            break;
          }
        }
      }

      return hitCount;
    }

    private List<int> fillTestNumbers1() {
      return new List<int>() { 1, 2, 3, 4, 5, 6 };
    }

    private List<int> fillTestNumbers2() {
      return new List<int>() { 5, 6, 7, 8, 9, 10 };
    }
  }
}
