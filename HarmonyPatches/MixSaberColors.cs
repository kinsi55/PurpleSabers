using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiraUtil.Affinity;
using UnityEngine;
using Zenject;
using static PlayerSaveData;

namespace PurpleSabers.HarmonyPatches {
	class MixSaberColors : IAffinity {
		[AffinityPatch(typeof(ColorManager), nameof(ColorManager.ColorForSaberType))]
		[AffinityPrefix]
		bool ColorForSaberType(ColorScheme ____colorScheme, ref Color __result) {
			__result = (____colorScheme.saberAColor + ____colorScheme.saberBColor) / 2;
			return false;
		}
	}
}
