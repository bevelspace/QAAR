using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class MarkUp : MonoBehaviour {

    public string title;
    public GameObject markedObject;
    public Vector3 relativePosition;
    public DateTime dateCreated;

    public bool isSolved;

    public enum MarkUpType {question, problem, testResult}
    public MarkUpType markUpType;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
