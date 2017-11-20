using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseStabber : MonoBehaviour
{

	public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			RaycastHit hit; 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
			if ( Physics.Raycast (ray,out hit,100.0f)) {
				StartCoroutine(ScaleMe(hit.transform));
				Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
				text.text = "Correct!";
				
				//else
				//{
					// there is no way to see if it is a shooter, needs to create a func to evaluate
					// edginess text.text = "Incorrect!";
				//}
			}
		}
	}
	
	IEnumerator ScaleMe(Transform objTr) {
		objTr.localScale *= 1.2f;
		yield return new WaitForSeconds(0.5f);
		objTr.localScale /= 1.2f;
	}
}
