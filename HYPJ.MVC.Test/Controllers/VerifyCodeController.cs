﻿using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using HYPJ.Utilities.Helper;
using System.Web;
using System;

namespace HYPJ.MVC.Test.Controllers
{
    public class VerifyCodeController : Controller
    {
        public IActionResult Index()
        {
            (Bitmap bp, string code) = VerifyCodeHelper.CreateVerifyCode();

            string encryptCode = DESEncryptHelper.EncryptDES(code);
            WebHelper.WriteCookie("VerifyCode", encryptCode, 30);

            MemoryStream stream = new MemoryStream();
            bp.Save(stream, ImageFormat.Png);
            return File(stream.ToArray(), @"image/png");//返回FileContentResult图片
        }

        [ActionName("get")]
        public string GetVerifyCode(string cdoe)
        {
            try
            {
                string decodeCode = HttpUtility.UrlDecode(cdoe);
                string verifyCode = WebHelper.GetCookie("VerifyCode");
                return DESEncryptHelper.DecryptDES(verifyCode);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}