using System.Collections.Generic;

namespace MoshDbMigrator.Models.Repository
{
    public interface IGetRepository
    {
        void GetAll();
        void GetById(string id);
    }
}
