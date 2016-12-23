﻿using WinEchek.Engine.Rules;
using Type = WinEchek.Model.Piece.Type;

namespace WinEchek.Engine.RuleManager
{
    public class KingRuleGroup : RuleGroup
    {
        public KingRuleGroup()
        {
            Rules.Add(new KingMovementRule());
            Rules.Add(new CanOnlyTakeEnnemyRuleKing());
            Rules.Add(new CastlingRule());
            Rules.Add(new WillNotMakeCheck());

        }
        protected override Type Type => Type.King;
    }
}