using UnityEngine;
using System.Collections;

public class Interactive_Menu_Item : MonoBehaviour {

	public Color selectedColor;		//Color the selected item changes to

	private Vector3 originalScale;
	public Vector3 hoverScale;
	public Vector3 selectScale;

	void Start () {

		originalScale = transform.localScale;
	}

	void Update () {


	
	}

	void OnMouseEnter(){

		iTween.ScaleTo(this.gameObject, hoverScale, .5f);

	}

	void OnMouseExit(){

		iTween.ScaleTo(this.gameObject, originalScale, .5f);

	}

	void OnMouseUp(){

		SendMessageUpwards("OnMenuItemSelected", gameObject.name, SendMessageOptions.RequireReceiver);

		iTween.ColorFrom(this.gameObject, selectedColor, .5f);
		iTween.ScaleTo(this.gameObject, originalScale, .5f);

	}
}
