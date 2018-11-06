using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    [SerializeField]private UnityEngine.UI.Image _image;
    private Heart _heart;


	// Use this for initialization
	void Start ()
    {
        _heart = new Heart(_image);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            _heart.Replenish(1);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            _heart.Deplete(1);
        }
	}
}
