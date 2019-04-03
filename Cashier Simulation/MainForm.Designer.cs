namespace Cashier_Simulation
{
  partial class MainForm
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
      this.lbTicketUnit = new System.Windows.Forms.Label();
      this.lbMoneyUnit = new System.Windows.Forms.Label();
      this.lbDenoTicket = new System.Windows.Forms.Label();
      this.lbDenoMoney = new System.Windows.Forms.Label();
      this.btnDenoTicketEdit = new System.Windows.Forms.Button();
      this.clboxDenoMoney = new System.Windows.Forms.CheckedListBox();
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.listViewDenoTicket = new System.Windows.Forms.ListView();
      this.listViewBackMoney = new System.Windows.Forms.ListView();
      this.tabPageBackMoney = new System.Windows.Forms.TabPage();
      this.btnDenoMoneyEdit = new System.Windows.Forms.Button();
      this.listViewPayMoney = new System.Windows.Forms.ListView();
      this.statusStrip2 = new System.Windows.Forms.StatusStrip();
      this.labelIDCode = new System.Windows.Forms.Label();
      this.labelPayAndBackMethods = new System.Windows.Forms.Label();
      this.tabControlDetails = new System.Windows.Forms.TabControl();
      this.tabPagePayMoney = new System.Windows.Forms.TabPage();
      this.gBoxSetting = new System.Windows.Forms.GroupBox();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tabPageBackMoney.SuspendLayout();
      this.tabControlDetails.SuspendLayout();
      this.tabPagePayMoney.SuspendLayout();
      this.gBoxSetting.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbTicketUnit
      // 
      this.lbTicketUnit.AutoSize = true;
      this.lbTicketUnit.Location = new System.Drawing.Point(329, 18);
      this.lbTicketUnit.Name = "lbTicketUnit";
      this.lbTicketUnit.Size = new System.Drawing.Size(68, 13);
      this.lbTicketUnit.TabIndex = 7;
      this.lbTicketUnit.Text = "(1.000 đồng)";
      this.lbTicketUnit.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // lbMoneyUnit
      // 
      this.lbMoneyUnit.AutoSize = true;
      this.lbMoneyUnit.Location = new System.Drawing.Point(60, 16);
      this.lbMoneyUnit.Name = "lbMoneyUnit";
      this.lbMoneyUnit.Size = new System.Drawing.Size(68, 13);
      this.lbMoneyUnit.TabIndex = 6;
      this.lbMoneyUnit.Text = "(1.000 đồng)";
      this.lbMoneyUnit.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // lbDenoTicket
      // 
      this.lbDenoTicket.AutoSize = true;
      this.lbDenoTicket.Location = new System.Drawing.Point(145, 16);
      this.lbDenoTicket.Name = "lbDenoTicket";
      this.lbDenoTicket.Size = new System.Drawing.Size(42, 13);
      this.lbDenoTicket.TabIndex = 5;
      this.lbDenoTicket.Text = "Loại vé";
      // 
      // lbDenoMoney
      // 
      this.lbDenoMoney.AutoSize = true;
      this.lbDenoMoney.Location = new System.Drawing.Point(8, 16);
      this.lbDenoMoney.Name = "lbDenoMoney";
      this.lbDenoMoney.Size = new System.Drawing.Size(47, 13);
      this.lbDenoMoney.TabIndex = 4;
      this.lbDenoMoney.Text = "Loại tiền";
      // 
      // btnDenoTicketEdit
      // 
      this.btnDenoTicketEdit.Location = new System.Drawing.Point(148, 195);
      this.btnDenoTicketEdit.Name = "btnDenoTicketEdit";
      this.btnDenoTicketEdit.Size = new System.Drawing.Size(75, 23);
      this.btnDenoTicketEdit.TabIndex = 3;
      this.btnDenoTicketEdit.Text = "Edit";
      this.btnDenoTicketEdit.UseVisualStyleBackColor = true;
      // 
      // clboxDenoMoney
      // 
      this.clboxDenoMoney.FormattingEnabled = true;
      this.clboxDenoMoney.Location = new System.Drawing.Point(8, 34);
      this.clboxDenoMoney.Name = "clboxDenoMoney";
      this.clboxDenoMoney.Size = new System.Drawing.Size(120, 154);
      this.clboxDenoMoney.TabIndex = 0;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Ghi chú";
      this.columnHeader3.Width = 200;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Mã số";
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Giá vé";
      this.columnHeader1.Width = 50;
      // 
      // listViewDenoTicket
      // 
      this.listViewDenoTicket.CheckBoxes = true;
      this.listViewDenoTicket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.listViewDenoTicket.FullRowSelect = true;
      this.listViewDenoTicket.HideSelection = false;
      this.listViewDenoTicket.Location = new System.Drawing.Point(148, 34);
      this.listViewDenoTicket.Name = "listViewDenoTicket";
      this.listViewDenoTicket.Size = new System.Drawing.Size(249, 155);
      this.listViewDenoTicket.TabIndex = 8;
      this.listViewDenoTicket.UseCompatibleStateImageBehavior = false;
      this.listViewDenoTicket.View = System.Windows.Forms.View.Details;
      // 
      // listViewBackMoney
      // 
      this.listViewBackMoney.CheckBoxes = true;
      this.listViewBackMoney.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listViewBackMoney.FullRowSelect = true;
      this.listViewBackMoney.HideSelection = false;
      this.listViewBackMoney.Location = new System.Drawing.Point(3, 3);
      this.listViewBackMoney.Name = "listViewBackMoney";
      this.listViewBackMoney.Size = new System.Drawing.Size(248, 124);
      this.listViewBackMoney.TabIndex = 0;
      this.listViewBackMoney.UseCompatibleStateImageBehavior = false;
      this.listViewBackMoney.View = System.Windows.Forms.View.Details;
      // 
      // tabPageBackMoney
      // 
      this.tabPageBackMoney.Controls.Add(this.listViewBackMoney);
      this.tabPageBackMoney.Location = new System.Drawing.Point(4, 22);
      this.tabPageBackMoney.Name = "tabPageBackMoney";
      this.tabPageBackMoney.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageBackMoney.Size = new System.Drawing.Size(254, 130);
      this.tabPageBackMoney.TabIndex = 1;
      this.tabPageBackMoney.Text = "Thồi tiền";
      this.tabPageBackMoney.UseVisualStyleBackColor = true;
      // 
      // btnDenoMoneyEdit
      // 
      this.btnDenoMoneyEdit.Location = new System.Drawing.Point(8, 194);
      this.btnDenoMoneyEdit.Name = "btnDenoMoneyEdit";
      this.btnDenoMoneyEdit.Size = new System.Drawing.Size(75, 23);
      this.btnDenoMoneyEdit.TabIndex = 1;
      this.btnDenoMoneyEdit.Text = "Edit";
      this.btnDenoMoneyEdit.UseVisualStyleBackColor = true;
      // 
      // listViewPayMoney
      // 
      this.listViewPayMoney.CheckBoxes = true;
      this.listViewPayMoney.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listViewPayMoney.FullRowSelect = true;
      this.listViewPayMoney.HideSelection = false;
      this.listViewPayMoney.LabelEdit = true;
      this.listViewPayMoney.Location = new System.Drawing.Point(3, 3);
      this.listViewPayMoney.Name = "listViewPayMoney";
      this.listViewPayMoney.Size = new System.Drawing.Size(248, 124);
      this.listViewPayMoney.TabIndex = 0;
      this.listViewPayMoney.UseCompatibleStateImageBehavior = false;
      this.listViewPayMoney.View = System.Windows.Forms.View.Details;
      // 
      // statusStrip2
      // 
      this.statusStrip2.AutoSize = false;
      this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
      this.statusStrip2.Location = new System.Drawing.Point(421, 195);
      this.statusStrip2.Name = "statusStrip2";
      this.statusStrip2.Size = new System.Drawing.Size(255, 22);
      this.statusStrip2.SizingGrip = false;
      this.statusStrip2.TabIndex = 12;
      this.statusStrip2.Text = "statusStrip2";
      // 
      // labelIDCode
      // 
      this.labelIDCode.AutoSize = true;
      this.labelIDCode.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.labelIDCode.Location = new System.Drawing.Point(558, 16);
      this.labelIDCode.Name = "labelIDCode";
      this.labelIDCode.Size = new System.Drawing.Size(0, 13);
      this.labelIDCode.TabIndex = 11;
      // 
      // labelPayAndBackMethods
      // 
      this.labelPayAndBackMethods.AutoSize = true;
      this.labelPayAndBackMethods.Location = new System.Drawing.Point(418, 16);
      this.labelPayAndBackMethods.Name = "labelPayAndBackMethods";
      this.labelPayAndBackMethods.Size = new System.Drawing.Size(134, 13);
      this.labelPayAndBackMethods.TabIndex = 10;
      this.labelPayAndBackMethods.Text = "Các cách trả tiền, thồi tiền:";
      // 
      // tabControlDetails
      // 
      this.tabControlDetails.Controls.Add(this.tabPagePayMoney);
      this.tabControlDetails.Controls.Add(this.tabPageBackMoney);
      this.tabControlDetails.Location = new System.Drawing.Point(421, 33);
      this.tabControlDetails.Name = "tabControlDetails";
      this.tabControlDetails.SelectedIndex = 0;
      this.tabControlDetails.Size = new System.Drawing.Size(262, 156);
      this.tabControlDetails.TabIndex = 9;
      // 
      // tabPagePayMoney
      // 
      this.tabPagePayMoney.Controls.Add(this.listViewPayMoney);
      this.tabPagePayMoney.Location = new System.Drawing.Point(4, 22);
      this.tabPagePayMoney.Name = "tabPagePayMoney";
      this.tabPagePayMoney.Padding = new System.Windows.Forms.Padding(3);
      this.tabPagePayMoney.Size = new System.Drawing.Size(254, 130);
      this.tabPagePayMoney.TabIndex = 0;
      this.tabPagePayMoney.Text = "Trả tiền";
      this.tabPagePayMoney.UseVisualStyleBackColor = true;
      // 
      // gBoxSetting
      // 
      this.gBoxSetting.AutoSize = true;
      this.gBoxSetting.Controls.Add(this.statusStrip2);
      this.gBoxSetting.Controls.Add(this.labelIDCode);
      this.gBoxSetting.Controls.Add(this.labelPayAndBackMethods);
      this.gBoxSetting.Controls.Add(this.tabControlDetails);
      this.gBoxSetting.Controls.Add(this.listViewDenoTicket);
      this.gBoxSetting.Controls.Add(this.lbTicketUnit);
      this.gBoxSetting.Controls.Add(this.lbMoneyUnit);
      this.gBoxSetting.Controls.Add(this.lbDenoTicket);
      this.gBoxSetting.Controls.Add(this.lbDenoMoney);
      this.gBoxSetting.Controls.Add(this.btnDenoTicketEdit);
      this.gBoxSetting.Controls.Add(this.btnDenoMoneyEdit);
      this.gBoxSetting.Controls.Add(this.clboxDenoMoney);
      this.gBoxSetting.Dock = System.Windows.Forms.DockStyle.Top;
      this.gBoxSetting.Location = new System.Drawing.Point(0, 49);
      this.gBoxSetting.Name = "gBoxSetting";
      this.gBoxSetting.Size = new System.Drawing.Size(1441, 237);
      this.gBoxSetting.TabIndex = 7;
      this.gBoxSetting.TabStop = false;
      this.gBoxSetting.Text = "Setting";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1441, 25);
      this.toolStrip1.TabIndex = 6;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
      this.exitToolStripMenuItem.Text = "&Exit";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1441, 24);
      this.menuStrip1.TabIndex = 5;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 695);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1441, 22);
      this.statusStrip1.TabIndex = 4;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1441, 717);
      this.Controls.Add(this.gBoxSetting);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.statusStrip1);
      this.Name = "MainForm";
      this.Text = "Cashier Simulation";
      this.tabPageBackMoney.ResumeLayout(false);
      this.tabControlDetails.ResumeLayout(false);
      this.tabPagePayMoney.ResumeLayout(false);
      this.gBoxSetting.ResumeLayout(false);
      this.gBoxSetting.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbTicketUnit;
    private System.Windows.Forms.Label lbMoneyUnit;
    private System.Windows.Forms.Label lbDenoTicket;
    private System.Windows.Forms.Label lbDenoMoney;
    private System.Windows.Forms.Button btnDenoTicketEdit;
    private System.Windows.Forms.CheckedListBox clboxDenoMoney;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ListView listViewDenoTicket;
    private System.Windows.Forms.ListView listViewBackMoney;
    private System.Windows.Forms.TabPage tabPageBackMoney;
    private System.Windows.Forms.Button btnDenoMoneyEdit;
    private System.Windows.Forms.ListView listViewPayMoney;
    private System.Windows.Forms.StatusStrip statusStrip2;
    private System.Windows.Forms.Label labelIDCode;
    private System.Windows.Forms.Label labelPayAndBackMethods;
    private System.Windows.Forms.TabControl tabControlDetails;
    private System.Windows.Forms.TabPage tabPagePayMoney;
    private System.Windows.Forms.GroupBox gBoxSetting;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.StatusStrip statusStrip1;
  }
}

