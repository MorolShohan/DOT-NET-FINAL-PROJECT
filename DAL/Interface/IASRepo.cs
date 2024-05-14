using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IASRepo<CLASS, ID, RET, RET2>
    {




        List<CLASS> Read();
        List<CLASS> NotApprove();
        List<RET2> ReadMonthly();


        CLASS GetID(ID id);
        RET Update(ID id);

        bool Delete(ID id);


    }
}
