﻿using HarmonyLib;
using MAI2System;
using Manager;

namespace AquaMai.Cheat
{
    public class UnlockUtage
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(GameManager), "CanUnlockUtageTotalJudgement")]
        public static bool CanUnlockUtageTotalJudgement(out ConstParameter.ResultOfUnlockUtageJudgement result1P, out ConstParameter.ResultOfUnlockUtageJudgement result2P)
        {
            result1P = ConstParameter.ResultOfUnlockUtageJudgement.Unlocked;
            result2P = ConstParameter.ResultOfUnlockUtageJudgement.Unlocked;
            return false;
        }
    }
}