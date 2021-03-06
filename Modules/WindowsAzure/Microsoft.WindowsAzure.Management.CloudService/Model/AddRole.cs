﻿// ----------------------------------------------------------------------------------
//
// Copyright 2011 Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Management.Automation;
using Microsoft.WindowsAzure.Management.CloudService.Services;

namespace Microsoft.WindowsAzure.Management.CloudService.Model
{
    /// <summary>
    /// Create scaffolding for a new hosted service. Generates a basic folder structure, 
    /// default cscfg file which wires up node/iisnode at startup in Azure as well as startup.js. 
    /// </summary>
    public abstract class AddRole : DeploymentServiceManagementCmdletBase
    {
        int instanceCount;

        [Parameter(Position = 0, HelpMessage = "Role name")]
        [Alias("n")]
        public string Name { get; set; }

        [Parameter(Position = 1, HelpMessage = "Instances count")]
        [Alias("i")]
        public int Instances
        {
            get { return instanceCount; }
            set { instanceCount = value; }
        }

        public AddRole()
        {
            instanceCount = 1;
        }
    }
}