using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDoors : MonoBehaviour
{
    BoxCollider2D TriggerTP;
    BoxCollider2D Locker;

    [SerializeField] Transform RoomToTP;

    [SerializeField] public bool StatusWhenStarting = true;

    // Start is called before the first frame update
    void Start()
    {
        List<Component> collidersBox = new List<Component>();

        GetComponents(typeof(BoxCollider2D), collidersBox);

        foreach (BoxCollider2D box in collidersBox)
        {
            if (box.isTrigger)
                TriggerTP = box;
            else
                Locker = box;
        }
        Locker.enabled = StatusWhenStarting;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Unlock()
    {
        Locker.enabled = false;
    }

    public void Lock()
    {
        Locker.enabled = true;
    }



    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider == null)
            return;

        if (collider.gameObject.tag == "Player")
        {
            collider.transform.parent.transform.SetPositionAndRotation(new Vector3(RoomToTP.position.x, RoomToTP.position.y, 0), collider.transform.rotation);
            RoomToTP.parent.parent.GetComponent<Room>().CheckLockDoors();
            GameObject camera = GameObject.Find("Camera");

            if (gameObject.name.Contains("West"))
                camera.transform.SetPositionAndRotation(new Vector3(camera.transform.position.x - 30, camera.transform.position.y, -10), camera.transform.rotation);
            else if (gameObject.name.Contains("East"))
                camera.transform.SetPositionAndRotation(new Vector3(camera.transform.position.x + 30, camera.transform.position.y, -10), camera.transform.rotation);
            else if (gameObject.name.Contains("North"))
                camera.transform.SetPositionAndRotation(new Vector3(camera.transform.position.x, camera.transform.position.y + 20, -10), camera.transform.rotation);
            else if (gameObject.name.Contains("South"))
                camera.transform.SetPositionAndRotation(new Vector3(camera.transform.position.x, camera.transform.position.y - 20, -10), camera.transform.rotation);
        }
    }

}
