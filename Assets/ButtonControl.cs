using UnityEngine;
using System.Collections;

/*
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
			size.y = 250;
		} else {
			size.y = 5;
		}
		doShow = !doShow;
		rect.sizeDelta = size;
	}
}
