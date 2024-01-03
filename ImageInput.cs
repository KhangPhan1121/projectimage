using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectimage
{
    public class ImageInput
    {
        public string Convert(string text)
        {
            // var a = text[0].ToString().ToUpper()+text.Substring(1).ToLower();
            var b = text.Replace(" ", "_");
            var a = text[0].ToString().ToUpper()+text.Substring(1).ToLower();

            return $"https://raw.githubusercontent.com/microsoft/fluentui-emoji/main/assets/{a}/3D/{b.ToLower()}_3d.png".Trim();
        }
    }
}