namespace TimeRegistratorUI
{
  partial class Registrator
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrator));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.ClockInButton = new System.Windows.Forms.Button();
      this.ClockOutButton = new System.Windows.Forms.Button();
      this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
      this.CustomerNameLabel = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(938, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // toolStrip1
      // 
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.DeleteToolStripButton});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(938, 27);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
      // 
      // OpenToolStripButton
      // 
      this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
      this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.OpenToolStripButton.Name = "OpenToolStripButton";
      this.OpenToolStripButton.Size = new System.Drawing.Size(24, 24);
      this.OpenToolStripButton.Text = "OpenToolStripButton";
      this.OpenToolStripButton.ToolTipText = "Open";
      this.OpenToolStripButton.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // SaveToolStripButton
      // 
      this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
      this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.SaveToolStripButton.Name = "SaveToolStripButton";
      this.SaveToolStripButton.Size = new System.Drawing.Size(24, 24);
      this.SaveToolStripButton.Text = "SaveToolStripButton";
      this.SaveToolStripButton.ToolTipText = "Save";
      // 
      // DeleteToolStripButton
      // 
      this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
      this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.DeleteToolStripButton.Name = "DeleteToolStripButton";
      this.DeleteToolStripButton.Size = new System.Drawing.Size(24, 24);
      this.DeleteToolStripButton.Text = "toolStripButton3";
      this.DeleteToolStripButton.ToolTipText = "Delete";
      // 
      // ClockInButton
      // 
      this.ClockInButton.Location = new System.Drawing.Point(12, 145);
      this.ClockInButton.Name = "ClockInButton";
      this.ClockInButton.Size = new System.Drawing.Size(143, 37);
      this.ClockInButton.TabIndex = 2;
      this.ClockInButton.Text = "Clock In";
      this.ClockInButton.UseVisualStyleBackColor = true;
      this.ClockInButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // ClockOutButton
      // 
      this.ClockOutButton.Location = new System.Drawing.Point(191, 145);
      this.ClockOutButton.Name = "ClockOutButton";
      this.ClockOutButton.Size = new System.Drawing.Size(141, 37);
      this.ClockOutButton.TabIndex = 3;
      this.ClockOutButton.Text = "Clock Out";
      this.ClockOutButton.UseVisualStyleBackColor = true;
      this.ClockOutButton.Click += new System.EventHandler(this.ClockOutButton_Click);
      // 
      // CustomerNameTextBox
      // 
      this.CustomerNameTextBox.Location = new System.Drawing.Point(182, 84);
      this.CustomerNameTextBox.Name = "CustomerNameTextBox";
      this.CustomerNameTextBox.Size = new System.Drawing.Size(150, 22);
      this.CustomerNameTextBox.TabIndex = 4;
      this.CustomerNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // CustomerNameLabel
      // 
      this.CustomerNameLabel.AutoSize = true;
      this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CustomerNameLabel.Location = new System.Drawing.Point(26, 87);
      this.CustomerNameLabel.Name = "CustomerNameLabel";
      this.CustomerNameLabel.Size = new System.Drawing.Size(109, 17);
      this.CustomerNameLabel.TabIndex = 5;
      this.CustomerNameLabel.Text = "Customer Name";
      this.CustomerNameLabel.Click += new System.EventHandler(this.label1_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
      this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.dataGridView1.Location = new System.Drawing.Point(386, 27);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(540, 537);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
      this.pictureBox1.Location = new System.Drawing.Point(29, 238);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(300, 282);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // Registrator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(938, 565);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.CustomerNameLabel);
      this.Controls.Add(this.CustomerNameTextBox);
      this.Controls.Add(this.ClockOutButton);
      this.Controls.Add(this.ClockInButton);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Registrator";
      this.Text = "Form1";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton OpenToolStripButton;
    private System.Windows.Forms.ToolStripButton SaveToolStripButton;
    private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
    private System.Windows.Forms.Button ClockInButton;
    private System.Windows.Forms.Button ClockOutButton;
    private System.Windows.Forms.TextBox CustomerNameTextBox;
    private System.Windows.Forms.Label CustomerNameLabel;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

