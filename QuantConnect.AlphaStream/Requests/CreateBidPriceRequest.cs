﻿using QuantConnect.AlphaStream.Infrastructure;
using QuantConnect.AlphaStream.Models;
using RestSharp;

namespace QuantConnect.AlphaStream.Requests
{
    /// <summary>
    /// Create a bid price request.
    /// </summary>
    [Endpoint(Method.GET, "/alpha/{id}/prices/bids/create")]
    public class CreateBidPriceRequest : AttributeRequest<BidResponse>
    {
        /// <summary>
        /// Unique id hash of an Alpha published to the marketplace.
        /// </summary>
        [PathParameter("id")]
        public string Id { get; set; }

        /// <summary>
        /// Unique id hash of an Alpha published to the marketplace.
        /// </summary>
        [QueryParameter("bid")]
        public int Bid { get; set; }

        /// <summary>
        /// Bid for the exclusive price (optional if shared is defined).
        /// </summary>
        [QueryParameter("allocation")]
        public int Allocation { get; set; }

        /// <summary>
        /// Bid for the shared price (optional if exclusive is defined).
        /// </summary>
        [QueryParameter("period")]
        public int Period { get; set; }

        /// <summary>
        /// Expiration time of the bid.
        /// </summary>
        [QueryParameter("good-until")]
        public long GoodUntil { get; set; }
    }
}