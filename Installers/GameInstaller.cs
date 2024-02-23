using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurpleSabers.HarmonyPatches;
using Zenject;

namespace PurpleSabers.Installers {
	class GameInstaller : MonoInstaller {
		public override void InstallBindings() {
			if(!Config.Instance.enabled)
				return;

			Container.BindInterfacesTo<IgnoreWrongSaberCut>().AsSingle();
			Container.Bind<DisableScoreSubmission>().AsSingle().NonLazy();
			Container.BindInterfacesTo<MixSaberColors>().AsSingle();
		}
	}
}
