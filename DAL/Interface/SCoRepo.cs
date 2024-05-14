using System.Collections.Generic;

namespace DAL.Interface
{
    public interface SCoRepo<CLASS, ID, RET, ID2>
    {
        CLASS Create(CLASS obj);

        List<CLASS> GetCourses();

        bool BuyCourse(ID id, ID2 courseId);

        bool Delete(ID id);
    }

}
