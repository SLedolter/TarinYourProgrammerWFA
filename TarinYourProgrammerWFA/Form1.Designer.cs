
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
      this.lbl_array_in_label = new System.Windows.Forms.Label();
      this.lbl_array_out_label = new System.Windows.Forms.Label();
      this.lbl_array_out = new System.Windows.Forms.Label();
      this.lbl_array_in = new System.Windows.Forms.Label();
      this.btn_min_max = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.lbl_count = new System.Windows.Forms.Label();
      this.btn_refill = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_min_max = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lbl_array_in_label
      // 
      this.lbl_array_in_label.AutoSize = true;
      this.lbl_array_in_label.Location = new System.Drawing.Point(18, 13);
      this.lbl_array_in_label.Name = "lbl_array_in_label";
      this.lbl_array_in_label.Size = new System.Drawing.Size(46, 13);
      this.lbl_array_in_label.TabIndex = 0;
      this.lbl_array_in_label.Text = "In-Array:";
      // 
      // lbl_array_out_label
      // 
      this.lbl_array_out_label.AutoSize = true;
      this.lbl_array_out_label.Location = new System.Drawing.Point(18, 63);
      this.lbl_array_out_label.Name = "lbl_array_out_label";
      this.lbl_array_out_label.Size = new System.Drawing.Size(54, 13);
      this.lbl_array_out_label.TabIndex = 0;
      this.lbl_array_out_label.Text = "Out-Array:";
      // 
      // lbl_array_out
      // 
      this.lbl_array_out.AutoSize = true;
      this.lbl_array_out.Location = new System.Drawing.Point(76, 63);
      this.lbl_array_out.Name = "lbl_array_out";
      this.lbl_array_out.Size = new System.Drawing.Size(0, 13);
      this.lbl_array_out.TabIndex = 1;
      // 
      // lbl_array_in
      // 
      this.lbl_array_in.AutoSize = true;
      this.lbl_array_in.Location = new System.Drawing.Point(76, 13);
      this.lbl_array_in.Name = "lbl_array_in";
      this.lbl_array_in.Size = new System.Drawing.Size(0, 13);
      this.lbl_array_in.TabIndex = 2;
      // 
      // btn_min_max
      // 
      this.btn_min_max.Location = new System.Drawing.Point(135, 33);
      this.btn_min_max.Name = "btn_min_max";
      this.btn_min_max.Size = new System.Drawing.Size(123, 23);
      this.btn_min_max.TabIndex = 3;
      this.btn_min_max.Text = "MinMax Calc";
      this.btn_min_max.UseVisualStyleBackColor = true;
      this.btn_min_max.Click += new System.EventHandler(this.Btn_min_max_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(264, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(90, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Umschichtungen:";
      // 
      // lbl_count
      // 
      this.lbl_count.AutoSize = true;
      this.lbl_count.Location = new System.Drawing.Point(360, 38);
      this.lbl_count.Name = "lbl_count";
      this.lbl_count.Size = new System.Drawing.Size(0, 13);
      this.lbl_count.TabIndex = 5;
      // 
      // btn_refill
      // 
      this.btn_refill.Location = new System.Drawing.Point(14, 33);
      this.btn_refill.Name = "btn_refill";
      this.btn_refill.Size = new System.Drawing.Size(86, 23);
      this.btn_refill.TabIndex = 6;
      this.btn_refill.Text = "Refill Array";
      this.btn_refill.UseVisualStyleBackColor = true;
      this.btn_refill.Click += new System.EventHandler(this.Btn_refill_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 106);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Min./Max.:";
      // 
      // lbl_min_max
      // 
      this.lbl_min_max.AutoSize = true;
      this.lbl_min_max.Location = new System.Drawing.Point(85, 106);
      this.lbl_min_max.Name = "lbl_min_max";
      this.lbl_min_max.Size = new System.Drawing.Size(0, 13);
      this.lbl_min_max.TabIndex = 8;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lbl_min_max);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btn_refill);
      this.Controls.Add(this.lbl_count);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btn_min_max);
      this.Controls.Add(this.lbl_array_out);
      this.Controls.Add(this.lbl_array_in);
      this.Controls.Add(this.lbl_array_out_label);
      this.Controls.Add(this.lbl_array_in_label);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_array_in_label;
    private System.Windows.Forms.Label lbl_array_out_label;
    private System.Windows.Forms.Label lbl_array_out;
    private System.Windows.Forms.Label lbl_array_in;
    private System.Windows.Forms.Button btn_min_max;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbl_count;
    private System.Windows.Forms.Button btn_refill;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbl_min_max;
  }
}

