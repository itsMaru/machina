﻿// Machina ~ TCPIPConnection.cs
// 
// Copyright © 2017 Ravahn - All Rights Reserved
// 
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.If not, see<http://www.gnu.org/licenses/>.

using System;

namespace Machina
{
    public class TCPConnection
    {
        public uint LocalIP { get; set; }
        public ushort LocalPort { get; set; }
        public uint RemoteIP { get; set; }
        public ushort RemotePort { get; set; }

        public string ID
        { get; set; }

        public IPDecoder IPDecoder_Receive
        { get; set; }
        public IPDecoder IPDecoder_Send
        { get; set; }
        public TCPDecoder TCPDecoder_Receive
        { get; set; }
        public TCPDecoder TCPDecoder_Send
        { get; set; }

        public override bool Equals(Object obj)
        {
            TCPConnection c = obj as TCPConnection;
            if (c == null)
                return false;
            return LocalIP == c.LocalIP &&
                LocalPort == c.LocalPort &&
                RemoteIP == c.RemoteIP &&
                RemotePort == c.RemotePort;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return (int)(LocalIP ^ LocalPort ^ RemoteIP ^ RemotePort);
            }
        }

        public override string ToString()
        {
            return (new System.Net.IPAddress(LocalIP)).ToString() + ":" + LocalPort.ToString() + "=>" +
                (new System.Net.IPAddress(RemoteIP)).ToString() + ":" + RemotePort.ToString();
        }
    }

}
