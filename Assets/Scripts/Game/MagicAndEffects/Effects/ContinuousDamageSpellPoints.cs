﻿// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2018 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using DaggerfallConnect.Arena2;

namespace DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects
{
    /// <summary>
    /// Continuous Damage - Spell Points
    /// </summary>
    public class ContinuousDamageSpellPoints : BaseEntityEffect
    {
        public override string Key { get { return "ContinuousDamage-SpellPoints"; } }
        public override string GroupName { get { return TextManager.Instance.GetText("ClassicEffects", "continuousDamage"); } }
        public override string SubGroupName { get { return TextManager.Instance.GetText("ClassicEffects", "spellPoints"); } }
        public override int ClassicGroup { get { return 4; } }
        public override int ClassicSubGroup { get { return 2; } }
        public override TextFile.Token[] SpellMakerDescription { get { return DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1506); } }
        public override TextFile.Token[] SpellBookDescription { get { return DaggerfallUnity.Instance.TextProvider.GetRSCTokens(1206); } }
        public override bool SupportChance { get { return false; } }
        public override TargetTypes AllowedTargets { get { return EntityEffectBroker.TargetFlags_Other; } }
        public override ElementTypes AllowedElements { get { return EntityEffectBroker.ElementFlags_All; } }
    }
}