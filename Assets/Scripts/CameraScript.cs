using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Camera cameraPlayer;
    private GameObject player;
    [SerializeField] private float offsetY = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        cameraPlayer = GetComponent<Camera>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            cameraPlayer.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offsetY, cameraPlayer.transform.position.z);
        }
        else
        {
            Debug.Log("Who wrote this code!");
        }
    }
}
