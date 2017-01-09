using DLPT.Interface.IDao;
using DLPT.Dao;

namespace DLPT
{
	/// <summary>
    /// DALFactory
    /// </summary>
	public partial class DALFactory
	{
        private static readonly IAgentGenDao agentGenDao = new AgentGenDao();

   

        /// <summary>
        /// Property AgentGenDao
        /// </summary>
        public static IAgentGenDao AgentGenDao
        {
            get
            {
                return agentGenDao;
            }
        }

    

	}
}