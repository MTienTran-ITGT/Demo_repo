using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhomTho
{
    public class Tho
    {
        public string  matho { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public string sodienthoai { get; set; }
        public string manhomtho { get; set; }
        public Tho() { }
        public Tho(Tho t)
        {
            this.matho = t.matho;
            this.hoten = t.hoten;
            this.diachi = t.diachi;
            this.sodienthoai = t.sodienthoai;
        }
        public Tho(string matho, string hoten, string diachi, string sodienthoai, string manhomtho, NhomTho nt)
        {
            this.matho = matho;
            this.hoten = hoten;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
            this.manhomtho = manhomtho;
            this.nhomtho = nt;
        }
        public NhomTho nhomtho { get; set; }
    }
}
