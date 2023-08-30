using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemImage
    {
        public int ImgId { get; set; }
        public int? ItemCardId { get; set; }
        public byte[] Image { get; set; }
        public string ImgDesc1 { get; set; }
        public string ImgDesc2 { get; set; }
        public string ImgPath { get; set; }
        public string ImgPath2 { get; set; }
        public string ImgPath3 { get; set; }
        public string ImgPath4 { get; set; }
        public string ImgPath5 { get; set; }
        public string ImgPath6 { get; set; }

        public virtual MsItemCard ItemCard { get; set; }
    }
}
