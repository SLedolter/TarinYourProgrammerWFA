
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
      this.lbox_left = new System.Windows.Forms.ListBox();
      this.lbox_right = new System.Windows.Forms.ListBox();
      this.btn_move_to_right = new System.Windows.Forms.Button();
      this.btn_move_to_left = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbox_left
      // 
      this.lbox_left.FormattingEnabled = true;
      this.lbox_left.Location = new System.Drawing.Point(12, 12);
      this.lbox_left.Name = "lbox_left";
      this.lbox_left.Size = new System.Drawing.Size(227, 251);
      this.lbox_left.TabIndex = 0;
      this.lbox_left.SelectedIndexChanged += new System.EventHandler(this.lbox_left_SelectedIndexChanged);
      // 
      // lbox_right
      // 
      this.lbox_right.FormattingEnabled = true;
      this.lbox_right.Location = new System.Drawing.Point(326, 12);
      this.lbox_right.Name = "lbox_right";
      this.lbox_right.Size = new System.Drawing.Size(227, 251);
      this.lbox_right.TabIndex = 1;
      this.lbox_right.SelectedIndexChanged += new System.EventHandler(this.lbox_right_SelectedIndexChanged);
      // 
      // btn_move_to_right
      // 
      this.btn_move_to_right.Location = new System.Drawing.Point(245, 12);
      this.btn_move_to_right.Name = "btn_move_to_right";
      this.btn_move_to_right.Size = new System.Drawing.Size(75, 23);
      this.btn_move_to_right.TabIndex = 2;
      this.btn_move_to_right.Text = "--->";
      this.btn_move_to_right.UseVisualStyleBackColor = true;
      this.btn_move_to_right.Click += new System.EventHandler(this.btn_move_to_right_Click);
      // 
      // btn_move_to_left
      // 
      this.btn_move_to_left.Location = new System.Drawing.Point(245, 41);
      this.btn_move_to_left.Name = "btn_move_to_left";
      this.btn_move_to_left.Size = new System.Drawing.Size(75, 23);
      this.btn_move_to_left.TabIndex = 3;
      this.btn_move_to_left.Text = "<---";
      this.btn_move_to_left.UseVisualStyleBackColor = true;
      this.btn_move_to_left.Click += new System.EventHandler(this.btn_move_to_left_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(564, 450);
      this.Controls.Add(this.btn_move_to_left);
      this.Controls.Add(this.btn_move_to_right);
      this.Controls.Add(this.lbox_right);
      this.Controls.Add(this.lbox_left);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lbox_left;
    private System.Windows.Forms.ListBox lbox_right;
    private System.Windows.Forms.Button btn_move_to_right;
    private System.Windows.Forms.Button btn_move_to_left;
  }
}

