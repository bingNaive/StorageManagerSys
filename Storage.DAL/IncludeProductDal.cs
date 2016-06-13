using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;
namespace Storage.DAL
{
    public class IncludeProductDal:BaseDal<IncludeProduct>
    {
        public int Add(IncludeProduct include)
        {
            return base.Add("insert into IncludeProduct values(@proid,@count,@price,@cusid,@includeTime,@userid)", include);
        }
        public int Delete(IncludeProduct include)
        {
            return base.Update("update IncludeProduct set IsDel=@isdel where id=@id",include);
        }
        public int Update(IncludeProduct include)
        {
            return base.Update("update IncludeProduct set ProId=@proid,Count=@count,Price=@price,CusId=@cusid,IncludeTime=@includeTime,UserId=@userid where id=@id",include);
        }
        public IEnumerable<IncludeProduct> GetSignleEntities()
        {
            return base.GetSignleEntities("select * from IncludeProduct where isDel = 0", null);
        }
    }
}
