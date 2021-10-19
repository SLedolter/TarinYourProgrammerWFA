
namespace TarinYourProgrammerWFA {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.bnt_choose_numbers = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_chosen_numbers = new System.Windows.Forms.Label();
      this.btn_start = new System.Windows.Forms.Button();
      this.lbl_count_tries = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "6 aus 45";
      // 
      // bnt_choose_numbers
      // 
      this.bnt_choose_numbers.Location = new System.Drawing.Point(13, 26);
      this.bnt_choose_numbers.Name = "bnt_choose_numbers";
      this.bnt_choose_numbers.Size = new System.Drawing.Size(75, 23);
      this.bnt_choose_numbers.TabIndex = 1;
      this.bnt_choose_numbers.Text = "Wähle Zahlen";
      this.bnt_choose_numbers.UseVisualStyleBackColor = true;
      this.bnt_choose_numbers.Click += new System.EventHandler(this.bnt_choose_numbers_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Gewählte Zahlen:";
      // 
      // lbl_chosen_numbers
      // 
      this.lbl_chosen_numbers.AutoSize = true;
      this.lbl_chosen_numbers.Location = new System.Drawing.Point(12, 75);
      this.lbl_chosen_numbers.Name = "lbl_chosen_numbers";
      this.lbl_chosen_numbers.Size = new System.Drawing.Size(0, 13);
      this.lbl_chosen_numbers.TabIndex = 3;
      // 
      // btn_start
      // 
      this.btn_start.Location = new System.Drawing.Point(13, 120);
      this.btn_start.Name = "btn_start";
      this.btn_start.Size = new System.Drawing.Size(75, 23);
      this.btn_start.TabIndex = 4;
      this.btn_start.Text = "Start";
      this.btn_start.UseVisualStyleBackColor = true;
      this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
      // 
      // lbl_count_tries
      // 
      this.lbl_count_tries.AutoSize = true;
      this.lbl_count_tries.Location = new System.Drawing.Point(10, 146);
      this.lbl_count_tries.Name = "lbl_count_tries";
      this.lbl_count_tries.Size = new System.Drawing.Size(0, 13);
      this.lbl_count_tries.TabIndex = 5;
      this.lbl_count_tries.Click += new System.EventHandler(this.label3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lbl_count_tries);
      this.Controls.Add(this.btn_start);
      this.Controls.Add(this.lbl_chosen_numbers);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.bnt_choose_numbers);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button bnt_choose_numbers;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbl_chosen_numbers;
    private System.Windows.Forms.Button btn_start;
    private System.Windows.Forms.Label lbl_count_tries;
  }
}

