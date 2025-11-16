using Common;
using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    [SerializeField]
    private AudioManager audioManager;
    [SerializeField]
    private InputActions inputActions;

    public override void InstallBindings()
    {
        InstallSignals();

        Container.BindInterfacesAndSelfTo<AudioManager>().FromInstance(audioManager).AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<InputActions>().FromInstance(inputActions).AsSingle().NonLazy();
    }

    private void InstallSignals()
    {
        SignalBusInstaller.Install(Container);

        Container.DeclareSignal<ExampleSignal>();
    }
}

