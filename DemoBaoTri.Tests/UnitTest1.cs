using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoBaoTri.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KiemTra_TinhPhiMoMo_Dung()
        {
            // Sửa chữ Program thành DemoBaoTriPhanMem.ThanhToan ở đây:
            double ketQuaThucTe = DemoBaoTriPhanMem.ThanhToan.TinhTongTien(100000);
            double ketQuaMongDoi = 105000;

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(ketQuaMongDoi, ketQuaThucTe);
        }
    }
}