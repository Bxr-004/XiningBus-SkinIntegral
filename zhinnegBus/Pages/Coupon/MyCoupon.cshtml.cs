using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using zhinnegBus.Models;

namespace zhinnegBus.Pages.Coupon
{
    public class MyCouponModel : PageModel
    {
        public List<Coupon> OwnCouponList { get; set; } = new List<Coupon>();

        // 和积分商城完全一致的优惠券数据源
        private static readonly List<Coupon> AllCoupons = new List<Coupon>()
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
            // 直接读取全局统一存储的已兑换优惠券ID
            var ownedIds = UserData.OwnedCouponIds;
            OwnCouponList = AllCoupons.Where(c => ownedIds.Contains(c.Id)).ToList();
        }
    }
}