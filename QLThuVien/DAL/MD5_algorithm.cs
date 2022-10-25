using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAL
{
    public class MD5_algorithm
    {
        public String MaHoaString(String giatriCanMa, String matKhau)
        {
            byte[] bGiaTriCanMa = Encoding.UTF8.GetBytes(giatriCanMa);
            byte[] bMatKhau = Encoding.UTF8.GetBytes(matKhau);
            byte[] ketQua = MaHoa(bGiaTriCanMa, bMatKhau);
            return Convert.ToBase64String(ketQua);
        }

        public String GiaiMaSring(String giatriCanGiaiMa, String matKhau)
        {
            byte[] bGiaTriCanGiaiMa = Convert.FromBase64String(giatriCanGiaiMa);
            byte[] bMatKhau = Encoding.UTF8.GetBytes(matKhau);
            byte[] ketQua = GiaiMa(bGiaTriCanGiaiMa, bMatKhau);
            return Encoding.UTF8.GetString(ketQua);
        }

        public byte[] MaHoa(byte[] giatriCanMa, byte[] matKhau)
        {
            //Lấy mật khẩu thông qua md5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] keys = md5.ComputeHash(matKhau);

            //Tạo bộ cài đặt mã hoá
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = keys;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;

            //Tạo bộ mã hoá và mã hoá
            ICryptoTransform transform = trip.CreateEncryptor();
            return transform.TransformFinalBlock(giatriCanMa, 0, giatriCanMa.Length);
        }

        public byte[] GiaiMa(byte[] giatriCanGiaiMa, byte[] matKhau)
        {
            //Lấy mật khẩu thông qua md5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] keys = md5.ComputeHash(matKhau);

            //Tạo bộ cài đặt mã hoá
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = keys;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;

            //Tạo bộ mã hoá và mã hoá
            ICryptoTransform transform = trip.CreateDecryptor();
            return transform.TransformFinalBlock(giatriCanGiaiMa, 0, giatriCanGiaiMa.Length);
        }
    }
}

