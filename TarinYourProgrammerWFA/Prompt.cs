using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarinYourProgrammerWFA {
  class Prompt : IDisposable {
    private Form prompt { get; set; }
    public string Result { get; set; }
    private string text { get; set; }
    private string caption { get; set; }

    public Prompt(string text, string caption) {
      this.text = text;
      this.caption = caption;
    }

    //use a using statement
    public string ShowDialog() {
      DialogResult dlgResult;

      prompt = new Form() {
        Width = 500,
        Height = 150,
        FormBorderStyle = FormBorderStyle.FixedDialog,
        Text = caption,
        StartPosition = FormStartPosition.CenterParent,
        TopMost = true
      };
      Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleCenter };
      TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
      Button confirmation = new Button() { Text = "Ok", Left = 50, Width = 100, Top = 70, DialogResult = DialogResult.OK };
      Button cancelation = new Button() { Text = "Cancel", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.Cancel };
      confirmation.Click += (sender, e) => { prompt.Close(); };
      prompt.Controls.Add(textBox);
      prompt.Controls.Add(confirmation);
      prompt.Controls.Add(cancelation);
      prompt.Controls.Add(textLabel);
      prompt.AcceptButton = confirmation;
      prompt.CancelButton = cancelation;

      dlgResult = prompt.ShowDialog();

      if(dlgResult == DialogResult.OK) {
        return textBox.Text;
      }

      if(dlgResult == DialogResult.Cancel) {
        return null;
      }
      return "";
    }
    public void Dispose() {
      if(prompt != null) {
        prompt.Dispose();
      }
    }
  }
}
