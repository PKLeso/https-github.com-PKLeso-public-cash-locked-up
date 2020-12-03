/*
 * Cash Locked Up Funds
 *
 * Cash Locked Up Funds
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using CashLockedUpFunds.Attributes;
using Microsoft.AspNetCore.Authorization;
using CashLockedUpFunds.Models;

namespace CashLockedUpFunds.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class MockedApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns a summary and detail of the locked funds associated with the entity but utilizes exchange rates internally to report in the currency requested </remarks>
        /// <param name="currencyType">The currency type</param>
        /// <param name="entityId">The entityId for the user to be dealt with.</param>
        /// <response code="200">OK </response>
        /// <response code="400">Bad request error messages. </response>
        /// <response code="401">Not Authorized</response>
        [HttpGet]
        [Route("/GetLockedUpFunds")]
        [ValidateModelState]
        [SwaggerOperation("GetLockedUpFundsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(CashLockedUpsResponse), description: "OK ")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorMessagesResponse), description: "Bad request error messages. ")]
        public virtual IActionResult GetLockedUpFundsGet([FromQuery][Required()]string currencyType, [FromQuery][Required()]int? entityId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CashLockedUpsResponse));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorMessagesResponse));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            string exampleJson = null;
            exampleJson = "{\r\n  \"summary\" : {\r\n    \"currency\" : \"ZAR\",\r\n    \"lockedUpFunds\" : 500.0\r\n  },\r\n  \"cashLockedUps\" : [ {\r\n    \"amount\" : 500.0,\r\n    \"trustAccountId\" : 72,\r\n    \"lockUpDate\" : \"2020-12-15T00:00:00.000+0000\",\r\n    \"currency\" : \"ZAR\",\r\n    \"amountAtRateOfExchange\" : 500.0,\r\n    \"id\" : 1,\r\n    \"rateOfExchange\" : 1.0\r\n  }, {\r\n    \"amount\" : 500.0,\r\n    \"trustAccountId\" : 72,\r\n    \"lockUpDate\" : \"2020-12-15T00:00:00.000+0000\",\r\n    \"currency\" : \"ZAR\",\r\n    \"amountAtRateOfExchange\" : 500.0,\r\n    \"id\" : 1,\r\n    \"rateOfExchange\" : 1.0\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CashLockedUpsResponse>(exampleJson)
            : default(CashLockedUpsResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Records locked up funds against an entity. </remarks>
        /// <param name="trustAccountId">trustAccountId for the user dealt with.</param>
        /// <param name="cashLockedUpWithdrawableRequest"></param>
        /// <response code="200">OK </response>
        [HttpPost]
        [Route("/locked-up-funds/calculate-withdrawable-amount")]
        [ValidateModelState]
        [SwaggerOperation("LockedUpFundsCalculateWithdrawableAmountPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(CashLockedUpWithdrawableResponse), description: "OK ")]
        public virtual IActionResult LockedUpFundsCalculateWithdrawableAmountPost([FromQuery][Required()]string trustAccountId, [FromBody]CashLockedUpWithdrawableRequest cashLockedUpWithdrawableRequest)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CashLockedUpWithdrawableResponse));

            string exampleJson = null;
            exampleJson = "{\r\n  \"unsettledTrades\" : 0.0,\r\n  \"withdrawable\" : 1300.0,\r\n  \"totalNAV\" : 1500.0,\r\n  \"freeCash\" : 1500.0,\r\n  \"currency\" : \"ZAR\",\r\n  \"lockedUpFunds\" : 200.0\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CashLockedUpWithdrawableResponse>(exampleJson)
            : default(CashLockedUpWithdrawableResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Records locked up funds against an entity. </remarks>
        /// <param name="authorization">Authorizer</param>
        /// <param name="id">Id for the cash locked up funds dealt with.</param>
        /// <param name="cashLockedUpRequest"></param>
        /// <response code="200">OK    </response>
        [HttpPost]
        [Route("/locked-up-funds/{Id}/unlock")]
        [ValidateModelState]
        [SwaggerOperation("LockedUpFundsIdUnlockPost")]
        public virtual IActionResult LockedUpFundsIdUnlockPost([FromHeader][Required()]string authorization, [FromRoute][Required]string id, [FromBody]CashLockedUpDateRequest cashLockedUpRequest)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Records locked up funds against an entity. </remarks>
        /// <param name="cashLockedUpRequest"></param>
        /// <response code="200">OK       </response>
        [HttpPost]
        [Route("/LockedUpFunds")]
        [ValidateModelState]
        [SwaggerOperation("LockedUpFundsPost")]
        public virtual IActionResult LockedUpFundsPost([FromBody]CashLockedUpRequest cashLockedUpRequest)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }
    }
}
