﻿namespace behaviac
{
    using Assets.Scripts.GameLogic;

    internal class Action_bt_WrapperAI_Hero_HeroGuideFollow_node84 : Action
    {
        private SkillSlotType method_p0 = SkillSlotType.SLOT_SKILL_0;

        protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
        {
            return ((ObjAgent) pAgent).CanUseSkill(this.method_p0);
        }
    }
}

