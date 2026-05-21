using System.Collections.Generic;
using Player;
using Player.PlayerAction;
using Player.PlayerAnimation;
using UnityEngine;
using VContainer.Unity;

namespace VContainer
{
   
    public class VContainerInjected : LifetimeScope
    {
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<PlayerSettings>(Lifetime.Scoped);

        }
    }
}