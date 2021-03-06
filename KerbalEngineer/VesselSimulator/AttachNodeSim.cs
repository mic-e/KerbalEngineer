﻿// 
//     Kerbal Engineer Redux
// 
//     Copyright (C) 2014 CYBUTEK
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 

#region Using Directives

using System;
using System.Text;

#endregion

namespace KerbalEngineer.VesselSimulator
{
    internal class AttachNodeSim
    {
        public PartSim attachedPartSim;
        public String id;
        public AttachNode.NodeType nodeType;

        public AttachNodeSim(PartSim partSim, String newId, AttachNode.NodeType newNodeType)
        {
            this.attachedPartSim = partSim;
            this.nodeType = newNodeType;
            this.id = newId;
        }

        public void DumpToBuffer(StringBuilder buffer)
        {
            if (this.attachedPartSim == null)
            {
                buffer.Append("<staged>:<n>");
            }
            else
            {
                buffer.Append(this.attachedPartSim.name);
                buffer.Append(":");
                buffer.Append(this.attachedPartSim.partId);
            }
            buffer.Append("#");
            buffer.Append(this.nodeType);
            buffer.Append(":");
            buffer.Append(this.id);
        }
    }
}