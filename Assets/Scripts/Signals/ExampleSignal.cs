using UnityEngine;

public class ExampleSignal
{
    public GameObject SignalOrigin { get; private set; }

    public ExampleSignal(GameObject signalOrigin)
    {
        SignalOrigin = signalOrigin;
    }
}