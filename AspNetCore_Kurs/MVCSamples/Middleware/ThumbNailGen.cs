﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace MVCSamples.Middleware
{
    public class ThumbNailGen
    {
        public ThumbNailGen(RequestDelegate next)
        {

        }

        public async Task Invoke(HttpContext context)
        {
            var img = context.Request.Query["img"][0];

            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + img;

            using (var sr = new FileStream(pfad, FileMode.Open))
            {
                using (var image = new System.Drawing.Bitmap(sr))
                {
                    var resized = new System.Drawing.Bitmap(300, 200);

                    using (var graphics = System.Drawing.Graphics.FromImage(resized))
                    {
                        graphics.DrawImage(image, 0, 0, 300, 200);
                        var ms = new MemoryStream();

                        resized.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        await context.Response.Body.WriteAsync(ms.ToArray());

                    }
                }
            }
        }
    }


    public static class ThumbNailsExtensions
    {
        public static IApplicationBuilder UseThumbnailGen(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ThumbNailGen>();
        }
    }
}
