using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using zhinnegBus.Models;

namespace zhinnegBus.Pages
{
    public class SkinDetailModel : PageModel
    {
        // 当前预览的皮肤
        public Skin CurrentSkin { get; set; }
        // 判断用户是否已拥有该皮肤
        public bool IsOwned { get; set; }

        // 和SkinShop完全统一的皮肤数据源，路径全部改为skinX
        private readonly List<Skin> AllSkinData = new()
{
    new Skin
    {
        Id = 1,
        SkinName = "爱自己是终身幸福",
        Category = "治愈文字风",
        ImgPath = "/img/skin1.jpg",
        PreviewImg = "/img/preview/skin1_screen.png",
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
        PreviewImg = "/img/preview/skin2_screen.png",
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
        PreviewImg = "/img/preview/skin3_screen.png",
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
        PreviewImg = "/img/preview/skin4_screen.png",
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
        PreviewImg = "/img/preview/skin5_screen.png",
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
        PreviewImg = "/img/preview/skin6_screen.png",
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
        PreviewImg = "/img/preview/skin7_screen.png",
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
        PreviewImg = "/img/preview/skin8_screen.png",
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
        PreviewImg = "/img/preview/skin9_screen.png",
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
        PreviewImg = "/img/preview/skin10_screen.png",
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
        PreviewImg = "/img/preview/skin11_screen.png",
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
        PreviewImg = "/img/preview/skin12_screen.png",
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
        PreviewImg = "/img/preview/skin13_screen.png",
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
        PreviewImg = "/img/preview/skin14_screen.png",
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
        PreviewImg = "/img/preview/skin15_screen.png",
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
        PreviewImg = "/img/preview/skin16_screen.png",
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
        PreviewImg = "/img/preview/skin17_screen.png",
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
        PreviewImg = "/img/preview/skin18_screen.png",
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
        PreviewImg = "/img/preview/skin19_screen.png",
        IsUnlock = false,
        CostPoint = 15,
        Tag = "清新花卉",
        IsFree = false,
        Price = 3.99m
    }
};

        // 接收路由皮肤ID：/SkinDetail?skinId=1
        public void OnGet(int skinId)
        {
            CurrentSkin = AllSkinData.FirstOrDefault(s => s.Id == skinId);
            // 皮肤不存在跳回商城
            if (CurrentSkin == null)
            {
                RedirectToPage("/SkinShop");
                return;
            }
            // 判断是否已经兑换
            IsOwned = UserData.OwnedSkinIds.Contains(skinId);
        }

        // 兑换皮肤接口
        public IActionResult OnPostExchange(int skinId)
        {
            var targetSkin = AllSkinData.First(s => s.Id == skinId);
            // 校验1：已拥有
            if (UserData.OwnedSkinIds.Contains(skinId))
                return new JsonResult(new { success = false, msg = "你已经拥有该皮肤，无需重复兑换！" });
            // 校验2：积分不足
            if (UserData.UserPoint < targetSkin.CostPoint)
                return new JsonResult(new { success = false, msg = "积分不足，无法兑换！" });

            // 扣积分+存入已拥有列表
            UserData.UserPoint -= targetSkin.CostPoint;
            UserData.OwnedSkinIds.Add(skinId);
            return new JsonResult(new { success = true, msg = "兑换成功！现在可以使用该皮肤" });
        }

        // 使用皮肤接口（切换全局皮肤）
        public IActionResult OnPostUse(int skinId)
        {
            // 必须先拥有才能使用
            if (!UserData.OwnedSkinIds.Contains(skinId))
                return new JsonResult(new { success = false, msg = "请先兑换皮肤后再使用！" });
            // 修改全局当前皮肤ID
            UserData.CurrentUseSkinId = skinId;
            return new JsonResult(new { success = true, msg = "皮肤更换成功，全站页面已生效！" });
        }
    }
}