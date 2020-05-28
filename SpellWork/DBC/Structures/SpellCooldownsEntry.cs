﻿using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellCooldownsEntry
    {
        [Index(true)]
        public uint ID;
        public byte DifficultyID;
        public int CategoryRecoveryTime;
        public int RecoveryTime;
        public int StartRecoveryTime;
        public int SpellID;
    }
}
