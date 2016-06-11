using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Storage.DAL
{
    public class BaseDal<T> where T:class ,new ()
    {
        private readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        #region 基本增删改 返回受影响行数
        public int Add(string sql, T entity)
        {
            using (var conn = new SqlConnection(conStr))
            {
                return conn.Execute(sql, entity);
            }
        }

        public int Update(string sql, T entity)
        {
            using (var conn = new SqlConnection(conStr))
            {
                return conn.Execute(sql, entity);
            }
        }

        public int Delete(string sql, T entity)
        {
            using (var conn = new SqlConnection(conStr))
            {
                return conn.Execute(sql, entity);
            }
        } 
        #endregion

        /// <summary>
        /// 获取单个表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public IEnumerable<T> GetSignleEntities(string sql,T entity)
        {
            using (var conn = new SqlConnection(conStr))
            {
                return conn.Query<T>(sql,entity);
            }
        }

        public IEnumerable<TReturn> GetEntities<TFirst,TSecond,TReturn>(string sql,Func<TFirst,TSecond,TReturn> map,Object param = null)
        {
            using (var conn = new SqlConnection(conStr))
            {
                return conn.Query(sql,map,param);
            }
        } 
    }
}