﻿namespace CSProtocol
{
    using System;

    public enum SERVERKICK_REASON
    {
        SSKR_NOREASON,
        SSKR_KICKBYLOGIN,
        SSKR_SERVERERROR,
        SSKR_TOKENFAIL,
        SSKR_TOKENPAYFAIL,
        SSKR_VERSIONERROR,
        SSKR_NEEDAUTHERROR,
        SSKR_IDIPOPERATION,
        SSKR_PLAYERFULL,
        SSKR_COUNT
    }
}

