
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
      this.inp_zahl = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btn_calculate = new System.Windows.Forms.Button();
      this.lbl_err_msg = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_output = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // inp_zahl
      // 
      this.inp_zahl.Location = new System.Drawing.Point(56, 12);
      this.inp_zahl.Name = "inp_zahl";
      this.inp_zahl.Size = new System.Drawing.Size(100, 20);
      this.inp_zahl.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Zahl:";
      // 
      // btn_calculate
      // 
      this.btn_calculate.Location = new System.Drawing.Point(162, 10);
      this.btn_calculate.Name = "btn_calculate";
      this.btn_calculate.Size = new System.Drawing.Size(75, 23);
      this.btn_calculate.TabIndex = 2;
      this.btn_calculate.Text = "Berechnen";
      this.btn_calculate.UseVisualStyleBackColor = true;
      this.btn_calculate.Click += new System.EventHandler(this.button1_Click);
      // 
      // lbl_err_msg
      // 
      this.lbl_err_msg.AutoSize = true;
      this.lbl_err_msg.Location = new System.Drawing.Point(53, 35);
      this.lbl_err_msg.Name = "lbl_err_msg";
      this.lbl_err_msg.Size = new System.Drawing.Size(0, 13);
      this.lbl_err_msg.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(56, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(102, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Berechnete Reihen:";
      // 
      // lbl_output
      // 
      this.lbl_output.AutoSize = true;
      this.lbl_output.Location = new System.Drawing.Point(56, 90);
      this.lbl_output.Name = "lbl_output";
      this.lbl_output.Size = new System.Drawing.Size(0, 13);
      this.lbl_output.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lbl_output);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lbl_err_msg);
      this.Controls.Add(this.btn_calculate);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.inp_zahl);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox inp_zahl;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_calculate;
    private System.Windows.Forms.Label lbl_err_msg;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbl_output;
  }
}

