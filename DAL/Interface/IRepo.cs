using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IRepo<CLASS, ID, RET, ID2>
    {


        List<CLASS> Get();
        CLASS Get(ID key);
        RET Get(CLASS obj);
        bool Delete(ID id);
        RET Add(CLASS obj);
        CLASS Reademail(ID2 id);

        RET Update(CLASS obj);

    }
}
