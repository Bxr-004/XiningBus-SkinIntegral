using System;

namespace zhinnegBus.Models;

public class SkinOrder
{
    public int Id { get; set; }
    // 用户ID
    public int UserId { get; set; }
    // 对应皮肤ID
    public int SkinId { get; set; }
    // 下单时间
    public DateTime BuyTime { get; set; }

    // 新增：订单类型（免费领取 / 积分兑换 / 付费购买）
    public string OrderType { get; set; }
    // 本次消耗积分
    public int CostPoint { get; set; }
    // 本次付费金额
    public decimal PayMoney { get; set; }
}