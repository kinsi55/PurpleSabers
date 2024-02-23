using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiraUtil.Affinity;

namespace PurpleSabers.HarmonyPatches {
	class IgnoreWrongSaberCut : IAffinity {
		[AffinityPatch(typeof(GameNoteController), nameof(GameNoteController.HandleCut))]
		[AffinityPrefix]
		bool Prefix() => false;
	}
}
