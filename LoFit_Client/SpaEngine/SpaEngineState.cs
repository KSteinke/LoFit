using LoFit_Client.SpaEngine.Interfaces;
using Microsoft.AspNetCore.Components;
using LoFit_Client.Pages;
using LoFit_Client.SpaEngine.SpaEngineStates;

namespace LoFit_Client.SpaEngine;

public abstract class SpaEngineState
{
    protected ISpaEngineService _spaEngineService;
    public SpaEngineStatesEnum spaEngineStateName;
    public SpaEngineStatesEnum SpaEngineStateName 
    {
        get{return spaEngineStateName;} 
        set{spaEngineStateName = value;}
    }
    public void SetSpaEngineService(ISpaEngineService spaEngineService)
    {
        this._spaEngineService = spaEngineService;
    }   

    public virtual void StartTraining()
    {
        //Empty Default Implementation
    }

    public SpaEngineStatesEnum GetCurrentStateName()
    {
        return this.spaEngineStateName;
    }
}

public enum SpaEngineStatesEnum
{
    Init,
    ListTrainings,
    Training
}