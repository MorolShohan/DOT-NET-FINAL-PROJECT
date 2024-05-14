using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IMRepo<CLASS, ID, RET>
    {




        RET Create(CLASS obj);
        bool Delete(ID id);
        RET Get(ID id);
        RET Update(CLASS obj);
        RET UpdateReply(CLASS obj);
        List<CLASS> Read(ID id);
        List<CLASS> TRead(ID id);



    }
}
