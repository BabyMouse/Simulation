using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Simulation
{
  public partial class MainForm : Form
  {
    #region Fields
    private MoneyCollection _moneyCollection = new MoneyCollection(1000, "đồng", new int[] { 10, 20, 50, 100, 200, 500 });
    private TicketCollection _ticketCollection = new TicketCollection(1000, "đồng");
    #endregion

    public MainForm()
    {
      InitializeComponent();
      InitMainForm();
    }

    private void InitMainForm()
    {
      lbMoneyUnit.Text = $"({_moneyCollection.Multiplier} {_moneyCollection.UnitName})";
      clboxDenoMoney.Items.AddRange(_moneyCollection.Items);

      for (int i = 0; i < _moneyCollection.Count; i++)
      {
        ColumnHeader __columHeaderPayMoney = new ColumnHeader()
        {
          Text = _moneyCollection[i].ToString(),
          Width = 30
        };

        ColumnHeader __columHeaderBackMoney = (ColumnHeader)__columHeaderPayMoney.Clone();

        listViewPayMoney.Columns.Add(__columHeaderPayMoney);
        listViewBackMoney.Columns.Add(__columHeaderBackMoney);

      }

      _ticketCollection.Add(new Ticket(40, "LP-51_1", "Loại 1: Long Phước - QL51"));
      _ticketCollection.Add(new Ticket(60, "LP-51_2", "Loại 2: Long Phước - QL51"));
      _ticketCollection.Add(new Ticket(80, "LP-51_3", "Loại 3: Long Phước - QL51"));
      _ticketCollection.Add(new Ticket(100, "LP-51_4", "Loại 4: Long Phước - QL51"));
      _ticketCollection.Add(new Ticket(160, "LP-51_5", "Loại 5: Long Phước - QL51"));

      for (int i = 0; i < _ticketCollection.Count; i++)
      {
        listViewDenoTicket.Items.Add(new ListViewItem(_ticketCollection[i].ToArray()));
      }


    }

  }
}
