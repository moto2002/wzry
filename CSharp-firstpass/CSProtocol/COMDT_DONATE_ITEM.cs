﻿namespace CSProtocol
{
    using Assets.Scripts.Common;
    using System;
    using tsf4g_tdr_csharp;

    public class COMDT_DONATE_ITEM : ProtocolObject
    {
        public static readonly uint BASEVERSION = 1;
        public byte bFriendType;
        public static readonly int CLASS_ID = 0x203;
        public static readonly uint CURRVERSION = 1;
        public uint dwDonateTime;
        public COMDT_ACNT_UNIQ stAcntUniq = ((COMDT_ACNT_UNIQ) ProtocolObjectPool.Get(COMDT_ACNT_UNIQ.CLASS_ID));

        public override TdrError.ErrorType construct()
        {
            return TdrError.ErrorType.TDR_NO_ERROR;
        }

        public override int GetClassID()
        {
            return CLASS_ID;
        }

        public override void OnRelease()
        {
            if (this.stAcntUniq != null)
            {
                this.stAcntUniq.Release();
                this.stAcntUniq = null;
            }
            this.bFriendType = 0;
            this.dwDonateTime = 0;
        }

        public override void OnUse()
        {
            this.stAcntUniq = (COMDT_ACNT_UNIQ) ProtocolObjectPool.Get(COMDT_ACNT_UNIQ.CLASS_ID);
        }

        public override TdrError.ErrorType pack(ref TdrWriteBuf destBuf, uint cutVer)
        {
            TdrError.ErrorType type = TdrError.ErrorType.TDR_NO_ERROR;
            if ((cutVer == 0) || (CURRVERSION < cutVer))
            {
                cutVer = CURRVERSION;
            }
            if (BASEVERSION > cutVer)
            {
                return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
            }
            type = this.stAcntUniq.pack(ref destBuf, cutVer);
            if (type == TdrError.ErrorType.TDR_NO_ERROR)
            {
                type = destBuf.writeUInt8(this.bFriendType);
                if (type != TdrError.ErrorType.TDR_NO_ERROR)
                {
                    return type;
                }
                type = destBuf.writeUInt32(this.dwDonateTime);
                if (type != TdrError.ErrorType.TDR_NO_ERROR)
                {
                    return type;
                }
            }
            return type;
        }

        public TdrError.ErrorType pack(ref byte[] buffer, int size, ref int usedSize, uint cutVer)
        {
            if (((buffer == null) || (buffer.GetLength(0) == 0)) || (size > buffer.GetLength(0)))
            {
                return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
            }
            TdrWriteBuf destBuf = ClassObjPool<TdrWriteBuf>.Get();
            destBuf.set(ref buffer, size);
            TdrError.ErrorType type = this.pack(ref destBuf, cutVer);
            if (type == TdrError.ErrorType.TDR_NO_ERROR)
            {
                buffer = destBuf.getBeginPtr();
                usedSize = destBuf.getUsedSize();
            }
            destBuf.Release();
            return type;
        }

        public override TdrError.ErrorType unpack(ref TdrReadBuf srcBuf, uint cutVer)
        {
            TdrError.ErrorType type = TdrError.ErrorType.TDR_NO_ERROR;
            if ((cutVer == 0) || (CURRVERSION < cutVer))
            {
                cutVer = CURRVERSION;
            }
            if (BASEVERSION > cutVer)
            {
                return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
            }
            type = this.stAcntUniq.unpack(ref srcBuf, cutVer);
            if (type == TdrError.ErrorType.TDR_NO_ERROR)
            {
                type = srcBuf.readUInt8(ref this.bFriendType);
                if (type != TdrError.ErrorType.TDR_NO_ERROR)
                {
                    return type;
                }
                type = srcBuf.readUInt32(ref this.dwDonateTime);
                if (type != TdrError.ErrorType.TDR_NO_ERROR)
                {
                    return type;
                }
            }
            return type;
        }

        public TdrError.ErrorType unpack(ref byte[] buffer, int size, ref int usedSize, uint cutVer)
        {
            if (((buffer == null) || (buffer.GetLength(0) == 0)) || (size > buffer.GetLength(0)))
            {
                return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
            }
            TdrReadBuf srcBuf = ClassObjPool<TdrReadBuf>.Get();
            srcBuf.set(ref buffer, size);
            TdrError.ErrorType type = this.unpack(ref srcBuf, cutVer);
            usedSize = srcBuf.getUsedSize();
            srcBuf.Release();
            return type;
        }
    }
}

