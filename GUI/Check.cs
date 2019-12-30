using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class DateServer
    {
        public static TcpClient client1;
        public static NetworkStream clientstrem;
        public static DateTime Date()
        {
            Server_Client.Client cl = new Server_Client.Client();
            client1 = cl.Connect(Luu.IP, Luu.Ports);
            Entities.CheckRefer pt = new Entities.CheckRefer();
            clientstrem = cl.SerializeObj(client1, "Datetime", pt);
            DateTime dt = new DateTime();
            dt = (DateTime)cl.DeserializeHepper(clientstrem, dt);
            return dt;
        }
    }
    public class Check
    {
        public TcpClient client1;
        public NetworkStream clientstrem;
        public bool CheckReference(string tenTruong, string maTruong)
        {
            try
            {
                Server_Client.Client cl = new Server_Client.Client();
                this.client1 = cl.Connect(Luu.IP, Luu.Ports);
                Entities.CheckRefer pt = new Entities.CheckRefer(tenTruong, maTruong);
                bool kt = false;
                clientstrem = cl.SerializeObj(this.client1, "CheckRefer", pt);
                kt = (bool)cl.DeserializeHepper(clientstrem, kt);
                return kt;
            }
            catch
            {
                return false;
            }
        }
    }

    public class TienIch
    {
        
        string GET(string ten, List<List<string>> l)
        {
            string kq = string.Empty;
            for (int i = 0; i < l[0].Count; i++) { if (l[0][i].Equals(ten)) kq = l[1][i]; }
            return kq;
        }

       
        public void AutoFormatMoney(object sender)
        {
            try
            {
                TextBox temp = (TextBox)sender;
                int vt = temp.SelectionStart;
                string str = new string(temp.Text.Replace(",", "").ToList<char>().Where(c => char.IsNumber(c)).ToArray<char>());
                temp.Text = FormatMoney(str);
                temp.SelectionStart = temp.Text.Length;
            }
            catch { }
        }

        /// <summary>
        /// Tự động định dạng với AutoFormat
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="okTextBox">TRUE: TextBox, FALSE: ToolStripTextBox</param>
        /// <param name="okMoney">TRUE: FormatMoney, FALSE: InputINT</param>
        public void AutoFormat(object sender, bool okTextBox, bool okMoney)
        {
            try
            {
                if (okTextBox && okMoney)
                {//FormatMoney For TextBox
                    TextBox temp = (TextBox)sender;
                    int vt = temp.SelectionStart;
                    string str = new string(temp.Text.Replace(",", "").ToList<char>().Where(c => char.IsNumber(c)).ToArray<char>());
                    temp.Text = FormatMoney(str);
                    temp.SelectionStart = temp.Text.Length;
                }
                else if (!okTextBox && okMoney)
                {//FormatMoney For ToolStripTextBox
                    ToolStripTextBox temp = (ToolStripTextBox)sender;
                    int vt = temp.SelectionStart;
                    string str = new string(temp.Text.Replace(",", "").ToList<char>().Where(c => char.IsNumber(c)).ToArray<char>());
                    temp.Text = FormatMoney(str);
                    temp.SelectionStart = temp.Text.Length;
                }
                else if (okTextBox && !okMoney)
                {//InputINT For TextBox
                    TextBox temp = (TextBox)sender;
                    int vt = temp.SelectionStart;
                    string str = new string(temp.Text.ToList<char>().Where(c => char.IsNumber(c)).ToArray<char>());
                    temp.Text = str;
                    temp.SelectionStart = temp.Text.Length;
                }
                else if (!okTextBox && !okMoney)
                {//InputINT For ToolStripTextBox
                    ToolStripTextBox temp = (ToolStripTextBox)sender;
                    int vt = temp.SelectionStart;
                    string str = new string(temp.Text.ToList<char>().Where(c => char.IsNumber(c)).ToArray<char>());
                    temp.Text = str;
                    temp.SelectionStart = temp.Text.Length;
                }
            }
            catch { }
        }

        public string FormatMoney(string money)
        {
            if (double.Parse(money) >= 0 && double.Parse(money) < 10)
                return money;
            string str = "";
            try
            {
                if (double.Parse(money) < 0)
                    str = String.Format("{0,-0:0,0}", double.Parse(money));
                else
                    str = String.Format("{0:0,0}", double.Parse(money));
            }
            catch { return ""; }
            return str;
        }

        public static Entities.DiemThuongKhachHang DiemThuongKhachHang_TO_DiemThuongKhachHang(Entities.DiemThuongKhachHang dtkh)
        {
            Entities.DiemThuongKhachHang kq = new Entities.DiemThuongKhachHang();
            kq.MaDiemThuongKhachHang = dtkh.MaDiemThuongKhachHang;
            kq.MaKhachHang = dtkh.MaKhachHang;
            kq.TenKhachHang = dtkh.TenKhachHang;
            kq.TongDiem = dtkh.TongDiem;
            kq.DiemDaDung = dtkh.DiemDaDung;
            kq.DiemConLai = dtkh.DiemConLai;
            kq.GhiChu = dtkh.GhiChu;
            kq.Deleted = dtkh.Deleted;
            return kq;
        }

        public static List<double> TinhDoanhThu(double TT, double vip, double uudai)
        {
            double UseVIP = 0;
            double UseUD = 0;
            double DT = 0;
            List<double> kq = new List<double>();
            if (TT - vip < 0)
            {
                DT = 0;
                UseVIP = TT;
                UseUD = 0;
            }
            else if (TT - vip == 0)
            {
                DT = 0;
                UseVIP = vip;
                UseUD = 0;
            }
            else
            {
                if (TT - vip - uudai < 0)
                {
                    DT = 0;
                    UseVIP = vip;
                    UseUD = TT - vip;
                }
                else if (TT - vip - uudai == 0)
                {
                    DT = 0;
                    UseVIP = vip;
                    UseUD = uudai;
                }
                else
                {
                    DT = TT - vip - uudai;
                    UseVIP = vip;
                    UseUD = uudai;
                }
            }
            kq.Add(TT);
            kq.Add(UseVIP);
            kq.Add(UseUD);
            kq.Add(DT);
            return kq;
        }
    }
}
