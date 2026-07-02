using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using zhinnegBus.Models;

namespace zhinnegBus.Pages.Coupon
{
    public class PointMallModel : PageModel
    {
        public List<Coupon> CouponList { get; set; } = new List<Coupon>();
        public int UserPoint { get; set; }

        private static readonly List<Coupon> _staticAllCoupons = new List<Coupon>()
        {
            new Coupon
            {
                Id = 1,
                CouponName = "1元乘车抵扣券",
                ImgPath = "/img/coupon1.jpg",
                CostPoint = 10,
                DiscountMoney = 1,
                ValidDay = 30,
                Tag = "热门",
                IsFree = false,
                SaleCount = 15
            },
            new Coupon
            {
                Id = 2,
                CouponName = "单次乘车免单券",
                ImgPath = "/img/coupon2.jpg",
                CostPoint = 50,
                DiscountMoney = 2,
                ValidDay = 30,
                Tag = "限量",
                IsFree = false,
                SaleCount = 9
            }
        };

        public void OnGet()
        {
            UserPoint = UserData.UserPoint;
            CouponList = _staticAllCoupons.ToList();
        }

        public async Task<IActionResult> OnPostExchangeAsync(int couponId)
        {
            var coupon = _staticAllCoupons.FirstOrDefault(c => c.Id == couponId);
            if (coupon == null)
                return new JsonResult(new { success = false, msg = "优惠券不存在！" });

            if (UserData.OwnedCouponIds.Contains(couponId))
                return new JsonResult(new { success = false, msg = "你已经拥有该优惠券！" });

            if (!coupon.IsFree)
            {
                if (UserData.UserPoint < coupon.CostPoint)
                    return new JsonResult(new { success = false, msg = $"积分不足！需要{coupon.CostPoint}积分，当前{UserData.UserPoint}积分" });
                UserData.UserPoint -= coupon.CostPoint;
            }

            UserData.OwnedCouponIds.Add(couponId);
            coupon.SaleCount++;
            return new JsonResult(new { success = true, msg = "兑换成功！前往我的优惠券查看" });
        }

        public List<int> GetOwnedCouponIds()
        {
            return UserData.OwnedCouponIds;
        }
    }
}