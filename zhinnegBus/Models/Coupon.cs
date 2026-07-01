namespace zhinnegBus.Models
{
    public class Coupon
    {
        /// <summary>优惠券主键ID</summary>
        public int Id { get; set; }
        /// <summary>优惠券名称</summary>
        public string? CouponName { get; set; }
        /// <summary>优惠券图片路径</summary>
        public string? ImgPath { get; set; }
        /// <summary>兑换所需积分</summary>
        public int CostPoint { get; set; }
        /// <summary>抵扣金额</summary>
        public decimal DiscountMoney { get; set; }
        /// <summary>有效天数</summary>
        public int ValidDay { get; set; }
        /// <summary>标签描述（如热门、限时）</summary>
        public string? Tag { get; set; }
        /// <summary>是否免费领取</summary>
        public bool IsFree { get; set; }
        /// <summary>兑换销量（用于热门排序）</summary>
        public int SaleCount { get; set; }
    }
}