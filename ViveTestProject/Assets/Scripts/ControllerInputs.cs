using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class ControllerInputs : MonoBehaviour
{
    SteamVR_TrackedObject trackedObj;

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Start ()
    {

    }
	

	void Update ()
    {
            var device = SteamVR_Controller.Input((int)trackedObj.index);

            if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                Debug.Log("Laser Down");
                gameObject.GetComponent<SteamVR_LaserPointer>().thickness = .002f;
            }
            else if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                Debug.Log("Laser Up");
                gameObject.GetComponent<SteamVR_LaserPointer>().thickness = 0;
            }
        }
}
