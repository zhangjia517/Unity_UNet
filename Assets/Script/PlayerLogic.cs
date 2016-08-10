using UnityEngine;
using UnityEngine.Networking;

public class PlayerLogic : NetworkBehaviour
{
    private void Start()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        this.transform.position = new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));
    }

    private void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 2f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-Vector3.left * Time.deltaTime * 2f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 2f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.up * Time.deltaTime * 2f);
        }
    }
}