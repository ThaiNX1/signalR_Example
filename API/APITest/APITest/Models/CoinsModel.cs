using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Models
{
    public class CoinsModel
    {
        /// <summary>
        /// Tên loại coin
        /// </summary>
        public string symbol { get; set; }
        /// <summary>
        /// Giá thay đổi
        /// </summary>
        public string priceChange { get; set; }
        /// <summary>
        /// Tỷ lệ % giá thay đổi
        /// </summary>
        public string priceChangePercent { get; set; }
        /// <summary>
        /// Giá trung bình
        /// </summary>
        public string weightedAvgPrice { get; set; }
        /// <summary>
        /// Giá trước đó
        /// </summary>
        public string prevClosePrice { get; set; }
        /// <summary>
        /// Giá cuối cùng
        /// </summary>
        public string lastPrice { get; set; }
        public string lastQty { get; set; }
        /// <summary>
        /// Giá cao nhất
        /// </summary>
        public string highPrice { get; set; }
        /// <summary>
        /// Giá thấp nhất
        /// </summary>
        public string lowPrice { get; set; }
        /// <summary>
        /// Khối lượng 
        /// </summary>
        public string volume { get; set; }
        /// <summary>
        /// Khối lượng 24h
        /// </summary>
        public string quoteVolume { get; set; }
    }
}
