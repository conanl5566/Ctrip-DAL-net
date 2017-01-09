using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Arch.Data;
using Arch.Data.DbEngine;
using DLPT.Entity.DataModel;
using DLPT.Interface.IDao;

namespace DLPT.Dao
{
    /// <summary>
    ///
    /// </summary>
    public partial class AgentGenDao : IAgentGenDao
    {
        readonly BaseDao baseDao = BaseDaoFactory.CreateBaseDao("dao_test");
        
        //特别注意，如果是可空类型，建议以如下方式使用：
        // var data = reader["field"];
        // entity.stringData = data == null ? data : data.ToString();
        //如需要手工映射，请反注释如下代码，并注意转换类型
        /*
        /// <summary>
        /// 手工映射，建议使用1.2.0.5版本以上的VisitDataReader
        /// </summary>
        /// <returns>结果</returns>
        public AgentGen OrmByHand(string sql)
        {
            try
            {
                return baseDao.VisitDataReader<AgentGen>(sql, (reader) =>
                {
                    AgentGen entity = new AgentGen();
					if(reader.Read())
					{
                        entity.Id = reader["Id"];
                        entity.Name = reader["Name"];
                    }
                    return entity;
                });

                //AgentGen entity = new AgentGen();
                //using(var reader = baseDao.SelectDataReader(sql))
                //{
					//if(reader.Read())
					//{
                        //entity.Id = reader["Id"];
                        //entity.Name = reader["Name"];
	                //}
                //}
                //return entity;
            }
            catch (Exception ex)
            {
                throw new DalException("调用AgentGenDao时，访问OrmByHand时出错", ex);
            }
        }
        */
        /// <summary>
        ///  插入AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGen实体对象</param>
        /// <returns>新增的主键,如果有多个主键则返回第一个主键</returns>
		public int InsertAgentGen(AgentGen agentGen)
        {
            try
            {
                Object result = baseDao.Insert<AgentGen>(agentGen);
			    int iReturn = Convert.ToInt32(result);
                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("调用AgentGen时，访问Insert时出错", ex);
            }
        }
        /// <summary>
        /// 修改AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGen实体对象</param>
        /// <returns>状态代码</returns>
        public int UpdateAgentGen(AgentGen agentGen)
        {
            try
            {
                Object result = baseDao.Update<AgentGen>(agentGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("调用AgentGen时，访问Update时出错", ex);
            }
        }
        /// <summary>
        /// 删除AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGen实体对象</param>
        /// <returns>状态代码</returns>
        public int DeleteAgentGen(AgentGen agentGen)
        {
            try
            {
                Object result = baseDao.Delete<AgentGen>(agentGen);
                int iReturn = Convert.ToInt32(result);

                return iReturn;
            }
            catch (Exception ex)
            {
                throw new DalException("调用AgentGen时，访问Delete时出错", ex);
            }
        }
        /// <summary>
        /// 根据主键获取AgentGen信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>AgentGen信息</returns>
        public AgentGen FindByPk(int id )
        {
            try
            {
                return baseDao.GetByKey<AgentGen>(id);
            }
            catch (Exception ex)
            {
                throw new DalException("调用AgentGenDao时，访问FindByPk时出错", ex);
            }
        }
        /// <summary>
        /// 获取所有AgentGen信息
        /// </summary>
        /// <returns>AgentGen列表</returns>
        public IList<AgentGen> GetAll()
        {
            try
            {
                return baseDao.GetAll<AgentGen>();
            }
            catch (Exception ex)
            {
                throw new DalException("调用AgentGenDao时，访问GetAll时出错", ex);
            }
        }
        /// <summary>
        /// 取得总记录数
        /// </summary>
        /// <returns>记录数</returns>
        public long Count()
        {
            try
            {
                String sql = "SELECT count(1) from agent    ";
                object obj = baseDao.ExecScalar(sql);
                long ret = Convert.ToInt64(obj);
                return ret;
            }
            catch (Exception ex)
            {
                throw new DalException("调用AgentGenDao时，访问Count时出错", ex);
            }
        }
        /// <summary>
        ///  检索AgentGen，带翻页
        /// </summary>
        /// <param name="obj">AgentGen实体对象检索条件</param>
        /// <param name="pagesize">每页记录数</param>
        /// <param name="pageNo">页码</param>
        /// <returns>检索结果</returns>
        public IList<AgentGen> GetListByPage(AgentGen obj, int pagesize, int pageNo)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder(200);

                sbSql.Append(@"select Id, Name from agent ");
                sbSql.Append(" order by Id desc ");
                sbSql.Append(string.Format("limit {0}, {1} ", (pageNo - 1) * pagesize, pagesize));
                IList<AgentGen> list = baseDao.SelectList<AgentGen>(sbSql.ToString());
                return list;
            }
            catch (Exception ex)
            {
                throw new DalException("调用AgentGenDao时，访问GetListByPage时出错", ex);
            }
        }

		/// <summary>
        ///  批量插入AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGen实体对象列表</param>
        /// <returns>状态代码</returns>
        public bool BulkInsertAgentGen(IList<AgentGen> agentGenList)
		{
            try
            {
                return baseDao.BulkInsert<AgentGen>(agentGenList);
            }
            catch (Exception ex)
            {
                throw new DalException("调用AgentGenDao时，访问BulkInsert时出错", ex);
            }
        }

        
    }
}