using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Avatar = Alteruna.Avatar;
using TrackedPoseDriver = UnityEngine.SpatialTracking.TrackedPoseDriver;
using UnityEngine.XR.Interaction.Toolkit;

 
public class PlayerController : MonoBehaviour
{
    private Avatar _avatar;
    [SerializeField] private Transform head;
    [SerializeField] private Camera cam;
    //[SerializeField] private int playerSelfLayer;
    [SerializeField] private TrackedPoseDriver rightController, leftController;
    [SerializeField] Shoot shootScript;
    [SerializeField] XRController leftXR, rightXR;
 
    private void Awake()
    {
        _avatar = GetComponent<Avatar>();
    }
 
    private void Start()
    {
        if (!_avatar.IsOwner)
        {
            rightController.enabled = false;
            leftController.enabled = false;
            leftXR.enabled = false;
            rightXR.enabled = false;
            shootScript.enabled = false;
            //cam.gameObject.SetActive(false);
        }
    }
 
    /*private void Update()
    {
        if (!_avatar.IsOwner)
        {
            return;
        }
            
 
        head.localPosition = cam.transform.localPosition;
        head.rotation = cam.transform.rotation;

        

    }*/
    
}
