using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using zhinnegBus.Models;

namespace zhinnegBus.Pages.Skin
{
    public class SkinShopModel : PageModel
    {
        // 页面展示皮肤列表
        public List<Skin> SkinList { get; set; } = new List<Skin>();

        // 构造函数：每次页面实例都会加载皮肤，GET/POST都有数据
        public SkinShopModel()
        {
            SkinList = new List<Skin>()
{
    new Skin
    {
        Id = 1,
        SkinName = "爱自己是终身幸福",
        Category = "治愈文字风",
        ImgPath = "/img/skin1.jpg",
        IsUnlock = false,
        CostPoint = 9,
        Tag = "温柔治愈短句",
        IsFree = false,
        Price = 1.99m
    },
    new Skin
    {
        Id = 2,
        SkinName = "暮山策马",
        Category = "古风",
        ImgPath = "/img/skin2.jpg",
        IsUnlock = false,
        CostPoint = 299,
        Tag = "江湖山河侠客",
        IsFree = false,
        Price = 16.99m
    },
    new Skin
    {
        Id = 3,
        SkinName = "哆啦A梦奶茶毛绒",
        Category = "动漫风",
        ImgPath = "/img/skin3.jpg",
        IsUnlock = false,
        CostPoint = 149,
        Tag = "治愈奶茶蓝胖子",
        IsFree = false,
        Price = 7.99m
    },
    new Skin
    {
        Id = 4,
        SkinName = "疯狂动物城朱迪尼克新年",
        Category = "动漫风",
        ImgPath = "/img/skin4.jpg",
        IsUnlock = false,
        CostPoint = 169,
        Tag = "疯狂动物城新年限定",
        IsFree = false,
        Price = 9.99m
    },
    new Skin
    {
        Id = 5,
        SkinName = "首要万事开心",
        Category = "治愈文字风",
        ImgPath = "/img/skin5.jpg",
        IsUnlock = false,
        CostPoint = 11,
        Tag = "清新海边治愈",
        IsFree = false,
        Price = 2.49m
    },
    new Skin
    {
        Id = 6,
        SkinName = "最好的一天是今天",
        Category = "治愈文字风",
        ImgPath = "/img/skin6.jpg",
        IsUnlock = false,
        CostPoint = 12,
        Tag = "浪漫氛围感",
        IsFree = false,
        Price = 2.99m
    },
    new Skin
    {
        Id = 7,
        SkinName = "猫和老鼠复古报纸",
        Category = "动漫风",
        ImgPath = "/img/skin7.jpg",
        IsUnlock = false,
        CostPoint = 159,
        Tag = "经典怀旧猫和老鼠",
        IsFree = false,
        Price = 8.99m
    },
    new Skin
    {
        Id = 8,
        SkinName = "奶白兔子蛋糕",
        Category = "简约风",
        ImgPath = "/img/skin8.jpg",
        IsUnlock = false,
        CostPoint = 10,
        Tag = "温柔奶油风",
        IsFree = false,
        Price = 2.99m
    },
    new Skin
    {
        Id = 9,
        SkinName = "浅白小狗简笔画",
        Category = "简约风",
        ImgPath = "/img/skin9.jpg",
        IsUnlock = false,
        CostPoint = 0,
        Tag = "简约治愈免费款",
        IsFree = true,
        Price = 0.00m
    },
    new Skin
    {
        Id = 10,
        SkinName = "浅蓝水面小花",
        Category = "简约风",
        ImgPath = "/img/skin10.jpg",
        IsUnlock = false,
        CostPoint = 15,
        Tag = "清冷浅蓝调",
        IsFree = false,
        Price = 3.99m
    },
    new Skin
    {
        Id = 11,
        SkinName = "人生是旷野",
        Category = "治愈文字风",
        ImgPath = "/img/skin11.jpg",
        IsUnlock = false,
        CostPoint = 12,
        Tag = "开阔治愈风景",
        IsFree = false,
        Price = 2.99m
    },
    new Skin
    {
        Id = 12,
        SkinName = "万事顺遂好运",
        Category = "治愈文字风",
        ImgPath = "/img/skin12.jpg",
        IsUnlock = false,
        CostPoint = 0,
        Tag = "可爱祈福免费款",
        IsFree = true,
        Price = 0.00m
    },
    new Skin
    {
        Id = 13,
        SkinName = "柿柿如意Q版女孩小猫",
        Category = "动漫风",
        ImgPath = "/img/skin13.jpg",
        IsUnlock = false,
        CostPoint = 0,
        Tag = "国风Q版免费款",
        IsFree = true,
        Price = 0.00m
    },
    new Skin
    {
        Id = 14,
        SkinName = "云裳花容",
        Category = "古风",
        ImgPath = "/img/skin14.jpg",
        IsUnlock = false,
        CostPoint = 0,
        Tag = "瘦金书法免费款",
        IsFree = true,
        Price = 0.00m
    },
    new Skin
    {
        Id = 15,
        SkinName = "墨竹书蝶",
        Category = "古风",
        ImgPath = "/img/skin15.jpg",
        IsUnlock = false,
        CostPoint = 269,
        Tag = "水墨国风书法",
        IsFree = false,
        Price = 14.99m
    },
    new Skin
    {
        Id = 16,
        SkinName = "星空花海哆啦A梦",
        Category = "动漫风",
        ImgPath = "/img/skin16.jpg",
        IsUnlock = false,
        CostPoint = 189,
        Tag = "梦幻星空限定",
        IsFree = false,
        Price = 11.99m
    },
    new Skin
    {
        Id = 17,
        SkinName = "清宵剑影",
        Category = "古风",
        ImgPath = "/img/skin17.jpg",
        IsUnlock = false,
        CostPoint = 289,
        Tag = "暗夜清冷侠女",
        IsFree = false,
        Price = 15.99m
    },
    new Skin
    {
        Id = 18,
        SkinName = "月下白衣",
        Category = "古风",
        ImgPath = "/img/skin18.jpg",
        IsUnlock = false,
        CostPoint = 289,
        Tag = "黑白水墨古风",
        IsFree = false,
        Price = 15.99m
    },
    new Skin
    {
        Id = 19,
        SkinName = "紫黄郁金香",
        Category = "简约风",
        ImgPath = "/img/skin19.jpg",
        IsUnlock = false,
        CostPoint = 15,
        Tag = "清新花卉",
        IsFree = false,
        Price = 3.99m
    }
};
        }

        public void OnGet()
        {

        }

        /// <summary>
        /// 兑换皮肤接口
        /// </summary>
        public IActionResult OnPostExchange(int skinId)
        {
            var targetSkin = SkinList.FirstOrDefault(s => s.Id == skinId);
            if (targetSkin == null)
            {
                return new JsonResult(new { success = false, msg = "皮肤不存在！" });
            }

            if (UserData.OwnedSkinIds.Contains(skinId))
            {
                return new JsonResult(new { success = false, msg = "你已经拥有这款皮肤啦！" });
            }

            if (!targetSkin.IsFree)
            {
                if (UserData.UserPoint < targetSkin.CostPoint)
                {
                    return new JsonResult(new { success = false, msg = $"积分不足！需要{targetSkin.CostPoint}积分，当前{UserData.UserPoint}积分" });
                }
                UserData.UserPoint -= targetSkin.CostPoint;
            }

            UserData.OwnedSkinIds.Add(skinId);
            targetSkin.SaleCount++;
            return new JsonResult(new { success = true, msg = "领取成功！前往「我的皮肤」查看" });
        }

        /// <summary>
        /// 对外提供已拥有皮肤ID集合，供MySkin页面调用
        /// </summary>
        public List<int> GetOwnedSkinIds()
        {
            return UserData.OwnedSkinIds;
        }
    }
}