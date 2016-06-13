using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;
namespace Storage.DAL
{
    public class ExportProductDal:BaseDal<ExportProduct>
    {
        public int Add(ExportProduct export)
        {
            return base.Add("Insert into ExportProduct values(@proid,@count,@exporttime,@price,@totalmoney,@cusid,@userid)",export);
        }
        public int Delete(ExportProduct export)
        {
            return base.Delete("Update ExportProduct set IsDel=@isdel where id=@id",export);
        }
        public int Update(ExportProduct export)
        {
            return base.Update("Update ExportProduct set Proid=@proid,Count=@count,ExportTime=@exporttime,Price=@price,TotalMoney=@totalmoney,Cusid=@cusid,UserId=@userid where Id=@id",export);
        }
        public IEnumerable<ExportProduct> GetSignleEntities()
        {
            return base.GetSignleEntities("select * from ExportProduct where IsDel=0",null);
        }
    }
}
