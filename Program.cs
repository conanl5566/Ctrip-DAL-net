using Arch.Data.Common.constant;
using DLPT;
using DLPT.Interface.IDao;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Arch.Data.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDao dao = BaseDaoFactory.CreateBaseDao("dao_test");
            IAgentGenDao agentGenDao = DALFactory.AgentGenDao;
            ////DLPT.Entity.DataModel.AgentGen AgentGenaa = new DLPT.Entity.DataModel.AgentGen();
            ////AgentGenaa.Id = 1;
            ////AgentGenaa.Name = "111";
            ////dao.Insert<DLPT.Entity.DataModel.AgentGen>(AgentGenaa);

            IDictionary<String, IList<String>> dict = new Dictionary<String, IList<String>> { { "0", new List<String> { "0", "1" } } };




            IDictionary hints = new Dictionary<String, Object>();
            IList<String> shards = new List<String> { "0", "1" };
             hints.Add(DALExtStatementConstant.TABLE_IDS, shards);
            var result = dao.ExecScalar("SELECT count(1) from agentGen_{0} where name='77'", null, hints);
            //"SELECT count(1) from agent_{0} where name='77'"

            // var result = dao.GetAll<DLPT.Entity.DataModel.AgentGen>(hints, Common.Enums.OperationType.Default);

            ////String sql = "SELECT count(1) from agent    ";
            ////object obj = dao.ExecScalar(sql);
            ////long ret = Convert.ToInt64(obj);

            //("select count(0) from  AgentGen ");
            Console.WriteLine(result);
            ////    IAgentGenDao agentGenDao = DALFactory.AgentGenDao;


            ////  //AgentGen orm = agentGenDao.OrmByHand("select * from table");
            ////  DLPT.Entity.DataModel.AgentGen AgentGen = new DLPT.Entity.DataModel.AgentGen();
            //////  AgentGen.Id = 1;
            ////  AgentGen.Name = "111";
            ////  int insertResult = agentGenDao.InsertAgentGen(AgentGen);
            ////  Console.WriteLine(insertResult);
            //  Console.ReadKey();


            Console.Read();
        }
    }
}