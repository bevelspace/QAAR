using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Tridify;
using Bevel;

//stick this thing onto the text element on some canvas where you want the data to show up.
public class MetaDataDisplay : MonoBehaviour {

    [Tooltip("Create and drag in a canvas with a large text box")]
    public LayerMask elementLayer;
    //temproary?
    public bool isCropped;
    public LayerMask clipLayer;

    string dataPresentationString;

	// Use this for initialization
	void Start ()
    {
        if (isCropped)
        {
            BevelInput.clickObjectEventCropped += ShowData;
        }
        else
        {
            BevelInput.clickObjectEvent += ShowData;
        }
    }
	
	//// Update is called once per frame
	//void Update () {
 //       //check for touching elements
 //       if (isCropped)
 //       {
 //           GameObject controlledHit = BevelInput.TestClick(elementLayer, clipLayer);
 //           if (controlledHit)
 //           {
 //               FindObjectOfType<ObjectSelection>().SelectSingleObject(controlledHit);
 //               ShowData(controlledHit);
 //           }
 //       }
 //       else
 //       {
 //           GameObject hitObject = BevelInput.TestClick(elementLayer);
 //           if (hitObject)
 //           {
 //               FindObjectOfType<ObjectSelection>().SelectSingleObject(hitObject);
 //               ShowData(hitObject);
 //           }
 //       }
 //   }

    public void ShowData(GameObject element){
        dataPresentationString = "\n";
        IfcPresentationLayerAssignment ifcPresentationLayerAssignment;
        if (ifcPresentationLayerAssignment = element.GetComponent<IfcPresentationLayerAssignment>())
        {
            dataPresentationString += "IFC Layer Name: " + ifcPresentationLayerAssignment.Name + "\n\n";
        }
        IfcPropertySet ifcPropertySet;
        if (ifcPropertySet = element.GetComponent<IfcPropertySet>())
        {
            foreach (var attribute in ifcPropertySet.Attributes)
            {
                dataPresentationString += attribute.Name + ": " + attribute.Value + "\n\n";
            }
            
        }
        GetComponent<Text>().text = dataPresentationString;
    }

}
