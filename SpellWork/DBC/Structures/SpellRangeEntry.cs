﻿using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellRangeEntry
    {
        [Index(true)]
        public uint ID;
        public string DisplayName;
        public string DisplayNameShort;
        public byte Flags;
        [Cardinality(2)]
        public float[] MinRange = new float[2];
        [Cardinality(2)]
        public float[] MaxRange = new float[2];
    }
}
