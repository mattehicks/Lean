﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/
/**********************************************************
* USING NAMESPACES
**********************************************************/
using System;
using QuantConnect.Interfaces;
using QuantConnect.Packets;

namespace QuantConnect.Api
{
    /******************************************************** 
    * CLASS DEFINITIONS
    *********************************************************/
    /// <summary>
    /// Cloud algorithm activity controls
    /// </summary>
    public class Api : IApi
    {
        /******************************************************** 
        * CLASS VARIABLES
        *********************************************************/

        /******************************************************** 
        * CLASS PROPERTIES
        *********************************************************/

        /******************************************************** 
        * CLASS METHODS:
        *********************************************************/
        /// <summary>
        /// Initialize the API.
        /// </summary>
        public void Initialize()
        {
            //Nothing to initialize in the local copy of the engine.
        }

        /// <summary>
        /// Calculate the remaining bytes of user log allowed based on the user's cap and daily cumulative usage.
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <param name="userToken">User API token</param>
        /// <returns>int[3] iUserBacktestLimit, iUserDailyLimit, remaining</returns>
        public int[] ReadLogAllowance(int userId, string userToken) 
        {
            return new[] { Int32.MaxValue, Int32.MaxValue, Int32.MaxValue };
        }

        /// <summary>
        /// Update the daily log of allowed logging-data
        /// </summary>
        /// <param name="userId">Id of the User</param>
        /// <param name="backtestId">BacktestId</param>
        /// <param name="url">URL of the log entry</param>
        /// <param name="length">length of data</param>
        /// <param name="userToken">User access token</param>
        /// <param name="hitLimit">Boolean signifying hit log limit</param>
        /// <returns>Number of bytes remaining</returns>
        public void UpdateDailyLogUsed(int userId, string backtestId, string url, int length, string userToken, bool hitLimit = false)
        {
            //
        }

        /// <summary>
        /// Get the algorithm status from the user with this algorithm id.
        /// </summary>
        /// <param name="algorithmId">String algorithm id we're searching for.</param>
        /// <returns>Algorithm status enum</returns>
        public AlgorithmStatus GetAlgorithmStatus(string algorithmId)
        {
            return AlgorithmStatus.Running;
        }

        /// <summary>
        /// Algorithm passes back its current status to the UX.
        /// </summary>
        /// <param name="status">Status of the current algorithm</param>
        /// <param name="algorithmId">String algorithm id we're setting.</param>
        /// <returns>Algorithm status enum</returns>
        public void SetAlgorithmStatus(string algorithmId, AlgorithmStatus status)
        {
            //
        }

        /// <summary>
        /// Get the calendar open hours for the today.
        /// </summary>
        public MarketToday MarketToday(SecurityType type)
        {
            return new MarketToday();
        }

        /// <summary>
        /// Store logs with these authentication type
        /// </summary>
        public void Store(string data, string location, StoragePermissions permissions, bool async = false)
        {
            //
        }

    } // End usage controls class

} // End QC Namespace
