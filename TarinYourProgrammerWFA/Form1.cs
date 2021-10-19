using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TarinYourProgrammerWFA {
  public partial class Form1 : Form {
    List<int> userNumbers = new List<int>();
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
      List<int> randomNumbers = new List<int>();
      Random random = new Random();
      bool strike = false;
      double counter = 0;
      int newNumber;

      while(!strike) {
        while(randomNumbers.Count < 6) {
          newNumber = random.Next(1, 46);
          if(!randomNumbers.Contains(newNumber)) {
            randomNumbers.Add(newNumber);
          }
        }
        randomNumbers.Sort();

        lbl_count_tries.Text = $"Azahl der Versuche: {counter}";
        counter++;
        if(counter % 100 == 0) {
          lbl_count_tries.Refresh();
        }
        if(randomNumbers.SequenceEqual(userNumbers)) {
          strike = true;
        }
        randomNumbers.Clear();
      }
    }
  }
}
