﻿using System;
using System.Runtime.InteropServices;

public class AkChannelConfig : IDisposable
{
    protected bool swigCMemOwn;
    private IntPtr swigCPtr;

    public AkChannelConfig() : this(AkSoundEnginePINVOKE.CSharp_new_AkChannelConfig__SWIG_0(), true)
    {
    }

    public AkChannelConfig(uint in_uChannelMask) : this(AkSoundEnginePINVOKE.CSharp_new_AkChannelConfig__SWIG_1(in_uChannelMask), true)
    {
    }

    internal AkChannelConfig(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }

    public void Clear()
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_Clear(this.swigCPtr);
    }

    public void Deserialize(uint in_uChannelConfig)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_Deserialize(this.swigCPtr, in_uChannelConfig);
    }

    public virtual void Dispose()
    {
        AkChannelConfig config = this;
        lock (config)
        {
            if (this.swigCPtr != IntPtr.Zero)
            {
                if (this.swigCMemOwn)
                {
                    this.swigCMemOwn = false;
                    AkSoundEnginePINVOKE.CSharp_delete_AkChannelConfig(this.swigCPtr);
                }
                this.swigCPtr = IntPtr.Zero;
            }
            GC.SuppressFinalize(this);
        }
    }

    ~AkChannelConfig()
    {
        this.Dispose();
    }

    internal static IntPtr getCPtr(AkChannelConfig obj)
    {
        return ((obj != null) ? obj.swigCPtr : IntPtr.Zero);
    }

    public bool IsChannelConfigSupported()
    {
        return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_IsChannelConfigSupported(this.swigCPtr);
    }

    public bool IsValid()
    {
        return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_IsValid(this.swigCPtr);
    }

    public AkChannelConfig RemoveCenter()
    {
        return new AkChannelConfig(AkSoundEnginePINVOKE.CSharp_AkChannelConfig_RemoveCenter(this.swigCPtr), true);
    }

    public AkChannelConfig RemoveLFE()
    {
        return new AkChannelConfig(AkSoundEnginePINVOKE.CSharp_AkChannelConfig_RemoveLFE(this.swigCPtr), true);
    }

    public void Serialize(out uint out_uChannelConfig)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_Serialize(this.swigCPtr, out out_uChannelConfig);
    }

    public void SetAmbisonic(uint in_uNumChannels)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_SetAmbisonic(this.swigCPtr, in_uNumChannels);
    }

    public void SetAnonymous(uint in_uNumChannels)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_SetAnonymous(this.swigCPtr, in_uNumChannels);
    }

    public void SetStandard(uint in_uChannelMask)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_SetStandard(this.swigCPtr, in_uChannelMask);
    }

    public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask)
    {
        AkSoundEnginePINVOKE.CSharp_AkChannelConfig_SetStandardOrAnonymous(this.swigCPtr, in_uNumChannels, in_uChannelMask);
    }

    public uint eConfigType
    {
        get
        {
            return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_eConfigType_get(this.swigCPtr);
        }
        set
        {
            AkSoundEnginePINVOKE.CSharp_AkChannelConfig_eConfigType_set(this.swigCPtr, value);
        }
    }

    public uint uChannelMask
    {
        get
        {
            return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_uChannelMask_get(this.swigCPtr);
        }
        set
        {
            AkSoundEnginePINVOKE.CSharp_AkChannelConfig_uChannelMask_set(this.swigCPtr, value);
        }
    }

    public uint uNumChannels
    {
        get
        {
            return AkSoundEnginePINVOKE.CSharp_AkChannelConfig_uNumChannels_get(this.swigCPtr);
        }
        set
        {
            AkSoundEnginePINVOKE.CSharp_AkChannelConfig_uNumChannels_set(this.swigCPtr, value);
        }
    }
}

