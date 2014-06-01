using UnityEngine;
using System.Collections;

public static class GameObjectExts {
	public static bool IsPlayer(this GameObject go) {
		return go.tag == "Player";
	}
}
