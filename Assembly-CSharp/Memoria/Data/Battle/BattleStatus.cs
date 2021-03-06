﻿using System;

namespace Memoria.Data
{
    [Flags]
    public enum BattleStatus : uint
    {
        Petrify = 1 << 0, // 1,
        Venom = 1 << 1, //2
        Virus = 1 << 2, //4,
        Silence = 1 << 3, //8,
        Blind = 1 << 4, //16,
        Trouble = 1 << 5, //32,
        Zombie = 1 << 6, //64,
        EasyKill = 1 << 7, //128,
        Death = 1 << 8, //256,
        LowHP = 1 << 9, //512,
        Confuse = 1 << 10, //1024,
        Berserk = 1 << 11, //2048,
        Stop = 1 << 12, //4096,
        AutoLife = 1 << 13, //8192,
        Trance = 1 << 14, //16384,
        Defend = 1 << 15, //32768,
        Poison = 1 << 16, //65536,
        Sleep = 1 << 17, //131072,
        Regen = 1 << 18, //262144,
        Haste = 1 << 19, //524288,
        Slow = 1 << 20, //1048576,
        Float = 1 << 21, //2097152,
        Shell = 1 << 22, //4194304,
        Protect = 1 << 23, //8388608,
        Heat = 1 << 24, //16777216,
        Freeze = 1 << 25, //33554432,
        Vanish = 1 << 26, //67108864,
        Doom = 1 << 27, //134217728,
        Mini = 1 << 28, //268435456,
        Reflect = 1 << 29, //536870912,
        Jump = 1 << 30, //1073741824,
        GradualPetrify = 1u << 31, //2147483648,

        Achievement = Petrify | Venom | Virus | Silence | Blind | Trouble | Zombie | Death | LowHP | Confuse | Berserk | Stop | AutoLife | Poison | Sleep | Regen | Haste | Slow | Float | Shell | Protect | Heat | Freeze | Vanish | Doom | Mini | Reflect | GradualPetrify,
        ContiGood1 = 619446272,
        ContiBad = 2601713664,
        OprCount = 327682,
        NoInput = 1107434755,
        CmdCancel = 134403,
        IdleDying = Venom | LowHP | Poison | Sleep,
        Immobilized = Petrify | Venom | Stop | Freeze,
        FrozenAnimation = Immobilized | Jump,
        StopAtb = 1073746177,
        NoMagic = 318905611,
        ChgPolyCol = Zombie | Berserk | Heat | Freeze,
        CannotEscape = Petrify | Venom | Zombie | Death | Stop | Sleep | Freeze | Jump,
        CannotTrance = Petrify | Venom | Zombie | Death | Stop | Trance | Freeze,
        NoReset = 2281766783,
        BattleEnd = Petrify | Venom | Death | Stop,
        CancelPhysics = 132096,
        TimeOpr = 2282045442,
        NoReaction = FrozenAnimation | Death,
        CancelEvent = Confuse | Stop | Defend | Freeze
    }
}