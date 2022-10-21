using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class DTO_borrow
    {
        public string issue_id { get; set; }
        public string book_id { get; set; }
        public string date_issue { get; set; }
        public string date_expirary { get; set; }
        public string student_id { get; set; }
        public string staff_id { get; set; }
    }
}
