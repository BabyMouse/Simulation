using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Simulation
{
  class BaseCollection<T>
  {
    public BaseCollection()
    {
      _items = new List<T>();
    }

    public BaseCollection(int multiplier, string unitName) : this()
    {
      Multiplier = multiplier;
      UnitName = unitName;
    }

    /// <summary>
    /// Danh sách các phần tử.
    /// </summary>
    protected List<T> _items;

    /// <summary>
    /// Hệ số nhân.
    /// </summary>
    public int Multiplier { get; set; }

    /// <summary>
    /// Tên đơn vị.
    /// </summary>
    public string UnitName { get; set; }

    /// <summary>
    /// Số lượng phần tử.
    /// </summary>
    public int Count
    {
      get { return _items.Count; }
    }

    /// <summary>
    /// Truy cập danh sách theo chỉ mục.
    /// </summary>
    /// <param name="idx">Số chỉ mục.</param>
    /// <returns>Trả về phần tử tương ứng số chỉ mục.</returns>
    public T this[int idx]
    {
      get => _items[idx];
      set => _items[idx] = value;
    }

    /// <summary>
    /// Xóa phần tử.
    /// </summary>
    /// <param name="item"></param>
    public void Remove(T item)
    {
      _items.Remove(item);
    }
  }

  /// <summary>
  /// Bộ tiền giấy.
  /// </summary>
  class MoneyCollection : BaseCollection<int>
  {
    /// <summary>
    /// Khởi tạo.
    /// </summary>
    /// <param name="multiplier">Hệ số nhân.</param>
    /// <param name="unitName">Tên đơn vị.</param>
    /// <param name="values">Tập mệnh giá.</param>
    public MoneyCollection(int multiplier, string unitName, int[] values) : base(multiplier, unitName)
    {
      for (int i = 0; i < values.Length; i++)
      {
        Add(values[i]);
      }
      Sort();
    }

    public object[] Items
    {
      get => Array.ConvertAll<int, object>(_items.ToArray(), (x) => x);
    }

    /// <summary>
    /// Thêm vào danh sách mệnh giá tiền giấy.
    /// </summary>
    /// <param name="value">Mệnh giá tờ tiền.</param>
    public void Add(int value)
    {
      if (!_items.Exists(v => v == value)) { _items.Add(value); }
    }

    public void Sort()
    {
      _items.Sort();
    }


  }

  /// <summary>
  /// Vé.
  /// </summary>
  class Ticket
  {
    public Ticket(int value, string idCode, string note)
    {
      Value = value;
      IDCode = idCode;
      Note = note;
    }

    /// <summary>
    /// Mệnh giá vé.
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// Mã định danh từng loại vé.
    /// </summary>
    public string IDCode { get; set; }

    /// <summary>
    /// Ghi chú.
    /// </summary>
    public string Note { get; set; }

    public string[] ToArray() => new string[3] { Value.ToString(), IDCode, Note };

  }

  class TicketCollection : BaseCollection<Ticket>
  {
    public TicketCollection(int multiplier, string unitName) : base(multiplier, unitName) { }
    /// <summary>
    /// Thêm vào danh sách loại vé.
    /// </summary>
    /// <param name="ticket">Loại vé.</param>
    public void Add(Ticket ticket)
    {
      if (!_items.Exists(t => t.IDCode == ticket.IDCode)) { _items.Add(ticket); }
    }
  }

}
