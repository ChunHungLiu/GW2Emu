/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 08-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Core;
using GameRevision.GW2Emu.Core.Types;
using GameRevision.GW2Emu.Core.Serializers;

namespace GameRevision.GW2Emu.Messages.GameServer.CtoS
{
    public class P004_UnknownMessage : GenericTriggerableMessage
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public Vector4 Unknown3;
        public int Unknown4;
        public Vector4 Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        
        public override ushort Header
        {
            get
            {
                return 4;
            }
        }
        
        public override void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadInt16();
            this.Unknown1 = deserializer.ReadVarint();
            this.Unknown2 = deserializer.ReadByte();
            this.Unknown3 = deserializer.ReadVector4();
            this.Unknown4 = deserializer.ReadVarint();
            this.Unknown5 = deserializer.ReadVector4();
            this.Unknown6 = deserializer.ReadByte();
            this.Unknown7 = deserializer.ReadByte();
            this.Unknown8 = deserializer.ReadByte();
        }
    }
}