/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position (new Vector3)
        // New sadece bu satýr için yeni bir vector tanýmlamaya yaradý (Vector bir deðiþkene ait deðil)
        // transform.position = player.transform.position + new Vector3(0, 5, -7);
        transform.position = player.transform.position + offset;
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public GameObject player;
    const int camera_num = 2;
    private Vector3[] offsets = new Vector3[camera_num];
    private Quaternion[] rotates = new Quaternion[camera_num];
    private int view = 0;
    // Start is called before the first frame update
    void Start()
    {
        offsets[0] = new Vector3(0, 6, -12);
        offsets[1] = new Vector3(0, 1.77f, .97f);
        rotates[0] = Quaternion.Euler(12, 0, 0);
        rotates[1] = player.transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            view = (view + 1) % camera_num;
        }
        Vector3 offset = offsets[view];
        rotates[1] = player.transform.rotation;
        transform.position = player.transform.position + offset;
        transform.rotation = rotates[view];
    }
}