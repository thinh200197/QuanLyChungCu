using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.DTO
{
    public static class Common
    {
        public static class ServiceStatus
        {
            public static string Cancel = "Hủy";
            public static string Inactive = "Tạm ngưng";
            public static string Active = "Hoạt động";

            public static string GetNameByValue(string value)
            {
                if (string.IsNullOrEmpty(value))
                {
                    return string.Empty;
                }

                if (value == Cancel)
                {
                    return nameof(Common.ServiceStatus.Cancel);
                }

                if (value == Active)
                {
                    return nameof(Common.ServiceStatus.Active);
                }

                if (value == Inactive)
                {
                    return nameof(Common.ServiceStatus.Inactive);
                }

                return string.Empty;
            }

            public static string GetValueByName(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    return string.Empty;
                }
                switch (name)
                {
                    case nameof(Common.ServiceStatus.Cancel):
                        return Common.ServiceStatus.Cancel;

                    case nameof(Common.ServiceStatus.Active):
                        return Common.ServiceStatus.Active;

                    case nameof(Common.ServiceStatus.Inactive):
                        return Common.ServiceStatus.Inactive;

                    default:
                        return string.Empty;
                }
            }
        }

        public static class ServiceCategogy
        {
            public static string DichVuDinhKy = "DVDK";
            public static string DichVuCongCong = "DVCC";
        }
    }
}
