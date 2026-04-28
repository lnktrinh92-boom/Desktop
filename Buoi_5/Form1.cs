using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_5
{
    public partial class Form1 : Form
    {
        List<Student> listSV;
        List<Lop> listLop;
        public class Student
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public int Tuoi { get; set; }
            public string[] NangKhieu { get; set; }
            public string MaLop { get; set; }
            public override string ToString()
                => $"{MSSV,5} | {HoTen,25} | {Tuoi,3} | {MaLop,3} | {string.Join(",", NangKhieu)}";
        }
        public class Lop
        {
            public string MaLop { get; set; }
            public string TenLop { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        void Hello(string str)
        {
            rtxKQ.Text += "Hello " + str + "\n";
        }

        void Goodbye(string str)
        {
            rtxKQ.Text += "Goodbye " + str + "\n";
        }

        delegate void MyDelegate (string str);

        private void btnCase1_Click(object sender, EventArgs e)
        {
            rtxKQ.Text = "";

            rtxKQ.Text += "Delegate 1 hàm Hello" + Environment.NewLine;
            //MyDelegate myDelegate = new MyDelegate(Hello);
            MyDelegate myDelegate = Hello;
            myDelegate("Nam");

            //MultiCast Delegate
            rtxKQ.Text += "\nGọi Delegate với Multi Cast: \n";
            MyDelegate myDelegate_MultiCast = Hello;
            myDelegate_MultiCast += Goodbye;
            myDelegate_MultiCast("Tung");
        }

        private void btnCase2_Click(object sender, EventArgs e)
        {
            rtxKQ.Text = "";

            //Action là một delegate có sẵn trong .NET Framework, có thể thay thế cho MyDelegate
            Action<string> action_Delegate = Hello;
            rtxKQ.Text += "Action Delegate 1 hàm Hello" + Environment.NewLine;
            action_Delegate("Nam - Action");

            rtxKQ.Text += "\nAction Delegate với Lambda: \n";
            action_Delegate = str => {
                rtxKQ.Text += str + Environment.NewLine;
            };
            action_Delegate("Nguyên - Action");

            if (txtA.Text != "" && txtB.Text != "")
            {
                //Func là một delegate có sẵn trong .NET Framework, có thể thay thế cho MyDelegate
                Func<int, int, int> func_Delegate = (a, b) => a + b; //Hoặc { return a + b; }
                int result = func_Delegate(int.Parse(txtA.Text), int.Parse(txtB.Text));

                rtxKQ.Text += "\nFunc Delegate với Lambda: \n";
                rtxKQ.Text += "Kết quả: " + txtA.Text + " + " + txtB.Text + " = " + result;
            }
        }

        async Task LamXong_Callback(string str, MyCallback callback)
        {
            rtxKQ.Text += "Bắt đầu thực hiện công việc... 5s xong!" + "\n";

            //Giả sử đây là một công việc tốn thời gian, ví dụ như gọi API, xử lý dữ liệu, v.v.
            await Task.Delay(3000); //Tạm dừng 3 giây để giả lập công việc tốn thời gian

            //Sau khi công việc hoàn thành, gọi callback để thông báo
            callback(str);
        }

        void Callback_KhiXong(string str)
        {
            rtxKQ.Text += "Sau khi chạy xong thì Callback: " + str + "\n";
        }
        delegate void MyCallback(string str);
        void myWork(string str, MyCallback callback)
        {
            rtxKQ.Text += "Bắt đầu thực hiện công việc... tốn 3s xong!" + "\n";
            Refresh(); //Cập nhật giao diện để hiển thị thông báo trước khi tạm dừng
                       //Giả sử đây là một công việc tốn thời gian, ví dụ như gọi API, xử lý dữ liệu, v.v.
            System.Threading.Thread.Sleep(3000); //Tạm dừng 3 giây để giả lập công việc tốn thời gian

            //Sau khi công việc hoàn thành, gọi callback để thông báo
            callback(str);
        }

        private void btnCallback_Click(object sender, EventArgs e)
        {
            rtxKQ.Text = "";
            LamXong_Callback("Đã hoàn thành công việc!", Callback_KhiXong);
            //myWork("Đã hoàn thành công việc... không dùng bất đồng bộ!", Callback_KhiXong);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.OutputEncoding = Encoding.Unicode;

            listSV = new List<Student>()
            {
                new Student {MSSV = "SV1", HoTen = "Tran Thanh Dat", Tuoi = 20,
                     NangKhieu = new string[] {"Bong Da", "Game", "Tennis"}, MaLop = "" },
                new Student {MSSV = "SV2", HoTen = "Le Thanh Phat", Tuoi = 19,
                     NangKhieu = new string[] {"Game"}, MaLop = "CS" },
                new Student {MSSV = "SV3", HoTen = "Nguyen Quan", Tuoi = 18,
                 NangKhieu = new string[] {"Bong Da", "Tennis"}, MaLop = "CS" },
                new Student {MSSV = "SV4", HoTen = "Truong Thi Ngoc Dieu", Tuoi = 18,
                     NangKhieu = new string[] {"Tennis"}, MaLop = "DS" },
                new Student {MSSV = "SV5", HoTen = "No Name", Tuoi = 20,
                    NangKhieu = new string[] {"Bong Da"}, MaLop = "EE"},
            };

            listLop = new List<Lop>()
            {
                new Lop { MaLop = "CS", TenLop = "Computer Science" },
                new Lop { MaLop = "DS", TenLop = "Data Science" }
            };
        }

        private void btnLinQ_Click(object sender, EventArgs e)
        {
            rtxKQ.Text = "";
            Linq_Select();
            Linq_SelectMany();
            Linq_Where();
            Linq_Max();
            Linq_Join();
            Linq_Join_GroupJoin();
        }

        public void Linq_Select()
        {
            var kq = listSV.Select(
                    p =>
                    {
                        //return $"Mã lớp: {p.MaLop} - Tên lớp: {p.TenLop}";
                        return $"Mã lớp: {p.MaLop} - Tên lớp: {p.HoTen}";
                    }
                );
            rtxKQ.AppendText("LINQ SELECT: \n");
            foreach (var item in kq)
                rtxKQ.AppendText(item + "\n");
        }

        public void Linq_SelectMany()
        {
            var kq = listSV.SelectMany(
                p =>
                {
                    return p.NangKhieu;
                }
            ).Distinct();//Có thể kết hợp .Distinct();

            var kq1 = listSV.SelectMany(
                p => p.NangKhieu
            ).Distinct();//Có thể kết hợp .Distinct();

            rtxKQ.AppendText("\n\nLINQ SELECTMANY: \n");
            foreach (var item in kq)
                rtxKQ.AppendText(item + "\n");
        }

        public void Linq_Where()
        {
            rtxKQ.AppendText("\n\n LINQ WHERE: \n");
            var kq = listSV.Where(x => x.MSSV.Equals("SV2") || x.MSSV.Equals("SV3")).ToList();
            foreach (var k in kq)
                rtxKQ.AppendText(k.ToString() + "\n");
        }

        public void Linq_Max()
        {
            rtxKQ.AppendText("\n\n LINQ MAX: \n");
            var kq = listSV.Where(x => x.Tuoi.Equals(listSV.Max(y => y.Tuoi))).ToList();
            foreach (var k in kq)
                rtxKQ.AppendText(k.ToString() + "\n");
        }

        public void Linq_Join()
        {
            //------------Join-------------//
            var kq = listSV.Join(listLop, pSV => pSV.MaLop, pLop => pLop.MaLop, (pSV, PLop) =>
            {
                return new
                {
                    TenLop = PLop.TenLop,
                    MSSV = pSV.MSSV,
                    HoTen = pSV.HoTen,
                };
            }
            );
            rtxKQ.Text = "\n\nLINQ JOIN:\n";
            foreach (var item in kq)
                rtxKQ.AppendText(item.ToString() + "\n");
        }

        public void Linq_Join_GroupJoin()
        {
            //------------GroupJoin-------------//
            var kqGroupJoin = listLop.GroupJoin(listSV, lop => lop.MaLop, sv => sv.MaLop, (dsLop, dsSV) =>
            {
                return new
                {
                    TenLop = dsLop.TenLop,
                    dsSVLop = dsSV,
                };
            }
            );
            rtxKQ.AppendText("\nLINQ GROUP JOIN:\n");
            foreach (var lop in kqGroupJoin)
            {
                rtxKQ.AppendText(lop.TenLop + ":\n");
                foreach (var sv in lop.dsSVLop)
                {
                    rtxKQ.AppendText($"\t\t{sv.HoTen} - {sv.Tuoi} tuổi.\n");
                }
            }
        }
    }
}