using System;
using System.Collections.Generic;
using DLPT.Entity.DataModel;

namespace DLPT.Interface.IDao
{
        public partial interface IAgentGenDao
        {

        /// <summary>
        ///  插入AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGen实体对象</param>
        /// <returns>新增的主键,如果有多个主键则返回第一个主键</returns>
		int InsertAgentGen(AgentGen agentGen);
        /// <summary>
        /// 修改AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGen实体对象</param>
        /// <returns>状态代码</returns>
        int UpdateAgentGen(AgentGen agentGen);
        /// <summary>
        /// 删除AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGen实体对象</param>
        /// <returns>状态代码</returns>
        int DeleteAgentGen(AgentGen agentGen);
        /// <summary>
        /// 根据主键获取AgentGen信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>AgentGen信息</returns>
        AgentGen FindByPk(int id);
        /// <summary>
        /// 获取所有AgentGen信息
        /// </summary>
        /// <returns>AgentGen列表</returns>
        IList<AgentGen> GetAll();
        /// <summary>
        /// 取得总记录数
        /// </summary>
        /// <returns>记录数</returns>
        long Count();
		/// <summary>
        ///  批量插入AgentGen
        /// </summary>
        /// <param name="agentGen">AgentGen实体对象列表</param>
        /// <returns>状态代码</returns>
        bool BulkInsertAgentGen(IList<AgentGen> agentGenList);
        /// <summary>
        ///  检索AgentGen，带翻页
        /// </summary>
        /// <param name="obj">AgentGen实体对象检索条件</param>
        /// <param name="pagesize">每页记录数</param>
        /// <param name="pageNo">页码</param>
        /// <returns>检索结果</returns>
        IList<AgentGen> GetListByPage(AgentGen obj, int pagesize, int pageNo);


        }
}