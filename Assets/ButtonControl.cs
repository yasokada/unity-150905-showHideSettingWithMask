using UnityEngine;
using System.Collections;

/*
 * v0.2 2015/09/05
 *  - collapse toward the left/top
 * v0.1 2015/09/05
 *  - show / hide setting
 */

public class ButtonControl : MonoBehaviour {
	private bool doShow = false;
	
	public void ShowSettingClick() {
		GameObject panel = GameObject.Find ("PanelSetting");
		if (panel == null) {
			return;
		}
		
		// size change
		RectTransform rect = panel.GetComponent (typeof(RectTransform)) as RectTransform;
		Vector2 size = rect.sizeDelta;
		if (doShow) {
			size.x = 200;
			size.y = 250;
		} else {
			size.x = 20;
			size.y = 20;
		}
		doShow = !doShow;
		rect.sizeDelta = size;
	}
}
