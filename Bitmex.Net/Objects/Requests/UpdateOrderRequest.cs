﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace   Bitmex.Net.Client.Objects.Requests
{  
    /// <summary>
    /// Parameters for order updating
    /// </summary>
    public class UpdateOrderRequest
    {
        public UpdateOrderRequest()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newPrice">new price for order</param>
        /// <param name="orderId">exchange order id</param>
        /// <param name="clientOrderId">your order id, sended at posting order</param>
        public UpdateOrderRequest(decimal newPrice, string orderId = null, string clientOrderId = null)
        {
            Price = newPrice;
            Id = orderId;
            OrigClOrdId = clientOrderId;
        }
       
        [JsonProperty("orderID")]
        public string Id { get; set; }
        /// <summary>
        /// Client Order ID. See POST /order.
        /// </summary>
        [JsonProperty("origClOrdID")]
        public string OrigClOrdId { get; set; }
        /// <summary>
        /// Optional new Client Order ID, requires origClOrdID.
        /// </summary>
        [JsonProperty("clOrdID")]
        public string ClOrdId { get; set; }
        /// <summary>
        /// Optional order quantity in units of the instrument (i.e. contracts).
        /// </summary>
        [JsonProperty("orderQty")] 
        public decimal? OrderQty { get; set; }
        /// <summary>
        /// Optional leaves quantity in units of the instrument (i.e. contracts). Useful for amending partially filled orders.
        /// </summary>
        [JsonProperty("leavesQty")] 
        public decimal? LeavesQty { get; set; }
        /// <summary>
        /// Optional trigger price for 'Stop', 'StopLimit', 'MarketIfTouched', and 'LimitIfTouched' orders. Use a price below the current price for stop-sell orders and buy-if-touched orders.
        /// </summary>
        [JsonProperty("stopPx")]
        public decimal? StopPx { get; set; }
        /// <summary>
        /// Optional trailing offset from the current price for 'Stop', 'StopLimit', 'MarketIfTouched', and 'LimitIfTouched' orders; use a negative offset for stop-sell orders and buy-if-touched orders. Optional offset from the peg price for 'Pegged' orders.
        /// </summary>
        [JsonProperty("pegOffsetValue")]
        public decimal? PegOffsetValue { get; set; }
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Optional amend annotation. e.g. 'Adjust skew'.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

    }
}
