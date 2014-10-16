// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// The List Definitions operation response.
    /// </summary>
    public partial class NetworkSecurityGroupListResponse : OperationResponse, IEnumerable<NetworkSecurityGroup>
    {
        private IList<NetworkSecurityGroup> _networkSecurityGroups;
        
        /// <summary>
        /// Optional. All Network Security Groups in a subscription.
        /// </summary>
        public IList<NetworkSecurityGroup> NetworkSecurityGroups
        {
            get { return this._networkSecurityGroups; }
            set { this._networkSecurityGroups = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkSecurityGroupListResponse
        /// class.
        /// </summary>
        public NetworkSecurityGroupListResponse()
        {
            this.NetworkSecurityGroups = new LazyList<NetworkSecurityGroup>();
        }
        
        /// <summary>
        /// Gets the sequence of NetworkSecurityGroups.
        /// </summary>
        public IEnumerator<NetworkSecurityGroup> GetEnumerator()
        {
            return this.NetworkSecurityGroups.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of NetworkSecurityGroups.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
