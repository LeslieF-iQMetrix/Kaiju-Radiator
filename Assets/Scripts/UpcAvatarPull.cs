using UnityEngine;
using System.Collections;

public class UpcAvatarPull : MonoBehaviour {


	private string AvatarIcon = "https://avatars2.githubusercontent.com/u/5374751?v=2";
	// Use this for initialization
	IEnumerator Start() {
		WWW www = new WWW(AvatarIcon);
		yield return www;
		renderer.material.mainTexture = www.texture;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
