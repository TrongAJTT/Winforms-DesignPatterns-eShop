using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;

namespace _3S_eShop.BLL
{
    internal class RewardPointBLL
    {
        private RewardPointDAO dao;

        public RewardPointBLL(RewardPointDAO rewardPointDAO)
        {
            this.dao = rewardPointDAO;
        }

        public void AddRewardPointForNewUser(long userId)
        {
            RewardPointDTO dto = new RewardPointBuilder().Default()
                .SetUserId(userId).Build();
            dao.Add(dto);
        }
    }
}
