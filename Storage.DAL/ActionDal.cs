using System.Collections.Generic;
using Storage.Model;

namespace Storage.DAL
{
    public class ActionDal:BaseDal<Action>
    {
        public int Add(Action action)
        {
            return base.Add("", action);
        }

        public int Update(Action action)
        {
            return base.Update("", action);
        }

        public int Delete(Action action)
        {
            return base.Update("", action);
        }

        public IEnumerable<Action> GetSignleActions()
        {
            return base.GetSignleEntities("select id,actionNumber,actionName from actions where isdel = 0", null);
        } 
    }
}