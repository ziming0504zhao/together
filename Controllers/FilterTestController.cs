﻿using System.Web.Mvc;
using YiYouLun.Weixin.MP.MvcExtension;

namespace Drp.WeiXinWeb.Controllers
{
    /// <summary>
    /// 演示Choiskycn.Weixin.MP.MvcExtension.WeixinInternalRequestAttribute
    /// </summary>
    public class FilterTestController : Controller
    {
        [WeixinInternalRequest("访问被拒绝，请通过微信客户端访问！","nofilter")]
        public ContentResult Index()
        {
            return Content("访问正常。当前地址：" + Request.Url.PathAndQuery + "<br />请点击右上角转发按钮，使用【在浏览器中打开】功能进行测试！<br />或者也可以直接在外部浏览器打开http://weixin.senparc.com/FilterTest/进行测试。");
        }
    }
}