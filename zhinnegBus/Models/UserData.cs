using System.Collections.Generic;

namespace zhinnegBus.Models
{
    public static class UserData
    {
        // 全局统一积分，皮肤商城、积分商城共用
        public static int UserPoint = 100;
        // 已兑换皮肤ID集合
        public static readonly List<int> OwnedSkinIds = new List<int>();
        // 已兑换优惠券ID集合
        public static readonly List<int> OwnedCouponIds = new List<int>();
        // 新增：当前全站正在使用的皮肤ID，0代表默认无皮肤
        public static int CurrentUseSkinId = 0;
    }
}