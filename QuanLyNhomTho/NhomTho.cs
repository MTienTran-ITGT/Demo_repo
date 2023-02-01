using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhomTho
{
    public class NhomTho
    {
        private string v1;
        private string v2;
        private List<Tho> thos;
        private string v3;

        public string manhomtho { get; set; }
        public string tennhom { get; set; }
        public string mota { get; set; }
        public string matruongnhom { get; set; }
        public NhomTho(string v) { }
        public NhomTho(NhomTho nt)
        {
            this.manhomtho = nt.manhomtho;
            this.tennhom = nt.tennhom;
            this.mota = nt.mota;
            this.dstho_nhom = nt.dstho_nhom;
            this.matruongnhom = nt.matruongnhom;
        }
        public NhomTho(string manhomtho, string tennhom, string mota,ICollection<NhomTho> dstho_nhom, string matruongnhom)
        {
            this.manhomtho = manhomtho;
            this.tennhom = tennhom;
            this.mota = mota;
            this.dstho_nhom = dstho_nhom;
            this.matruongnhom = matruongnhom;
        }

        public NhomTho(string v, string v1, string v2, List<Tho> thos, string v3) : this(v)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.thos = thos;
            this.v3 = v3;
        }

        // related = plural
        public ICollection<NhomTho> dstho_nhom { get; set; }
        // related = singular
        public Tho truongnhom { get; set; }
    }
}
