﻿namespace SpellWork.DBC.Structures
{
    public sealed class SpellAuraRestrictionsEntry
    {
        public uint Id;
        //public uint spellId;                                      // 1  - Pandaria
        //public uint Difficulty;                                   // 2  - Pandaria, difficulty?
        public uint CasterAuraState;
        public uint TargetAuraState;
        public uint CasterAuraStateNot;
        public uint TargetAuraStateNot;
        public uint CasterAuraSpell;
        public uint TargetAuraSpell;
        public uint ExcludeCasterAuraSpell;
        public uint ExcludeTargetAuraSpell;
    }
}
