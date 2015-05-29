using Microsoft.Prospecting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Mvc;

namespace Microsoft.Prospecting.Controllers
{
    [RoutePrefix("api/Offers")]
    public class OffersController : ApiController
    {
        public OffersController()
        {

        }
        // GET api/<controller>
        public IEnumerable<OffersModel> Get()
        {
            var offers = GetAllOffers();
            return offers;
        }

        [Route("GetAllOffers")]
        public List<OffersModel> GetAllOffers()
        {
            var offers = new List<OffersModel>
            {
                new OffersModel 
                {
                    MerchantName = "Microsoft Corporation",
                    City = "Redmond",
                    DealStatus = "Live",
                    OfferStartDate = "05-05-2015"
                },
                new OffersModel 
                {
                    MerchantName = "Starbucks",
                    City = "Multiple Locations",
                    DealStatus = "Live",
                    OfferStartDate = "05-10-2015"
                },
                new OffersModel 
                {
                    MerchantName = "Starbucks Online",
                    City = "Seattle",
                    DealStatus = "Live",
                    OfferStartDate = "05-10-2015"
                },
                new OffersModel 
                {
                    MerchantName = "Papa John's",
                    City = "Multiple Locations",
                    DealStatus = "Live",
                    OfferStartDate = "05-10-2014"
                },
                new OffersModel 
                {
                    MerchantName = "7 Eleven",
                    City = "Multiple Locations",
                    DealStatus = "Live",
                    OfferStartDate = "05-10-2015"
                },
                new OffersModel 
                {
                    MerchantName = "Pizza Hut",
                    City = "Multiple Locations",
                    DealStatus = "Live",
                    OfferStartDate = "05-10-2013"
                },
                new OffersModel 
                {
                    MerchantName = "OneDrive",
                    City = "Redmond",
                    DealStatus = "Live",
                    OfferStartDate = "02-12-2015"
                },
                new OffersModel 
                {
                    MerchantName = "Whole Foods",
                    City = "Multiple Locations",
                    DealStatus = "Live",
                    OfferStartDate = "02-11-2011"
                },
                new OffersModel 
                {
                    MerchantName = "Wingstop",
                    City = "Bellevue",
                    DealStatus = "Processing",
                    OfferStartDate = "02-12-2015"
                },
                new OffersModel 
                {
                    MerchantName = "Blue Martini",
                    City = "Bellevue",
                    DealStatus = "Pause",
                    OfferStartDate = "02-10-2014"
                },
                new OffersModel 
                {
                    MerchantName = "Blue Martini",
                    City = "Redmond",
                    DealStatus = "Live",
                    OfferStartDate = "02-11-2014"
                }
                ,
                new OffersModel 
                {
                    MerchantName = "Starbucks",
                    City = "Multiple Locations",
                    DealStatus = "Live",
                    OfferStartDate = "05-10-2015"
                },
                new OffersModel 
                {
                    MerchantName = "Starbucks Online",
                    City = "Seattle",
                    DealStatus = "Live",
                    OfferStartDate = "05-10-2015"
                },
                new OffersModel 
                {
                    MerchantName = "Papa John's",
                    City = "Multiple Locations",
                    DealStatus = "Live",
                    OfferStartDate = "05-10-2014"
                }
                //,new OffersModel 
                //{
                //    MerchantName = "7 Eleven",
                //    City = "Multiple Locations",
                //    DealStatus = "Live",
                //    OfferStartDate = "05-10-2015"
                //},
                //new OffersModel 
                //{
                //    MerchantName = "Pizza Hut",
                //    City = "Multiple Locations",
                //    DealStatus = "Live",
                //    OfferStartDate = "05-10-2013"
                //},
                //new OffersModel 
                //{
                //    MerchantName = "OneDrive",
                //    City = "Redmond",
                //    DealStatus = "Live",
                //    OfferStartDate = "02-12-2015"
                //},
                //new OffersModel 
                //{
                //    MerchantName = "Whole Foods",
                //    City = "Multiple Locations",
                //    DealStatus = "Live",
                //    OfferStartDate = "02-11-2011"
                //},
                //new OffersModel 
                //{
                //    MerchantName = "Wingstop",
                //    City = "Bellevue",
                //    DealStatus = "Processing",
                //    OfferStartDate = "02-12-2015"
                //},
                //new OffersModel 
                //{
                //    MerchantName = "Blue Martini",
                //    City = "Bellevue",
                //    DealStatus = "Pause",
                //    OfferStartDate = "02-10-2014"
                //},
                //new OffersModel 
                //{
                //    MerchantName = "Blue Martini",
                //    City = "Redmond",
                //    DealStatus = "Live",
                //    OfferStartDate = "02-11-2014"
                //}
            };
            return offers;
        }
        // GET api/<controller>/5
        public IEnumerable<OffersModel> Get(string id)
        {

            IEnumerable<OffersModel> results = GetAllOffers()
                                               .Where(x => x.MerchantName.ToLower().StartsWith(id.ToLower()) 
                                                   || x.City.ToLower().StartsWith(id.ToLower())
                                                   || x.DealStatus.ToLower().StartsWith(id.ToLower())
                                                   ).ToList();                
            return results;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}