using _3S_eShop.BLL.DTOs;
using _3S_eShop.DAL.DAOs;
using _3S_eShop.PatternDistinctive.DbBuilder.ConcreteBuilder;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3S_eShop.BLL
{
    internal class CouponBLL
    {
        private CouponDAO CouponDAO;

        public CouponBLL(CouponDAO couponDAO)
        {
            CouponDAO = couponDAO;
        }

        public bool Add(byte discountPercent, uint maxDiscountAmount, DateTime startDate, DateTime expirationDate, byte remainingUses)
        {
            try
            {
                CouponDTO couponDTO = new CouponBuilder()
                .SetDiscountPercent(discountPercent)
                .SetMaxDiscountAmount(maxDiscountAmount)
                .SetStartDate(startDate)
                .SetStatus(true)
                .SetExpirationDate(expirationDate)
                .SetRemainingUses(remainingUses)
                .Build();
                CouponDAO.Add(couponDTO);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(long id, byte discountPercent, uint maxDiscountAmount, DateTime startDate, DateTime expirationDate, byte remainingUses)
        {
            try
            {
                CouponDTO couponDTO = new CouponBuilder()
                .SetId(id)
                .SetDiscountPercent(discountPercent)
                .SetMaxDiscountAmount(maxDiscountAmount)
                .SetStartDate(startDate)
                .SetStatus(true)
                .SetExpirationDate(expirationDate)
                .SetRemainingUses(remainingUses)
                .Build();
                CouponDAO.Update(id, couponDTO);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool AnyMatch(string property, string value)
        {
            return CouponDAO.AnyMatch(property, value);
        }

        public long GetUnusableCouponCount()
        {
            string query = $"select count(*) from {CouponDAO.TableName} " +
                $"where status = 0 or expiration_date < @now or remaining_uses = 0";
            return (long)DataProvider.Instance.ExecuteScalar(query, DateTime.Now);
        }

        public CouponDTO GetCoupon(string id_code)
        {
            return CouponDAO.GetById(Convert.ToInt64(id_code));
        }

        public CouponDTO ApplyCoupon(string id_code)
        {
            CouponDTO coupon = GetCoupon(id_code);
            if (coupon == null)
            {
                return null;
            }
            if (coupon.Status == false)
            {
                return null;
            }
            if (coupon.RemainingUses == 0)
            {
                return null;
            }
            if (coupon.ExpirationDate < DateTime.Now)
            {
                return null;
            }
            return coupon;
        }

    }
}
