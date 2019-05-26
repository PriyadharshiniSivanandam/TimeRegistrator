using System;

using System.ComponentModel;
using System.Windows.Forms;

using TimeRegistratorBusinessLogic;

namespace TimeRegistratorUI
{
  public partial class Registrator : Form
  {
    private BindingList<TimeRegistratorData> Data;

    private TimeTracker TimeTracker;

    /// <summary>
    /// Timer used for UI refreshes
    /// </summary>
    private Timer RefreshTimer;

    public Registrator()
    {
      Data = new BindingList<TimeRegistratorData>();

      TimeTracker = new TimeTracker();

      RefreshTimer = new Timer
      {
        Interval = 100
      };

      InitializeComponent();

      this.dataGridView1.DataSource = Data;
    }

  
    private void button1_Click(object sender, EventArgs e)
    {
      TimeTracker.Start();
      RefreshTimer.Start();
      RefreshTrackingButtons();

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
    
    }

    private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void RefreshTrackingButtons()
    {
      var tracking = TimeTracker.Tracking;

      this.ClockInButton.Enabled = !tracking;
      this.ClockOutButton.Enabled = tracking;

    }

    private void ClockOutButton_Click(object sender, EventArgs e)
    {
      RefreshTimer.Stop();

      TimeRegistratorData item = TimeTracker.Stop();
      item.CustomerName = this.CustomerNameTextBox.Text;

      Data.Add(item);
      RefreshTrackingButtons();
      this.CustomerNameTextBox.Text = string.Empty;

    }
  }
}
