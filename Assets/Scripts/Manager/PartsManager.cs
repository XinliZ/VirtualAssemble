﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsManager : MonoBehaviour
{
    private List<GameObject> AssemblesList = new List<GameObject>();
    private Transform[] FatherModelObject;
    public List<Vector3> EndPosList = new List<Vector3>();
    public bool AssembleFlag;

    public List<Parts> PartsList = new List<Parts>();

    // Use this for initialization
    void Start()
    {
        FatherModelObject = GlobalVar._FatherGameObject.GetComponentsInChildren<Transform>();
        foreach (Transform child in FatherModelObject)
        {
            if (null != child.GetComponent<MeshFilter>())
            {
                AssemblesList.Add(child.gameObject);
                EndPosList.Add(child.transform.position);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
