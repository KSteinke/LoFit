using LoFit_Client.SpaEngine.Interfaces;
using LoFit_Client.SpaEngine.SpaEngineStates;
using Microsoft.AspNetCore.Components;
using LoFit_Client.Pages;
namespace LoFit_Client.SpaEngine;

public class SpaEngineService : ISpaEngineService
{
    private SpaEngineState _spaState = null;
    public SpaEngineService()
    {
        this.TransitionTo(new InitSpaEngineState());
    }
    public void TransitionTo(SpaEngineState newSpaState)
    {
        this._spaState = newSpaState;
        this._spaState.SetSpaEngineService(this);
    }
    public void StartTraining()
    {
        _spaState.StartTraining();
    }

    public SpaEngineStatesEnum GetCurrentStateName()
    {
        return this._spaState.GetCurrentStateName();
    }
    
}