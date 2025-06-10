using QuanLySieuThi.Models;
using QuanLySieuThi.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using QuanLySieuThi.Service;

namespace QuanLySieuThi.Forms
{
    public partial class NhapOTPForm : System.Windows.Forms.Form
    {
        private readonly IKhachHangService khachHangService;
        KhachHang khachHang;
        private bool isOtpEntered = false;
        private System.Timers.Timer otpTimer;

        private void OtpTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!isOtpEntered)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        TienIch.UIHelper.ShowMessageError("Mã OTP đã hết hạn. Vui lòng yêu cầu mã mới.");
                    }));
                }
                else
                {
                    TienIch.UIHelper.ShowMessageError("Mã OTP đã hết hạn. Vui lòng yêu cầu mã mới.");
                }
            }
        }

        public NhapOTPForm(KhachHang khachHang, IKhachHangService khachHangService)
        {
            InitializeComponent();
            this.khachHang = khachHang;
            this.khachHangService = khachHangService;

            otpTimer = new System.Timers.Timer(60000); // 1 phút = 60000 ms
            otpTimer.Elapsed += OtpTimer_Elapsed;
            otpTimer.AutoReset = false;
            otpTimer.Start();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaOTP.Text))
            {
                TienIch.UIHelper.ShowMessageError("Vui lòng nhập mã OTP.");
                return;
            }
            if (txtMaOTP.Text == "123456") // Giả sử mã OTP là 123456
            {
                TienIch.UIHelper.ShowMessage("Mã OTP hợp lệ. Đăng ký thành công!");
                Close();
            }
            else
            {
                TienIch.UIHelper.ShowMessageError("Mã OTP không hợp lệ. Vui lòng thử lại.");
            }
        }

        private void btnNewOTP_Click(object sender, EventArgs e)
        {
            TienIch.UIHelper.ShowMessage($"Mã OTP mới đã được gửi đến số điện thoại {khachHang.Sdt} của khách hàng.");
        }
    }
}
