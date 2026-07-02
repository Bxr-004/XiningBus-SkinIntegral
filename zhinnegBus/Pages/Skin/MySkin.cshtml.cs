using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using zhinnegBus.Models;

namespace zhinnegBus.Pages.Skin
{
    public class MySkinModel : PageModel
    {
        public List<Skin> MySkinList { get; set; } = new List<Skin>();
        // 当前正在使用的皮肤
        public Skin CurrentUseSkin { get; set; }

        public void OnGet()
        {
            var shopPage = new SkinShopModel();
            var allSkinData = shopPage.SkinList;
            var ownSkinIds = shopPage.GetOwnedSkinIds();

            MySkinList = allSkinData.Where(s => ownSkinIds.Contains(s.Id)).ToList();
            // 匹配当前启用皮肤
            CurrentUseSkin = allSkinData.FirstOrDefault(s => s.Id == UserData.CurrentUseSkinId);
        }

        // 切换皮肤接口
        public IActionResult OnPostUseSkin(int skinId)
        {
            var shopPage = new SkinShopModel();
            var allSkinData = shopPage.SkinList;
            var ownSkinIds = shopPage.GetOwnedSkinIds();

            // 校验是否拥有该皮肤
            if (!ownSkinIds.Contains(skinId))
            {
                return new JsonResult(new { success = false, msg = "你未拥有该皮肤，无法使用" });
            }
            // 修改全局启用皮肤ID
            UserData.CurrentUseSkinId = skinId;
            return new JsonResult(new { success = true, msg = "皮肤切换成功，全站页面已生效" });
        }
    }
}