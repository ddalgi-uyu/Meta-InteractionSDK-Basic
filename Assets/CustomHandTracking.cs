using System.Collections.Generic;
using UnityEngine;

public class CustomHandTracking : MonoBehaviour
{
    [Header("Base Hand")]
    public Transform base_Hand;
    public Transform base_Wrist;
    public Transform base_Index1;
    public Transform base_Index2;
    public Transform base_Index3;
    public Transform base_Middle1;
    public Transform base_Middle2;
    public Transform base_Middle3;
    public Transform base_Pinky0;
    public Transform base_Pinky1;
    public Transform base_Pinky2;
    public Transform base_Pinky3;
    public Transform base_Ring1;
    public Transform base_Ring2;
    public Transform base_Ring3;
    public Transform base_Thumb0;
    public Transform base_Thumb1;
    public Transform base_Thumb2;
    public Transform base_Thumb3;

    [Header("Custom Hand")]
    public CustomBone custom_Hand;
    public CustomBone custom_Wrist;
    public CustomBone custom_Index1;
    public CustomBone custom_Index2;
    public CustomBone custom_Index3;
    public CustomBone custom_Middle1;
    public CustomBone custom_Middle2;
    public CustomBone custom_Middle3;
    public CustomBone custom_Pinky0;
    public CustomBone custom_Pinky1;
    public CustomBone custom_Pinky2;
    public CustomBone custom_Pinky3;
    public CustomBone custom_Ring1;
    public CustomBone custom_Ring2;
    public CustomBone custom_Ring3;
    public CustomBone custom_Thumb0;
    public CustomBone custom_Thumb1;
    public CustomBone custom_Thumb2;
    public CustomBone custom_Thumb3;
    List<CustomBone> Bones;
    [System.Serializable]
    public class CustomBone
    {
        public Transform transform;
        public Vector3 positionOffset;
        public Vector3 rotationOffset;
    }
    void Awake()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Retarget(base_Hand, custom_Hand);
        Retarget(base_Wrist, custom_Wrist);
        Retarget(base_Index1, custom_Index1);
        Retarget(base_Index2, custom_Index2);
        Retarget(base_Index3, custom_Index3);
        Retarget(base_Middle1, custom_Middle1);
        Retarget(base_Middle2, custom_Middle2);
        Retarget(base_Middle3, custom_Middle3);
        Retarget(base_Pinky0, custom_Pinky0);
        Retarget(base_Pinky1, custom_Pinky1);
        Retarget(base_Pinky2, custom_Pinky2);
        Retarget(base_Pinky3, custom_Pinky3);
        Retarget(base_Ring1, custom_Ring1);
        Retarget(base_Ring2, custom_Ring2);
        Retarget(base_Ring3, custom_Ring3);
        Retarget(base_Thumb0, custom_Thumb0);
        Retarget(base_Thumb1, custom_Thumb1);
        Retarget(base_Thumb2, custom_Thumb2);
        Retarget(base_Thumb3, custom_Thumb3);
    }

    public void Retarget(Transform source, CustomBone target)
    {
        if (!source || !target.transform)
            return;

        target.transform.rotation = source.rotation * Quaternion.Euler(target.rotationOffset);
        target.transform.position = source.TransformPoint(target.positionOffset);
    }
}
