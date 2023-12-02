using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;

public class VRHand : MonoBehaviour
{
    private XRRayInteractor m_XrRayInteractor;

    // Start is called before the first frame update
    void Start()
    {
        m_XrRayInteractor = GetComponentInChildren<XRRayInteractor>();
        m_XrRayInteractor.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs arg0)
    {
        var go = arg0.interactableObject.transform;
        Debug.Log(go.name);
        if (go.CompareTag("TV"))
        {
            go.GetComponent<VideoPlayer>().Play();
        }
    }
}