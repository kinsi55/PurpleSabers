using HarmonyLib;
using IPA;
using IPA.Config;
using IPA.Config.Stores;
using SiraUtil.Zenject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

namespace PurpleSabers {
	[Plugin(RuntimeOptions.SingleStartInit)]
	public class Plugin {
		internal static Plugin Instance;
		internal static IPALogger Log;

		[Init]
		public Plugin(IPALogger logger, IPA.Config.Config conf, Zenjector zenjector) {
			Instance = this;
			Log = logger;
			Config.Instance = conf.Generated<Config>();

			zenjector.Install<Installers.GameInstaller>(Location.StandardPlayer);
		}

		[OnEnable]
		public void OnEnable() {
			BeatSaberMarkupLanguage.GameplaySetup.GameplaySetup.instance.AddTab("PurpleSabers", "PurpleSabers.UI.GameSetup.bsml", Config.Instance);
		}
	}
}
