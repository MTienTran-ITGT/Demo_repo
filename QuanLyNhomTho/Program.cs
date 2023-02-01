using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhomTho
{
    public class Program
    {
        // dữ liệu
        public static List<Tho> dsTho = new List<Tho>();
        public static List<NhomTho> dsNhomTho = new List<NhomTho>();
        public static void taoDSNhomTho()
        {
            dsNhomTho.Add(new NhomTho("N01", "Nhóm Máy",
                "Các công việc liên quan đến động cơ xe.", new List<Tho>(), ""));
            dsNhomTho.Add(new NhomTho("N02", "Nhóm Điện",
                "Các công việc liên quan đến điện trong xe.", new List<Tho>(), ""));
            dsNhomTho.Add(new NhomTho("N03", "Nhóm Đồng-Sơn",
                "Các công việc liên quan đến làm đồng và sơn xe.", new List<Tho>(), ""));
        }
        public static void taoDSTho()
        {
            dsTho.Add(new Tho("T001", "Nguyễn Văn A", "UTE", "0983456281",
                dsNhomTho[0].manhomtho, dsNhomTho[0]));
            dsTho.Add(new Tho("T002", "Nguyễn Văn B", "UTE", "3029567201",
                dsNhomTho[1].manhomtho, dsNhomTho[1]));
            dsTho.Add(new Tho("T003", "Nguyễn Văn C", "UTE", "5630879213",
                dsNhomTho[0].manhomtho, dsNhomTho[0]));
            dsTho.Add(new Tho("T004", "Nguyễn Văn D", "UTE", "9993338989",
                dsNhomTho[2].manhomtho, dsNhomTho[2]));
            dsTho.Add(new Tho("T005", "Nguyễn Văn E", "UTE", "0903982345",
                dsNhomTho[1].manhomtho, dsNhomTho[1]));
            dsTho.Add(new Tho("T006", "Nguyễn Văn F", "UTE", "0913456789",
                dsNhomTho[2].manhomtho, dsNhomTho[2]));
            dsTho.Add(new Tho("T007", "Nguyễn Văn G", "UTE", "0908086789",
                dsNhomTho[2].manhomtho, dsNhomTho[2]));
            dsTho.Add(new Tho("T008", "Nguyễn Văn H", "UTE", "0902345678",
                dsNhomTho[1].manhomtho, dsNhomTho[1]));
            dsTho.Add(new Tho("T009", "Nguyễn Văn I", "UTE", "0907698456",
                dsNhomTho[0].manhomtho, dsNhomTho[0]));
            //
            dsNhomTho[0].dstho_nhom.Add(dsTho[0]);
            dsNhomTho[0].dstho_nhom.Add(dsTho[2]);
            dsNhomTho[0].dstho_nhom.Add(dsTho[8]);

            dsNhomTho[1].dstho_nhom.Add(dsTho[1]);
            dsNhomTho[1].dstho_nhom.Add(dsTho[4]);
            dsNhomTho[1].dstho_nhom.Add(dsTho[7]);

            dsNhomTho[2].dstho_nhom.Add(dsTho[3]);
            dsNhomTho[2].dstho_nhom.Add(dsTho[5]);
            dsNhomTho[2].dstho_nhom.Add(dsTho[6]);
            //
            dsNhomTho[0].matruongnhom = dsTho[2].matho;
            dsNhomTho[0].truongnhom = new Tho(dsTho[2]);

            dsNhomTho[1].matruongnhom = dsTho[7].matho;
            dsNhomTho[1].truongnhom = new Tho(dsTho[7]);

            dsNhomTho[2].matruongnhom = dsTho[5].matho;
            dsNhomTho[2].truongnhom = new Tho(dsTho[5]);

        }
        // LINQ TO SQL/OBJECT
        // Liệt kê danh sách các nhóm thợ
        public static void Linq01()
        {
            // lambda
            var dsnhom = dsNhomTho.Select(nt => nt);
            foreach (var nhom in dsnhom)
            {
                Console.WriteLine("{0} - {1} - {2} - Truong Nhom: {3} ",
                    nhom.manhomtho, nhom.tennhom, nhom.mota, nhom.truongnhom.hoten);
                foreach (var tho in nhom.dstho_nhom)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}",
                        tho.matho, tho.hoten, tho.diachi, tho.sodienthoai);
                }
                Console.WriteLine();
            }
        }
        // Cho biết thông tin một thợ
        public static void Linq02(string matho)
        {
            Tho th = dsTho.Where(t => t.matho == matho)
                .FirstOrDefault();
            if (th != null)
            {
                Console.WriteLine("Thông tin tho:");
                Console.WriteLine("{0} - {1} - {2} - {3} - {4}",
                 th.matho, th.hoten, th.diachi, th.sodienthoai,
                            th.nhomtho.tennhom);
            }
            else
                Console.WriteLine("Không có thợ có mã thợ {0}.", matho);
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            taoDSNhomTho();
            taoDSTho();

            Linq01();
            Console.WriteLine("----------------");
            Linq02("T001");
            Console.ReadKey();
        }
    }
}
