using System.Collections.Generic;

namespace DAL.Interface
{
    public interface mEarningRepo
    {
        List<decimal> CalculateMonthlyIncome(int courseId);
    }
}
