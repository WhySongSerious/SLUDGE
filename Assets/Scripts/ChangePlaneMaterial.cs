using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ChangePlaneMaterial : MonoBehaviour
{
    public ARPlaneManager PlaneManager;
    public MeshRenderer prefabMeshRenderer;
    public Material LeatherMaterial;

    void Start()
    {
        // 시작 시 모든 평면에 LeatherMaterial 적용
        ApplyLeatherMaterial();
    }

    void ApplyLeatherMaterial()
    {
        prefabMeshRenderer.material = LeatherMaterial;
        foreach (var plane in PlaneManager.trackables)
        {
            plane.GetComponent<MeshRenderer>().material = LeatherMaterial;
        }
    }


    public void StopPlaneDetection()
    {
        // 평면 인식 기능 비활성화
        PlaneManager.enabled = false;

        // 기존에 감지된 평면들을 비활성화
        foreach (var plane in PlaneManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }
    }
}